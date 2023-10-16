using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();
        DataTable Table = new DataTable();
        public int rowIndex;
        private void Form1_Load(object sender, EventArgs e)
        {
            Table.Columns.Add("Employee ID   ", typeof(string));
            Table.Columns.Add("First Name    ", typeof(string));
            Table.Columns.Add("Last Name     ", typeof(string));
            Table.Columns.Add("Department     ", typeof(string));
            Table.Columns.Add("Salary (R)     ", typeof(double));


            bs.DataSource = Table;
            dgvEmployees.DataSource = bs;

            Table.Rows.Add("577669", "Lewan", "Staden", "Maintanance", 32000.95);
            Table.Rows.Add("600669", "Thabiso", "Moloyi", "Developer", 39000.05);
            Table.Rows.Add("565845", "Delight", "Chipiro", "HR", 15000.95);
            Table.Rows.Add("577669", "Thuli", "Phogolo", "Finance", 48000.95);
        }
        public void refresh()
        {
            txteID.Focus();
            txteID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtDep.Clear();
            txtSalary.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string employeeID = txteID.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string dep = txtDep.Text;
            string salary = txtSalary.Text;

            Table.Rows.Add(employeeID, name, surname, dep, salary);

            refresh();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            MessageBox.Show($"You've selected employee number: {Convert.ToString(rowIndex + 1)}");

            DataGridViewRow row = dgvEmployees.Rows[rowIndex];

            txteID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtSurname.Text = row.Cells[2].Value.ToString();
            txtDep.Text = row.Cells[3].Value.ToString();
            txtSalary.Text = row.Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvEmployees.Rows[rowIndex];

            row.Cells[0].Value = txteID.Text;
            row.Cells[1].Value = txtName.Text;
            row.Cells[2].Value = txtSurname.Text;
            row.Cells[3].Value = txtDep.Text;
            row.Cells[4].Value = txtSalary.Text;

            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = dgvEmployees.CurrentCell.RowIndex;
            dgvEmployees.Rows.RemoveAt(row);

            refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
