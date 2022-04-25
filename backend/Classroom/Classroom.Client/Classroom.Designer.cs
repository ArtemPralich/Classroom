
using System.Drawing;
using System.Windows.Forms;

namespace Classroom.Client
{
    partial class Classroom
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classroom));
            this.Authorize = new System.Windows.Forms.Panel();
            this.AuthorizeForm = new System.Windows.Forms.Panel();
            this.SingInButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SecretaryMenu = new System.Windows.Forms.Panel();
            this.WorkWithAttachmentsPanel = new System.Windows.Forms.Panel();
            this.WorkWithSubjectsPanel = new System.Windows.Forms.Panel();
            this.CreateSubjectButton = new System.Windows.Forms.Button();
            this.SelectTeacherInput = new System.Windows.Forms.Label();
            this.SelectTeacher = new System.Windows.Forms.ComboBox();
            this.SubjectTitleLabel = new System.Windows.Forms.Label();
            this.SubjectTitle = new System.Windows.Forms.TextBox();
            this.WorkWithGroupsPanel = new System.Windows.Forms.Panel();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.SelectCourseInput = new System.Windows.Forms.ComboBox();
            this.SelectCourse = new System.Windows.Forms.Label();
            this.GroupNumberLabel = new System.Windows.Forms.Label();
            this.AddNewGroup = new System.Windows.Forms.Label();
            this.EnterNunberOfGroupInput = new System.Windows.Forms.TextBox();
            this.ListGroup = new System.Windows.Forms.ListBox();
            this.WorkWithTeachersPanel = new System.Windows.Forms.Panel();
            this.CreateTeacher = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TeacherAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TeacherUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TeacherEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TeacherPassword = new System.Windows.Forms.TextBox();
            this.TeacherLastname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TeacherFirstname = new System.Windows.Forms.TextBox();
            this.WorkWithStudentsPanel = new System.Windows.Forms.Panel();
            this.CreateStudent = new System.Windows.Forms.Button();
            this.SelectGroup = new System.Windows.Forms.Label();
            this.StudentGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentUsername = new System.Windows.Forms.TextBox();
            this.EnterEmail = new System.Windows.Forms.Label();
            this.StudentEmail = new System.Windows.Forms.TextBox();
            this.EnterPasswordForCreate = new System.Windows.Forms.Label();
            this.StudentPassword = new System.Windows.Forms.TextBox();
            this.StudentLastname = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentFirstname = new System.Windows.Forms.TextBox();
            this.WorkWithTasksPanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateSubject = new System.Windows.Forms.Button();
            this.SelectSubject = new System.Windows.Forms.Label();
            this.SelectType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WorkWithAttachment = new System.Windows.Forms.Button();
            this.WorkWithSubjects = new System.Windows.Forms.Button();
            this.WorkWithTasks = new System.Windows.Forms.Button();
            this.WorkWithTeachers = new System.Windows.Forms.Button();
            this.WorkWithGroups = new System.Windows.Forms.Button();
            this.WorkWithStudents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitPictureSecretary = new System.Windows.Forms.PictureBox();
            this.NameSecretary = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Panel();
            this.UploadDocument = new System.Windows.Forms.Button();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Authorize.SuspendLayout();
            this.AuthorizeForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SecretaryMenu.SuspendLayout();
            this.WorkWithSubjectsPanel.SuspendLayout();
            this.WorkWithGroupsPanel.SuspendLayout();
            this.WorkWithTeachersPanel.SuspendLayout();
            this.WorkWithStudentsPanel.SuspendLayout();
            this.WorkWithTasksPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureSecretary)).BeginInit();
            this.Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authorize
            // 
            this.Authorize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Authorize.Controls.Add(this.AuthorizeForm);
            this.Authorize.Location = new System.Drawing.Point(0, 0);
            this.Authorize.Name = "Authorize";
            this.Authorize.Size = new System.Drawing.Size(1200, 0);
            this.Authorize.TabIndex = 0;
            // 
            // AuthorizeForm
            // 
            this.AuthorizeForm.BackColor = System.Drawing.Color.White;
            this.AuthorizeForm.Controls.Add(this.SingInButton);
            this.AuthorizeForm.Controls.Add(this.PasswordLabel);
            this.AuthorizeForm.Controls.Add(this.UsernameLabel);
            this.AuthorizeForm.Controls.Add(this.PasswordInput);
            this.AuthorizeForm.Controls.Add(this.UsernameInput);
            this.AuthorizeForm.Controls.Add(this.pictureBox1);
            this.AuthorizeForm.Location = new System.Drawing.Point(400, 80);
            this.AuthorizeForm.Name = "AuthorizeForm";
            this.AuthorizeForm.Size = new System.Drawing.Size(400, 600);
            this.AuthorizeForm.TabIndex = 0;
            this.AuthorizeForm.Paint += new System.Windows.Forms.PaintEventHandler(this.Authorize_Paint);
            // 
            // SingInButton
            // 
            this.SingInButton.BackColor = System.Drawing.Color.Black;
            this.SingInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingInButton.Location = new System.Drawing.Point(147, 520);
            this.SingInButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.SingInButton.Name = "SingInButton";
            this.SingInButton.Size = new System.Drawing.Size(100, 40);
            this.SingInButton.TabIndex = 5;
            this.SingInButton.Text = "SingIn";
            this.SingInButton.UseVisualStyleBackColor = false;
            this.SingInButton.Click += new System.EventHandler(this.SingInButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(80, 439);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(80, 371);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(80, 462);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(239, 27);
            this.PasswordInput.TabIndex = 2;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(80, 394);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(239, 27);
            this.UsernameInput.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SecretaryMenu
            // 
            this.SecretaryMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.SecretaryMenu.Controls.Add(this.WorkWithAttachmentsPanel);
            this.SecretaryMenu.Controls.Add(this.WorkWithSubjectsPanel);
            this.SecretaryMenu.Controls.Add(this.WorkWithGroupsPanel);
            this.SecretaryMenu.Controls.Add(this.WorkWithTeachersPanel);
            this.SecretaryMenu.Controls.Add(this.WorkWithStudentsPanel);
            this.SecretaryMenu.Controls.Add(this.panel1);
            this.SecretaryMenu.Controls.Add(this.WorkWithTasksPanel);
            this.SecretaryMenu.Controls.Add(this.panel2);
            this.SecretaryMenu.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecretaryMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SecretaryMenu.Location = new System.Drawing.Point(0, 0);
            this.SecretaryMenu.Name = "SecretaryMenu";
            this.SecretaryMenu.Size = new System.Drawing.Size(1200, 800);
            this.SecretaryMenu.TabIndex = 1;
            // 
            // WorkWithAttachmentsPanel
            // 
            this.WorkWithAttachmentsPanel.Location = new System.Drawing.Point(267, 80);
            this.WorkWithAttachmentsPanel.Name = "WorkWithAttachmentsPanel";
            this.WorkWithAttachmentsPanel.Size = new System.Drawing.Size(932, 0);
            this.WorkWithAttachmentsPanel.TabIndex = 3;
            // 
            // WorkWithSubjectsPanel
            // 
            this.WorkWithSubjectsPanel.Controls.Add(this.CreateSubjectButton);
            this.WorkWithSubjectsPanel.Controls.Add(this.SelectTeacherInput);
            this.WorkWithSubjectsPanel.Controls.Add(this.SelectTeacher);
            this.WorkWithSubjectsPanel.Controls.Add(this.SubjectTitleLabel);
            this.WorkWithSubjectsPanel.Controls.Add(this.SubjectTitle);
            this.WorkWithSubjectsPanel.Location = new System.Drawing.Point(270, 80);
            this.WorkWithSubjectsPanel.Name = "WorkWithSubjectsPanel";
            this.WorkWithSubjectsPanel.Size = new System.Drawing.Size(932, 720);
            this.WorkWithSubjectsPanel.TabIndex = 2;
            // 
            // CreateSubjectButton
            // 
            this.CreateSubjectButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateSubjectButton.Location = new System.Drawing.Point(536, 46);
            this.CreateSubjectButton.Name = "CreateSubjectButton";
            this.CreateSubjectButton.Size = new System.Drawing.Size(163, 40);
            this.CreateSubjectButton.TabIndex = 4;
            this.CreateSubjectButton.Text = "Create";
            this.CreateSubjectButton.UseVisualStyleBackColor = true;
            this.CreateSubjectButton.Click += new System.EventHandler(this.CreateSubjectButton_Click);
            // 
            // SelectTeacherInput
            // 
            this.SelectTeacherInput.AutoSize = true;
            this.SelectTeacherInput.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeacherInput.Location = new System.Drawing.Point(286, 16);
            this.SelectTeacherInput.Name = "SelectTeacherInput";
            this.SelectTeacherInput.Size = new System.Drawing.Size(113, 31);
            this.SelectTeacherInput.TabIndex = 3;
            this.SelectTeacherInput.Text = "Enter title";
            this.SelectTeacherInput.Click += new System.EventHandler(this.label5_Click);
            // 
            // SelectTeacher
            // 
            this.SelectTeacher.FormattingEnabled = true;
            this.SelectTeacher.Location = new System.Drawing.Point(286, 50);
            this.SelectTeacher.Name = "SelectTeacher";
            this.SelectTeacher.Size = new System.Drawing.Size(227, 35);
            this.SelectTeacher.TabIndex = 2;
            // 
            // SubjectTitleLabel
            // 
            this.SubjectTitleLabel.AutoSize = true;
            this.SubjectTitleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubjectTitleLabel.Location = new System.Drawing.Point(33, 17);
            this.SubjectTitleLabel.Name = "SubjectTitleLabel";
            this.SubjectTitleLabel.Size = new System.Drawing.Size(113, 31);
            this.SubjectTitleLabel.TabIndex = 1;
            this.SubjectTitleLabel.Text = "Enter title";
            this.SubjectTitleLabel.Click += new System.EventHandler(this.Title_Click);
            // 
            // SubjectTitle
            // 
            this.SubjectTitle.Location = new System.Drawing.Point(33, 51);
            this.SubjectTitle.Name = "SubjectTitle";
            this.SubjectTitle.Size = new System.Drawing.Size(222, 34);
            this.SubjectTitle.TabIndex = 0;
            // 
            // WorkWithGroupsPanel
            // 
            this.WorkWithGroupsPanel.Controls.Add(this.AddGroupButton);
            this.WorkWithGroupsPanel.Controls.Add(this.SelectCourseInput);
            this.WorkWithGroupsPanel.Controls.Add(this.SelectCourse);
            this.WorkWithGroupsPanel.Controls.Add(this.GroupNumberLabel);
            this.WorkWithGroupsPanel.Controls.Add(this.AddNewGroup);
            this.WorkWithGroupsPanel.Controls.Add(this.EnterNunberOfGroupInput);
            this.WorkWithGroupsPanel.Controls.Add(this.ListGroup);
            this.WorkWithGroupsPanel.Location = new System.Drawing.Point(268, 80);
            this.WorkWithGroupsPanel.Name = "WorkWithGroupsPanel";
            this.WorkWithGroupsPanel.Size = new System.Drawing.Size(932, 0);
            this.WorkWithGroupsPanel.TabIndex = 5;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(686, 128);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(112, 36);
            this.AddGroupButton.TabIndex = 7;
            this.AddGroupButton.Text = "Add";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            // 
            // SelectCourseInput
            // 
            this.SelectCourseInput.FormattingEnabled = true;
            this.SelectCourseInput.Location = new System.Drawing.Point(332, 218);
            this.SelectCourseInput.Name = "SelectCourseInput";
            this.SelectCourseInput.Size = new System.Drawing.Size(348, 35);
            this.SelectCourseInput.TabIndex = 6;
            // 
            // SelectCourse
            // 
            this.SelectCourse.AutoSize = true;
            this.SelectCourse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectCourse.Location = new System.Drawing.Point(332, 183);
            this.SelectCourse.Name = "SelectCourse";
            this.SelectCourse.Size = new System.Drawing.Size(148, 31);
            this.SelectCourse.TabIndex = 5;
            this.SelectCourse.Text = "Select course";
            // 
            // GroupNumberLabel
            // 
            this.GroupNumberLabel.AutoSize = true;
            this.GroupNumberLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupNumberLabel.Location = new System.Drawing.Point(332, 96);
            this.GroupNumberLabel.Name = "GroupNumberLabel";
            this.GroupNumberLabel.Size = new System.Drawing.Size(247, 31);
            this.GroupNumberLabel.TabIndex = 4;
            this.GroupNumberLabel.Text = "Enter number of group";
            // 
            // AddNewGroup
            // 
            this.AddNewGroup.AutoSize = true;
            this.AddNewGroup.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewGroup.Location = new System.Drawing.Point(472, 22);
            this.AddNewGroup.Name = "AddNewGroup";
            this.AddNewGroup.Size = new System.Drawing.Size(208, 38);
            this.AddNewGroup.TabIndex = 3;
            this.AddNewGroup.Text = "Add new group";
            // 
            // EnterNunberOfGroupInput
            // 
            this.EnterNunberOfGroupInput.Location = new System.Drawing.Point(332, 130);
            this.EnterNunberOfGroupInput.Name = "EnterNunberOfGroupInput";
            this.EnterNunberOfGroupInput.Size = new System.Drawing.Size(348, 34);
            this.EnterNunberOfGroupInput.TabIndex = 2;
            // 
            // ListGroup
            // 
            this.ListGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListGroup.FormattingEnabled = true;
            this.ListGroup.ItemHeight = 31;
            this.ListGroup.Location = new System.Drawing.Point(34, 22);
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.Size = new System.Drawing.Size(236, 314);
            this.ListGroup.TabIndex = 1;
            // 
            // WorkWithTeachersPanel
            // 
            this.WorkWithTeachersPanel.Controls.Add(this.CreateTeacher);
            this.WorkWithTeachersPanel.Controls.Add(this.label6);
            this.WorkWithTeachersPanel.Controls.Add(this.TeacherAge);
            this.WorkWithTeachersPanel.Controls.Add(this.label7);
            this.WorkWithTeachersPanel.Controls.Add(this.TeacherUsername);
            this.WorkWithTeachersPanel.Controls.Add(this.label8);
            this.WorkWithTeachersPanel.Controls.Add(this.TeacherEmail);
            this.WorkWithTeachersPanel.Controls.Add(this.label9);
            this.WorkWithTeachersPanel.Controls.Add(this.TeacherPassword);
            this.WorkWithTeachersPanel.Controls.Add(this.TeacherLastname);
            this.WorkWithTeachersPanel.Controls.Add(this.label10);
            this.WorkWithTeachersPanel.Controls.Add(this.label11);
            this.WorkWithTeachersPanel.Controls.Add(this.TeacherFirstname);
            this.WorkWithTeachersPanel.Location = new System.Drawing.Point(270, 80);
            this.WorkWithTeachersPanel.Name = "WorkWithTeachersPanel";
            this.WorkWithTeachersPanel.Size = new System.Drawing.Size(932, 720);
            this.WorkWithTeachersPanel.TabIndex = 1;
            // 
            // CreateTeacher
            // 
            this.CreateTeacher.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeacher.Location = new System.Drawing.Point(587, 64);
            this.CreateTeacher.Name = "CreateTeacher";
            this.CreateTeacher.Size = new System.Drawing.Size(274, 43);
            this.CreateTeacher.TabIndex = 29;
            this.CreateTeacher.Text = "Add teacher";
            this.CreateTeacher.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(283, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Enter age";
            // 
            // TeacherAge
            // 
            this.TeacherAge.Location = new System.Drawing.Point(283, 215);
            this.TeacherAge.Name = "TeacherAge";
            this.TeacherAge.Size = new System.Drawing.Size(280, 34);
            this.TeacherAge.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(283, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter  username";
            // 
            // TeacherUsername
            // 
            this.TeacherUsername.Location = new System.Drawing.Point(283, 140);
            this.TeacherUsername.Name = "TeacherUsername";
            this.TeacherUsername.Size = new System.Drawing.Size(280, 34);
            this.TeacherUsername.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enter email";
            // 
            // TeacherEmail
            // 
            this.TeacherEmail.Location = new System.Drawing.Point(18, 215);
            this.TeacherEmail.Name = "TeacherEmail";
            this.TeacherEmail.Size = new System.Drawing.Size(236, 34);
            this.TeacherEmail.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(283, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "Enter password";
            // 
            // TeacherPassword
            // 
            this.TeacherPassword.Location = new System.Drawing.Point(283, 64);
            this.TeacherPassword.Name = "TeacherPassword";
            this.TeacherPassword.Size = new System.Drawing.Size(280, 34);
            this.TeacherPassword.TabIndex = 19;
            // 
            // TeacherLastname
            // 
            this.TeacherLastname.Location = new System.Drawing.Point(18, 140);
            this.TeacherLastname.Name = "TeacherLastname";
            this.TeacherLastname.Size = new System.Drawing.Size(236, 34);
            this.TeacherLastname.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Enter lastname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(20, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 31);
            this.label11.TabIndex = 16;
            this.label11.Text = "Enter firstname";
            // 
            // TeacherFirstname
            // 
            this.TeacherFirstname.Location = new System.Drawing.Point(18, 64);
            this.TeacherFirstname.Name = "TeacherFirstname";
            this.TeacherFirstname.Size = new System.Drawing.Size(236, 34);
            this.TeacherFirstname.TabIndex = 15;
            // 
            // WorkWithStudentsPanel
            // 
            this.WorkWithStudentsPanel.Controls.Add(this.CreateStudent);
            this.WorkWithStudentsPanel.Controls.Add(this.SelectGroup);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentGroup);
            this.WorkWithStudentsPanel.Controls.Add(this.label4);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentAge);
            this.WorkWithStudentsPanel.Controls.Add(this.label3);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentUsername);
            this.WorkWithStudentsPanel.Controls.Add(this.EnterEmail);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentEmail);
            this.WorkWithStudentsPanel.Controls.Add(this.EnterPasswordForCreate);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentPassword);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentLastname);
            this.WorkWithStudentsPanel.Controls.Add(this.LastName);
            this.WorkWithStudentsPanel.Controls.Add(this.label2);
            this.WorkWithStudentsPanel.Controls.Add(this.StudentFirstname);
            this.WorkWithStudentsPanel.Location = new System.Drawing.Point(270, 80);
            this.WorkWithStudentsPanel.Name = "WorkWithStudentsPanel";
            this.WorkWithStudentsPanel.Size = new System.Drawing.Size(932, 720);
            this.WorkWithStudentsPanel.TabIndex = 70;
            // 
            // CreateStudent
            // 
            this.CreateStudent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateStudent.Location = new System.Drawing.Point(605, 190);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(274, 43);
            this.CreateStudent.TabIndex = 14;
            this.CreateStudent.Text = "Add student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            // 
            // SelectGroup
            // 
            this.SelectGroup.AutoSize = true;
            this.SelectGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectGroup.Location = new System.Drawing.Point(605, 12);
            this.SelectGroup.Name = "SelectGroup";
            this.SelectGroup.Size = new System.Drawing.Size(145, 31);
            this.SelectGroup.TabIndex = 13;
            this.SelectGroup.Text = "Select Group";
            // 
            // StudentGroup
            // 
            this.StudentGroup.FormattingEnabled = true;
            this.StudentGroup.Location = new System.Drawing.Point(605, 46);
            this.StudentGroup.Name = "StudentGroup";
            this.StudentGroup.Size = new System.Drawing.Size(266, 35);
            this.StudentGroup.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(297, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter age";
            // 
            // StudentAge
            // 
            this.StudentAge.Location = new System.Drawing.Point(297, 197);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(280, 34);
            this.StudentAge.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(297, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter  username";
            // 
            // StudentUsername
            // 
            this.StudentUsername.Location = new System.Drawing.Point(297, 122);
            this.StudentUsername.Name = "StudentUsername";
            this.StudentUsername.Size = new System.Drawing.Size(280, 34);
            this.StudentUsername.TabIndex = 8;
            // 
            // EnterEmail
            // 
            this.EnterEmail.AutoSize = true;
            this.EnterEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterEmail.Location = new System.Drawing.Point(34, 163);
            this.EnterEmail.Name = "EnterEmail";
            this.EnterEmail.Size = new System.Drawing.Size(129, 31);
            this.EnterEmail.TabIndex = 7;
            this.EnterEmail.Text = "Enter email";
            // 
            // StudentEmail
            // 
            this.StudentEmail.Location = new System.Drawing.Point(32, 197);
            this.StudentEmail.Name = "StudentEmail";
            this.StudentEmail.Size = new System.Drawing.Size(236, 34);
            this.StudentEmail.TabIndex = 6;
            // 
            // EnterPasswordForCreate
            // 
            this.EnterPasswordForCreate.AutoSize = true;
            this.EnterPasswordForCreate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordForCreate.Location = new System.Drawing.Point(297, 12);
            this.EnterPasswordForCreate.Name = "EnterPasswordForCreate";
            this.EnterPasswordForCreate.Size = new System.Drawing.Size(171, 31);
            this.EnterPasswordForCreate.TabIndex = 5;
            this.EnterPasswordForCreate.Text = "Enter password";
            // 
            // StudentPassword
            // 
            this.StudentPassword.Location = new System.Drawing.Point(297, 46);
            this.StudentPassword.Name = "StudentPassword";
            this.StudentPassword.Size = new System.Drawing.Size(280, 34);
            this.StudentPassword.TabIndex = 4;
            // 
            // StudentLastname
            // 
            this.StudentLastname.Location = new System.Drawing.Point(32, 122);
            this.StudentLastname.Name = "StudentLastname";
            this.StudentLastname.Size = new System.Drawing.Size(236, 34);
            this.StudentLastname.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(32, 88);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(166, 31);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Enter lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter firstname";
            // 
            // StudentFirstname
            // 
            this.StudentFirstname.Location = new System.Drawing.Point(32, 46);
            this.StudentFirstname.Name = "StudentFirstname";
            this.StudentFirstname.Size = new System.Drawing.Size(236, 34);
            this.StudentFirstname.TabIndex = 0;
            // 
            // WorkWithTasksPanel
            // 
            this.WorkWithTasksPanel.Controls.Add(this.comboBox2);
            this.WorkWithTasksPanel.Controls.Add(this.comboBox1);
            this.WorkWithTasksPanel.Controls.Add(this.CreateSubject);
            this.WorkWithTasksPanel.Controls.Add(this.SelectSubject);
            this.WorkWithTasksPanel.Controls.Add(this.SelectType);
            this.WorkWithTasksPanel.Location = new System.Drawing.Point(270, 80);
            this.WorkWithTasksPanel.Name = "WorkWithTasksPanel";
            this.WorkWithTasksPanel.Size = new System.Drawing.Size(932, 0);
            this.WorkWithTasksPanel.TabIndex = 72;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(234, 35);
            this.comboBox2.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 35);
            this.comboBox1.TabIndex = 43;
            // 
            // CreateSubject
            // 
            this.CreateSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateSubject.Location = new System.Drawing.Point(596, 67);
            this.CreateSubject.Name = "CreateSubject";
            this.CreateSubject.Size = new System.Drawing.Size(274, 43);
            this.CreateSubject.TabIndex = 42;
            this.CreateSubject.Text = "Create ";
            this.CreateSubject.UseVisualStyleBackColor = true;
            // 
            // SelectSubject
            // 
            this.SelectSubject.AutoSize = true;
            this.SelectSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectSubject.Location = new System.Drawing.Point(289, 41);
            this.SelectSubject.Name = "SelectSubject";
            this.SelectSubject.Size = new System.Drawing.Size(157, 31);
            this.SelectSubject.TabIndex = 37;
            this.SelectSubject.Text = "Select Subject";
            // 
            // SelectType
            // 
            this.SelectType.AutoSize = true;
            this.SelectType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectType.Location = new System.Drawing.Point(24, 41);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(129, 31);
            this.SelectType.TabIndex = 32;
            this.SelectType.Text = "Select Type";
            this.SelectType.Click += new System.EventHandler(this.label15_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.WorkWithAttachment);
            this.panel2.Controls.Add(this.WorkWithSubjects);
            this.panel2.Controls.Add(this.WorkWithTasks);
            this.panel2.Controls.Add(this.WorkWithTeachers);
            this.panel2.Controls.Add(this.WorkWithGroups);
            this.panel2.Controls.Add(this.WorkWithStudents);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 794);
            this.panel2.TabIndex = 4;
            // 
            // WorkWithAttachment
            // 
            this.WorkWithAttachment.BackColor = System.Drawing.Color.Gainsboro;
            this.WorkWithAttachment.FlatAppearance.BorderSize = 0;
            this.WorkWithAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkWithAttachment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkWithAttachment.Location = new System.Drawing.Point(0, 291);
            this.WorkWithAttachment.Name = "WorkWithAttachment";
            this.WorkWithAttachment.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WorkWithAttachment.Size = new System.Drawing.Size(264, 36);
            this.WorkWithAttachment.TabIndex = 6;
            this.WorkWithAttachment.Text = "Work with attachment";
            this.WorkWithAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithAttachment.UseVisualStyleBackColor = false;
            this.WorkWithAttachment.Click += new System.EventHandler(this.WorkWithAttachment_Click);
            // 
            // WorkWithSubjects
            // 
            this.WorkWithSubjects.BackColor = System.Drawing.Color.Gainsboro;
            this.WorkWithSubjects.FlatAppearance.BorderSize = 0;
            this.WorkWithSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkWithSubjects.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkWithSubjects.Location = new System.Drawing.Point(0, 249);
            this.WorkWithSubjects.Name = "WorkWithSubjects";
            this.WorkWithSubjects.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WorkWithSubjects.Size = new System.Drawing.Size(264, 36);
            this.WorkWithSubjects.TabIndex = 5;
            this.WorkWithSubjects.Text = "Work with subjects";
            this.WorkWithSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithSubjects.UseVisualStyleBackColor = false;
            this.WorkWithSubjects.Click += new System.EventHandler(this.WorkWithSubjects_Click);
            // 
            // WorkWithTasks
            // 
            this.WorkWithTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.WorkWithTasks.FlatAppearance.BorderSize = 0;
            this.WorkWithTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkWithTasks.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkWithTasks.Location = new System.Drawing.Point(0, 207);
            this.WorkWithTasks.Name = "WorkWithTasks";
            this.WorkWithTasks.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WorkWithTasks.Size = new System.Drawing.Size(264, 36);
            this.WorkWithTasks.TabIndex = 4;
            this.WorkWithTasks.Text = "Work with tasks";
            this.WorkWithTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithTasks.UseVisualStyleBackColor = false;
            this.WorkWithTasks.Click += new System.EventHandler(this.WorkWithTasks_Click);
            // 
            // WorkWithTeachers
            // 
            this.WorkWithTeachers.BackColor = System.Drawing.Color.Gainsboro;
            this.WorkWithTeachers.FlatAppearance.BorderSize = 0;
            this.WorkWithTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkWithTeachers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkWithTeachers.Location = new System.Drawing.Point(0, 165);
            this.WorkWithTeachers.Name = "WorkWithTeachers";
            this.WorkWithTeachers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WorkWithTeachers.Size = new System.Drawing.Size(264, 36);
            this.WorkWithTeachers.TabIndex = 3;
            this.WorkWithTeachers.Text = "Work with teachers";
            this.WorkWithTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithTeachers.UseVisualStyleBackColor = false;
            this.WorkWithTeachers.Click += new System.EventHandler(this.WorkWithTeachers_Click);
            // 
            // WorkWithGroups
            // 
            this.WorkWithGroups.BackColor = System.Drawing.Color.Gainsboro;
            this.WorkWithGroups.FlatAppearance.BorderSize = 0;
            this.WorkWithGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkWithGroups.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkWithGroups.Location = new System.Drawing.Point(0, 80);
            this.WorkWithGroups.Margin = new System.Windows.Forms.Padding(0);
            this.WorkWithGroups.Name = "WorkWithGroups";
            this.WorkWithGroups.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WorkWithGroups.Size = new System.Drawing.Size(264, 40);
            this.WorkWithGroups.TabIndex = 1;
            this.WorkWithGroups.Text = "Work with groups";
            this.WorkWithGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithGroups.UseVisualStyleBackColor = false;
            this.WorkWithGroups.Click += new System.EventHandler(this.WorkWithGroups_Click);
            // 
            // WorkWithStudents
            // 
            this.WorkWithStudents.BackColor = System.Drawing.Color.Gainsboro;
            this.WorkWithStudents.FlatAppearance.BorderSize = 0;
            this.WorkWithStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkWithStudents.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkWithStudents.Location = new System.Drawing.Point(0, 123);
            this.WorkWithStudents.Name = "WorkWithStudents";
            this.WorkWithStudents.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.WorkWithStudents.Size = new System.Drawing.Size(264, 36);
            this.WorkWithStudents.TabIndex = 2;
            this.WorkWithStudents.Text = "Work with students";
            this.WorkWithStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithStudents.UseVisualStyleBackColor = false;
            this.WorkWithStudents.Click += new System.EventHandler(this.WorkWithStudents_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitPictureSecretary);
            this.panel1.Controls.Add(this.NameSecretary);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "LogOut";
            // 
            // ExitPictureSecretary
            // 
            this.ExitPictureSecretary.BackColor = System.Drawing.Color.Silver;
            this.ExitPictureSecretary.Image = ((System.Drawing.Image)(resources.GetObject("ExitPictureSecretary.Image")));
            this.ExitPictureSecretary.InitialImage = ((System.Drawing.Image)(resources.GetObject("ExitPictureSecretary.InitialImage")));
            this.ExitPictureSecretary.Location = new System.Drawing.Point(20, 9);
            this.ExitPictureSecretary.Name = "ExitPictureSecretary";
            this.ExitPictureSecretary.Size = new System.Drawing.Size(55, 61);
            this.ExitPictureSecretary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPictureSecretary.TabIndex = 1;
            this.ExitPictureSecretary.TabStop = false;
            this.ExitPictureSecretary.Click += new System.EventHandler(this.ExitPictureSecretary_Click);
            // 
            // NameSecretary
            // 
            this.NameSecretary.AutoSize = true;
            this.NameSecretary.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameSecretary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameSecretary.Location = new System.Drawing.Point(908, 17);
            this.NameSecretary.Name = "NameSecretary";
            this.NameSecretary.Size = new System.Drawing.Size(263, 38);
            this.NameSecretary.TabIndex = 0;
            this.NameSecretary.Text = "Firstname Lastname";
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.AliceBlue;
            this.Student.Controls.Add(this.UploadDocument);
            this.Student.Controls.Add(this.TaskLabel);
            this.Student.Controls.Add(this.listBox1);
            this.Student.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Student.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Student.Location = new System.Drawing.Point(0, 0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(1200, 0);
            this.Student.TabIndex = 1;
            // 
            // UploadDocument
            // 
            this.UploadDocument.Location = new System.Drawing.Point(929, 112);
            this.UploadDocument.Name = "UploadDocument";
            this.UploadDocument.Size = new System.Drawing.Size(143, 66);
            this.UploadDocument.TabIndex = 6;
            this.UploadDocument.Text = "Upload";
            this.UploadDocument.UseVisualStyleBackColor = true;
            this.UploadDocument.Click += new System.EventHandler(this.UploadDocument_Click);
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskLabel.Location = new System.Drawing.Point(36, 88);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(99, 31);
            this.TaskLabel.TabIndex = 5;
            this.TaskLabel.Text = "All Tasks";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(36, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 624);
            this.listBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Classroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Authorize);
            this.Controls.Add(this.SecretaryMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Classroom";
            this.Text = "Classroom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Authorize.ResumeLayout(false);
            this.AuthorizeForm.ResumeLayout(false);
            this.AuthorizeForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SecretaryMenu.ResumeLayout(false);
            this.WorkWithSubjectsPanel.ResumeLayout(false);
            this.WorkWithSubjectsPanel.PerformLayout();
            this.WorkWithGroupsPanel.ResumeLayout(false);
            this.WorkWithGroupsPanel.PerformLayout();
            this.WorkWithTeachersPanel.ResumeLayout(false);
            this.WorkWithTeachersPanel.PerformLayout();
            this.WorkWithStudentsPanel.ResumeLayout(false);
            this.WorkWithStudentsPanel.PerformLayout();
            this.WorkWithTasksPanel.ResumeLayout(false);
            this.WorkWithTasksPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureSecretary)).EndInit();
            this.Student.ResumeLayout(false);
            this.Student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Authorize;
        private System.Windows.Forms.Panel AuthorizeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button SingInButton;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private Panel SecretaryMenu;
        private Label NameSecretary;
        private Panel panel1;
        private Button WorkWithStudents;
        private Button WorkWithGroups;
        private Panel panel2;
        private PictureBox ExitPictureSecretary;
        private Label label1;
        private Button WorkWithTeachers;
        private Button WorkWithTasks;
        private Button WorkWithSubjects;
        private Button WorkWithAttachment;
        private Panel WorkWithGroupsPanel;
        private Panel WorkWithAttachmentsPanel;
        private Panel WorkWithSubjectsPanel;
        private Panel WorkWithTeachersPanel;
        private Panel WorkWithStudentsPanel;
        private ListBox ListGroup;
        private Label AddNewGroup;
        private TextBox EnterNunberOfGroupInput;
        private Label GroupNumberLabel;
        private ComboBox SelectCourseInput;
        private Label SelectCourse;
        private Button AddGroupButton;
        private Label LastName;
        private Label label2;
        private TextBox StudentFirstname;
        private TextBox StudentLastname;
        private Label EnterPasswordForCreate;
        private TextBox StudentPassword;
        private TextBox StudentEmail;
        private Label EnterEmail;
        private Label label3;
        private TextBox StudentUsername;
        private Label label4;
        private TextBox StudentAge;
        private Label SelectGroup;
        private ComboBox StudentGroup;
        private Button CreateStudent;
        private Button CreateTeacher;
        private Label label6;
        private TextBox TeacherAge;
        private Label label7;
        private TextBox TeacherUsername;
        private Label label8;
        private TextBox TeacherEmail;
        private Label label9;
        private TextBox TeacherPassword;
        private TextBox TeacherLastname;
        private Label label10;
        private Label label11;
        private TextBox TeacherFirstname;
        private Panel WorkWithTasksPanel;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button CreateSubject;
        private Label SelectSubject;
        private Label SelectType;
        private Label SubjectTitleLabel;
        private TextBox SubjectTitle;
        private ComboBox SelectTeacher;
        private Label SelectTeacherInput;
        private Button CreateSubjectButton;
        private Panel Student;
        private Label TaskLabel;
        private ListBox listBox1;
        private Button UploadDocument;
        private OpenFileDialog openFileDialog1;
    }
}

