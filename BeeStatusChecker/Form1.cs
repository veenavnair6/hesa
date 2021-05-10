using BeeLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeeStatusChecker
{
    public partial class Form1 : Form
    {
        public List<Bee> Bees;

        private void GenerateBees()
        {
            Bees = new List<Bee>();
            Bees.Add(new WorkerBee());
            Bees.Add(new WorkerBee());
            Bees.Add(new WorkerBee());
            Bees.Add(new QueenBee());
            Bees.Add(new QueenBee());
            Bees.Add(new QueenBee());
            Bees.Add(new DroneBee());
            Bees.Add(new DroneBee());
            Bees.Add(new DroneBee());
        }

        private void DisplayBees()
        {
            int i = 1;
            tbl_lyt.Controls.Clear();
            foreach (var bee in Bees)
            {
                Label lbl_bee = new Label
                {
                    Text = $"Bee{i} : {bee.Health}"
                };
                tbl_lyt.Controls.Add(lbl_bee);
                i++;
            }
        }

        public Form1()
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
            foreach (var bee in Bees)
            {
                bee.Damage(new Random().Next(0, 80));
            }
              DisplayBees();
        }
    }
}
