using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();

            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            panelChart.Visible = false;
            panelReport.Visible = false;
        }

        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridStudents.DataSource = dt;
            BindChart(listStudents);
        }
        private void Clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            dateEnrolDate.Value = DateTime.Today;
            txtContactNo.Text = "";
            comboGender.SelectedItem = null;
            comboCourse.SelectedItem = null;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            emptyFieldValidator();
            if (comboGender.SelectedIndex != -1 && comboCourse.SelectedIndex != -1)
            {
                Student obj = new Student();
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = txtAddress.Text;
                obj.Email = txtEmail.Text;
                obj.EnrollDate = dateEnrolDate.Value;
                obj.ContactNo = txtContactNo.Text;
                obj.Gender = comboGender.SelectedItem.ToString();
                obj.Course = comboCourse.SelectedItem.ToString();
                obj.Add(obj);
                BindGrid();
                Clear();
            }            
        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                //get the value of the clicked rows id column
                string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(value);
                    Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    txtID.Text = s.Id.ToString();
                    txtFirstName.Text = s.Name.Split(' ')[0];
                    txtLastName.Text = s.Name.Split(' ')[1];
                    txtAddress.Text = s.Address;
                    txtEmail.Text = s.Email;
                    dateEnrolDate.Value = s.EnrollDate;
                    txtContactNo.Text = s.ContactNo;
                    comboGender.SelectedItem = s.Gender;
                    comboCourse.SelectedItem = s.Course;
                    btnSubmit.Visible = false;
                    btnUpdate.Visible = true;
                    btnCancel.Visible = true;
                    panelChart.Visible = false;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to Delete this Record?";
                string title = "Delete Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    //get the value of the clicked rows id column
                    string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                    obj.Delete(int.Parse(value));
                    BindGrid();
                    MessageBox.Show("Record Successfully Deleted");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Id = int.Parse(txtID.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            obj.Name = firstName + " " + lastName;
            obj.Address = txtAddress.Text;
            obj.Email = txtEmail.Text;
            obj.EnrollDate = dateEnrolDate.Value;
            obj.ContactNo = txtContactNo.Text;
            obj.Gender = comboGender.SelectedItem.ToString();
            obj.Course = comboCourse.SelectedItem.ToString();
            obj.Edit(obj);
            BindGrid();
            Clear();
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
            btnCancel.Visible = false;
            MessageBox.Show("Record Successfully Updated");

        }

        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.Course)
                    .Select(cl => new
                    {
                        Course = cl.First().Course,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chartWeeklyReport.DataSource = dt;
                chartWeeklyReport.Name = "Course";
                chartWeeklyReport.Series["Students"].XValueMember = "Course";
                chartWeeklyReport.Series["Students"].YValueMembers = "Count";
                //this.chartWeeklyReport.Titles.Remove(this.chartWeeklyReport.Titles.FirstOrDefault());
                //this.chartWeeklyReport.Titles.Add("Weekly Enrollment Chart");
                chartWeeklyReport.Series["Students"].IsValueShownAsLabel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEnrolStudent_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnEnrolStudent.Height;
            panelSelector.Top = btnEnrolStudent.Top;
            panelStudent.Visible = true;
            panelChart.Visible = false;
            panelReport.Visible = false;
            btnCancel.BringToFront();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnChart.Height;
            panelSelector.Top = btnChart.Top;
            panelChart.Visible = true;
            panelStudent.Visible = true;
            panelReport.Visible = false;
            panelStudent.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelSelector.Height = btnExit.Height;
            panelSelector.Top = btnExit.Top;
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
            btnCancel.Visible = false;

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            panelSelector.Height = btnReport.Height;
            panelSelector.Top = btnReport.Top;
            panelChart.Visible = false;
            panelStudent.Visible = false;
            panelReport.Visible = true;
            panelReport.BringToFront();


        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            int a = listStudents.Count;
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = i + 1; j < a; j++)
                {

                    if (listStudents[i].Name.CompareTo(listStudents[j].Name) > 0)
                    {
                        Student temp = listStudents[i];
                        listStudents[i] = listStudents[j];
                        listStudents[j] = temp;
                    }
                }

                DataTable dt = Utility.ConvertToDataTable(listStudents);
                dataGridStudents.DataSource = dt;
            }
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();

            int a = listStudents.Count;
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = i + 1; j < a; j++)
                {
                    if (listStudents[i].EnrollDate > listStudents[j].EnrollDate)
                    {
                        Student temp = listStudents[i];
                        listStudents[i] = listStudents[j];
                        listStudents[j] = temp;
                    }
                }
                DataTable dt = Utility.ConvertToDataTable(listStudents);
                dataGridStudents.DataSource = dt;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            DateTime inputDate = dpReport.Value;
            List<Student> listStudents = obj.List();
            DateTime[] datearray = obj.week(inputDate);
            List<Student> studentrep = obj.week(datearray, listStudents);
            var result = studentrep
                .GroupBy(s => s.Course)
                .Select(cs => new
                {
                    Course = cs.First().Course,
                    EnrolledStudents = cs.Count().ToString()

                }).ToList();
            DataTable d = Utility.ConvertToDataTable(result);
            dataGridReport.DataSource = d;
            dataGridReport.CurrentCell = null;
        }

        //Validating Begin

        private void emptyFieldValidator()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text)
                )
            {
                MessageBox.Show("Please fill all empty fields before submitting!");
            }
            else if (comboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields before submitting!");
            }
            else if (comboCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields before submitting!");
            }
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                fnameErrorProvider.SetError(txtFirstName, "Required!");
            }
            else
            {
                e.Cancel = false;
                fnameErrorProvider.SetError(txtFirstName, "");
                fnameErrorProvider.Clear();
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                addressErrorProvider.SetError(txtAddress, "Required!");
            }
            else
            {
                e.Cancel = false;
                addressErrorProvider.SetError(txtAddress, "");
                addressErrorProvider.Clear();
            }
        }

        private void comboGender_Validating(object sender, CancelEventArgs e)
        {
            if (comboGender.SelectedIndex == -1)
            {
                e.Cancel = true;
                comboGender.Focus();
                genderErrorProvider.SetError(comboGender, "Required!");
            }
            else
            {
                e.Cancel = false;
                genderErrorProvider.SetError(comboGender, "");
                genderErrorProvider.Clear();
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                lnameErrorProvider.SetError(txtLastName, "Required!");
            }
            else
            {
                e.Cancel = false;
                lnameErrorProvider.SetError(txtLastName, "");
                lnameErrorProvider.Clear();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(txtEmail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtEmail.Select(0, txtEmail.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.emailErrorProvider.SetError(txtEmail, errorMsg);
            }
            else
            {
                e.Cancel = false;
                emailErrorProvider.SetError(txtEmail, "");
                emailErrorProvider.Clear();
            }
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                e.Cancel = true;
                txtContactNo.Focus();
                contactErrorProvider.SetError(txtContactNo, "Required!");
            }
            else
            {
                e.Cancel = false;
                contactErrorProvider.SetError(txtContactNo, "");
                contactErrorProvider.Clear();
            }
        }

        private void comboCourse_Validating(object sender, CancelEventArgs e)
        {
            if (comboCourse.SelectedIndex == -1)
            {
                e.Cancel = true;
                comboCourse.Focus();
                courseErrorProvider.SetError(comboCourse, "Required!");
            }
            else
            {
                e.Cancel = false;
                courseErrorProvider.SetError(comboCourse, "");
                courseErrorProvider.Clear();
            }
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "Email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }
    }
}
