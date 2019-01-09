using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_4_Employees.Forms
{
    public partial class DeleteProjectPrompt : Form
    {
        public DeleteProjectPrompt()
        {
            InitializeComponent();
        }

        private void ConfirmDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void DenyDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
