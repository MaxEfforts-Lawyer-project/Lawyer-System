namespace Lawyer_System.Areas
{
    partial class MainForm
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
            this.LawSuitGridView = new System.Windows.Forms.DataGridView();
            this.settionsGridview = new System.Windows.Forms.DataGridView();
            this.EditLawsuitbutton = new System.Windows.Forms.Button();
            this.LawsuitserchtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchLawsuitradioButton = new System.Windows.Forms.RadioButton();
            this.searchnameradioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.yearesearchtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientnamesearchtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serchByNumgroupBox = new System.Windows.Forms.GroupBox();
            this.minaCenterPanel1 = new Mina.UI_WinForm.MinaCenterPanel();
            this.serchByNamegroupBox = new System.Windows.Forms.GroupBox();
            this.sessionbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LawSuitGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settionsGridview)).BeginInit();
            this.serchByNumgroupBox.SuspendLayout();
            this.minaCenterPanel1.SuspendLayout();
            this.serchByNamegroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LawSuitGridView
            // 
            this.LawSuitGridView.AllowUserToAddRows = false;
            this.LawSuitGridView.AllowUserToDeleteRows = false;
            this.LawSuitGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LawSuitGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LawSuitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LawSuitGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LawSuitGridView.Location = new System.Drawing.Point(0, 0);
            this.LawSuitGridView.MultiSelect = false;
            this.LawSuitGridView.Name = "LawSuitGridView";
            this.LawSuitGridView.ReadOnly = true;
            this.LawSuitGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LawSuitGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LawSuitGridView.Size = new System.Drawing.Size(330, 109);
            this.LawSuitGridView.TabIndex = 0;
            // 
            // settionsGridview
            // 
            this.settionsGridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settionsGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.settionsGridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settionsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.settionsGridview.Location = new System.Drawing.Point(39, 338);
            this.settionsGridview.MultiSelect = false;
            this.settionsGridview.Name = "settionsGridview";
            this.settionsGridview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.settionsGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.settionsGridview.Size = new System.Drawing.Size(870, 132);
            this.settionsGridview.TabIndex = 0;
            // 
            // EditLawsuitbutton
            // 
            this.EditLawsuitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditLawsuitbutton.FlatAppearance.BorderSize = 0;
            this.EditLawsuitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditLawsuitbutton.ForeColor = System.Drawing.Color.White;
            this.EditLawsuitbutton.Location = new System.Drawing.Point(764, 289);
            this.EditLawsuitbutton.Name = "EditLawsuitbutton";
            this.EditLawsuitbutton.Size = new System.Drawing.Size(120, 30);
            this.EditLawsuitbutton.TabIndex = 1;
            this.EditLawsuitbutton.Text = "تعديل دعوى";
            this.EditLawsuitbutton.UseVisualStyleBackColor = true;
            this.EditLawsuitbutton.Click += new System.EventHandler(this.EditLawSuit_Click);
            // 
            // LawsuitserchtextBox
            // 
            this.LawsuitserchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LawsuitserchtextBox.Location = new System.Drawing.Point(171, 12);
            this.LawsuitserchtextBox.Name = "LawsuitserchtextBox";
            this.LawsuitserchtextBox.Size = new System.Drawing.Size(103, 20);
            this.LawsuitserchtextBox.TabIndex = 2;
            this.LawsuitserchtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LawsuitserchtextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "رقم الدعوة";
            // 
            // searchLawsuitradioButton
            // 
            this.searchLawsuitradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLawsuitradioButton.AutoSize = true;
            this.searchLawsuitradioButton.Location = new System.Drawing.Point(793, 45);
            this.searchLawsuitradioButton.Name = "searchLawsuitradioButton";
            this.searchLawsuitradioButton.Size = new System.Drawing.Size(111, 17);
            this.searchLawsuitradioButton.TabIndex = 88;
            this.searchLawsuitradioButton.TabStop = true;
            this.searchLawsuitradioButton.Text = "رقم الدعوي والسنة";
            this.searchLawsuitradioButton.UseVisualStyleBackColor = true;
            this.searchLawsuitradioButton.CheckedChanged += new System.EventHandler(this.searchLawsuitradioButton_CheckedChanged);
            // 
            // searchnameradioButton
            // 
            this.searchnameradioButton.AutoSize = true;
            this.searchnameradioButton.Location = new System.Drawing.Point(454, 45);
            this.searchnameradioButton.Name = "searchnameradioButton";
            this.searchnameradioButton.Size = new System.Drawing.Size(76, 17);
            this.searchnameradioButton.TabIndex = 88;
            this.searchnameradioButton.TabStop = true;
            this.searchnameradioButton.Text = "اسم الموكل";
            this.searchnameradioButton.UseVisualStyleBackColor = true;
            this.searchnameradioButton.CheckedChanged += new System.EventHandler(this.searchnameradioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 33);
            this.label2.TabIndex = 87;
            this.label2.Text = "بحـث";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // yearesearchtextBox
            // 
            this.yearesearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearesearchtextBox.Location = new System.Drawing.Point(22, 12);
            this.yearesearchtextBox.Name = "yearesearchtextBox";
            this.yearesearchtextBox.Size = new System.Drawing.Size(83, 20);
            this.yearesearchtextBox.TabIndex = 2;
            this.yearesearchtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LawsuitserchtextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "السنة";
            // 
            // clientnamesearchtextBox
            // 
            this.clientnamesearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientnamesearchtextBox.Location = new System.Drawing.Point(275, 21);
            this.clientnamesearchtextBox.Name = "clientnamesearchtextBox";
            this.clientnamesearchtextBox.Size = new System.Drawing.Size(112, 20);
            this.clientnamesearchtextBox.TabIndex = 2;
            this.clientnamesearchtextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.clientnamesearchtextBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "اسم  الموكل";
            // 
            // serchByNumgroupBox
            // 
            this.serchByNumgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchByNumgroupBox.Controls.Add(this.minaCenterPanel1);
            this.serchByNumgroupBox.Location = new System.Drawing.Point(579, 73);
            this.serchByNumgroupBox.Name = "serchByNumgroupBox";
            this.serchByNumgroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serchByNumgroupBox.Size = new System.Drawing.Size(330, 68);
            this.serchByNumgroupBox.TabIndex = 89;
            this.serchByNumgroupBox.TabStop = false;
            this.serchByNumgroupBox.Text = "بحث";
            // 
            // minaCenterPanel1
            // 
            this.minaCenterPanel1.Controls.Add(this.yearesearchtextBox);
            this.minaCenterPanel1.Controls.Add(this.LawsuitserchtextBox);
            this.minaCenterPanel1.Controls.Add(this.label3);
            this.minaCenterPanel1.Controls.Add(this.label1);
            this.minaCenterPanel1.Location = new System.Drawing.Point(-8, 13);
            this.minaCenterPanel1.Name = "minaCenterPanel1";
            this.minaCenterPanel1.Size = new System.Drawing.Size(346, 42);
            this.minaCenterPanel1.TabIndex = 95;
            // 
            // serchByNamegroupBox
            // 
            this.serchByNamegroupBox.Controls.Add(this.label4);
            this.serchByNamegroupBox.Controls.Add(this.clientnamesearchtextBox);
            this.serchByNamegroupBox.Location = new System.Drawing.Point(39, 73);
            this.serchByNamegroupBox.Name = "serchByNamegroupBox";
            this.serchByNamegroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serchByNamegroupBox.Size = new System.Drawing.Size(491, 68);
            this.serchByNamegroupBox.TabIndex = 90;
            this.serchByNamegroupBox.TabStop = false;
            this.serchByNamegroupBox.Text = "بحث";
            this.serchByNamegroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sessionbutton
            // 
            this.sessionbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionbutton.FlatAppearance.BorderSize = 0;
            this.sessionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sessionbutton.ForeColor = System.Drawing.Color.White;
            this.sessionbutton.Location = new System.Drawing.Point(629, 289);
            this.sessionbutton.Name = "sessionbutton";
            this.sessionbutton.Size = new System.Drawing.Size(120, 30);
            this.sessionbutton.TabIndex = 91;
            this.sessionbutton.Text = "جلسات الدعوة";
            this.sessionbutton.UseVisualStyleBackColor = true;
            this.sessionbutton.Click += new System.EventHandler(this.sessionbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LawSuitGridView);
            this.panel1.Location = new System.Drawing.Point(579, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 109);
            this.panel1.TabIndex = 93;
            // 
            // clientdataGridView
            // 
            this.clientdataGridView.AllowUserToAddRows = false;
            this.clientdataGridView.AllowUserToDeleteRows = false;
            this.clientdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clientdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdataGridView.Location = new System.Drawing.Point(257, 164);
            this.clientdataGridView.Name = "clientdataGridView";
            this.clientdataGridView.ReadOnly = true;
            this.clientdataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientdataGridView.Size = new System.Drawing.Size(273, 109);
            this.clientdataGridView.TabIndex = 94;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 491);
            this.Controls.Add(this.clientdataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sessionbutton);
            this.Controls.Add(this.serchByNamegroupBox);
            this.Controls.Add(this.serchByNumgroupBox);
            this.Controls.Add(this.searchnameradioButton);
            this.Controls.Add(this.searchLawsuitradioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditLawsuitbutton);
            this.Controls.Add(this.settionsGridview);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LawSuitGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settionsGridview)).EndInit();
            this.serchByNumgroupBox.ResumeLayout(false);
            this.minaCenterPanel1.ResumeLayout(false);
            this.minaCenterPanel1.PerformLayout();
            this.serchByNamegroupBox.ResumeLayout(false);
            this.serchByNamegroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LawSuitGridView;
        private System.Windows.Forms.DataGridView settionsGridview;
        private System.Windows.Forms.Button EditLawsuitbutton;
        private System.Windows.Forms.TextBox LawsuitserchtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton searchLawsuitradioButton;
        private System.Windows.Forms.RadioButton searchnameradioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearesearchtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientnamesearchtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox serchByNumgroupBox;
        private System.Windows.Forms.GroupBox serchByNamegroupBox;
        private System.Windows.Forms.Button sessionbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView clientdataGridView;
        private Mina.UI_WinForm.MinaCenterPanel minaCenterPanel1;
    }
}