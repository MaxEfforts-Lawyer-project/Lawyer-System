using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.OpponentArea
{
    public partial class EditOppnentForm : Form
    {
        ApplicationDbContext context;
        int oppnentId;
        Opponent curentoppnent;

        public EditOppnentForm(int id)
        {

            InitializeComponent();
            context = new ApplicationDbContext();
            oppnentId = id;
        }

        private void EditOppnentForm_Load(object sender, EventArgs e)
        {
             curentoppnent = context.opponents.FirstOrDefault(o=>o.Id == oppnentId);
            OpponenttextBox.Text = curentoppnent.Name;
            notsrichTextBox.Text = curentoppnent.Notes;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (OpponenttextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الخصم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            curentoppnent.Name = OpponenttextBox.Text;
            curentoppnent.Notes = notsrichTextBox.Text;
            context.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
