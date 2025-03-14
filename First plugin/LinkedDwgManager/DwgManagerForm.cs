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
using View = Autodesk.Revit.DB.View;

namespace FirstPlugin.LinkedDwgManager
{
    public partial class DwgManagerForm: System.Windows.Forms.Form
    {
        public IList<ImportInstance> DwgInstances { get; set; }
        ImportInstance selectedDwg = null;
        View selectedView = null;
        int linkCounter = 0;
        int importCounter = 0;

        Document Doc;
        UIDocument uidoc;
        public DwgManagerForm(Document doc)
        {
            InitializeComponent();
            Doc = doc;
            DwgInstances = new List<ImportInstance>();
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            DwgInstances = collector.OfClass(typeof(ImportInstance)).Cast<ImportInstance>().ToList();

            foreach (ImportInstance dwg in DwgInstances)
            {
                ListViewItem item = new ListViewItem(dwg.Category.Name.ToString());
                DwgListView.Items.Add(item);
                if (dwg.IsLinked)
                {
                    item.SubItems.Add("Připojeno");
                    linkCounter = linkCounter + 1;
                }
                else
                {
                    item.SubItems.Add("Importováno");
                    importCounter = importCounter + 1;
                }

                item.SubItems.Add(dwg.Id.ToString());

                if (dwg.OwnerViewId.ToString() != "-1")
                {
                    string viewCategory = Doc.GetElement(Doc.GetElement(dwg.OwnerViewId).GetTypeId()).Name.ToString();
                    string viewName = Doc.GetElement(dwg.OwnerViewId).Name.ToString();

                    item.SubItems.Add(viewCategory + " - " + viewName);
                }
                else
                {
                    item.SubItems.Add("Umístěno ve všech pohledech");
                }

                if (dwg.OwnerViewId.ToString() == "-1")
                {
                    item.SubItems.Add(" - ");
                }
                else
                {
                    if (dwg.IsHidden(Doc.GetElement(dwg.OwnerViewId) as View))
                    {
                        item.SubItems.Add("Ano");
                    }
                    else
                    {
                        item.SubItems.Add("Ne");
                    }
                }

            }
            LinkCounter.Text = "Počet připojených DWG  = " + linkCounter.ToString();
            ImportCounter.Text = "Počet importovaných DWG  = " + importCounter.ToString();
        }
        private void DwgManagerForm_Load(object sender, EventArgs e)
        {

        }
        private void DwgListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectButton.Enabled = DwgListView.SelectedItems.Count > 0;
            DeleteButton.Enabled = DwgListView.SelectedItems.Count > 0;
            selectedDwg = DwgInstances[DwgListView.SelectedIndices[0]];
            selectedView = Doc.GetElement(selectedDwg.OwnerViewId) as View;

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Opravdu chcete smazat vybraný prvek?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (selectedDwg.IsLinked)
                {
                    linkCounter = linkCounter - 1;
                    LinkCounter.Text = "Počet připojených DWG  = " + linkCounter.ToString();
                }
                else
                {
                    importCounter = importCounter - 1;
                    ImportCounter.Text = "Počet importovaných DWG  = " + importCounter.ToString();
                }
                DwgInstances.Remove(selectedDwg);

                DwgListView.Items.RemoveAt(DwgListView.SelectedIndices[0]);

                using (Transaction transaction = new Transaction(Doc, "Vymazat DWG"))
                {
                    transaction.Start();
                    Doc.Delete(selectedDwg.Id);
                    transaction.Commit();
                }
            }
        }


        private void SelectButton_Click(object sender, EventArgs e)
        {
            List<ElementId> dwgListId = new List<ElementId>();
            dwgListId.Add(selectedDwg.Id);
            uidoc = new UIDocument(Doc);
            uidoc.ActiveView = selectedView;
            Transaction transaction = new Transaction(Doc, "Vybrat DWG");
            transaction.Start();
            if (selectedView != null)
            {
                if (selectedDwg.IsHidden(selectedView))
                {
                    selectedView.EnableRevealHiddenMode();
                }
                uidoc.Selection.SetElementIds(dwgListId);
            }
            else
            {
                uidoc.Selection.SetElementIds(dwgListId);
            }
            transaction.Commit();
            Close();
        }
    }
}
