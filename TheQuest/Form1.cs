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
        }

        private void UpdateModel()
        {
            // Update Player
            pictureBoxPlayer.Location = game.GetActorPos( game.GamePlayer );
            labelPlayerHitPoint.Text = game.GamePlayer.ActorStatus.HitPoint.ToString();
            pictureBoxPlayer.Update();


            // Update Enemies

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            bool showWizard = false;
            int enemiesShown = 0;

            foreach(Enemy enemy in game.Enemies)
            {
                if( enemy is Bat)
                {
                    pictureBoxBat.Location = game.GetActorPos( enemy );
                    labelBatHP.Text = enemy.ActorStatus.HitPoint.ToString();
                    if(enemy.ActorStatus.HitPoint > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if ( enemy is Ghost )
                {
                    pictureBoxGhost.Location = game.GetActorPos( enemy );
                    labelGhostHP.Text = enemy.ActorStatus.HitPoint.ToString();
                    if ( enemy.ActorStatus.HitPoint > 0 )
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if ( enemy is Ghoul )
                {
                    pictureBoxGhoul.Location = game.GetActorPos( enemy );
                    labelGhoulHP.Text = enemy.ActorStatus.HitPoint.ToString();
                    if ( enemy.ActorStatus.HitPoint > 0 )
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
                if ( enemy is Wizard )
                {
                    pictureBoxWizard.Location = game.GetActorPos( enemy );
                    labelWizardHP.Text = enemy.ActorStatus.HitPoint.ToString();
                    if ( enemy.ActorStatus.HitPoint > 0 )
                    {
                        showWizard = true;
                        enemiesShown++;
                    }
                }
            }

            if(showBat)
            {
                pictureBoxBat.Visible = true;
            }
            else
            {
                pictureBoxBat.Visible = false;
                labelBat.Visible = false;
                labelBatHP.Visible = false;
            }
            if ( showGhost )
            {
                pictureBoxGhost.Visible = true;
            }
            else
            {
                pictureBoxGhost.Visible = false;
                labelGhost.Visible = false;
                labelGhostHP.Visible = false;
            }
            if ( showGhoul )
            {
                pictureBoxGhoul.Visible = true;
            }
            else
            {
                pictureBoxGhoul.Visible = false;
                labelGhoul.Visible = false;
                labelGhoulHP.Visible = false;
            }
            if ( showWizard )
            {
                pictureBoxWizard.Visible = true;
            }
            else
            {
                pictureBoxWizard.Visible = false;
                labelWizard.Visible = false;
                labelWizardHP.Visible = false;
            }

            // Update Item
            pictureBoxSword.Visible = false;
            pictureBoxBow.Visible = false;
            pictureBoxBattleAxe.Visible = false;
            pictureBoxBomb.Visible = false;
            pictureBoxMace.Visible = false;
            pictureBoxPotionBlue.Visible = false;
            pictureBoxPotionRed.Visible = false;
            pictureBoxQuiver.Visible = false;
            pictureBoxShield.Visible = false;

            Control itemControl = null;
            switch(game.ItemInRoom.Name)
            {
                case "Sword":
                    {
                        itemControl = pictureBoxSword;
                    }
                    break;
                case "Bow":
                    {
                        itemControl = pictureBoxBow;
                    }
                    break;
                case "BattleAxe":
                    {
                        itemControl = pictureBoxBattleAxe;
                    }
                    break;
                case "Bomb":
                    {
                        itemControl = pictureBoxBomb;
                    }
                    break;
                case "Mace":
                    {
                        itemControl = pictureBoxMace;
                    }
                    break;
                case "PotionBlue":
                    {
                        itemControl = pictureBoxPotionBlue;
                    }
                    break;
                case "PotionRed":
                    {
                        itemControl = pictureBoxPotionRed;
                    }
                    break;
                case "Quiver":
                    {
                        itemControl = pictureBoxQuiver;
                    }
                    break;
                case "Shield":
                    {
                        itemControl = pictureBoxShield;
                    }
                    break;
            }

            itemControl.Location = game.GetActorPos( game.ItemInRoom );
            if(game.ItemInRoom.IsPickedUp)
            {
                itemControl.Visible = false;
            }
            else
            {
                itemControl.Visible = true;
            }

            if(game.GamePlayer.ActorStatus.HitPoint <= 0)
            {
                MessageBox.Show( "유다희" );
                Application.Exit();
            }
            if(enemiesShown < 1)
            {
                MessageBox.Show( "You have defeated the enemies on this level" );
                game.NewLevel( random );
                UpdateModel();
            }

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

        private void TheQuestForm_Load( object sender, EventArgs e )
        {
            game = new Game( new MyRect( 100, 60, 650, 260 ) );

            game.NewLevel( random );
            UpdateModel();
        }
    }
}
