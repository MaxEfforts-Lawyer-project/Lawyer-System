using Lawyer_System.Areas.LawsuitArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lawyer_System.Areas
{
    public partial class MainForm : Form
    { 
        Form CurrentForm;
        ApplicationDbContext context;
        List<Lawsuit> allLawSuuit = new List<Lawsuit>();
      //  List<Client> allLclients = new List<Client>();
         List<ClientDto> curntlawsuit;
        public MainForm()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
          //  pictureBox2.Dock = DockStyle.Fill;
            refreshForm();
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
                label2.ForeColor = ThemeColors.SecondaryColor;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            loadThemeColor();
            refreshForm();
            searchLawsuitradioButton.Checked = true;
        }
        private void OpenForm(Form form)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            form.MdiParent = this.MdiParent;
            CurrentForm = form;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CreateLawSuitArea addLawsuit = new CreateLawSuitArea();
            OpenForm(addLawsuit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
        public void refreshForm()
        {
            context = new ApplicationDbContext();
         //   pictureBox2.Visible = true;
            Task.Run(() =>
            {

                allLawSuuit = context.lawsuits.ToList();
             
            }).GetAwaiter().OnCompleted(() =>
            {
                if(allLawSuuit.Count > 0)
                    loadGrid();
              //  pictureBox2.Visible = false;
            });
        }

        private void loadGrid()
        {
            try
            {
                LawSuitGridView.Rows.Clear();
                LawSuitGridView.DataSource = null;
                LawSuitGridView.DataSource = allLawSuuit;
                if (LawSuitGridView.Columns["Id"] != null)
                {
                    LawSuitGridView.Columns["Id"].Visible = false;
                    LawSuitGridView.Columns["clients"].Visible = false;
                    LawSuitGridView.Columns["documents"].Visible = false;

                    var all = context.clients.ToList();
                    clientdataGridView.DataSource = null;
                    clientdataGridView.DataSource = all;
                    clientdataGridView.Columns["Id"].Visible = false;
                    //clientdataGridView.Columns[]
                    clientdataGridView.Columns["AuthorizationDate"].Visible = false;
                    clientdataGridView.Columns["lawsuits"].Visible = false;
                }
            }
            catch
            {

            }

        }

        private void EditLawSuit_Click(object sender, EventArgs e)
        {
            if (LawSuitGridView.SelectedRows.Count > 0 && LawSuitGridView.SelectedRows.Count < 2)
            {

                int lawsuitid = int.Parse(LawSuitGridView.SelectedRows[0].Cells[0].Value.ToString());
                EditLawSuitForm editlawSuitform = new EditLawSuitForm(lawsuitid);
                editlawSuitform.FormClosed += formclosed;
                editlawSuitform.ShowDialog();

            }
            else
            {
                MessageBox.Show(" اختر الدعوى المراد تعديلها فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void formclosed(object sender, FormClosedEventArgs e)
        {
            refreshForm();
            if (allLawSuuit.Count > 0)
                loadGrid();
        }

        private void DeleteLawSuit_Click(object sender, EventArgs e)
        {
            if (LawSuitGridView.SelectedRows.Count > 0 && LawSuitGridView.SelectedRows.Count < 2)
            {

                int lawsuitid = int.Parse(LawSuitGridView.SelectedRows[0].Cells[0].Value.ToString());
                var lawsuit = context.lawsuits.FirstOrDefault(l => l.Id == lawsuitid);
                DialogResult res = MessageBox.Show(" هل انت والثق من حذف هذة لدعوى", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    context.lawsuits.Remove(lawsuit);
                    context.SaveChanges();
                    refreshForm();
                    if (allLawSuuit.Count > 0)
                        loadGrid();

                    MessageBox.Show(" تم الحذف بنجاح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show(" اختر الدعوى المراد تعديلها فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void clientbutton_Click(object sender, EventArgs e)
        {
            if (LawSuitGridView.SelectedRows.Count > 0 && LawSuitGridView.SelectedRows.Count < 2)
            {
                int lawsuitid = int.Parse(LawSuitGridView.SelectedRows[0].Cells[0].Value.ToString());
                var cliens = context.ides.Where(i => i.LawsuiteId == lawsuitid).Select(i => i.Client).ToList();
                settionsGridview.DataSource = cliens;
                settionsGridview.Columns["Id"].Visible = false;
            }
            else
            {
                MessageBox.Show(" اختر الدعوى المراد رؤية موكليها فقط", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void searchLawsuitradioButton_CheckedChanged(object sender, EventArgs e)
        {
            serchByNamegroupBox.Enabled = false;
            serchByNumgroupBox.Enabled = true;
        }

        private void searchnameradioButton_CheckedChanged(object sender, EventArgs e)
        {
            serchByNumgroupBox.Enabled = false;
            serchByNamegroupBox.Enabled = true;
        }

        private void LawsuitserchtextBox_KeyUp(object sender, KeyEventArgs e)
        {
           // pictureBox2.Visible = true;
            if (LawsuitserchtextBox.Text == "" && yearesearchtextBox.Text == "" )
            {
                refreshForm();
            }
            else
                Task.Run(() =>
                {
                    context = new ApplicationDbContext();
                    var serchLawsuitnumAndyearnum = context.lawsuits.Select(x => x);
                    if (LawsuitserchtextBox.Text != "")
                    {
                        serchLawsuitnumAndyearnum = serchLawsuitnumAndyearnum.Where(l => l.LawsuitNumber.Contains(LawsuitserchtextBox.Text));
                    }
                    if (yearesearchtextBox.Text != "")
                    {
                      serchLawsuitnumAndyearnum = serchLawsuitnumAndyearnum.Where(l => l.year.Contains(yearesearchtextBox.Text));
                    }
                   
                    curntlawsuit = serchLawsuitnumAndyearnum.Select(x => new ClientDto
                    {
                        Id = x.Id,
                        lawsuitNum = x.LawsuitNumber,
                        yeare = x.year,
                        date = x.date
                        
                    
                    }).ToList();
                }).GetAwaiter().OnCompleted(() =>
                {
                    //pictureBox2.Visible = false;
                    LawSuitGridView.DataSource = null;
                    context = new ApplicationDbContext();
                    LawSuitGridView.DataSource = curntlawsuit;
                    LawSuitGridView.Columns["Id"].Visible = false;              
                });
        }
        public class ClientDto
        {
            public int Id { get; set; }
       
            
            [DisplayName("رقم الدعوى")]
            public string lawsuitNum { get; set; }
            [DisplayName("السنة")]
            public string yeare { get; set; }
            [DisplayName("تاريخ الجلسة")]
            public DateTime date { get; set; }

        }

        private void clientnamesearchtextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (clientnamesearchtextBox.Text == "")
            {
                refreshForm();
            }
            else
            {
                var nameserch = context.clients.Where(l => l.Name.Contains(LawsuitserchtextBox.Text));

            }
        }

        private void sessionbutton_Click(object sender, EventArgs e)
        {
            if (LawSuitGridView.SelectedRows.Count > 0 && LawSuitGridView.SelectedRows.Count < 2)
            {
                var lawsuitid = int.Parse(LawSuitGridView.SelectedRows[0].Cells[0].Value.ToString());
                var aseetions  = context.sessions.Where(x => x.LawsuiteId == lawsuitid).ToList();
                settionsGridview.DataSource = aseetions;
                settionsGridview.Columns["Id"].Visible = false;
                settionsGridview.Columns["LawsuiteId"].Visible = false;
                settionsGridview.Columns["lawsuit"].Visible = false;
            }
            else
            {
                MessageBox.Show(" اختر صف واحدد فقط للتعديل");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
