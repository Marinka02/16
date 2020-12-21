using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap[] imagesFruits = new Bitmap[4];

        Rectangle rDish, rFruit;

        int fallingSpeed;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) pictureBoxDish.Left -= 15;
            if (e.KeyData == Keys.Right) pictureBoxDish.Left += 15;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"Images\fruit1.png");
            imagesFruits[0] = (Bitmap)bitmap.Clone();
            bitmap = new Bitmap(@"Images\fruit2.png");
            imagesFruits[1] = (Bitmap)bitmap.Clone();
            bitmap = new Bitmap(@"Images\fruit3.png");
            imagesFruits[2] = (Bitmap)bitmap.Clone();
            bitmap = new Bitmap(@"Images\fruit4.png");
            imagesFruits[3] = (Bitmap)bitmap.Clone();


            pictureBoxDish.Parent = pictureBG;
            pictureBoxFruit.Parent = pictureBG;

            Random random = new Random();
            pictureBoxFruit.Image = imagesFruits[random.Next(0,3)];
            pictureBoxDish.BackColor = Color.Transparent;
            pictureBoxFruit.BackColor = Color.Transparent;

            fallingSpeed = 10;

            pictureBoxFruit.Top = -40;
            pictureBoxFruit.Left = random.Next(200, 600);

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBoxFruit.Top += fallingSpeed;

            if(pictureBoxFruit.Top >=pictureBG.Height)
            {
                timer1.Enabled = false;
                MessageBox.Show("Конец игры");
                
            }

            rDish = pictureBoxFruit.DisplayRectangle;
            rDish.Location = pictureBoxFruit.Location;

            rFruit = pictureBoxDish.DisplayRectangle;
            rFruit.Location = pictureBoxDish.Location;

            if(rDish.IntersectsWith(rFruit))
            {
                timer1.Enabled = false;
                MessageBox.Show("Вы выиграли!");
            }
        }
    }
}
