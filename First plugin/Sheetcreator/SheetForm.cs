using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace FirstPlugin.Sheetcreator
{
    public partial class SheetForm : System.Windows.Forms.Form
    {
        Document Doc;
        public SheetForm(Document doc)
        {
            InitializeComponent();
            Doc = doc;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            IList<Element> tBlockTypes = new FilteredElementCollector(Doc)
                .OfCategory(BuiltInCategory.OST_TitleBlocks).WhereElementIsElementType().ToElements();

            string selectedTblock = this.sheet_titleBlock.ToString();
            Element titleBlock = null;

            foreach (Element tBlockType in tBlockTypes)
            {
                if (tBlockType.Name == selectedTblock)
                {
                    titleBlock = tBlockType;
                }

                if (SheetName == "")
                {
                    TaskDialog.Show("Null value", string.Format("One or more fields missing"));
                }
                else
                {
                    using (Transaction sheetTrans = new Transaction(Doc, "Create sheets"))
                    {
                        sheetTrans.Start();

                        ViewSheet newSheet = ViewSheet.Create(Doc, titleBlock.Id);
                        newSheet.Name = SheetName;
                        newSheet.SheetNumber = SheetNumber;

                        sheetTrans.Commit();
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }
        public string SheetName
        {
            get { return this.sheet_name.Text; }
        }
        public string SheetNumber
        {
            get { return this.sheet_number.Text; }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void sheet_titleBlock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SheetForm_Load(object sender, EventArgs e)
        {
            IList<Element> tBlockTypes = new FilteredElementCollector(Doc)
            .OfCategory(BuiltInCategory.OST_TitleBlocks).WhereElementIsElementType().ToElements();

            try
            {
                IList<string> titleBlocks = new List<string>();

                foreach (Element tBlock in tBlockTypes)
                {
                    titleBlocks.Add(tBlock.Name);
                }
                sheet_titleBlock.DataSource = titleBlocks;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error", ex.ToString());

            }
        }
    }
}
