using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classroom.Client.HelpEntities;
using Classroom.Client.Helpers;

namespace Classroom.Client
{
    public partial class Classroom : Form
    {
        private static  List<PanelDto> _listPanels { get; set; } 
        private static  List<PanelDto> _listPanelsForSecretary { get; set; } 
        public Classroom()
        {
            InitializeComponent();
            _listPanels = new List<PanelDto>();
            _listPanels.Add(new PanelDto() {PanelEntity = this.Authorize, Name = $"{nameof(this.Authorize)}"});
            _listPanels.Add(new PanelDto() {PanelEntity = this.SecretaryMenu, Name = $"{nameof(this.SecretaryMenu)}"});
            _listPanels.Add(new PanelDto() {PanelEntity = this.Student, Name = $"{nameof(this.Student)}"});
            
            _listPanelsForSecretary = new List<PanelDto>();
            _listPanelsForSecretary.Add(new PanelDto() {PanelEntity = this.WorkWithGroupsPanel, Name = $"{nameof(this.WorkWithGroupsPanel)}"});
            _listPanelsForSecretary.Add(new PanelDto() {PanelEntity = this.WorkWithStudentsPanel, Name = $"{nameof(this.WorkWithStudentsPanel)}"});
            _listPanelsForSecretary.Add(new PanelDto() {PanelEntity = this.WorkWithAttachmentsPanel, Name = $"{nameof(this.WorkWithAttachmentsPanel)}"});
            _listPanelsForSecretary.Add(new PanelDto() {PanelEntity = this.WorkWithTeachersPanel, Name = $"{nameof(this.WorkWithTeachersPanel)}"});
            _listPanelsForSecretary.Add(new PanelDto() {PanelEntity = this.WorkWithSubjectsPanel, Name = $"{nameof(this.WorkWithSubjectsPanel)}"});
            _listPanelsForSecretary.Add(new PanelDto() {PanelEntity = this.WorkWithTasksPanel, Name = $"{nameof(this.WorkWithTasksPanel)}"});
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangePanel_Click(object sender, EventArgs e)
        {
            var panelDto =_listPanels.Where(p => p.Name == "Authorize").FirstOrDefault();
            if (panelDto != null)
            {
                panelDto.PanelEntity.Width = 0;
            }
        }

        private void Authorize_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(AuthorizeForm.Parent.BackColor);
            Control control = AuthorizeForm;
            int radius = 30;
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddLine(radius, 0, control.Width - radius, 0);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
                path.AddLine(control.Width, radius, control.Width, control.Height - radius);
                path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
                path.AddLine(control.Width - radius, control.Height, radius, control.Height);
                path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
                path.AddLine(0, control.Height - radius, 0, radius);
                path.AddArc(0, 0, radius, radius, 180, 90);
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
        

        private void SingInButton_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanels, "SecretaryMenu");
        }

        private void ExitPictureSecretary_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanels, "Authorize");
        }

        private void WorkWithGroups_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanelsForSecretary, "WorkWithGroupsPanel");
        }

        private void WorkWithStudents_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanelsForSecretary, "WorkWithStudentsPanel");
        }

        private void WorkWithTeachers_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanelsForSecretary, "WorkWithTeachersPanel");
        }

        private void WorkWithTasks_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanelsForSecretary, "WorkWithTasksPanel");
        }

        private void WorkWithSubjects_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanelsForSecretary, "WorkWithSubjectsPanel");
        }

        private void WorkWithAttachment_Click(object sender, EventArgs e)
        {
            PanelHelper.OpenPanel(_listPanelsForSecretary, "WorkWithAttachmentsPanel");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateSubjectButton_Click(object sender, EventArgs e)
        {

        }

        private void UploadDocument_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select file to be upload.";
            openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
            if (filename == null)
            {
                MessageBox.Show("Please select a valid document.");
            }
            else
            {
                //we already define our connection globaly. We are just calling the object of connection.
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                System.IO.File.Copy(openFileDialog1.FileName, path  + filename);
                MessageBox.Show("Document uploaded.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
