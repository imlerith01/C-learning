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

namespace FirstPlugin
{
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    [Transaction(TransactionMode.Manual)]
    public class Class1 : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            

            return Result.Succeeded;


        }

        public Result OnStartup(UIControlledApplication application)
        {
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("MyRibbonPanel");


            // Create button and add it to the panel
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData buttonData = new PushButtonData("FirstCommand", "My Test", assemblyPath, "FirstPlugin.MyTest");

            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;

            // optionally you can add other propertis to the pushbutton
            pushButton.ToolTip = "Hello this is my first plugin";

            Uri uriImage = new Uri(@"C:\Users\dvoracek\source\repos\First plugin\icon.png");
            BitmapImage bitmapImage = new BitmapImage(uriImage);
            pushButton.LargeImage = bitmapImage;
            return Result.Succeeded;
        }
    }
    [Regeneration(RegenerationOption.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    [Transaction(TransactionMode.Manual)]
    public class MyTest : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var uiapp = commandData.Application;
            var app = uiapp.Application;
            var uidoc = uiapp.ActiveUIDocument;
            var doc = uidoc.Document;

            TaskDialog.Show("Revit", "1st step");
            TaskDialog.Show("Revit", "2nd step");
            TaskDialog.Show("Revit", "3rd step");
            return Result.Succeeded;


        }
    }
}