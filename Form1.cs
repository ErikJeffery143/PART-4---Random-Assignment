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
        int Min;
        int Max;
        int randNum;


        public RandomNumbers()
        {
            InitializeComponent();
        }
        
        private void RandomNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            

            randNum = generator.Next(Min, Max);
           
            
            lblFinal.Text = randNum + "";






        }

        private void lblMin_Click(object sender, EventArgs e)
        {

        }
    }
}
