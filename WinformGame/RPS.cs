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
            if (playerDecision == computerDecision)
                return Enums.WinnerTypes.Draw;

            switch (computerDecision)
            {
                case Enums.RPSTypes.Rock:
                    if (playerDecision == Enums.RPSTypes.Paper)
                        return Enums.WinnerTypes.Human;
                    if (playerDecision == Enums.RPSTypes.Scissors)
                        return Enums.WinnerTypes.Computer;
                    break;
                case Enums.RPSTypes.Paper:
                    if (playerDecision == Enums.RPSTypes.Rock)
                        return Enums.WinnerTypes.Computer;
                    if (playerDecision == Enums.RPSTypes.Scissors)
                        return Enums.WinnerTypes.Human;
                    break;
                case Enums.RPSTypes.Scissors:
                    if (playerDecision == Enums.RPSTypes.Rock)
                        return Enums.WinnerTypes.Human;
                    if (playerDecision == Enums.RPSTypes.Paper)
                        return Enums.WinnerTypes.Computer;
                    break;
                default:
                    return Enums.WinnerTypes.Error;
            }
            return Enums.WinnerTypes.Error;
        }

        private void winnerOutcome(Enums.WinnerTypes winner)
        {
            
            switch (winner)
            {
                case Enums.WinnerTypes.Human:
                    MessageBox.Show("Well done, you win!");
                    Globals.player.SetPoints(new Points(Globals.player.score.wins += 1, Globals.player.score.losses, Globals.player.score.draws));
                    break;
                case Enums.WinnerTypes.Computer:
                    MessageBox.Show("You lost!");
                    Globals.player.SetPoints(new Points(Globals.player.score.wins, Globals.player.score.losses += 1, Globals.player.score.draws));
                    break;
                case Enums.WinnerTypes.Draw:
                    MessageBox.Show("Draw!");
                    Globals.player.SetPoints(new Points(Globals.player.score.wins, Globals.player.score.losses, Globals.player.score.draws += 1));
                    break;
                case Enums.WinnerTypes.Error:
                    MessageBox.Show("Critical error! Exiting now!");
                    System.Windows.Forms.Application.Exit();
                    break;

            }
            label6.Text = Convert.ToString(Globals.player.score.wins);
            label5.Text = Convert.ToString(Globals.player.score.losses);
            label4.Text = Convert.ToString(Globals.player.score.draws);
        }

        private Enums.RPSTypes computerDecision()
        {
            Random random = new Random();
            Enums.RPSTypes decision = (Enums.RPSTypes)random.Next(1, 3);
            return decision;
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            winnerOutcome(winnerDecision(computerDecision(), Enums.RPSTypes.Rock));
            
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            winnerOutcome(winnerDecision(computerDecision(), Enums.RPSTypes.Paper));
           
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            winnerOutcome(winnerDecision(computerDecision(), Enums.RPSTypes.Scissors));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RPS_Load(object sender, EventArgs e)
        {
            //Globals.player.SetPoints(new Points(Globals.player.score.wins +=1, 0, 0));
            //label1.Text = Convert.ToString(Globals.player.score.wins);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
