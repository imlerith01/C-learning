namespace FirstPlugin.Sheetcreator
{
    partial class SheetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sheet_name = new System.Windows.Forms.TextBox();
            this.sheet_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sheet_titleBlock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sheet name";
            // 
            // sheet_name
            // 
            this.sheet_name.Location = new System.Drawing.Point(15, 36);
            this.sheet_name.Name = "sheet_name";
            this.sheet_name.Size = new System.Drawing.Size(363, 20);
            this.sheet_name.TabIndex = 1;
            // 
            // sheet_number
            // 
            this.sheet_number.Location = new System.Drawing.Point(12, 91);
            this.sheet_number.Name = "sheet_number";
            this.sheet_number.Size = new System.Drawing.Size(363, 20);
            this.sheet_number.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sheet number";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(121, 223);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(251, 223);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(124, 23);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titleblock type";
            // 
            // sheet_titleBlock
            // 
            this.sheet_titleBlock.FormattingEnabled = true;
            this.sheet_titleBlock.Location = new System.Drawing.Point(12, 146);
            this.sheet_titleBlock.Name = "sheet_titleBlock";
            this.sheet_titleBlock.Size = new System.Drawing.Size(363, 21);
            this.sheet_titleBlock.TabIndex = 5;
            this.sheet_titleBlock.SelectedIndexChanged += new System.EventHandler(this.sheet_titleBlock_SelectedIndexChanged);
            // 
            // SheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 256);
            this.Controls.Add(this.sheet_titleBlock);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.sheet_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sheet_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SheetForm";
            this.Text = "Sheet creator";
            this.Load += new System.EventHandler(this.SheetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sheet_name;
        private System.Windows.Forms.TextBox sheet_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sheet_titleBlock;
    }
}