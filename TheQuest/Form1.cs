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

        private readonly PointVec dirUp = new PointVec( 0, -1 );
        private readonly PointVec dirDown = new PointVec( 0, 1 );
        private readonly PointVec dirLeft = new PointVec( -1, 0 );
        private readonly PointVec dirRight = new PointVec( 1, 0 );

        public TheQuestForm()
        {
            InitializeComponent();
            game = new Game( new MyRect( 100, 60, 650, 260 ) );

        }

        private void UpdateModel()
        {
            pictureBoxPlayer.Location = game.GetActorPos( game.GamePlayer );
            pictureBoxPlayer.Update();
        }

        private void buttonMoveUp_Click( object sender, EventArgs e )
        {
            game.PlayerMove( dirUp );
            UpdateModel();
        }

        private void buttonMoveLeft_Click( object sender, EventArgs e )
        {
            game.PlayerMove( dirLeft );
            UpdateModel();
        }

        private void buttonMoveRight_Click( object sender, EventArgs e )
        {
            game.PlayerMove( dirRight );
            UpdateModel();
        }

        private void buttonMoveDown_Click( object sender, EventArgs e )
        {
            game.PlayerMove( dirDown );
            UpdateModel();
        }
    }
}
