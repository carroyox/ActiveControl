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

namespace ActiveUser
{
    public partial class FControl : Form
    {
        string HostName = System.Environment.MachineName;


        public FControl()
        {
            InitializeComponent();
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            initial();
            this.ActiveControl = lb1;

        }

        private void initial()
        {


            string path = @"C:\Users\Cesar\Desktop\" + HostName + ".txt";

            lbName.Text = HostName;
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                tbOwner.Text = lines[1];
                tbRequestor.Text = lines[2];
                tbExperiment.Text = lines[3];
            }
            else
            {
                var file = File.Create(path);
                file.Close();

                string[] lines = { HostName, " - ", " - ", " - " };
                File.WriteAllLines(path, lines);
            }



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbOwner.ReadOnly == true)
            {

                tbOwner.BackColor = Color.WhiteSmoke;
                tbRequestor.BackColor = Color.WhiteSmoke;
                tbExperiment.BackColor = Color.WhiteSmoke;
                tbOwner.ForeColor = Color.Black;
                tbRequestor.ForeColor = Color.Black;
                tbExperiment.ForeColor = Color.Black;


                tbOwner.ReadOnly = false;
                tbRequestor.ReadOnly = false;
                tbExperiment.ReadOnly = false;
            }
            else
            {
                tbOwner.BackColor = Color.DimGray;
                tbRequestor.BackColor = Color.DimGray;
                tbExperiment.BackColor = Color.DimGray;
                tbOwner.ForeColor = Color.White;
                tbRequestor.ForeColor = Color.White;
                tbExperiment.ForeColor = Color.White;


                tbOwner.ReadOnly = true;
                tbRequestor.ReadOnly = true;
                tbExperiment.ReadOnly = true;
            }

        }


        private void btSave_Click(object sender, EventArgs e)
        {
            string[] lines = { HostName, tbOwner.Text, tbRequestor.Text, tbExperiment.Text };

            File.WriteAllLines(@"C:\Users\Cesar\Desktop\" + HostName + ".txt", lines);

            tbOwner.BackColor = Color.DimGray;
            tbRequestor.BackColor = Color.DimGray;
            tbExperiment.BackColor = Color.DimGray;
            tbOwner.ForeColor = Color.White;
            tbRequestor.ForeColor = Color.White;
            tbExperiment.ForeColor = Color.White;


            tbOwner.ReadOnly = true;
            tbRequestor.ReadOnly = true;
            tbExperiment.ReadOnly = true;
        }



    }
}
