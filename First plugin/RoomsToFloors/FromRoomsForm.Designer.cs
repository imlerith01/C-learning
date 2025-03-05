namespace FirstPlugin.RoomsToFloors
{
    partial class FromRoomsForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.select_rooms_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.select_floor_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(91, 234);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(111, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Zrušit";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(208, 234);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(111, 23);
            this.create_button.TabIndex = 1;
            this.create_button.Text = "Vytvořit";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // select_rooms_button
            // 
            this.select_rooms_button.Location = new System.Drawing.Point(9, 23);
            this.select_rooms_button.Name = "select_rooms_button";
            this.select_rooms_button.Size = new System.Drawing.Size(106, 23);
            this.select_rooms_button.TabIndex = 2;
            this.select_rooms_button.Text = "Vyber místnosti";
            this.select_rooms_button.UseVisualStyleBackColor = true;
            this.select_rooms_button.Click += new System.EventHandler(this.select_rooms_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odsazení od podlaží";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(9, 81);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(106, 20);
            this.offset.TabIndex = 4;
            this.offset.TextChanged += new System.EventHandler(this.offset_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "mm";
            // 
            // select_floor_type
            // 
            this.select_floor_type.FormattingEnabled = true;
            this.select_floor_type.Location = new System.Drawing.Point(9, 143);
            this.select_floor_type.Name = "select_floor_type";
            this.select_floor_type.Size = new System.Drawing.Size(307, 21);
            this.select_floor_type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vyber typ podlahy";
            // 
            // FromRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 272);
            this.Controls.Add(this.select_floor_type);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_rooms_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.cancel_button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FromRoomsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generátor podlah";
            this.Load += new System.EventHandler(this.FromRoomsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button select_rooms_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox offset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox select_floor_type;
        private System.Windows.Forms.Label label3;
    }
}