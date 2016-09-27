using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kimmy.UX;

namespace CSharpLINQ.View
{
    public partial class ViewStudent : UserControl
    {
        Controller.StudentController student = new Controller.StudentController();

        public ViewStudent() {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e) {
            LoadStudents();
            cboCourse.DataSource = new Controller.CourseController().List();
            cboCourse.ValueMember = "CourseID";
            cboCourse.DisplayMember = "Description";
        }

        void LoadStudents() {
            var data = student.List();
            dgvStudent.DataSource = data;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(txtStudentID.ValidateInput()) {
                student.Add(txtStudentID.Text, txtName.Text, Convert.ToInt32(txtAge.Text), txtEmail.Text, Convert.ToInt32(cboCourse.SelectedValue));
            }
            LoadStudents();
        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var ID = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
            student.Delete(ID);
            LoadStudents();
        }
    }
}
