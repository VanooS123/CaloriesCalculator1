using System;
using System.Windows.Forms;

namespace CaloriesCalculator
{
    public partial class Elementary : Form
    {
        public Elementary()
        {
            InitializeComponent();
        }

        private void GoingMainForm_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1
            {
                Visible = true
            };
            Visible = false;
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Manual.chm");
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Программу сделал учащийся 21-п группы Стульский Иван");
        }
    }
}