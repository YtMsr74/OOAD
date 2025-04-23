using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patlab3
{
    public partial class Form1 : Form
    {
        const int maxWeight = 200;
        const double outageChance = 0.2;
        Elevator elevator = new Elevator(maxWeight, outageChance);
        List<int> floorLoads = new List<int>();

        public Form1()
        {
            InitializeComponent();
            txtMaxWeight.Text = maxWeight.ToString();
            gridFloors.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            for (int i = 0; i < 6; i++)
            {
                floorLoads.Add(50);
                gridFloors.Rows.Add(i + 1, floorLoads[i], "");
            }
            txtLoadFloor.Text = floorLoads[elevator.CurrentFloor].ToString();
            gridFloors.Rows[0].Cells[2].Value = "ВЫ";
        }

        private void btnElev2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int floor = int.Parse(button.Text);

            gridFloors.Rows[elevator.CurrentFloor - 1].Cells[2].Value = "";
            elevator.CallFloor(floor);
            if (elevator.CurrentFloor != floor && elevator.CurrentWeight <= elevator.MaxWeight)
            {
                figFloor.Visible = false;
                txtOutage.Visible = true;
            }
            txtLoadFloor.Text = floorLoads[elevator.CurrentFloor - 1].ToString();
            txtFloor.Text = elevator.CurrentFloor.ToString();
            txtFloorSign.Text = elevator.CurrentFloor.ToString();
            gridFloors.Rows[elevator.CurrentFloor - 1].Cells[2].Value = "ВЫ";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            elevator.RestorePower();
            figFloor.Visible = true;
            txtOutage.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            elevator.Load(floorLoads[elevator.CurrentFloor - 1]);
            floorLoads[elevator.CurrentFloor - 1] = 0;

            txtLoadFloor.Text = "0";
            gridFloors.Rows[elevator.CurrentFloor - 1].Cells[1].Value = 0;
            txtCurWeight.Text = elevator.CurrentWeight.ToString();
            if (elevator.CurrentWeight > elevator.MaxWeight)
                txtCurWeight.ForeColor = Color.Red;
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            int newWeight = floorLoads[elevator.CurrentFloor - 1] += elevator.Unload((int)numUnload.Value);

            txtLoadFloor.Text = newWeight.ToString();
            gridFloors.Rows[elevator.CurrentFloor - 1].Cells[1].Value = newWeight;
            txtCurWeight.Text = elevator.CurrentWeight.ToString();
            if (elevator.CurrentWeight <= elevator.MaxWeight)
                txtCurWeight.ForeColor = Color.LimeGreen;
        }

        private void timerRestock_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                if (i + 1 != elevator.CurrentFloor)
                {
                    switch (rnd.Next(0, 3))
                    {
                        case 0:
                            gridFloors.Rows[i].Cells[1].Value = floorLoads[i] += rnd.Next(1, 20);
                            break;

                        case 1:
                            int newLoad = rnd.Next(1, 20);
                            if (floorLoads[i] - newLoad >= 0)
                                gridFloors.Rows[i].Cells[1].Value = floorLoads[i] -= newLoad;
                            break;
                    }
                }
            }
        }
    }
}
