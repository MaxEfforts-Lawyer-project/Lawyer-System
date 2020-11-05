using System;
using System.Collections.Generic;
using System.Drawing;
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
        }

        

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
                    Color color = ThemeColors.selectButtonColor(colorIndex);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new Font("", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    currentButton.Image = (Image)new Bitmap(currentButton.Image, new Size(52, 52));
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.2);
                    panelTitleBar.BackColor =ThemeColors.ChangeColorBrightness(color,-0.05);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor= ThemeColors.ChangeColorBrightness(color, -0.2);
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
            int colorIndex = 7;
            openForm(clientsForm,sender,colorIndex,formTitle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control btn in panelMainMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    buttons.Add((Button)btn);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeButton(sender, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activeButton(sender, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activeButton(sender, 8);
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
        }
    }

}
