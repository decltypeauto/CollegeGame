using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinformGame
{
    public partial class Form1 : Form
    {
        Player player;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
            player = new Player("O:\\vs\\WinformGame\\WinformGame\\Resources\\Picture1.png", "test", new Points(1,2,3));
            Console.WriteLine(player.username);
            pictureBox2.Image = Image.FromFile(player.profilePicture);
            
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            label1.Text = file.FileName;
            player.SetProfile(file.FileName);
            pictureBox2.Image = Image.FromFile(player.profilePicture);
        }
    }
}
