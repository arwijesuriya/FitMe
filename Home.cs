using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        FitnessResults fitnessResults = null;
        NutritionAdvices nutritionAdvices = null;

        private void btnFitness_Click(object sender, EventArgs e)
        {
            if(fitnessResults == null || fitnessResults.IsDisposed) {
                fitnessResults = new FitnessResults();
            }

            fitnessResults.Show();
            this.Hide();
        }

        private void btnNutrition_Click(object sender, EventArgs e)
        {
            if (nutritionAdvices == null || nutritionAdvices.IsDisposed)
            {
                nutritionAdvices = new NutritionAdvices();
            }

            nutritionAdvices.Show();
            this.Hide();
        }
    }
}
