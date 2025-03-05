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

namespace FirstPlugin
{
    public partial class wall_counter : System.Windows.Forms.Form
    {
        Document Doc;
        public wall_counter(Document doc)
        {
            InitializeComponent();
            Doc = doc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICollection<Element> walls =
                new FilteredElementCollector(Doc, Doc.ActiveView.Id).OfCategory(BuiltInCategory.OST_Walls).WhereElementIsNotElementType().ToElements();

            TaskDialog.Show("Wall count", walls.Count.ToString() + "walls");
            this.Close();

        }
    }
}
