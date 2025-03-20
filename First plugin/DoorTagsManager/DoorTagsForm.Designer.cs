namespace FirstPlugin.DoorTagsManager
{
    partial class DoorTagsForm
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
            this.SelectButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TagTypesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(12, 261);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(96, 33);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Vybrat dveře";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(114, 261);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 33);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Zrušit";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TagTypesBox
            // 
            this.TagTypesBox.FormattingEnabled = true;
            this.TagTypesBox.Location = new System.Drawing.Point(12, 104);
            this.TagTypesBox.Name = "TagTypesBox";
            this.TagTypesBox.Size = new System.Drawing.Size(276, 21);
            this.TagTypesBox.TabIndex = 1;
            // 
            // DoorTagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.TagTypesBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectButton);
            this.Name = "DoorTagsForm";
            this.Text = "DoorTagsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoorTagsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox TagTypesBox;
    }
}