using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matrix = new int[3, 3];
            for (int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 3; y++)
                    matrix[x, y] = rand.Next(0, 9);
            }
            string matrixText = "{" + matrix[0, 0]+", "+matrix[0, 1]+", "+matrix[0, 2]+ "},\n{" + matrix[1, 0] + ", " + matrix[1, 1] + ", " + matrix[1, 2] + "},\n{" + matrix[2, 0] + ", " + matrix[2, 1] + ", " + matrix[2, 2] + "}";
            MessageBox.Show("Matrix: ["+matrixText+"]"+"\nMatrix Sonucu: "+(
                matrix[0, 0]
                *
                matrix[1, 1]
                *
                matrix[2, 2]
                +
                matrix[0, 1]
                *
                matrix[1, 2]
                *
                matrix[2, 0]
                +
                matrix[0, 2]
                *
                matrix[1, 0]
                *
                matrix[2, 1]
                -
                matrix[0, 2]
                *
                matrix[1, 1]
                *
                matrix[2, 0]
                -
                matrix[0, 0]
                *
                matrix[1, 2]
                *
                matrix[2, 1]
                -
                matrix[0, 1]
                *
                matrix[1, 0]
                *
                matrix[2, 2]));
        }
    }
}
