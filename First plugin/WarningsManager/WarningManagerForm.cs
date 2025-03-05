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

namespace FirstPlugin.WarningsManager
{
    public partial class WarningManagerForm : System.Windows.Forms.Form
    {
        public IList<FailureMessage> Warnings { get; set; }
        public IList<FailureMessage> SelectedWarningTypes { get; set; }

        Document Doc;
        UIDocument uidoc;
        public WarningManagerForm(Document doc)
        {
            InitializeComponent();
            Doc = doc;
            Warnings = new List<FailureMessage>();
            SelectedWarningTypes = new List<FailureMessage>();
        }
        public WarningManagerForm()
        {
        
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void WarningManagerForm_Load(object sender, EventArgs e)
        {
            Warnings = Doc.GetWarnings();
            HashSet<string> uniqueWarning = new HashSet<string>();
            int warningsCount = 0;
            foreach (FailureMessage warning in Warnings)
            {
                uniqueWarning.Add(warning.GetDescriptionText());
                warningsCount = warningsCount + 1;
            }
            List<string> warningList = uniqueWarning.ToList();
            WarningDescriptionListBox.DataSource = warningList;
            warningsCounter.Text = "Celkový počet upozornění = " + warningsCount.ToString();
        }


        private void WarningDescriptionListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedWarningTypes.Clear();
            int failureNumber = 1;
            WarningNumberListBox.Items.Clear();
            foreach (FailureMessage failureMessage in Warnings)
            {
                if (failureMessage.GetDescriptionText().ToString() == WarningDescriptionListBox.SelectedItem.ToString())
                {
                    string failureString = "Upozornění " +  failureNumber.ToString();
                    failureNumber = failureNumber + 1;
                    
                    WarningNumberListBox.Items.Add(failureString);
                    SelectedWarningTypes.Add(failureMessage);
                    poisonListView1.Items.Add(failureString);
                }
            }
        }

        private void WarningNumberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FailureMessage selectedMessage = SelectedWarningTypes[WarningNumberListBox.SelectedIndex];
            ElementId failingElement1ID = selectedMessage.GetFailingElements().ToList()[0];
            Element failingElement1 = Doc.GetElement(failingElement1ID);

            if (selectedMessage.GetFailingElements().Count > 1)
            {
                ElementId failingElement2ID = selectedMessage.GetFailingElements().ToList()[1];
                Element failingElement2 = Doc.GetElement(failingElement2ID);

                if (failingElement1 is FamilyInstance)
                {
                    FamilyInstance familyInstance1 = failingElement1 as FamilyInstance;
                    FailingElement1.Text = familyInstance1.Symbol.FamilyName + " - " + failingElement1.Name + "- ID " + failingElement1ID;
                }
                else
                {
                    FailingElement1.Text = failingElement1.Name + "- ID " + failingElement1ID;
                }

                if (failingElement2 is FamilyInstance)
                {
                    FamilyInstance familyInstance2 = failingElement2 as FamilyInstance;
                    FailingElement2.Text = familyInstance2.Symbol.FamilyName + " - " + failingElement2.Name + "- ID " + failingElement2ID;
                }
                else
                {
                    FailingElement2.Text = failingElement2.Name + "- ID " + failingElement2ID;
                }
            }
            else
            {
                if (failingElement1 is FamilyInstance)
                {
                    FamilyInstance familyInstance1 = failingElement1 as FamilyInstance;
                    FailingElement1.Text = familyInstance1.Symbol.FamilyName + " - " + failingElement1.Name + "- ID " + failingElement1ID;
                    FailingElement2.Text = " ";
                }
                else
                {
                    FailingElement1.Text = failingElement1.Name + "- ID " + failingElement1ID;
                    FailingElement2.Text = " ";
                }
            }
        }

        private void UnselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < WarningNumberListBox.Items.Count; i++)
            {
                WarningNumberListBox.SetItemChecked(i, false);
            }
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < WarningNumberListBox.Items.Count; i++)
            {
                WarningNumberListBox.SetItemChecked(i, true);
            }
        }

        private void SectionBoxButton_Click(object sender, EventArgs e)
        {
            List<FailureMessage> selectedMessages = new List<FailureMessage>();
            foreach (int index in WarningNumberListBox.CheckedIndices)
            {
                selectedMessages.Add(SelectedWarningTypes[index]);
            }

            List<ElementId> selectedElements = new List<ElementId>();
            foreach (FailureMessage failureMessage in selectedMessages)
            {
                foreach (ElementId elementId in failureMessage.GetFailingElements())
                    selectedElements.Add(elementId);
            }

            if (selectedElements.Count < 1)
            {
                TaskDialogResult taskDialogResult = TaskDialog.Show("Upozornění", "Vyber alespoň 1 upozornění");
            }
            if (!(Doc.ActiveView is View3D view3D))
            {
                TaskDialogResult taskDialogResult = TaskDialog.Show("Upozornění", "Tato funkce funguje pouze ve 3D zobrazení");
            }
            View3D view3D1 = Doc.ActiveView as View3D;
            
                if (selectedElements.Count > 0)
                {
                    if (view3D1.get_Parameter(BuiltInParameter.VIEWER_VOLUME_OF_INTEREST_CROP).AsElementId() == ElementId.InvalidElementId)
                    {
                        Transaction transaction = new Transaction(Doc, "Vytvořit ořezový kvádr");
                        transaction.Start();
                        if (!(view3D1.IsSectionBoxActive))
                        {
                            view3D1.get_Parameter(BuiltInParameter.VIEWER_MODEL_CLIP_BOX_ACTIVE).Set(1);
                        }
                        view3D1.SetSectionBox(GetTotalBoundingBox(selectedElements));
                        transaction.Commit();
                        Close();
                    }
                    else
                    {
                        TaskDialogResult taskDialogResult = TaskDialog.Show("Upozornění", "V aktuálním 3D pohledu vypni orientovaný kvádr");
                    }
                }
        }

        public BoundingBoxXYZ GetTotalBoundingBox (List<ElementId> elementIds)
        {
            List<double> bboxX = new List<double>();
            List<double> bboxY = new List<double>();
            List<double> bboxZ = new List<double>();
            foreach (ElementId elementId in elementIds)
            {
                Element element = Doc.GetElement(elementId);
                BoundingBoxXYZ elementbbox = element.get_BoundingBox(null);
                bboxX.Add(elementbbox.Min.X);
                bboxX.Add(elementbbox.Max.X);
                bboxY.Add(elementbbox.Min.Y);
                bboxY.Add(elementbbox.Max.Y);
                bboxZ.Add(elementbbox.Min.Z);
                bboxZ.Add(elementbbox.Max.Z);
            }
            XYZ min = new XYZ(bboxX.Min(), bboxY.Min(), bboxZ.Min());
            XYZ max = new XYZ(bboxX.Max(), bboxY.Max(), bboxZ.Max());
            BoundingBoxXYZ bbox = new BoundingBoxXYZ();
            bbox.Min = min;
            bbox.Max = max;
            return bbox;
        }

        private void IsolateInViewButton_Click(object sender, EventArgs e)
        {
            List<FailureMessage> selectedMessages = new List<FailureMessage>();
            foreach (int index in WarningNumberListBox.CheckedIndices)
            {
                selectedMessages.Add(SelectedWarningTypes[index]);
            }

            List<ElementId> selectedElements = new List<ElementId>();
            foreach (FailureMessage failureMessage in selectedMessages)
            {
                foreach (ElementId elementId in failureMessage.GetFailingElements())
                    selectedElements.Add(elementId);
            }
            HashSet<BuiltInCategory> allowedCategories = new HashSet<BuiltInCategory>
            {
                BuiltInCategory.OST_CurtainWallMullions,
                BuiltInCategory.OST_CurtainWallPanels,
            };
            foreach (ElementId elementId in selectedElements.ToList())
            {
                if (allowedCategories.Contains(Doc.GetElement(elementId).Category.BuiltInCategory))
                {
                    FamilyInstance familyInstance = Doc.GetElement(elementId) as FamilyInstance;
                    selectedElements.Remove(elementId);
                    selectedElements.Add(familyInstance.Host.Id);
                }
            }

            if (selectedElements.Count > 0)
            {
                 Transaction transaction = new Transaction(Doc, "Izolovat prvky");
                transaction.Start();
                Doc.ActiveView.IsolateElementsTemporary(selectedElements);
                transaction.Commit();
                Close();
            }
            else
            {
                TaskDialogResult taskDialogResult = TaskDialog.Show("Upozornění", "Vyber alespoň 1 upozornění");
            }
        }

        private void SelectElementsInModelButton_Click(object sender, EventArgs e)
        {
            List<FailureMessage> selectedMessages = new List<FailureMessage>();
            foreach (int index in WarningNumberListBox.CheckedIndices)
            {
                selectedMessages.Add(SelectedWarningTypes[index]);
            }
            List<ElementId> selectedElements = new List<ElementId>();
            foreach (FailureMessage failureMessage in selectedMessages)
            {
                foreach (ElementId elementId in failureMessage.GetFailingElements())
                    selectedElements.Add(elementId);
            }
            if (selectedElements.Count > 0)
            {
                // Select the elements in the model
                uidoc = new UIDocument(Doc);
                uidoc.Selection.SetElementIds(selectedElements);
            }
            else
            {
                TaskDialog.Show("Upozornění", "Vyber alespoň 1 upozornění");
            }
            Close();
        }
    }
}
