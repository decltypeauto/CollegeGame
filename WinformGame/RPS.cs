using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformGame
{
    public partial class RPS : Form
    {
        public RPS()
        {
            InitializeComponent();
        }

        private Enums.WinnerTypes winnerDecision(Enums.RPSTypes computerDecision, Enums.RPSTypes playerDecision)
        {
            
        }

        private Enums.RPSTypes computerDecision()
        {
            Random random = new Random();
            Enums.RPSTypes decision = (Enums.RPSTypes)random.Next(1, 3);
            return decision;
        }
        private void playerDecision()
        {

        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(computerDecision());
        }

        private void paperButton_Click(object sender, EventArgs e)
        {

        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
