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

namespace FirstPlugin.Links
{
    public partial class RevitLinksManagerForm: System.Windows.Forms.Form
    {
        Document Doc;
        UIDocument uidoc;
        public IList<RevitLinkInstance> allRevitLinks = new List<RevitLinkInstance>();
        RevitLinkInstance selectedLink = null;

        public RevitLinksManagerForm(Document doc)
        {
            InitializeComponent();
            Doc = doc;
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            allRevitLinks = collector.OfClass(typeof(RevitLinkInstance)).Cast<RevitLinkInstance>().ToList();

            foreach (RevitLinkInstance linkInstance in allRevitLinks)
            {

                ListViewItem item = new ListViewItem(Doc.GetElement(linkInstance.GetTypeId()).Name);
                RvtListView.Items.Add(item);

                item.SubItems.Add(linkInstance.Id.ToString());
            }
        }
        public void RvtListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectButton.Enabled = RvtListView.SelectedItems.Count > 0;
            selectedLink = allRevitLinks[RvtListView.SelectedIndices[0]];

        }

        private void RevitLinksManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            List<ElementId> linkIds = new List<ElementId>();
            linkIds.Add(selectedLink.Id);
            uidoc = new UIDocument(Doc);
            Transaction transaction = new Transaction(Doc, "Vybrat model");

            transaction.Start();

            uidoc.Selection.SetElementIds(linkIds);

            transaction.Commit();
            Close();
        }
    }
}
