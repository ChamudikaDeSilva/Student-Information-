using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_01
{
    public partial class Form1 : Form
    {
        private Final_Details finalDetails=null;
        public static string allDetails = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult re = OpenFileDialogLoadImage.ShowDialog();
            if (re.Equals(DialogResult.OK))
            {
                if(openFileDialogLoadImage.FileName != null)
                {
                    pictureBoxStudentImage.Image = Image.FormFile(openFileDialogLoadImage.FileName);
                }
            }
        }

    }
}
