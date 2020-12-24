using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int grade = 0;
            if(quest1Answer1.Checked){
                grade = grade + 25;
            }
            if(quest2Answer2.Checked){
                grade = grade + 25;
            }
            if(quest3Answer3.Checked){
                grade = grade + 25;
            }
            if(quest4Answer4.Checked){
                grade = grade + 25;
            }
            MessageBox.Show("Your C# Quiz Grade Is: "+ grade + "%");
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            quest1Answer1.Checked = true;
            quest2Answer2.Checked = true;
            quest3Answer3.Checked = true;
            quest4Answer4.Checked = true;
        }
    }
}
