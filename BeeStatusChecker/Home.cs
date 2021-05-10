using BeeLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeeStatusChecker
{
    public partial class Home : Form
    {
        public List<Bee> Bees = new List<Bee>();

        private void GenerateBees()
        {
            for (int i = 0; i <= 9; i++)
            {
                if (i % 3 == 0)
                {
                    Bees.Add(new QueenBee());
                }
                else if (i % 2 == 0)
                {
                    Bees.Add(new DroneBee());
                }
                else
                {
                    Bees.Add(new WorkerBee());
                }
            }
        }

        private void DisplayBees()
        {
            int i = 1;
            tbl_lyt.Controls.Clear();
            foreach (var bee in Bees)
            {
                var text = string.Empty;
                if (!bee.Dead)
                    text = $"Bee {i} : {bee.Health}";
                else
                    text = $"Bee {i} : Dead";
                Label lbl_bee = new Label
                {

                    Text = text
                };
                tbl_lyt.Controls.Add(lbl_bee);
                i++;
            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateBees();
            DisplayBees();
        }

        private void btn_Dmg_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            foreach (var bee in Bees)
            {
                var rndDmg = rand.Next(0, 80);
                bee.Damage(rndDmg);
            }
            DisplayBees();
        }
    }
}
