using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_4_Employees.Domain.Repositories;

namespace Internship_4_Employees.Forms
{
    public partial class EditProjects : Form
    {
        public EditProjects()
        {
            InitializeComponent();
            foreach (var project in MockProjects.AllProjects)
            {
                editProjectsListBox.Items.Add(project);
            }
        }

        private void editProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projectDetails = new ProjectDetails();
            projectDetails.Show();
        }
    }
}
