namespace FirstPlugin.WarningsManager
{
    partial class WarningManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningManagerForm));
            this.SectionBoxButton = new System.Windows.Forms.Button();
            this.IsolateInViewButton = new System.Windows.Forms.Button();
            this.WarningNumberListBox = new System.Windows.Forms.CheckedListBox();
            this.WarningDescriptionListBox = new System.Windows.Forms.ListBox();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.UnselectAllButton = new System.Windows.Forms.Button();
            this.FailingElement1 = new System.Windows.Forms.TextBox();
            this.FailingElement2 = new System.Windows.Forms.TextBox();
            this.warningsCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectInModelButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SectionBoxButton
            // 
            this.SectionBoxButton.Location = new System.Drawing.Point(1004, 379);
            this.SectionBoxButton.Name = "SectionBoxButton";
            this.SectionBoxButton.Size = new System.Drawing.Size(103, 39);
            this.SectionBoxButton.TabIndex = 1;
            this.SectionBoxButton.Text = "Vytvořit ořezový kvádr";
            this.SectionBoxButton.UseVisualStyleBackColor = true;
            this.SectionBoxButton.Click += new System.EventHandler(this.SectionBoxButton_Click);
            // 
            // IsolateInViewButton
            // 
            this.IsolateInViewButton.Location = new System.Drawing.Point(1113, 379);
            this.IsolateInViewButton.Name = "IsolateInViewButton";
            this.IsolateInViewButton.Size = new System.Drawing.Size(103, 39);
            this.IsolateInViewButton.TabIndex = 1;
            this.IsolateInViewButton.Text = "Izolovat v pohledu";
            this.IsolateInViewButton.UseVisualStyleBackColor = true;
            this.IsolateInViewButton.Click += new System.EventHandler(this.IsolateInViewButton_Click);
            // 
            // WarningNumberListBox
            // 
            this.WarningNumberListBox.FormattingEnabled = true;
            this.WarningNumberListBox.Location = new System.Drawing.Point(471, 25);
            this.WarningNumberListBox.Name = "WarningNumberListBox";
            this.WarningNumberListBox.ScrollAlwaysVisible = true;
            this.WarningNumberListBox.Size = new System.Drawing.Size(309, 364);
            this.WarningNumberListBox.TabIndex = 10;
            this.WarningNumberListBox.SelectedIndexChanged += new System.EventHandler(this.WarningNumberListBox_SelectedIndexChanged);
            // 
            // WarningDescriptionListBox
            // 
            this.WarningDescriptionListBox.FormattingEnabled = true;
            this.WarningDescriptionListBox.HorizontalScrollbar = true;
            this.WarningDescriptionListBox.Location = new System.Drawing.Point(12, 25);
            this.WarningDescriptionListBox.Name = "WarningDescriptionListBox";
            this.WarningDescriptionListBox.ScrollAlwaysVisible = true;
            this.WarningDescriptionListBox.Size = new System.Drawing.Size(453, 368);
            this.WarningDescriptionListBox.TabIndex = 11;
            this.WarningDescriptionListBox.SelectedValueChanged += new System.EventHandler(this.WarningDescriptionListBox_SelectedValueChanged);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.BackColor = System.Drawing.SystemColors.Window;
            this.SelectAllButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SelectAllButton.Location = new System.Drawing.Point(472, 395);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(103, 26);
            this.SelectAllButton.TabIndex = 0;
            this.SelectAllButton.Text = "Vybrat vše";
            this.SelectAllButton.UseVisualStyleBackColor = false;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // UnselectAllButton
            // 
            this.UnselectAllButton.Location = new System.Drawing.Point(581, 395);
            this.UnselectAllButton.Name = "UnselectAllButton";
            this.UnselectAllButton.Size = new System.Drawing.Size(103, 26);
            this.UnselectAllButton.TabIndex = 0;
            this.UnselectAllButton.Text = "Nevybrat žádné";
            this.UnselectAllButton.UseVisualStyleBackColor = true;
            this.UnselectAllButton.Click += new System.EventHandler(this.UnselectAllButton_Click);
            // 
            // FailingElement1
            // 
            this.FailingElement1.Location = new System.Drawing.Point(786, 25);
            this.FailingElement1.Name = "FailingElement1";
            this.FailingElement1.ReadOnly = true;
            this.FailingElement1.Size = new System.Drawing.Size(430, 20);
            this.FailingElement1.TabIndex = 14;
            this.FailingElement1.Tag = "";
            // 
            // FailingElement2
            // 
            this.FailingElement2.Location = new System.Drawing.Point(786, 80);
            this.FailingElement2.Name = "FailingElement2";
            this.FailingElement2.ReadOnly = true;
            this.FailingElement2.Size = new System.Drawing.Size(430, 20);
            this.FailingElement2.TabIndex = 14;
            this.FailingElement2.Tag = "";
            // 
            // warningsCounter
            // 
            this.warningsCounter.AutoSize = true;
            this.warningsCounter.Location = new System.Drawing.Point(12, 402);
            this.warningsCounter.Name = "warningsCounter";
            this.warningsCounter.Size = new System.Drawing.Size(89, 13);
            this.warningsCounter.TabIndex = 15;
            this.warningsCounter.Text = "WarningsCounter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Upozornění";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chybné prvky";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Typy upozornění";
            // 
            // SelectInModelButton
            // 
            this.SelectInModelButton.Location = new System.Drawing.Point(895, 379);
            this.SelectInModelButton.Name = "SelectInModelButton";
            this.SelectInModelButton.Size = new System.Drawing.Size(103, 39);
            this.SelectInModelButton.TabIndex = 1;
            this.SelectInModelButton.Text = "Vybrat prvky v modelu";
            this.SelectInModelButton.UseVisualStyleBackColor = true;
            this.SelectInModelButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(786, 379);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 39);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Zrušit";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // WarningManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1225, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warningsCounter);
            this.Controls.Add(this.FailingElement2);
            this.Controls.Add(this.FailingElement1);
            this.Controls.Add(this.WarningDescriptionListBox);
            this.Controls.Add(this.WarningNumberListBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.IsolateInViewButton);
            this.Controls.Add(this.SelectInModelButton);
            this.Controls.Add(this.SectionBoxButton);
            this.Controls.Add(this.UnselectAllButton);
            this.Controls.Add(this.SelectAllButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarningManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Správce upozornění";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.WarningManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SectionBoxButton;
        private System.Windows.Forms.Button IsolateInViewButton;
        private System.Windows.Forms.CheckedListBox WarningNumberListBox;
        private System.Windows.Forms.ListBox WarningDescriptionListBox;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button UnselectAllButton;
        private System.Windows.Forms.TextBox FailingElement1;
        private System.Windows.Forms.TextBox FailingElement2;
        private System.Windows.Forms.Label warningsCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectInModelButton;
        private System.Windows.Forms.Button CancelButton;
    }
}