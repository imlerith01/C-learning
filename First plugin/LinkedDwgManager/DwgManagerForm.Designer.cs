namespace FirstPlugin.LinkedDwgManager
{
    partial class DwgManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DwgManagerForm));
            this.DwgListView = new System.Windows.Forms.ListView();
            this.dwgName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dwgLinkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dwgID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LinkCounter = new System.Windows.Forms.Label();
            this.ImportCounter = new System.Windows.Forms.Label();
            this.placedInView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hiddenInView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DwgListView
            // 
            this.DwgListView.AutoArrange = false;
            this.DwgListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dwgName,
            this.dwgLinkType,
            this.dwgID,
            this.placedInView,
            this.hiddenInView});
            this.DwgListView.FullRowSelect = true;
            this.DwgListView.GridLines = true;
            this.DwgListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DwgListView.HideSelection = false;
            this.DwgListView.Location = new System.Drawing.Point(23, 24);
            this.DwgListView.MultiSelect = false;
            this.DwgListView.Name = "DwgListView";
            this.DwgListView.Size = new System.Drawing.Size(630, 400);
            this.DwgListView.TabIndex = 0;
            this.DwgListView.UseCompatibleStateImageBehavior = false;
            this.DwgListView.View = System.Windows.Forms.View.Details;
            this.DwgListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DwgListView_ItemSelectionChanged);
            // 
            // dwgName
            // 
            this.dwgName.Text = "Název DWG";
            this.dwgName.Width = 200;
            // 
            // dwgLinkType
            // 
            this.dwgLinkType.Text = "Typ připojení";
            this.dwgLinkType.Width = 130;
            // 
            // dwgID
            // 
            this.dwgID.Text = "ID";
            this.dwgID.Width = 66;
            // 
            // SelectButton
            // 
            this.SelectButton.Enabled = false;
            this.SelectButton.Location = new System.Drawing.Point(465, 430);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(91, 32);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Vybrat v modelu";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(562, 430);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 32);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Smazat";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(368, 430);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(91, 32);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Zrušit";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LinkCounter
            // 
            this.LinkCounter.AutoSize = true;
            this.LinkCounter.Location = new System.Drawing.Point(20, 428);
            this.LinkCounter.Name = "LinkCounter";
            this.LinkCounter.Size = new System.Drawing.Size(141, 13);
            this.LinkCounter.TabIndex = 5;
            this.LinkCounter.Text = "Počet připojených DWG: 15";
            // 
            // ImportCounter
            // 
            this.ImportCounter.AutoSize = true;
            this.ImportCounter.Location = new System.Drawing.Point(179, 428);
            this.ImportCounter.Name = "ImportCounter";
            this.ImportCounter.Size = new System.Drawing.Size(155, 13);
            this.ImportCounter.TabIndex = 5;
            this.ImportCounter.Text = "Počet importovaných DWG: 15";
            // 
            // placedInView
            // 
            this.placedInView.Text = "Umístěno v pohledu";
            this.placedInView.Width = 170;
            // 
            // hiddenInView
            // 
            this.hiddenInView.Text = "Skryto";
            this.hiddenInView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DwgManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 473);
            this.Controls.Add(this.ImportCounter);
            this.Controls.Add(this.LinkCounter);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.DwgListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DwgManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Správce DWG";
            this.Load += new System.EventHandler(this.DwgManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DwgListView;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ColumnHeader dwgName;
        private System.Windows.Forms.ColumnHeader dwgLinkType;
        private System.Windows.Forms.ColumnHeader dwgID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LinkCounter;
        private System.Windows.Forms.Label ImportCounter;
        private System.Windows.Forms.ColumnHeader placedInView;
        private System.Windows.Forms.ColumnHeader hiddenInView;
    }
}