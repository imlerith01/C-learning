namespace FirstPlugin.Links
{
    partial class RevitLinksManagerForm
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
            this.RvtListView = new System.Windows.Forms.ListView();
            this.rvtName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rvtID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RvtListView
            // 
            this.RvtListView.AutoArrange = false;
            this.RvtListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rvtName,
            this.rvtID});
            this.RvtListView.FullRowSelect = true;
            this.RvtListView.GridLines = true;
            this.RvtListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RvtListView.HideSelection = false;
            this.RvtListView.Location = new System.Drawing.Point(12, 12);
            this.RvtListView.MultiSelect = false;
            this.RvtListView.Name = "RvtListView";
            this.RvtListView.Size = new System.Drawing.Size(320, 268);
            this.RvtListView.TabIndex = 1;
            this.RvtListView.UseCompatibleStateImageBehavior = false;
            this.RvtListView.View = System.Windows.Forms.View.Details;
            this.RvtListView.SelectedIndexChanged += new System.EventHandler(this.RvtListView_SelectedIndexChanged);
            // 
            // rvtName
            // 
            this.rvtName.Text = "Název modelu";
            this.rvtName.Width = 220;
            // 
            // rvtID
            // 
            this.rvtID.Text = "ID";
            this.rvtID.Width = 100;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(148, 286);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 35);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Zrušit";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Enabled = false;
            this.SelectButton.Location = new System.Drawing.Point(243, 286);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(89, 35);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Vybrat v modleu";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // RevitLinksManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 332);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RvtListView);
            this.Name = "RevitLinksManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Správce připojených modelů";
            this.Load += new System.EventHandler(this.RevitLinksManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView RvtListView;
        private System.Windows.Forms.ColumnHeader rvtName;
        private System.Windows.Forms.ColumnHeader rvtID;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectButton;
    }
}