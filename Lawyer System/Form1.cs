using Lawyer_System.Areas;
using Lawyer_System.Areas.CalenderArea;
using Lawyer_System.Areas.LawsuitArea;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lawyer_System
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        private List<Button> buttons= new List<Button>();
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            tempIndex = 0;
            CloseButton.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;

            //Drag Form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);





        private Color selectRandomThemeColor()
        {

            int i = random.Next(ThemeColors.colors.Count);
            while (tempIndex == i)
                i = random.Next(ThemeColors.colors.Count);
            string color = ThemeColors.colors[i];
            return ColorTranslator.FromHtml(color);

        }


        private void activeButton (object btnSender, int colorIndex)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    disableOtherButtons();
                    Color color = ThemeColors.tempColorSelecet(colorIndex);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new Font("", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    currentButton.Image = (Image)new Bitmap(currentButton.Image, new Size(52, 52));
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.2);
                    panelTitleBar.BackColor =ThemeColors.ChangeColorBrightness(color,-0.05);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor= ThemeColors.ChangeColorBrightness(color, -0.2);
                    CloseButton.Visible = true;
                }
            }
        }


        private void disableOtherButtons()
        {
            foreach (Control previousButton in panelMainMenu.Controls)
            {
                if(previousButton.GetType() == typeof(Button)){
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font= new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }


        private void openForm(Form childForm, Object btnSender, int colorIndex,string formTitle)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeButton(btnSender,colorIndex);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHomeTitle.Text = formTitle;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string formTitle = "الموكلين";
            Form clientsForm = new Forms.Clients();
            int colorIndex = 0;//7
            openForm(clientsForm,sender,colorIndex,formTitle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          //  MainForm mainform = new MainForm();
          
            // openForm(mainform, sender, 0, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeButton(sender, 1);
            
            string formTitle = "اضافة دعوى";
            CreateLawSuitArea addlatsuit = new CreateLawSuitArea();
            int colorIndex = 1;
            openForm(addlatsuit, sender, colorIndex, formTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activeButton(sender, 2);
            CalenderMainLayout c = new CalenderMainLayout();
            openForm(c, sender, 2, "جدول المواعيد");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activeButton(sender, 3);//8
            MainForm mainform = new MainForm();
            string formTitle = "مدنى جذئى";
          
            int colorIndex = 3;//7
            openForm(mainform, sender, colorIndex, formTitle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            activeButton(sender, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            activeButton(sender, 5);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        void Reset() {
            disableOtherButtons();
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            CloseButton.Visible = false;
            labelHomeTitle.Text = "Welcome, Mina";
            currentButton = null;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
