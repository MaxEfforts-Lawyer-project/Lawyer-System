
using Lawyer_System.Areas.sessionarea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas.LawsuitArea
{
    public partial class CreateLawSuitArea : Form
    {
        ApplicationDbContext context;
        int CurentLaswuitId;
        List<Client> clientlist = new List<Client>();
        List<Opponent> oppnentlist = new List<Opponent>();
        public CreateLawSuitArea()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        
        }
       
     
        private void loadThemeColor()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
                label4.ForeColor = ThemeColors.SecondaryColor;
                label5.ForeColor = ThemeColors.SecondaryColor;
                lblLawsuitNumber.ForeColor = ThemeColors.SecondaryColor;
                lblYear.ForeColor = ThemeColors.SecondaryColor;
            }
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
            try
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
                if (LawsuitTypecomboBox.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل نوع الدعوى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var lawsuitEnryNum = Convert.ToInt32(LawSuitNumpertextBox.Text);
                var ifFoundFawsuitNumber = context.lawsuits.FirstOrDefault(l => l.LawsuitNumber == lawsuitEnryNum.ToString() && l.year ==YeartextBox.Text);
                if (ifFoundFawsuitNumber != null)
                {
                    MessageBox.Show("رقم الدعوى لهذة السنة موجود بالفعل لا يمكن اضافتة مرة اخرى", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Lawsuit ls = new Lawsuit()
                {
                    LawsuitNumber = LawSuitNumpertextBox.Text,
                    year = YeartextBox.Text,
                    date = dateTimePicker1.Value,
                    LawsuitType = LawsuitTypecomboBox.SelectedValue.ToString(),
                    LawsuitDetails = tfaselEld3wacomboBox.SelectedValue == null ? "" :tfaselEld3wacomboBox.SelectedValue.ToString()
                };
                context.lawsuits.Add(ls);
                context.SaveChanges();
                
                CurentLaswuitId = ls.Id;
                context.sessions.Add(new session()
                {
                    date = dateTimePicker1.Value,
                    LawsuiteId = CurentLaswuitId
                }) ;
                context.SaveChanges();
                MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  var curentlawsuit = context.lawsuits.FirstOrDefault(l => l.Id == CurentLaswuitId);
                lblLawsuitNumber.Text = curentlawsuit.LawsuitNumber;
                lblYear.Text = curentlawsuit.year;
                panelAddNewClient.Enabled = true;
                Savebutton.Enabled = false;


            }
            catch (Exception dd){
                MessageBox.Show(dd.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void searchtextBox_KeyUp(object sender, KeyEventArgs e)
        {    
            //var d = context.clients.Where(c => c.Name.Contains(searchtextBox.Text)).ToList();
            //searchtextBox.AutoCompleteMode = d;

        }

        private void AddclientTolatsuit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("لا يوجد بيانات للاضافة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var curentLawsuit = context.lawsuits.Include(X => X.clients).FirstOrDefault(c => c.Id == CurentLaswuitId);
                foreach (var item in clientlist)
                {
                    var client = context.clients.FirstOrDefault(c => c.Id == item.Id);
                    curentLawsuit.clients.Add(client);
                    context.SaveChanges();
                   
                } if (OppnentdataGridView.Rows.Count > 0)
                    {
                        foreach (var oppnent in oppnentlist)
                        {
                            var newopp = new Opponent()
                            {
                                Name = oppnent.Name,
                                Notes = oppnent.Notes,
                                LawsuitId = CurentLaswuitId,
                            };
                            context.opponents.Add(newopp);
                            
                        }
                    }
                    context.SaveChanges();
                    MessageBox.Show("تم الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    OppnentdataGridView.DataSource = null;
                    OpponenttextBox.Text = "";
                    searnamechtextBox.Text = "";


                
            }
            catch
            { }
        }

        private void AddtoGrid_Click(object sender, EventArgs e)
        {
            if (searnamechtextBox.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموكل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var client = context.clients.FirstOrDefault(c => c.Name == searnamechtextBox.Text);
            if (client == null)
            {
                MessageBox.Show("لا يوجد موكل بهذا الاسم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var clientntt in clientlist)
            {
                if (clientntt.Name == searnamechtextBox.Text)
                {
                    MessageBox.Show("هذا الاسم موجود بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    searnamechtextBox.Text = "";
                    return;
                }
            }
            clientlist.Add(client);

            lodclientgrid();
            searnamechtextBox.Text = "";
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
        private void CreateLawSuitArea_Load(object sender, EventArgs e)
        {
            loadThemeColor();
            panelAddNewClient.Enabled = false;
            tfaselEld3wacomboBox.Enabled = false;
           

            LawsuitTypecomboBox.DataSource = ApplicationManager.LawsuitTypDictionary.ToArray();
            LawsuitTypecomboBox.DisplayMember = "Value";
            LawsuitTypecomboBox.ValueMember = "Key";
            //LawsuitTypecomboBox.Visible = true;
            LawsuitTypecomboBox.SelectedIndex = -1;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LawsuitTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tfaselEld3wacomboBox.Enabled = true;
                if (LawsuitTypecomboBox.SelectedIndex > -1)
                {
                    if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.MadanyGoz2y.ToString())
                    {
                        tfaselEld3wacomboBox.DataSource = ApplicationManager.LawsuitTypDictionarymadanygoz2y.ToArray();
                        tfaselEld3wacomboBox.DisplayMember = "Value";
                        tfaselEld3wacomboBox.ValueMember = "Key";
                    }

                    if (LawsuitTypecomboBox.SelectedValue.ToString() == ApplicationManager.LawsuitType.MadanyKoly.ToString())
                    {
                        tfaselEld3wacomboBox.DataSource = ApplicationManager.LawsuitTypDictionarymadanykoly.ToArray();
                        tfaselEld3wacomboBox.DisplayMember = "Value";
                        tfaselEld3wacomboBox.ValueMember = "Key";
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
            catch{ }
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            { 
             var cities = context.clients.Select(x => x.Name).ToArray();

            AutoCompleteStringCollection instcol = new AutoCompleteStringCollection();
            instcol.AddRange(cities);
            searnamechtextBox.AutoCompleteCustomSource = instcol;
            }
            catch { }
           
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
         OppnentdataGridView.DataSource = null;
            OppnentdataGridView.DataSource = oppnentlist;
            OppnentdataGridView.Columns["Id"].Visible = false;
            OppnentdataGridView.Columns["LawsuitId"].Visible = false;
            OppnentdataGridView.Columns["lawsuit"].Visible = false;
        }
        private void searchtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        
        }

        private void DeleteClientbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0 && dataGridView1.SelectedRows.Count<2)
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

        private void deleteoppnentbutton_Click(object sender, EventArgs e)
        {
            if (OppnentdataGridView.SelectedRows.Count > 0 && OppnentdataGridView.SelectedRows.Count < 2)
            {
                var oppnentnaame = OppnentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
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
        }
        AutoCompleteStringCollection instcol;
        private void searnamechtextBox_TextChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                context = new ApplicationDbContext();
                var cities = context.clients.Select(x => x.Name).ToArray();
                     instcol = new AutoCompleteStringCollection();
                    instcol.AddRange(cities);
            }).GetAwaiter().OnCompleted(() =>
            {
                searnamechtextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                searnamechtextBox.AutoCompleteCustomSource = instcol;
            });
            
        }

        private void searnamechtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back )
            {
                string s = searnamechtextBox.SelectedText;

                //searnamechtextBox.Text = s;
                //if (s.Length > 1)
                //{
                //    s = s.Substring(0, s.Length - 1);
                //}
                //else
                //{
                //    s = "0";
                //}
                int ss = searnamechtextBox.Text.IndexOf(s) - 1;
                searnamechtextBox.Text = searnamechtextBox.Text.Remove(ss, s.Length);




                //string s = searnamechtextBox.Text;

                //if (s.Length > 1)
                //{
                //    s = s.Substring(0, s.Length - 1);
                //}
                //else
                //{
                //    s = "0";
                //}

                //searnamechtextBox.Text = s;
                //e.SuppressKeyPress = true;
                //int selStart = searnamechtextBox.SelectionStart;
                //while (selStart > 0 && searnamechtextBox.Text.Substring(selStart - 1, 1) == " ")
                //{
                //    selStart--;
                //}
                //int prevSpacePos = -1;
                //if (selStart != 0)
                //{
                //    prevSpacePos = searnamechtextBox.Text.LastIndexOf(' ', selStart - 1);
                //}
                //searnamechtextBox.Select(prevSpacePos + 1, searnamechtextBox.SelectionStart - prevSpacePos - 1);
                //searnamechtextBox.SelectedText = "";
                ///////
                //string s = searnamechtextBox.Text;

                //if (s.Length > 1)
                //{
                //    s = s.Substring(0, s.Length - 1);
                //}
                //else
                //{
                //    s = "0";
                //}

                //searnamechtextBox.Text = s;
            }

        }
    }
}
