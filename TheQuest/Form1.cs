using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class TheQuestForm : Form
    {
        private Game game;
        private Random random = new Random();

        public TheQuestForm()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new MyRect(100, 60, 650, 260));

            game.NewLevel(random);
            UpdateModel();
        }

        private void UpdateModel()
        {
            pictureBoxPlayer.Location = game.GetActorPos( game.GamePlayer );
            pictureBoxPlayer.Update();
        }

        private void buttonMoveUp_Click( object sender, EventArgs e )
        {
            game.PlayerMove( PointVec.DirUp, random );
            UpdateModel();
        }

        private void buttonMoveLeft_Click( object sender, EventArgs e )
        {
            game.PlayerMove( PointVec.DirLeft, random );
            UpdateModel();
        }

        private void buttonMoveRight_Click( object sender, EventArgs e )
        {
            game.PlayerMove( PointVec.DirRight, random );
            UpdateModel();
        }

        private void buttonMoveDown_Click( object sender, EventArgs e )
        {
            game.PlayerMove( PointVec.DirDown, random );
            UpdateModel();
        }
    }
}
