using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog1.FileName);
            }
            Debug.WriteLine("ShowButton clicked");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture
            pictureBox.Image = null;
            Debug.WriteLine("ClearButton clicked");
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.BackColor = colorDialog1.Color;
            }
            Debug.WriteLine("BackgroundButton clicked");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Exits the application
            this.Close();//Application.Exit();
            Debug.WriteLine("CloseButton clicked");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            if (checkBox.Checked)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
            Debug.WriteLine("CheckBox clicked");
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Debug.WriteLine("Escape key pressed");
                    CloseButton_Click(sender, e);
                    break;
                case Keys.Enter:
                    Debug.WriteLine("Enter key pressed");
                    ShowButton_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
