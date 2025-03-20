using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Exceptions;
using System.Windows.Forms;

namespace FirstPlugin
{
    [Transaction(TransactionMode.Manual)]
    public class DoorTags : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;

            using (System.Windows.Forms.Form form = new FirstPlugin.DoorTagsManager.DoorTagsForm(doc))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    return Result.Succeeded;
                }
                else
                {
                    return Result.Cancelled;
                }
            }
        }
    }
}
