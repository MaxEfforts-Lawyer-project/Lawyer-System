using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.sessionarea
{
    public partial class AddNewsession : Form
    {
        ApplicationDbContext context;
        int curentLawsuit;
        public AddNewsession(int id)
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            curentLawsuit = id;
        }

      

        private void AddNewsession_Load(object sender, EventArgs e)
        {

        }

        private void savebutonbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
