using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PART_4___Random_Assingment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();



        public RandomNumbers()
        {
            InitializeComponent();
        }
        
        private void RandomNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            Double Min;
            Double Max;
            Double randNum;
            Double randNum2;

            Min = Convert.ToDouble(numMin.Text);
            Max = Convert.ToDouble(numMax.Text);
            randNum = generator.Next((int)Min, (int)Max);
            randNum2 = generator.NextDouble();
             
            lblFinal.Text = (randNum - 1 + randNum2) + "";






        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            int Min;
            int Max;
            int randNum;


            Min = Convert.ToInt32(numMin.Text);
            Max = Convert.ToInt32(numMax.Text);
            randNum = generator.Next((int)Min, (int)Max);

            lblFinal.Text = randNum + "";
        }
    }
}
