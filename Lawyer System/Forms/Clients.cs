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
        public Clients()
        {
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Save to DB
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            loadThemeColor();
        }
    }
}
