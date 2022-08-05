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
        private Dictionary<string, PictureBox> inventoryTable = new Dictionary<string, PictureBox>();
        private KeyValuePair<string, PictureBox> curItemPair;

        public TheQuestForm()
        {
            InitializeComponent();
            InitInventoryTable();
        }
        private void InitInventoryTable()
        {
            inventoryTable.Add("Sword", pictureBoxInventory1 );
            inventoryTable.Add("Bow", pictureBoxInventory2 );
            inventoryTable.Add("Mace", pictureBoxInventory3 );
            inventoryTable.Add("BattleAxe", pictureBoxInventory4 );
            inventoryTable.Add("BluePotion", pictureBoxInventory5 );
            inventoryTable.Add("RedPotion", pictureBoxInventory6 );
            inventoryTable.Add("Shield", pictureBoxInventory7 );
            inventoryTable.Add("Bomb", pictureBoxInventory8 );
            inventoryTable.Add("Quiver", pictureBoxInventory9 );
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

            // Update ItemInRoom
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
                
                // Add item to invetory table if key is not in table
                if( !inventoryTable.ContainsKey(curItemPair.Key) )
                {
                    inventoryTable.Add( curItemPair.Key, curItemPair.Value );
                }
            }
            else
            {
                itemControl.Visible = true;
            }


            foreach(KeyValuePair<string, PictureBox> pair in inventoryTable)
            {
                pair.Value.Visible = false;
            }
            foreach (string item in game.GamePlayer.Items)
            {
                inventoryTable[item].Visible = true;
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

        public void OnClickInventory(string key)
        {
            for( int i = 0; i < inventoryTable.Count; ++i )
            {
                string curKey = inventoryTable.ElementAt(i).Key;
                if (curKey.Equals(key) )
                {
                    inventoryTable[curKey].BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    inventoryTable[curKey].BorderStyle = BorderStyle.None;
                }
            }

            game.Equip( key );
            if( key.Equals("BluePotion") || key.Equals( "RedPotion" ) )
            {
                labelAttack.Text = "Potion";
                buttonAttackLeft.Enabled = false;
                buttonAttackDown.Enabled = false;
                buttonAttackRight.Enabled = false;
                buttonAttackUp.Text = "Drink";
            }
            else
            {
                labelAttack.Text = "Attack";
                buttonAttackLeft.Enabled = true;
                buttonAttackDown.Enabled = true;
                buttonAttackRight.Enabled = true;
                buttonAttackUp.Text = "Up";
            }
        }

        private void pictureBoxInventory1_Click(object sender, EventArgs e)
        {
            OnClickInventory( "Sword" );
        }

        private void pictureBoxInventory2_Click(object sender, EventArgs e)
        {
            OnClickInventory( "Bow" );
        }

        private void pictureBoxInventory3_Click(object sender, EventArgs e)
        {
            OnClickInventory( "Mace" );
        }

        private void pictureBoxInventory4_Click(object sender, EventArgs e)
        {
            OnClickInventory( "BattleAxe" );
        }

        private void pictureBoxInventory5_Click(object sender, EventArgs e)
        {
            OnClickInventory( "BluePotion" );
        }

        private void pictureBoxInventory6_Click(object sender, EventArgs e)
        {
            OnClickInventory( "RedPotion" );
        }

        private void pictureBoxInventory7_Click(object sender, EventArgs e)
        {
            OnClickInventory( "Shield" );
        }

        private void pictureBoxInventory8_Click(object sender, EventArgs e)
        {
            OnClickInventory( "Bomb" );
        }

        private void pictureBoxInventory9_Click(object sender, EventArgs e)
        {
            OnClickInventory( "Quiver" );
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
