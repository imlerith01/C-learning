using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Point = Autodesk.Revit.DB.Point;
using Rectangle = Autodesk.Revit.DB.Rectangle;
using View = Autodesk.Revit.DB.View;

namespace FirstPlugin.DoorTagsManager
{
    public partial class DoorTagsForm : System.Windows.Forms.Form
    {
        public IList<FamilySymbol> TagTypes { get; set; }
        public IList<Element> allDoors { get; set; }
        Document Doc;
        UIDocument uidoc;

        public DoorTagsForm(Document doc)
        {
            InitializeComponent();
            Doc = doc;

            TagTypes = new List<FamilySymbol>();
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            TagTypes = collector.OfCategory(BuiltInCategory.OST_DoorTags).WhereElementIsElementType().ToElements().OfType<FamilySymbol>().ToList();

            foreach (FamilySymbol tag in TagTypes)
            {

                TagTypesBox.Items.Add(tag.FamilyName + " - " + tag.Name);
            }

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            FilteredElementCollector collector = new FilteredElementCollector(Doc);
            allDoors = new List<Element>();
            allDoors = collector.OfCategory(BuiltInCategory.OST_Doors).WhereElementIsNotElementType().ToElements();
            View activeView = Doc.ActiveView;
            Element selectedTagType = TagTypes[TagTypesBox.SelectedIndex];
            List<Element> selectedDoors = new List<Element>();

            using (Transaction transaction = new Transaction(Doc, "Vytvořit popisky"))
            {
                transaction.Start();

                foreach (Element door in allDoors)
                {
                    ElementId doortypeId = door.GetTypeId();
                    Element doorType = Doc.GetElement(doortypeId);
                    if (Doc.GetElement(doortypeId).LookupParameter("Štítek").AsString() == "#Dveře")
                    {
                        selectedDoors.Add(door);
                        FamilyInstance familyInstance = door as FamilyInstance;
                        XYZ xYZ = familyInstance.FacingOrientation;
                        LocationPoint center = familyInstance.Location as LocationPoint;
                        TagOrientation orientation = TagOrientation.Horizontal;
                        double x = center.Point.X;
                        double y = center.Point.Y;
                        double z = center.Point.Z;
                        double offset = 0;

                        if (doorType.LookupParameter("Počet křídel").AsInteger() == 1)
                        {
                            offset = UnitUtils.ConvertToInternalUnits(400, UnitTypeId.Millimeters);
                        }
                        if (doorType.LookupParameter("Počet křídel").AsInteger() == 2)
                        {
                            offset = UnitUtils.ConvertToInternalUnits(900, UnitTypeId.Millimeters);
                        }

                        if (((int)xYZ.X) == 0 && ((int)xYZ.Y) == 1)
                        {
                            orientation = TagOrientation.Vertical;
                            y = center.Point.Y + offset;
                        }
                        if (((int)xYZ.X) == 0 && ((int)xYZ.Y) == -1)
                        {
                            orientation = TagOrientation.Vertical;
                            y = center.Point.Y - offset;
                        }
                        if (((int)xYZ.X) == 1 && ((int)xYZ.Y) == 0)
                        {
                            orientation = TagOrientation.Horizontal;
                            x = center.Point.X + offset;
                        }
                        if (((int)xYZ.X) == -1 && ((int)xYZ.Y) == 0)
                        {
                            orientation = TagOrientation.Horizontal;
                            x = center.Point.X - offset;
                        }

                        if (doorType.LookupParameter("Počet křídel").AsInteger() == 2)
                        {
                            double leafDiff = (door.LookupParameter("Šířka aktivního křídla").AsDouble() - door.LookupParameter("Šířka pasivního křídla").AsDouble()) / 2;
                            FamilyInstance instance = door as FamilyInstance;

                            if (orientation == TagOrientation.Vertical)
                            {
                                if (instance.Mirrored && instance.HandFlipped)
                                {
                                    x = x - leafDiff;
                                }
                                if (!instance.Mirrored && !instance.HandFlipped)
                                {
                                    x = x + leafDiff;
                                }
                                if (instance.Mirrored && !instance.HandFlipped)
                                {
                                    x = x + leafDiff;
                                }
                                if (!instance.Mirrored && instance.HandFlipped)
                                {
                                    x = x - leafDiff;
                                }

                            }
                            if (orientation == TagOrientation.Horizontal)
                            {
                                if (instance.Mirrored && instance.HandFlipped)
                                {
                                    y = y - leafDiff;
                                }
                                if (!instance.Mirrored && !instance.HandFlipped)
                                {
                                    y = y + leafDiff;
                                }
                                if (instance.Mirrored && !instance.HandFlipped)
                                {
                                    y = y + leafDiff;
                                }
                                if (!instance.Mirrored && instance.HandFlipped)
                                {
                                    y = y - leafDiff;
                                }
                            }
                        }

                        XYZ location = new XYZ(x, y, z);
                        XYZ centerPoint = new XYZ(center.Point.X, center.Point.Y, center.Point.Z);
                        XYZ point1 = new XYZ(location.X, centerPoint.Y, 0);
                        XYZ point2 = new XYZ(centerPoint.X, location.Y, 0);

                        double distanceA = (point1 - centerPoint).GetLength();
                        double distanceB = (point2 - centerPoint).GetLength();

                        XYZ leaderLocation = new XYZ(0, 0, 0);
                        if (distanceA > distanceB)
                        {
                            leaderLocation = point2;
                        }
                        else
                        {
                            leaderLocation = point1;
                        }


                        Reference reference = new Reference(door);
                        IndependentTag tag = IndependentTag.Create(Doc, selectedTagType.Id, activeView.Id, reference, false, orientation, location);
                        tag.HasLeader = true;
                        tag.LeaderEndCondition = LeaderEndCondition.Free;
                        tag.SetLeaderEnd(reference, leaderLocation);

                        //test test test
                    }
                }
                transaction.Commit();
            }


            TaskDialog.Show("test", "V modelu je " + selectedDoors.Count().ToString() + "dveří");
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoorTagsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
