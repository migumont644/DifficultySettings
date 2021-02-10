using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class titleLabel : Form
    {
        string heroName;
        string difficultyLevel;

        public titleLabel()
        {
            InitializeComponent();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.Gray;

            difficultyLevel = "easy";
           
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Yellow;
            hardButton.BackColor = Color.Gray;

            difficultyLevel = "medium";

        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Gray;
            mediumButton.BackColor = Color.Gray;
            hardButton.BackColor = Color.Red;

            difficultyLevel = "hard";

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            heroName = username.Text;    
            beginOutput.Text = $"Welcome {heroName} \n A true brave guard! Go ahead and take on {difficultyLevel} mode!";
        }
    }
}
