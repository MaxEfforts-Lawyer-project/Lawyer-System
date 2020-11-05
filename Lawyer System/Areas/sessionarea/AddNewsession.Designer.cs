namespace Lawyer_System.Areas.sessionarea
{
    partial class AddNewsession
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
            this.label2 = new System.Windows.Forms.Label();
            this.DesionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.savebutonbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "قرار الجلسة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "التاريخ";
            // 
            // DesionrichTextBox
            // 
            this.DesionrichTextBox.Location = new System.Drawing.Point(12, 12);
            this.DesionrichTextBox.Name = "DesionrichTextBox";
            this.DesionrichTextBox.Size = new System.Drawing.Size(237, 56);
            this.DesionrichTextBox.TabIndex = 1;
            this.DesionrichTextBox.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // savebutonbutton
            // 
            this.savebutonbutton.Location = new System.Drawing.Point(132, 143);
            this.savebutonbutton.Name = "savebutonbutton";
            this.savebutonbutton.Size = new System.Drawing.Size(75, 23);
            this.savebutonbutton.TabIndex = 3;
            this.savebutonbutton.Text = "Savebutton";
            this.savebutonbutton.UseVisualStyleBackColor = true;
            this.savebutonbutton.Click += new System.EventHandler(this.savebutonbutton_Click);
            // 
            // AddNewsession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 198);
            this.Controls.Add(this.savebutonbutton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DesionrichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewsession";
            this.Text = "AddNewsession";
            this.Load += new System.EventHandler(this.AddNewsession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DesionrichTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button savebutonbutton;
    }
}