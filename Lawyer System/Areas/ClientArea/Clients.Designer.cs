namespace Lawyer_System.Forms
{
    partial class Clients
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
            this.txtBoxclientName = new System.Windows.Forms.TextBox();
            this.lblclientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.txtBoxIdCard = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lblNewClient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tawkelNumbertextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxclientName
            // 
            this.txtBoxclientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxclientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxclientName.Location = new System.Drawing.Point(154, 121);
            this.txtBoxclientName.Name = "txtBoxclientName";
            this.txtBoxclientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxclientName.Size = new System.Drawing.Size(242, 20);
            this.txtBoxclientName.TabIndex = 0;
            // 
            // lblclientName
            // 
            this.lblclientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblclientName.AutoSize = true;
            this.lblclientName.Location = new System.Drawing.Point(428, 123);
            this.lblclientName.Name = "lblclientName";
            this.lblclientName.Size = new System.Drawing.Size(58, 13);
            this.lblclientName.TabIndex = 1;
            this.lblclientName.Text = "اسم الموكل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الموبايل";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(154, 178);
            this.txtBoxPhoneNumber.MaxLength = 11;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(242, 20);
            this.txtBoxPhoneNumber.TabIndex = 2;
            this.txtBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhoneNumber_KeyPress);
            // 
            // lblIDCard
            // 
            this.lblIDCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(428, 232);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(58, 13);
            this.lblIDCard.TabIndex = 5;
            this.lblIDCard.Text = "رقم البطاقة";
            // 
            // txtBoxIdCard
            // 
            this.txtBoxIdCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIdCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxIdCard.Location = new System.Drawing.Point(154, 230);
            this.txtBoxIdCard.MaxLength = 14;
            this.txtBoxIdCard.Name = "txtBoxIdCard";
            this.txtBoxIdCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxIdCard.Size = new System.Drawing.Size(242, 20);
            this.txtBoxIdCard.TabIndex = 3;
            this.txtBoxIdCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIdCard_KeyPress);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(108)))));
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(16, 321);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(120, 30);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "حـفـظ";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // lblNewClient
            // 
            this.lblNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewClient.Location = new System.Drawing.Point(289, 34);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(210, 39);
            this.lblNewClient.TabIndex = 7;
            this.lblNewClient.Text = "إضافة موكل جديد";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "رقم التوكيل";
            // 
            // tawkelNumbertextBox
            // 
            this.tawkelNumbertextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tawkelNumbertextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tawkelNumbertextBox.Location = new System.Drawing.Point(154, 275);
            this.tawkelNumbertextBox.MaxLength = 14;
            this.tawkelNumbertextBox.Name = "tawkelNumbertextBox";
            this.tawkelNumbertextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tawkelNumbertextBox.Size = new System.Drawing.Size(242, 20);
            this.tawkelNumbertextBox.TabIndex = 8;
            this.tawkelNumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIdCard_KeyPress);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tawkelNumbertextBox);
            this.Controls.Add(this.lblNewClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblIDCard);
            this.Controls.Add(this.txtBoxIdCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.lblclientName);
            this.Controls.Add(this.txtBoxclientName);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxclientName;
        private System.Windows.Forms.Label lblclientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.TextBox txtBoxIdCard;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lblNewClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tawkelNumbertextBox;
    }
}