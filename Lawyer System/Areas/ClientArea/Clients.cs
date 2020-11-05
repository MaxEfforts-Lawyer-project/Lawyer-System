using Lawyer_System.Areas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Forms
{
    public partial class Clients : Form
    {
        ApplicationDbContext context;
        public Clients()
        {
            context = new ApplicationDbContext();
            InitializeComponent();
        }


        private void loadThemeColor()
        {
            foreach (Control control in this.Controls)
            {
                if(control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
                lblNewClient.ForeColor = ThemeColors.SecondaryColor;
            }
        }

        private void txtBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtBoxIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        void cleareform()
        {
            txtBoxclientName.Text = "";
            txtBoxIdCard.Text = "";
            txtBoxPhoneNumber.Text = "";
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxclientName.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الموكل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxIdCard.Text != "")
                { 
                    var client = context.clients.FirstOrDefault(c => c.Name == txtBoxclientName.Text && c.NationalID == txtBoxIdCard.Text);
                    if (client != null)
                    {
                        MessageBox.Show("هذا الاسم موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var clientt = context.clients.FirstOrDefault( c=>c.NationalID == txtBoxIdCard.Text);

                    if (clientt != null)
                    {
                        MessageBox.Show("الرقم القومى لهذا العميل  موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                var nclient = new Client()
                {
                    Name = txtBoxclientName.Text,
                    NationalID = txtBoxIdCard.Text,
                    AuthorizationDate = DateTime.Now,
                    Phone = txtBoxPhoneNumber.Text,
                    tawkelNumber = tawkelNumbertextBox.Text
                };
                context.clients.Add(nclient) ;
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleareform();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void Clients_Load(object sender, EventArgs e)
        {
            loadThemeColor();
        }
    }
}
