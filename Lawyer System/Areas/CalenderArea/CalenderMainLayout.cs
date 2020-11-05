using Lawyer_System.Areas.CalenderArea.Compentents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.CalenderArea
{
    public partial class CalenderMainLayout : Form
    {
        public DateTime date { get; set; }

        public CalenderMainLayout()
        {
            InitializeComponent();
            pictureBox2.Dock = DockStyle.Fill;
        }

        private void CalenderMainLayout_Resize(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            Task.Run(calenderSizes).GetAwaiter().OnCompleted(() => pictureBox2.Visible = false);
        }

        private void calenderSizes()
        {
            if (date.ToShortDateString() == "1/1/0001")
                return;
            int MainMonth = date.Month;
            int DayWidth = (flowLayoutPanel1.Width / 7 - 1);
            int Dayheight = ((flowLayoutPanel1.Height - 33) / 6 - 1);
            for (int i = 0; i < 7; i++)
            {
                var panel = flowLayoutPanel1.Controls[i] as Panel;
                if (i == 0)
                    this.Invoke(new Action(() => { panel.Margin = new Padding(2, 0, 0, 0); }));
                this.Invoke(new Action(() => { panel.Width = DayWidth; }));
            }
            for (int i = 7; i < flowLayoutPanel1.Controls.Count;)
            {
                this.Invoke(new Action(() => { flowLayoutPanel1.Controls.RemoveAt(i); }));

            }
            date = date.AddDays((date.Day - 1) * -1);
            var DayInt = date.DayOfWeek.GetHashCode();
            var dateFlag = date;
            dateFlag = dateFlag.AddDays((DayInt * -1) - 1);
            for (int i = 0; i < DayInt; i++)
            {
                dateFlag = dateFlag.AddDays(1);
                var d = new DayOfCalender()
                {
                    Height = Dayheight,
                    Width = DayWidth,
                    BorderStyle = BorderStyle.FixedSingle,
                    date = dateFlag,
                    IsSelectedDate = dateFlag == dateTimePicker1.Value,
                    Margin = flowLayoutPanel1.Controls.Count % 7 == 0 || i == 0 ? new Padding(2, 0, 0, 0) : new Padding(0, 0, 0, 0),
                    DayNum = dateFlag.Day,
                    IsInMonth = dateFlag.Month == MainMonth
                };
                this.Invoke(new Action(() => { flowLayoutPanel1.Controls.Add(d); }));

            }
            int n = flowLayoutPanel1.Controls.Count;
            for (int i = 0; i < 49 - n; i++)
            {
                dateFlag = dateFlag.AddDays(1);
                var d = new DayOfCalender()
                {
                    Height = Dayheight,
                    Width = DayWidth,
                    BorderStyle = BorderStyle.FixedSingle,
                    IsSelectedDate = dateFlag == dateTimePicker1.Value,
                    Margin = flowLayoutPanel1.Controls.Count % 7 == 0 ? new Padding(2, 0, 0, 0) : new Padding(0, 0, 0, 0),
                    DayNum = dateFlag.Day,
                    IsInMonth = dateFlag.Month == MainMonth
                };
                this.Invoke(new Action(() => { flowLayoutPanel1.Controls.Add(d); }));
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            pictureBox2.Visible = true;
            Task.Run(calenderSizes).GetAwaiter().OnCompleted(() => pictureBox2.Visible = false);
        }

        private void CalenderMainLayout_Load(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
            pictureBox2.Visible = true;
            Task.Run(calenderSizes).GetAwaiter().OnCompleted(() => pictureBox2.Visible = false);
        }
    }
}
