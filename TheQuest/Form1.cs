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
            
        }


        private void buttonMoveUp_Click( object sender, EventArgs e )
        {

        }
    }
}
