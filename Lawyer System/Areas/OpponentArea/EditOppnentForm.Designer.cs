namespace Lawyer_System.Areas.OpponentArea
{
    partial class EditOppnentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOppnentForm));
            this.notsrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OpponenttextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.labelHomeTitle = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // notsrichTextBox
            // 
            this.notsrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notsrichTextBox.Location = new System.Drawing.Point(81, 114);
            this.notsrichTextBox.Name = "notsrichTextBox";
            this.notsrichTextBox.Size = new System.Drawing.Size(200, 35);
            this.notsrichTextBox.TabIndex = 2;
            this.notsrichTextBox.Text = "";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "ملاحظات";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "اسم الخصم";
            // 
            // OpponenttextBox
            // 
            this.OpponenttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpponenttextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.OpponenttextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.OpponenttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponenttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponenttextBox.Location = new System.Drawing.Point(84, 69);
            this.OpponenttextBox.Name = "OpponenttextBox";
            this.OpponenttextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpponenttextBox.Size = new System.Drawing.Size(197, 22);
            this.OpponenttextBox.TabIndex = 1;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(108)))));
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(12, 164);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(120, 30);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "حفظ";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.CloseButton);
            this.panelTitleBar.Controls.Add(this.labelHomeTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(431, 50);
            this.panelTitleBar.TabIndex = 91;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(376, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(55, 50);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // labelHomeTitle
            // 
            this.labelHomeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeTitle.ForeColor = System.Drawing.Color.White;
            this.labelHomeTitle.Location = new System.Drawing.Point(119, 10);
            this.labelHomeTitle.Name = "labelHomeTitle";
            this.labelHomeTitle.Size = new System.Drawing.Size(148, 32);
            this.labelHomeTitle.TabIndex = 0;
            this.labelHomeTitle.Text = "تعديل خصم";
            this.labelHomeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditOppnentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 206);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.notsrichTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OpponenttextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditOppnentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditOppnentForm_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox notsrichTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OpponenttextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label labelHomeTitle;
    }
}