using Lawyer_System.Areas.DocumentsArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.LawsuitArea
{
    public partial class CreateLawSuitArea : Form
    {
        ApplicationDbContext context;
        public CreateLawSuitArea()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LawSuitNumpertextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم الدعوى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (YeartextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل السنة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lawsuitEnryNum = int.Parse(LawSuitNumpertextBox.Text);
            var ifFoundFawsuitNumber = context.lawsuits.FirstOrDefault(l=>l.LawSuitNumber == lawsuitEnryNum && l.year == YeartextBox.Text);
            if (ifFoundFawsuitNumber != null)
            {
                MessageBox.Show("رقم الدعوى لهذة السنة موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lawsuit ls = new Lawsuit()
            {
                LawSuitNumber = int.Parse(LawSuitNumpertextBox.Text),
                year = YeartextBox.Text,
                date = dateTimePicker1.Value
            };
            context.lawsuits.Add(ls);
            context.SaveChanges();
            MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
