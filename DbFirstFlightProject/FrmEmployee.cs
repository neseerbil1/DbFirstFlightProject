using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFirstFlightProject.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbFirstFlightProject
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        //Eager Load - Lazy Load

        DbİstanbulAkademiFlightEntities2 ent = new DbİstanbulAkademiFlightEntities2();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = from x in ent.TblEmployee
                         select new
                         {
                             ID = x.EmployeeId,
                             Personel_Adı = x.EmployeeName,
                             Departmanı = x.TblDepartment.DepartmentName,
                             
                         };
            dataGridView1.DataSource = values.ToList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "DepartmentName";
            comboBox1.ValueMember = "DepartmentID";
            comboBox1.DataSource = ent.TblDepartment.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblEmployee tblEmployee = new TblEmployee();
            tblEmployee.EmployeeName = txtName.Text;
            tblEmployee.EmployeeDepartment = int.Parse(comboBox1.SelectedValue.ToString());
            ent.TblEmployee.Add(tblEmployee);
            ent.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var totalCountEmployee = ent.TblEmployee.Count();
            lblTotalCount.Text = totalCountEmployee.ToString();

            
        }
    }
}
