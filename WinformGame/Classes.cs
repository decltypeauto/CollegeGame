using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinformGame
{

    public class Points
    {
        public int wins, losses, draws;
        public Points(int w_, int l_, int d_)
        {
            wins = w_;
            losses = l_;
            draws = d_; 
        }
    }


    public class Player
    {
        public string profilePicture;
        public string username;
        public Points score;
        
        

        public Player(string profilePicture_, string username_, Points score_)
        {
            profilePicture = profilePicture_;
            username = username_;
            score = score_;
        }
        public void SetProfile(string profilePicture_)
        {
            profilePicture = profilePicture_;
        }
        public void SetUsername(string username_)
        {          
            username = username_;
        }
        public void SetPoints(Points score_)
        {
            score = score_;
        }
    }
}
