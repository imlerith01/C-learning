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
using Autodesk.Revit.Attributes;

namespace FirstPlugin.RoomsToFloors
{
    public partial class FromRoomsForm : System.Windows.Forms.Form
    {
        Document Doc;
        public FromRoomsForm(Document doc)
        {
            InitializeComponent();
            Doc = doc;

        }

        private void FromRoomsForm_Load(object sender, EventArgs e)
        {
            IList<Element> allFloorTypes = new FilteredElementCollector(Doc)
            .OfCategory(BuiltInCategory.OST_Floors).WhereElementIsElementType().ToElements();

            try
            {
                IList<string> floorTypes = new List<string>();

                foreach (Element fType in allFloorTypes)
                {
                    floorTypes.Add(fType.Name);
                }
                select_floor_type.DataSource = floorTypes;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error", ex.ToString());

            }

        }

        private void select_rooms_button_Click(object sender, EventArgs e)
        {

        }

        private void offset_TextChanged(object sender, EventArgs e)
        {

        }
        public string FloorOffset
        {
            get { return this.offset.Text; }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {

        }
    }
}
