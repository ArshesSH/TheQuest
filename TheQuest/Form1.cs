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
        private List<string> inventoryForms = new List<string>();
        private KeyValuePair<string, PictureBox> curItemPair;

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

            foreach ( Enemy enemy in game.Enemies )
            {
                if ( enemy is Bat )
                {
                    pictureBoxBat.Location = game.GetActorPos( enemy );
                    labelBatHP.Text = enemy.ActorStatus.HitPoint.ToString();
                    if ( enemy.ActorStatus.HitPoint > 0 )
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

            if ( showBat )
            {
                pictureBoxBat.Visible = true;
                labelBat.Visible = true;
                labelBatHP.Visible = true;
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
                labelGhost.Visible = true;
                labelGhostHP.Visible = true;
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
                labelGhoul.Visible = true;
                labelGhoulHP.Visible = true;
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
                labelWizard.Visible = true;
                labelWizardHP.Visible = true;
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
            switch ( game.ItemInRoom.Name )
            {
                case "Sword":
                    {
                        itemControl = pictureBoxSword;
                        curItemPair = new KeyValuePair<string, PictureBox>( "Sword", pictureBoxSword );
                    }
                    break;
                case "Bow":
                    {
                        itemControl = pictureBoxBow;
                        curItemPair = new KeyValuePair<string, PictureBox>( "Bow", pictureBoxBow );
                    }
                    break;
                case "BattleAxe":
                    {
                        itemControl = pictureBoxBattleAxe;
                        curItemPair = new KeyValuePair<string, PictureBox>( "BattleAxe", pictureBoxBattleAxe );
                    }
                    break;
                case "Bomb":
                    {
                        itemControl = pictureBoxBomb;
                        curItemPair = new KeyValuePair<string, PictureBox>( "Bomb", pictureBoxBomb );
                    }
                    break;
                case "Mace":
                    {
                        itemControl = pictureBoxMace;
                        curItemPair = new KeyValuePair<string, PictureBox>( "Mace", pictureBoxMace );
                    }
                    break;
                case "BluePotion":
                    {
                        itemControl = pictureBoxPotionBlue;
                        curItemPair = new KeyValuePair<string, PictureBox>( "BluePotion", pictureBoxPotionBlue );
                    }
                    break;
                case "RedPotion":
                    {
                        itemControl = pictureBoxPotionRed;
                        curItemPair = new KeyValuePair<string, PictureBox>( "RedPotion", pictureBoxPotionRed );
                    }
                    break;
                case "Quiver":
                    {
                        itemControl = pictureBoxQuiver;
                        curItemPair = new KeyValuePair<string, PictureBox>( "Quiver", pictureBoxQuiver );
                    }
                    break;
                case "Shield":
                    {
                        itemControl = pictureBoxShield;
                        curItemPair = new KeyValuePair<string, PictureBox>( "Shield", pictureBoxShield );
                    }
                    break;
            }

            itemControl.Location = game.GetActorPos( game.ItemInRoom );
            if ( game.ItemInRoom.IsPickedUp )
            {
                itemControl.Visible = false;

                if( !inventoryForms.Contains(curItemPair.Key) )
                {
                    inventoryForms.Add( curItemPair.Key );
                    AddToInventoryForm( curItemPair.Value, game.GamePlayer.Items.Count - 1 );
                }
            }
            else
            {
                itemControl.Visible = true;
            }

            if( game.GamePlayer.EquippedIdx == -1)
            {
                pictureBoxInventory1.BorderStyle = BorderStyle.None;
                pictureBoxInventory2.BorderStyle = BorderStyle.None;
                pictureBoxInventory3.BorderStyle = BorderStyle.None;
                pictureBoxInventory4.BorderStyle = BorderStyle.None;
                pictureBoxInventory5.BorderStyle = BorderStyle.None;
                pictureBoxInventory6.BorderStyle = BorderStyle.None;
                pictureBoxInventory7.BorderStyle = BorderStyle.None;
                pictureBoxInventory8.BorderStyle = BorderStyle.None;
                pictureBoxInventory9.BorderStyle = BorderStyle.None;
            }


            if (game.GamePlayer.ActorStatus.HitPoint <= 0)
            {
                MessageBox.Show( "You Died" );
                Application.Exit();
            }
            if(enemiesShown < 1)
            {
                MessageBox.Show( "You have defeated the enemies on this level" );
                game.NewLevel( random );
                UpdateModel();
            }

        }


        private void AddToInventoryForm(PictureBox picture, int index)
        {
            switch(index)
            {
                case 0:
                {
                    pictureBoxInventory1.Image = picture.Image;
                    pictureBoxInventory1.Visible = true;
                    break;
                }
                case 1:
                {
                    pictureBoxInventory2.Image = picture.Image;
                    pictureBoxInventory2.Visible = true;
                    break;
                }
                case 2:
                {
                    pictureBoxInventory3.Image = picture.Image;
                    pictureBoxInventory3.Visible = true;
                    break;
                }
                case 3:
                {
                    pictureBoxInventory4.Image = picture.Image;
                    pictureBoxInventory4.Visible = true;
                    break;
                }
                case 4:
                {
                    pictureBoxInventory5.Image = picture.Image;
                    pictureBoxInventory5.Visible = true;
                    break;
                }
                case 5:
                {
                    pictureBoxInventory6.Image = picture.Image;
                    pictureBoxInventory6.Visible = true;
                    break;
                }
                case 6:
                {
                    pictureBoxInventory7.Image = picture.Image;
                    pictureBoxInventory7.Visible = true;
                    break;
                }
                case 7:
                {
                    pictureBoxInventory8.Image = picture.Image;
                    pictureBoxInventory8.Visible = true;
                    break;
                }
                case 8:
                {
                    pictureBoxInventory9.Image = picture.Image;
                    pictureBoxInventory9.Visible = true;
                    break;
                }
                default:
                {
                    break;
                }
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

        private void pictureBoxInventory1_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[0] );
        }

        private void pictureBoxInventory2_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;

            game.Equip( inventoryForms[1] );
        }

        private void pictureBoxInventory3_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[2] );
        }

        private void pictureBoxInventory4_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[3] );
        }

        private void pictureBoxInventory5_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[4] );
        }

        private void pictureBoxInventory6_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[5] );
        }

        private void pictureBoxInventory7_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[6] );
        }

        private void pictureBoxInventory8_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxInventory9.BorderStyle = BorderStyle.None;
            game.Equip( inventoryForms[7] );
        }

        private void pictureBoxInventory9_Click(object sender, EventArgs e)
        {
            pictureBoxInventory1.BorderStyle = BorderStyle.None;
            pictureBoxInventory2.BorderStyle = BorderStyle.None;
            pictureBoxInventory3.BorderStyle = BorderStyle.None;
            pictureBoxInventory4.BorderStyle = BorderStyle.None;
            pictureBoxInventory5.BorderStyle = BorderStyle.None;
            pictureBoxInventory6.BorderStyle = BorderStyle.None;
            pictureBoxInventory7.BorderStyle = BorderStyle.None;
            pictureBoxInventory8.BorderStyle = BorderStyle.None;
            pictureBoxInventory9.BorderStyle = BorderStyle.FixedSingle;
            game.Equip( inventoryForms[8] );
        }

        private void buttonAttackUp_Click( object sender, EventArgs e )
        {
            game.PlayerAttack( PointVec.DirUp, random );
            UpdateModel();
        }

        private void buttonAttackLeft_Click( object sender, EventArgs e )
        {
            game.PlayerAttack( PointVec.DirLeft, random );
            UpdateModel();
        }

        private void buttonAttackRight_Click( object sender, EventArgs e )
        {
            game.PlayerAttack( PointVec.DirRight, random );
            UpdateModel();
        }

        private void buttonAttackDown_Click( object sender, EventArgs e )
        {
            game.PlayerAttack( PointVec.DirDown, random );
            UpdateModel();
        }
    }
}
