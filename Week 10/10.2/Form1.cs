using System.Xml.Linq;
using Mod7CodeFirstdemo.Models;
using Mod7CodeFirstdemo.Services;

namespace Mod7CodeFirstdemo
{
    public partial class Form1 : Form
    {

        //The CRUD class will be used now to interact with the methods.
        //using the context class on the form that is on the UI.

        CRUD curd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            curd = new CRUD();
            empGrid.DataSource = curd.GetEmployees();
            empGrid.Columns[4].Visible = false;
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
            foreach (var d in curd.GetDepartments())
            {
                comboDept.Items.Add(d.DepartmentName);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textId.Text = (curd.GetMaxId() + 1).ToString();
            textId.ReadOnly = true;
            textName.Clear();
            textSalary.Clear();
            btnSubmit.Enabled = true;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textId.Text) && !string.IsNullOrEmpty(textName.Text))
            {
                if (comboDept.SelectedIndex != -1)
                {
                    var newemp = new Employee();
                    newemp.EmpId = int.Parse(textId.Text);
                    newemp.Name = textName.Text;
                    newemp.Salary = double.Parse(textSalary.Text);
                    newemp.DepartmentID = comboDept.SelectedIndex + 1;
                    curd.AddRecord(newemp);
                    MessageBox.Show("Record Added");
                }
            }

            btnSubmit.Enabled = false;
            empGrid.DataSource = curd.GetEmployees();
            Clear();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            curd.DeleteRecord((int)id);
            MessageBox.Show("Record Deleted");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = empGrid.CurrentRow.Cells[0].Value;
            var emptoupdate = curd.FindEmployee((int)id);
            textId.Text = emptoupdate.EmpId.ToString();
            textId.ReadOnly = true;
            textName.Text = emptoupdate.Name;
            textSalary.Text = emptoupdate.Salary.ToString();
            comboDept.SelectedIndex = emptoupdate.DepartmentID - 1;
            btnUpdate.Enabled = true;

        }

        private void Clear()
        {
            textId.Clear();
            textName.Clear();
            textSalary.Clear();
            comboDept.SelectedIndex = -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textId.Text);
            var emptoupdate = curd.FindEmployee(id);
            emptoupdate.Name = textName.Text;
            emptoupdate.Salary = double.Parse(textSalary.Text);
            emptoupdate.DepartmentID = comboDept.SelectedIndex + 1;
            curd.UpdateRecord(id, emptoupdate);
            MessageBox.Show("Record Updated");
            empGrid.DataSource = curd.GetEmployees();
            btnUpdate.Enabled = false;
            Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
