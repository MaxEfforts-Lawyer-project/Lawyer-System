
using Lawyer_System.Areas.ClientArea;
using Lawyer_System.Areas.OpponentArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        List<Client> clientlist = new List<Client>();
        List<Client> AllClientforLawsuit ;
        List<Opponent> oppnentlist = new List<Opponent>();
        public bool IsMouseClicked { get; set; }



        //Tesssssssssssssssssssssssssssssssssst
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00040000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }




        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);







        public EditLawSuitForm(int id)
        {
            
            InitializeComponent();
            context = new ApplicationDbContext();
            LawsuitId = id;
            pictureBox2.Dock = DockStyle.Fill;  
            refreshForm();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        public void refreshForm()
        {
            context = new ApplicationDbContext();
            curentlawsuit = context.lawsuits.FirstOrDefault(l => l.Id == this.LawsuitId);
            try
            {
                AllClientforLawsuit = context.lawsuits.Include(x => x.clients).FirstOrDefault(x => x.Id == curentlawsuit.Id).clients.ToList();
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }

        private void loadThemeColor()
        {
            panelTitleBar.BackColor = ThemeColors.PrimaryColor;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                   // btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
                label4.ForeColor = ThemeColors.SecondaryColor;
                label5.ForeColor = ThemeColors.SecondaryColor;
                lblLawsuitNumber.ForeColor = ThemeColors.SecondaryColor;
                lblYear.ForeColor = ThemeColors.SecondaryColor;
            }
        }

        private void EditLawSuitForm_Load(object sender, EventArgs e)
        {

            loadThemeColor();

          //  refreshForm();
           
            LawsuitTypecomboBox.DataSource = ApplicationManager.LawsuitTypDictionary.ToArray();
            LawsuitTypecomboBox.DisplayMember = "Value";
            LawsuitTypecomboBox.ValueMember = "Key";

            LawSuitNumpertextBox.Text = curentlawsuit.LawsuitNumber.ToString();
            YeartextBox.Text = curentlawsuit.year.ToString();
            dateTimePicker1.Value = curentlawsuit.date;
            lblLawsuitNumber.Text = curentlawsuit.LawsuitNumber;
            lblYear.Text = curentlawsuit.year;
            LawsuitTypecomboBox.Text = ApplicationManager.LawsuitTypDictionary[curentlawsuit.LawsuitType];

            if (curentlawsuit.LawsuitType == ApplicationManager.LawsuitType.MadanyGoz2y.ToString())
            {
                tfaselEld3wacomboBox.DataSource = ApplicationManager.LawsuitTypDictionarymadanygoz2y.ToArray();
                tfaselEld3wacomboBox.DisplayMember = "Value";
                tfaselEld3wacomboBox.ValueMember = "Key";
                tfaselEld3wacomboBox.Text = ApplicationManager.LawsuitTypDictionarymadanygoz2y[curentlawsuit.LawsuitDetails];
            }

            if (curentlawsuit.LawsuitType == ApplicationManager.LawsuitType.MadanyKoly.ToString())
            {
                tfaselEld3wacomboBox.DataSource = ApplicationManager.LawsuitTypDictionarymadanykoly.ToArray();
                tfaselEld3wacomboBox.DisplayMember = "Value";
                tfaselEld3wacomboBox.ValueMember = "Key";
                tfaselEld3wacomboBox.Text = ApplicationManager.LawsuitTypDictionarymadanykoly[curentlawsuit.LawsuitDetails];
            }

            loadMaingrid();

            //DragForm

        }
        void loadMaingrid()
        {
            context = new ApplicationDbContext();
            MainClientsdataGridView.DataSource = null;
            var allclients = context.lawsuits.Include(x => x.clients).FirstOrDefault(x => x.Id == curentlawsuit.Id).clients.ToList();

            MainClientsdataGridView.DataSource = allclients;
            MainClientsdataGridView.Columns["Id"].Visible = false;
            MainClientsdataGridView.Columns["tawkelNumber"].Visible = false;
            MainClientsdataGridView.Columns["AuthorizationDate"].Visible = false;
            MainClientsdataGridView.Columns["lawsuits"].Visible = false;

            MainOppnentdataGridView.DataSource = null;
            var alloppnents = context.opponents.Where(x => x.LawsuitId == curentlawsuit.Id).ToList();

            MainOppnentdataGridView.DataSource = alloppnents;
            MainOppnentdataGridView.Columns["Id"].Visible = false;
            MainOppnentdataGridView.Columns["LawsuitId"].Visible = false;
            MainOppnentdataGridView.Columns["lawsuit"].Visible = false;
    }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (LawSuitNumpertextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم الدعوى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lawsuitEnryNum = int.Parse(LawSuitNumpertextBox.Text);
            var ifFoundFawsuitNumber = context.lawsuits.FirstOrDefault(l => l.LawsuitNumber == lawsuitEnryNum.ToString());
            if (ifFoundFawsuitNumber != null)
            {
                MessageBox.Show("رقم الدعوى موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var curentlawsuitt = context.lawsuits.FirstOrDefault(l => l.Id == curentlawsuit.Id);
            curentlawsuitt.LawsuitNumber = LawSuitNumpertextBox.Text;
            curentlawsuitt.year =YeartextBox.Text;
            curentlawsuitt.date = dateTimePicker1.Value;
            curentlawsuitt.LawsuitType = LawsuitTypecomboBox.SelectedValue.ToString();
            curentlawsuitt.LawsuitDetails = tfaselEld3wacomboBox.SelectedValue == null ? "" : tfaselEld3wacomboBox.SelectedValue.ToString();
            context.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var curentlawsuitafterchange = context.lawsuits.FirstOrDefault(l=>l.Id == curentlawsuit.Id);
            lblLawsuitNumber.Text = curentlawsuitafterchange.LawsuitNumber;
            lblYear.Text = curentlawsuitafterchange.year;

        }

        private void AddtoGrid_Click(object sender, EventArgs e)
        {
            if (searchtextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموكل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var client = context.clients.FirstOrDefault(c => c.Name == searchtextBox.Text);
            if (client == null)
            {
                MessageBox.Show("لا يوجد موكل بهذا الاسم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var clientntt in clientlist)
            {
                if (clientntt.Name == searchtextBox.Text)
                {
                    MessageBox.Show("هذا الاسم موجود بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    searchtextBox.Text = "";
                    return;
                }
            }
            clientlist.Add(client);
            lodclientgrid();
            searchtextBox.Text = "";
        }
        void lodclientgrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientlist;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["tawkelNumber"].Visible = false;
            dataGridView1.Columns["AuthorizationDate"].Visible = false;
            dataGridView1.Columns["lawsuits"].Visible = false;
        }
        
        private void AddclientTolatsuit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 && AddNewOppnentInlistdataGridView.Rows.Count <1)
            {
                MessageBox.Show("لا يوجد بيانات للاضافة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
          
            try
            { 
                var curentLawsuit = context.lawsuits.Include(X => X.clients).FirstOrDefault(c =>c.Id == curentlawsuit.Id);
                var alloppnent = context.opponents.Where(o=>o.LawsuitId == curentLawsuit.Id).ToList();
                foreach (var opp in oppnentlist)
                {
                    foreach (var item in alloppnent)
                    {
                        if (opp.Name == item.Name  && opp.Notes == item.Notes)
                        {
                            MessageBox.Show("يوجد خصم/ خصوم موجود بالفعل فى هذة الدعوى", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                            
                        }
                    }
                }
                foreach (var opp in oppnentlist)
                {
                    var newoppnent = new Opponent()
                    { 
                    Name = opp.Name,
                    Notes = opp.Notes,
                    LawsuitId = curentLawsuit.Id
                    };
                    context.opponents.Add(newoppnent);
                    context.SaveChanges();
                }
                    foreach (var item in clientlist)
                {
                    var client = context.clients.FirstOrDefault(c => c.Id == item.Id);

                    curentLawsuit.clients.Add(client);
                    
                }
                    context.SaveChanges();
                    MessageBox.Show("تم الحفظ  بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                AddNewOppnentInlistdataGridView.DataSource = null;
                    loadMaingrid();
                    return;

            }
            catch
            { }
        }

        private void LawsuitTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LawsuitTypecomboBox.SelectedIndex > -1)
            {
                if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.MadanyGoz2y.ToString())
                {
                    tfaselEld3wacomboBox.DataSource = ApplicationManager.LawsuitTypDictionarymadanygoz2y.ToArray();
                    tfaselEld3wacomboBox.DisplayMember = "Value";
                    tfaselEld3wacomboBox.ValueMember = "Key";
                    tfaselEld3wacomboBox.Enabled = true;
                }

                if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.MadanyKoly.ToString())
                {
                    tfaselEld3wacomboBox.DataSource = ApplicationManager.LawsuitTypDictionarymadanykoly.ToArray();
                    tfaselEld3wacomboBox.DisplayMember = "Value";
                    tfaselEld3wacomboBox.ValueMember = "Key";
                    tfaselEld3wacomboBox.Enabled = true;
                }
                if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.Est2naf.ToString())
                {
                    tfaselEld3wacomboBox.Text = "";
                    tfaselEld3wacomboBox.Enabled = false;
                }
                if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.Gon7.ToString())
                {
                    tfaselEld3wacomboBox.Text = "";
                    tfaselEld3wacomboBox.Enabled = false;
                }
                if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.Kda2Edary.ToString())
                {
                    tfaselEld3wacomboBox.Text = "";
                    tfaselEld3wacomboBox.Enabled = false;
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsMouseClicked = true;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsMouseClicked = false;
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && IsMouseClicked)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Cut"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void searchtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cities = context.clients.Select(x => x.Name).ToArray();

                AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();
                instcol.AddRange(cities);
                searchtextBox.AutoCompleteCustomSource = instcol;
            }
            catch { }
        }

        private void DeleteClientbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows.Count < 2)
            {
                var clientname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                foreach (var clientntt in clientlist)
                {
                    if (clientntt.Name == clientname)
                    {
                        clientlist.Remove(clientntt);
                        break;
                    }
                }
                lodclientgrid();
            }

        }

        private void AddOppnentbutton_Click(object sender, EventArgs e)
        {
            if (OpponenttextBox.Text == "")
            {

                MessageBox.Show("من فضلك ادخل اسم الخصم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var opppn in oppnentlist)
            {
                if (opppn.Name == OpponenttextBox.Text)
                {
                    MessageBox.Show("هذا الاسم موجود بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            var oppnent = new Opponent()
            {
                Name = OpponenttextBox.Text,
                Notes = notsrichTextBox.Text
            };
            oppnentlist.Add(oppnent);
            loadoppnentgrid();
            OpponenttextBox.Text = "";
            notsrichTextBox.Text = "";
        }
        void loadoppnentgrid()
            {
            AddNewOppnentInlistdataGridView.DataSource = null;
            AddNewOppnentInlistdataGridView.DataSource = oppnentlist;
            AddNewOppnentInlistdataGridView.Columns["Id"].Visible = false;
            AddNewOppnentInlistdataGridView.Columns["LawsuitId"].Visible = false;
            AddNewOppnentInlistdataGridView.Columns["lawsuit"].Visible = false;
            }
        private void deleteoppnentbutton_Click(object sender, EventArgs e)
        {
            if (MainOppnentdataGridView.SelectedRows.Count > 0 && MainOppnentdataGridView.SelectedRows.Count < 2)
            {
                var oppnentnaame = AddNewOppnentInlistdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                foreach (var oppne in oppnentlist)
                {
                    if (oppne.Name == oppnentnaame)
                    {
                        oppnentlist.Remove(oppne);
                        break;
                    }
                }
                loadoppnentgrid();
            }
            else
            {

                MessageBox.Show("اختر الخصم المراد حذفة", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void EditOppnenntbutton_Click(object sender, EventArgs e)
        {
            if (MainOppnentdataGridView.SelectedRows.Count > 0 && MainOppnentdataGridView.SelectedRows.Count < 2)
            {

                int oppnentid = int.Parse(MainOppnentdataGridView.SelectedRows[0].Cells[0].Value.ToString());
                EditOppnentForm oppnentForm = new EditOppnentForm(oppnentid);
                oppnentForm.FormClosed += closed;
                oppnentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" اختر العميل المراد تعديله فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void EditMainClientbutton_Click(object sender, EventArgs e)
        {
            if (MainClientsdataGridView.SelectedRows.Count > 0 && MainClientsdataGridView.SelectedRows.Count < 2)
            {

                int clientid = int.Parse(MainClientsdataGridView.SelectedRows[0].Cells[0].Value.ToString());   
                EditClientForm editClientForm = new EditClientForm(clientid);
                editClientForm.FormClosed += closed;
                editClientForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" اختر العميل المراد تعديله فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            loadMaingrid();
        }

        private void DeleteMainClientbutton_Click(object sender, EventArgs e)
        {
            if (MainClientsdataGridView.SelectedRows.Count > 0 && MainClientsdataGridView.SelectedRows.Count < 2)
            {

               DialogResult res =  MessageBox.Show(" هل انت واثق من حذف هذا العميل", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (res == DialogResult.No)
                {
                    return;
                }
                if (res == DialogResult.Yes)
                { 
                int clientid = int.Parse(MainClientsdataGridView.SelectedRows[0].Cells[0].Value.ToString());
                var clien = context.clients.FirstOrDefault(c=>c.Id == clientid);
                context.clients.Remove(clien);
                context.SaveChanges();
                  MessageBox.Show(" تم الحذف بنجاح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMaingrid();
                    return;
                }
                
                
            }
            else
            {
                MessageBox.Show(" اختر العميل المراد حذفة  فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void deletemainOppnentbutton_Click(object sender, EventArgs e)
        {
            if (MainOppnentdataGridView.SelectedRows.Count > 0 && MainOppnentdataGridView.SelectedRows.Count < 2)
            {

                DialogResult res = MessageBox.Show(" هل انت واثق من حذف هذا الخصم", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                {
                    return;
                }
                if (res == DialogResult.Yes)
                {
                    int oppnentid = int.Parse(MainOppnentdataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    var opp = context.opponents.FirstOrDefault(c => c.Id == oppnentid);
                    context.opponents.Remove(opp);
                    context.SaveChanges();
                    MessageBox.Show(" تم الحذف بنجاح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMaingrid();
                    return;
                }
            }
            else
            {
                MessageBox.Show(" اختر الخصم المراد تعديله فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
