using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPlugin
{
    [Transaction(TransactionMode.Manual)]
    public class SelectMirroredWindows : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            // Get the active document and UI document
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            // Start a transaction
            using (Transaction t = new Transaction(doc, "Select mirrored windows"))
            {
                t.Start();

                // Create a FilteredElementCollector to collect all window elements
                FilteredElementCollector collector = new FilteredElementCollector(doc);
                ICollection<Element> windows = collector
                    .OfCategory(BuiltInCategory.OST_Windows)
                    .WhereElementIsNotElementType()
                    .ToElements();

                // List to store IDs of mirrored windows with the specific label
                List<ElementId> mirroredWindowIds = new List<ElementId>();

                foreach (Element window in windows)
                {
                    if (window is FamilyInstance familyInstance)
                    {
                        // Check if the window is mirrored
                        if (familyInstance.Mirrored)
                        {
                            // Get the "Štítek" parameter
                            Parameter labelParam = familyInstance.Symbol.LookupParameter("Štítek");
                            if (labelParam != null && labelParam.AsString() == "#Okno")
                            {
                                // Add the mirrored window's ID to the list
                                mirroredWindowIds.Add(window.Id);
                            }
                        }
                    }
                }

                // Show a message with the count of mirrored windows found
                TaskDialog.Show("Mirrored Windows", $"There are {mirroredWindowIds.Count} mirrored windows in the model.");

                // Select the mirrored windows
                uidoc.Selection.SetElementIds(mirroredWindowIds);

                t.Commit();
            }

            return Result.Succeeded;
        }
    }
}

