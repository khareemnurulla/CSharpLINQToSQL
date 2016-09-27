namespace CSharpLINQ
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.navigation = new Kimmy.Navigation();
            this.navCourse = new Kimmy.Nav();
            this.navStudent = new Kimmy.Nav();
            this.pnlMain = new Kimmy.Panel();
            this.navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.BackColor = System.Drawing.Color.White;
            this.navigation.Controls.Add(this.navCourse);
            this.navigation.Controls.Add(this.navStudent);
            this.navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigation.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.Margin = new System.Windows.Forms.Padding(0);
            this.navigation.Name = "navigation";
            this.navigation.Size = new System.Drawing.Size(724, 48);
            this.navigation.TabIndex = 0;
            // 
            // navCourse
            // 
            this.navCourse.Active = false;
            this.navCourse.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.navCourse.BackColor = System.Drawing.Color.White;
            this.navCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navCourse.FlatAppearance.BorderSize = 0;
            this.navCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.navCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navCourse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navCourse.HoverBackColor = System.Drawing.Color.White;
            this.navCourse.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.navCourse.Location = new System.Drawing.Point(81, 0);
            this.navCourse.Margin = new System.Windows.Forms.Padding(0);
            this.navCourse.Name = "navCourse";
            this.navCourse.Size = new System.Drawing.Size(80, 46);
            this.navCourse.TabIndex = 1;
            this.navCourse.Text = "Course";
            this.navCourse.UseVisualStyleBackColor = false;
            this.navCourse.Click += new System.EventHandler(this.navCourse_Click);
            // 
            // navStudent
            // 
            this.navStudent.Active = false;
            this.navStudent.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.navStudent.BackColor = System.Drawing.Color.White;
            this.navStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navStudent.FlatAppearance.BorderSize = 0;
            this.navStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.navStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.navStudent.HoverBackColor = System.Drawing.Color.White;
            this.navStudent.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.navStudent.Location = new System.Drawing.Point(0, 0);
            this.navStudent.Margin = new System.Windows.Forms.Padding(0);
            this.navStudent.Name = "navStudent";
            this.navStudent.Size = new System.Drawing.Size(80, 46);
            this.navStudent.TabIndex = 0;
            this.navStudent.Text = "Student";
            this.navStudent.UseVisualStyleBackColor = false;
            this.navStudent.Click += new System.EventHandler(this.navStudent_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(12, 62);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(700, 418);
            this.pnlMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navigation);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp LINQ To SQL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Kimmy.Navigation navigation;
        private Kimmy.Panel pnlMain;
        private Kimmy.Nav navCourse;
        private Kimmy.Nav navStudent;
    }
}

