using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int id;
        ApplicationDbContext db = new ApplicationDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ID = int.Parse(txtId.Text);
            company.Name = txtName.Text;
            company.Description = txtDescription.Text;
            company.StartDate = dtInicio.Value;
            db.Companies.Add(company);
            db.SaveChanges();
        }
        private void btnBuscar_Click(object sender, EventArgs e) //Buscar
        {
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            dtInicio.Enabled = false;
            button1.Enabled = false;
            int id = int.Parse(txtId.Text);
            Company company= db.Companies.FirstOrDefault(c => c.ID == id);
            // List<Company> listaCompany = new List<Company>();
            // listaCompany.Add(company);
            lblName.Text = company.Name;
            lblDescription.Text = company.Description;
            lblFecha.Text = Convert.ToString(company.StartDate); //esto es parcear
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nameCompany;
            string descriptionCompany;
            int id = int.Parse(txtId.Text);
            nameCompany = txtName.Text;
            descriptionCompany = txtDescription.Text;
            Company company = db.Companies.FirstOrDefault(c => c.ID == id);
            company.Name = txtName.Text;
            company.Description = txtDescription.Text;
            company.StartDate = dtInicio.Value;
            db.SaveChanges();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            Company company = db.Companies.FirstOrDefault(c => c.ID == id);
            //Client clientEliminar = db.Clients.Where(c => c.Company.ID == company.ID);
            //Company company = db.Companies.FirstOrDefault(c => c.ID == id);
        }
    }
}
