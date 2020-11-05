using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.CalenderArea.Compentents
{
    public partial class DayOfCalender : UserControl
    {
        public int DayNum { get => int.Parse(button1.Text); set => button1.Text = value.ToString(); }
        public DateTime date { get; set; }
        public bool IsInMonth
        {
            get => Color.Orange == button1.BackColor;
            set
            {
                if (!value)
                {
                    button1.BackColor = Color.Azure;
                    button1.ForeColor = Color.Gray;
                    this.BackColor = Color.White;
                }
            }
        }

        public bool IsSelectedDate
        {
            get => Color.Yellow == this.BackColor;
            set
            {
                if (value)
                {
                    this.BackColor = Color.Yellow;
                }
                else
                {
                    this.BackColor = Color.Wheat;

                }
            }
        }
        public DayOfCalender()
        {
            InitializeComponent();
        }
    }
}
