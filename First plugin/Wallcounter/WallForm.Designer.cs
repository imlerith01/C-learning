namespace FirstPlugin
{
    partial class wall_counter
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
            this.walls_count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // walls_count
            // 
            this.walls_count.Location = new System.Drawing.Point(104, 39);
            this.walls_count.Name = "walls_count";
            this.walls_count.Size = new System.Drawing.Size(189, 69);
            this.walls_count.TabIndex = 0;
            this.walls_count.Text = "Count walls";
            this.walls_count.UseVisualStyleBackColor = true;
            this.walls_count.Click += new System.EventHandler(this.button1_Click);
            // 
            // wall_counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 167);
            this.Controls.Add(this.walls_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "wall_counter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wall counter";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button walls_count;
    }
}