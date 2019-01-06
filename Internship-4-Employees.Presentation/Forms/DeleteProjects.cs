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
    public partial class DeleteProjects : Form
    {
        public DeleteProjects()
        {
            InitializeComponent();
            foreach (var project in MockProjects.AllProjects)
            {
                deleteProjectsListBox.Items.Add(project);
            }
        }

        private void deleteProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
