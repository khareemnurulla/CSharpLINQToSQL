namespace CSharpLINQ.View
{
    partial class ViewStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl = new Kimmy.Label();
            this.dgvStudent = new Kimmy.DataGridView();
            this.txtName = new Kimmy.UX.UXTextbox();
            this.txtEmail = new Kimmy.UX.UXTextbox();
            this.txtAge = new Kimmy.UX.UXTextbox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new Kimmy.Label();
            this.btnSave = new Kimmy.Button();
            this.btnEdit = new Kimmy.Button();
            this.btnDelete = new Kimmy.Button();
            this.txtStudentID = new Kimmy.UX.UXTextbox();
            this.Search = new Kimmy.UX.Special.UXSearchbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lbl.Location = new System.Drawing.Point(14, 14);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(80, 27);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Student";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 1, 6, 1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.Location = new System.Drawing.Point(19, 239);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.ShowEditingIcon = false;
            this.dgvStudent.Size = new System.Drawing.Size(600, 180);
            this.dgvStudent.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.InputType = Kimmy.UX.UXTextbox.type_input.Name;
            this.txtName.isEmail = false;
            this.txtName.isNumber = false;
            this.txtName.isRequired = true;
            this.txtName.isText = false;
            this.txtName.Location = new System.Drawing.Point(199, 55);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Placeholder = "Name";
            this.txtName.PlaceholderSize = 12F;
            this.txtName.Size = new System.Drawing.Size(383, 32);
            this.txtName.TabIndex = 4;
            this.txtName.Valid = false;
            this.txtName.ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-. ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.InputType = Kimmy.UX.UXTextbox.type_input.Email;
            this.txtEmail.isEmail = false;
            this.txtEmail.isNumber = false;
            this.txtEmail.isRequired = true;
            this.txtEmail.isText = false;
            this.txtEmail.Location = new System.Drawing.Point(16, 98);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "Email";
            this.txtEmail.PlaceholderSize = 12F;
            this.txtEmail.Size = new System.Drawing.Size(200, 32);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Valid = false;
            this.txtEmail.ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-. 01234567890@";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.InputType = Kimmy.UX.UXTextbox.type_input.Number;
            this.txtAge.isEmail = false;
            this.txtAge.isNumber = false;
            this.txtAge.isRequired = true;
            this.txtAge.isText = false;
            this.txtAge.Location = new System.Drawing.Point(588, 55);
            this.txtAge.Multiline = false;
            this.txtAge.Name = "txtAge";
            this.txtAge.Placeholder = "Age";
            this.txtAge.PlaceholderSize = 12F;
            this.txtAge.Size = new System.Drawing.Size(100, 32);
            this.txtAge.TabIndex = 6;
            this.txtAge.Valid = false;
            this.txtAge.ValidCharacters = "01234567890";
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(567, 98);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(121, 27);
            this.cboCourse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(515, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(538, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.BorderSize = 1;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnEdit.Location = new System.Drawing.Point(625, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 28);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderSize = 1;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnDelete.Location = new System.Drawing.Point(625, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.InputType = Kimmy.UX.UXTextbox.type_input.Number;
            this.txtStudentID.isEmail = false;
            this.txtStudentID.isNumber = false;
            this.txtStudentID.isRequired = true;
            this.txtStudentID.isText = false;
            this.txtStudentID.Location = new System.Drawing.Point(16, 55);
            this.txtStudentID.Multiline = false;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Placeholder = "Student ID";
            this.txtStudentID.PlaceholderSize = 12F;
            this.txtStudentID.Size = new System.Drawing.Size(177, 32);
            this.txtStudentID.TabIndex = 13;
            this.txtStudentID.Valid = false;
            this.txtStudentID.ValidCharacters = "01234567890-";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.Font = new System.Drawing.Font("Calibri", 10F);
            this.Search.Location = new System.Drawing.Point(19, 201);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(200, 32);
            this.Search.TabIndex = 14;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewStudent";
            this.Size = new System.Drawing.Size(700, 438);
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kimmy.Label lbl;
        private Kimmy.DataGridView dgvStudent;
        private Kimmy.UX.UXTextbox txtName;
        private Kimmy.UX.UXTextbox txtEmail;
        private Kimmy.UX.UXTextbox txtAge;
        private System.Windows.Forms.ComboBox cboCourse;
        private Kimmy.Label label1;
        private Kimmy.Button btnSave;
        private Kimmy.Button btnEdit;
        private Kimmy.Button btnDelete;
        private Kimmy.UX.UXTextbox txtStudentID;
        private Kimmy.UX.Special.UXSearchbox Search;
    }
}
