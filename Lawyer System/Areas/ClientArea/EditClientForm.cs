using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.ClientArea
{
    public partial class EditClientForm : Form
    {
        ApplicationDbContext context;
        int clientId ;
        Client client;
        public EditClientForm(int id)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            clientId = id;
            this.Text = string.Empty;
            this.ControlBox = false;

        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            client = context.clients.FirstOrDefault(c => c.Id == clientId);
            txtBoxclientName.Text = client.Name;
            txtBoxPhoneNumber.Text = client.Phone;
            txtBoxIdCard.Text = client.NationalID;
            tawkelNumbertextBox.Text = client.tawkelNumber;
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
                    var clientt = context.clients.FirstOrDefault(c => c.NationalID == txtBoxIdCard.Text);

                    if (clientt != null)
                    {
                        MessageBox.Show("الرقم القومى لهذا العميل  موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                client.Name = txtBoxclientName.Text;
                client.Phone = txtBoxPhoneNumber.Text;
                client.NationalID = txtBoxIdCard.Text;
                client.tawkelNumber = tawkelNumbertextBox.Text;
                context.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }catch{ }
        }

       


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
