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

        private readonly Point dirUp = new Point( 0, -1 );
        private readonly Point dirDown = new Point( 0, 1 );
        private readonly Point dirLeft = new Point( -1, 0 );
        private readonly Point dirRight = new Point( 1, 0 );

        public TheQuestForm()
        {
            InitializeComponent();
            game = new Game( new Rectangle( 78, 57, 420, 155 ) );

        }

        private void UpdateModel()
        {
            pictureBoxPlayer.Location = game.GetActorPos( game.GamePlayer );

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
