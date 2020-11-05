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
    public partial class EditLawSuitForm : Form
    {
        int LawsuitId;
        ApplicationDbContext context;
        Lawsuit curentlawsuit;
        public EditLawSuitForm(int id)
        {
            InitializeComponent();
            LawsuitId = id;
            pictureBox2.Dock = DockStyle.Fill;
            context = new ApplicationDbContext();
            refreshForm();
        }
        public void refreshForm()
        {
            pictureBox2.Visible = true;
            Task.Run(() =>
            {
                curentlawsuit = context.lawsuits.FirstOrDefault(l=>l.Id == this.LawsuitId);
            }).GetAwaiter().OnCompleted(() =>
            {
                pictureBox2.Visible = false;
            });
        }
        private void EditLawSuitForm_Load(object sender, EventArgs e)
        {
            refreshForm();
            LawSuitNumpertextBox.Text = curentlawsuit.LawSuitNumber.ToString();
            YeartextBox.Text = curentlawsuit.year;
            dateTimePicker1.Value = curentlawsuit.date;
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (LawSuitNumpertextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم الدعوى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lawsuitEnryNum = int.Parse(LawSuitNumpertextBox.Text);
            var ifFoundFawsuitNumber = context.lawsuits.FirstOrDefault(l => l.LawSuitNumber == lawsuitEnryNum);
            if (ifFoundFawsuitNumber != null)
            {
                MessageBox.Show("رقم الدعوى موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            curentlawsuit.LawSuitNumber = int.Parse(LawSuitNumpertextBox.Text);
            curentlawsuit.year = YeartextBox.Text;
            curentlawsuit.date = dateTimePicker1.Value;
            context.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
