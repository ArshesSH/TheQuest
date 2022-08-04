
namespace TheQuest
{
    partial class TheQuestForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheQuestForm));
            this.labelMove = new System.Windows.Forms.Label();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonAttackDown = new System.Windows.Forms.Button();
            this.buttonAttackRight = new System.Windows.Forms.Button();
            this.buttonAttackLeft = new System.Windows.Forms.Button();
            this.buttonAttackUp = new System.Windows.Forms.Button();
            this.labelAttack = new System.Windows.Forms.Label();
            this.pictureBoxInventory2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.labelGhoul = new System.Windows.Forms.Label();
            this.labelGhoulHP = new System.Windows.Forms.Label();
            this.labelPlayerHitPoint = new System.Windows.Forms.Label();
            this.labelPlayerStatus = new System.Windows.Forms.Label();
            this.labelBat = new System.Windows.Forms.Label();
            this.labelGhost = new System.Windows.Forms.Label();
            this.labelBatHP = new System.Windows.Forms.Label();
            this.labelGhostHP = new System.Windows.Forms.Label();
            this.tableLayoutPanelInventory = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxInventory3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxInventory4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxInventory1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxInventory5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxSword = new System.Windows.Forms.PictureBox();
            this.pictureBoxBat = new System.Windows.Forms.PictureBox();
            this.pictureBoxGhoul = new System.Windows.Forms.PictureBox();
            this.pictureBoxGhost = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattleAxe = new System.Windows.Forms.PictureBox();
            this.pictureBoxBomb = new System.Windows.Forms.PictureBox();
            this.pictureBoxBow = new System.Windows.Forms.PictureBox();
            this.pictureBoxMace = new System.Windows.Forms.PictureBox();
            this.pictureBoxPotionBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxPotionRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuiver = new System.Windows.Forms.PictureBox();
            this.pictureBoxShield = new System.Windows.Forms.PictureBox();
            this.pictureBoxWizard = new System.Windows.Forms.PictureBox();
            this.labelWizard = new System.Windows.Forms.Label();
            this.labelWizardHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory2)).BeginInit();
            this.tableLayoutPanelStatus.SuspendLayout();
            this.tableLayoutPanelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleAxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotionBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWizard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Location = new System.Drawing.Point(950, 40);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(36, 12);
            this.labelMove.TabIndex = 1;
            this.labelMove.Text = "Move";
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(995, 66);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveUp.TabIndex = 2;
            this.buttonMoveUp.Text = "Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(952, 95);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveLeft.TabIndex = 2;
            this.buttonMoveLeft.Text = "Left";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(1033, 95);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveRight.TabIndex = 2;
            this.buttonMoveRight.Text = "Right";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(995, 124);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveDown.TabIndex = 2;
            this.buttonMoveDown.Text = "Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonAttackDown
            // 
            this.buttonAttackDown.Location = new System.Drawing.Point(995, 276);
            this.buttonAttackDown.Name = "buttonAttackDown";
            this.buttonAttackDown.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackDown.TabIndex = 4;
            this.buttonAttackDown.Text = "Down";
            this.buttonAttackDown.UseVisualStyleBackColor = true;
            // 
            // buttonAttackRight
            // 
            this.buttonAttackRight.Location = new System.Drawing.Point(1033, 247);
            this.buttonAttackRight.Name = "buttonAttackRight";
            this.buttonAttackRight.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackRight.TabIndex = 5;
            this.buttonAttackRight.Text = "Right";
            this.buttonAttackRight.UseVisualStyleBackColor = true;
            // 
            // buttonAttackLeft
            // 
            this.buttonAttackLeft.Location = new System.Drawing.Point(952, 247);
            this.buttonAttackLeft.Name = "buttonAttackLeft";
            this.buttonAttackLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackLeft.TabIndex = 6;
            this.buttonAttackLeft.Text = "Left";
            this.buttonAttackLeft.UseVisualStyleBackColor = true;
            // 
            // buttonAttackUp
            // 
            this.buttonAttackUp.Location = new System.Drawing.Point(995, 218);
            this.buttonAttackUp.Name = "buttonAttackUp";
            this.buttonAttackUp.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackUp.TabIndex = 7;
            this.buttonAttackUp.Text = "Up";
            this.buttonAttackUp.UseVisualStyleBackColor = true;
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Location = new System.Drawing.Point(950, 192);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(39, 12);
            this.labelAttack.TabIndex = 3;
            this.labelAttack.Text = "Attack";
            // 
            // pictureBoxInventory2
            // 
            this.pictureBoxInventory2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInventory2.Image")));
            this.pictureBoxInventory2.Location = new System.Drawing.Point(79, 3);
            this.pictureBoxInventory2.Name = "pictureBoxInventory2";
            this.pictureBoxInventory2.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxInventory2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInventory2.TabIndex = 8;
            this.pictureBoxInventory2.TabStop = false;
            this.pictureBoxInventory2.Visible = false;
            // 
            // tableLayoutPanelStatus
            // 
            this.tableLayoutPanelStatus.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelStatus.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelStatus.ColumnCount = 2;
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.4908F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.5092F));
            this.tableLayoutPanelStatus.Controls.Add(this.labelWizardHP, 1, 4);
            this.tableLayoutPanelStatus.Controls.Add(this.labelWizard, 0, 4);
            this.tableLayoutPanelStatus.Controls.Add(this.labelGhoul, 0, 3);
            this.tableLayoutPanelStatus.Controls.Add(this.labelGhoulHP, 0, 3);
            this.tableLayoutPanelStatus.Controls.Add(this.labelPlayerHitPoint, 1, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.labelPlayerStatus, 0, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.labelBat, 0, 1);
            this.tableLayoutPanelStatus.Controls.Add(this.labelGhost, 0, 2);
            this.tableLayoutPanelStatus.Controls.Add(this.labelBatHP, 1, 1);
            this.tableLayoutPanelStatus.Controls.Add(this.labelGhostHP, 1, 2);
            this.tableLayoutPanelStatus.Location = new System.Drawing.Point(944, 366);
            this.tableLayoutPanelStatus.Name = "tableLayoutPanelStatus";
            this.tableLayoutPanelStatus.RowCount = 5;
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelStatus.Size = new System.Drawing.Size(179, 120);
            this.tableLayoutPanelStatus.TabIndex = 9;
            // 
            // labelGhoul
            // 
            this.labelGhoul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGhoul.AutoSize = true;
            this.labelGhoul.Location = new System.Drawing.Point(4, 73);
            this.labelGhoul.Name = "labelGhoul";
            this.labelGhoul.Size = new System.Drawing.Size(65, 23);
            this.labelGhoul.TabIndex = 7;
            this.labelGhoul.Text = "Ghoul";
            this.labelGhoul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGhoulHP
            // 
            this.labelGhoulHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGhoulHP.AutoSize = true;
            this.labelGhoulHP.Location = new System.Drawing.Point(76, 73);
            this.labelGhoulHP.Name = "labelGhoulHP";
            this.labelGhoulHP.Size = new System.Drawing.Size(99, 23);
            this.labelGhoulHP.TabIndex = 6;
            this.labelGhoulHP.Text = "enemyHitPoint3";
            this.labelGhoulHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerHitPoint
            // 
            this.labelPlayerHitPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerHitPoint.AutoSize = true;
            this.labelPlayerHitPoint.Location = new System.Drawing.Point(76, 1);
            this.labelPlayerHitPoint.Name = "labelPlayerHitPoint";
            this.labelPlayerHitPoint.Size = new System.Drawing.Size(99, 23);
            this.labelPlayerHitPoint.TabIndex = 1;
            this.labelPlayerHitPoint.Text = "playerHitPoint";
            this.labelPlayerHitPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerStatus
            // 
            this.labelPlayerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerStatus.AutoSize = true;
            this.labelPlayerStatus.Location = new System.Drawing.Point(4, 1);
            this.labelPlayerStatus.Name = "labelPlayerStatus";
            this.labelPlayerStatus.Size = new System.Drawing.Size(65, 23);
            this.labelPlayerStatus.TabIndex = 0;
            this.labelPlayerStatus.Text = "Player";
            this.labelPlayerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBat
            // 
            this.labelBat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBat.AutoSize = true;
            this.labelBat.Location = new System.Drawing.Point(4, 25);
            this.labelBat.Name = "labelBat";
            this.labelBat.Size = new System.Drawing.Size(65, 23);
            this.labelBat.TabIndex = 3;
            this.labelBat.Text = "Bat";
            this.labelBat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGhost
            // 
            this.labelGhost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGhost.AutoSize = true;
            this.labelGhost.Location = new System.Drawing.Point(4, 49);
            this.labelGhost.Name = "labelGhost";
            this.labelGhost.Size = new System.Drawing.Size(65, 23);
            this.labelGhost.TabIndex = 5;
            this.labelGhost.Text = "Ghost";
            this.labelGhost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBatHP
            // 
            this.labelBatHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBatHP.AutoSize = true;
            this.labelBatHP.Location = new System.Drawing.Point(76, 25);
            this.labelBatHP.Name = "labelBatHP";
            this.labelBatHP.Size = new System.Drawing.Size(99, 23);
            this.labelBatHP.TabIndex = 4;
            this.labelBatHP.Text = "enemyHitPoint1";
            this.labelBatHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGhostHP
            // 
            this.labelGhostHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGhostHP.AutoSize = true;
            this.labelGhostHP.Location = new System.Drawing.Point(76, 49);
            this.labelGhostHP.Name = "labelGhostHP";
            this.labelGhostHP.Size = new System.Drawing.Size(99, 23);
            this.labelGhostHP.TabIndex = 2;
            this.labelGhostHP.Text = "enemyHitPoint2";
            this.labelGhostHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelInventory
            // 
            this.tableLayoutPanelInventory.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelInventory.ColumnCount = 5;
            this.tableLayoutPanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInventory.Controls.Add(this.pictureBoxInventory3, 0, 0);
            this.tableLayoutPanelInventory.Controls.Add(this.pictureBoxInventory4, 0, 0);
            this.tableLayoutPanelInventory.Controls.Add(this.pictureBoxInventory1, 0, 0);
            this.tableLayoutPanelInventory.Controls.Add(this.pictureBoxInventory5, 1, 0);
            this.tableLayoutPanelInventory.Controls.Add(this.pictureBoxInventory2, 0, 0);
            this.tableLayoutPanelInventory.Location = new System.Drawing.Point(117, 478);
            this.tableLayoutPanelInventory.MinimumSize = new System.Drawing.Size(70, 70);
            this.tableLayoutPanelInventory.Name = "tableLayoutPanelInventory";
            this.tableLayoutPanelInventory.RowCount = 1;
            this.tableLayoutPanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInventory.Size = new System.Drawing.Size(400, 80);
            this.tableLayoutPanelInventory.TabIndex = 10;
            // 
            // pictureBoxInventory3
            // 
            this.pictureBoxInventory3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInventory3.Image")));
            this.pictureBoxInventory3.Location = new System.Drawing.Point(155, 3);
            this.pictureBoxInventory3.Name = "pictureBoxInventory3";
            this.pictureBoxInventory3.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxInventory3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInventory3.TabIndex = 12;
            this.pictureBoxInventory3.TabStop = false;
            this.pictureBoxInventory3.Visible = false;
            // 
            // pictureBoxInventory4
            // 
            this.pictureBoxInventory4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInventory4.Image")));
            this.pictureBoxInventory4.Location = new System.Drawing.Point(231, 3);
            this.pictureBoxInventory4.Name = "pictureBoxInventory4";
            this.pictureBoxInventory4.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxInventory4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInventory4.TabIndex = 11;
            this.pictureBoxInventory4.TabStop = false;
            this.pictureBoxInventory4.Visible = false;
            // 
            // pictureBoxInventory1
            // 
            this.pictureBoxInventory1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInventory1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInventory1.Image")));
            this.pictureBoxInventory1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxInventory1.Name = "pictureBoxInventory1";
            this.pictureBoxInventory1.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxInventory1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInventory1.TabIndex = 10;
            this.pictureBoxInventory1.TabStop = false;
            this.pictureBoxInventory1.Visible = false;
            // 
            // pictureBoxInventory5
            // 
            this.pictureBoxInventory5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInventory5.Image")));
            this.pictureBoxInventory5.Location = new System.Drawing.Point(307, 3);
            this.pictureBoxInventory5.Name = "pictureBoxInventory5";
            this.pictureBoxInventory5.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxInventory5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInventory5.TabIndex = 9;
            this.pictureBoxInventory5.TabStop = false;
            this.pictureBoxInventory5.Visible = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.Image")));
            this.pictureBoxPlayer.Location = new System.Drawing.Point(117, 88);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlayer.TabIndex = 11;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxSword
            // 
            this.pictureBoxSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSword.Image")));
            this.pictureBoxSword.Location = new System.Drawing.Point(173, 88);
            this.pictureBoxSword.Name = "pictureBoxSword";
            this.pictureBoxSword.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSword.TabIndex = 12;
            this.pictureBoxSword.TabStop = false;
            this.pictureBoxSword.Visible = false;
            // 
            // pictureBoxBat
            // 
            this.pictureBoxBat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBat.Image")));
            this.pictureBoxBat.Location = new System.Drawing.Point(117, 256);
            this.pictureBoxBat.Name = "pictureBoxBat";
            this.pictureBoxBat.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBat.TabIndex = 13;
            this.pictureBoxBat.TabStop = false;
            this.pictureBoxBat.Visible = false;
            // 
            // pictureBoxGhoul
            // 
            this.pictureBoxGhoul.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGhoul.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGhoul.Image")));
            this.pictureBoxGhoul.Location = new System.Drawing.Point(285, 88);
            this.pictureBoxGhoul.Name = "pictureBoxGhoul";
            this.pictureBoxGhoul.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGhoul.TabIndex = 14;
            this.pictureBoxGhoul.TabStop = false;
            this.pictureBoxGhoul.Visible = false;
            // 
            // pictureBoxGhost
            // 
            this.pictureBoxGhost.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGhost.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGhost.Image")));
            this.pictureBoxGhost.Location = new System.Drawing.Point(117, 312);
            this.pictureBoxGhost.Name = "pictureBoxGhost";
            this.pictureBoxGhost.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGhost.TabIndex = 15;
            this.pictureBoxGhost.TabStop = false;
            this.pictureBoxGhost.Visible = false;
            // 
            // pictureBoxBattleAxe
            // 
            this.pictureBoxBattleAxe.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBattleAxe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBattleAxe.Image")));
            this.pictureBoxBattleAxe.Location = new System.Drawing.Point(397, 88);
            this.pictureBoxBattleAxe.Name = "pictureBoxBattleAxe";
            this.pictureBoxBattleAxe.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBattleAxe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBattleAxe.TabIndex = 16;
            this.pictureBoxBattleAxe.TabStop = false;
            this.pictureBoxBattleAxe.Visible = false;
            // 
            // pictureBoxBomb
            // 
            this.pictureBoxBomb.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBomb.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBomb.Image")));
            this.pictureBoxBomb.Location = new System.Drawing.Point(455, 88);
            this.pictureBoxBomb.Name = "pictureBoxBomb";
            this.pictureBoxBomb.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBomb.TabIndex = 17;
            this.pictureBoxBomb.TabStop = false;
            this.pictureBoxBomb.Visible = false;
            // 
            // pictureBoxBow
            // 
            this.pictureBoxBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBow.Image")));
            this.pictureBoxBow.Location = new System.Drawing.Point(511, 88);
            this.pictureBoxBow.Name = "pictureBoxBow";
            this.pictureBoxBow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBow.TabIndex = 18;
            this.pictureBoxBow.TabStop = false;
            this.pictureBoxBow.Visible = false;
            // 
            // pictureBoxMace
            // 
            this.pictureBoxMace.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMace.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMace.Image")));
            this.pictureBoxMace.Location = new System.Drawing.Point(567, 88);
            this.pictureBoxMace.Name = "pictureBoxMace";
            this.pictureBoxMace.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMace.TabIndex = 19;
            this.pictureBoxMace.TabStop = false;
            this.pictureBoxMace.Visible = false;
            // 
            // pictureBoxPotionBlue
            // 
            this.pictureBoxPotionBlue.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPotionBlue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPotionBlue.Image")));
            this.pictureBoxPotionBlue.Location = new System.Drawing.Point(623, 88);
            this.pictureBoxPotionBlue.Name = "pictureBoxPotionBlue";
            this.pictureBoxPotionBlue.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPotionBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPotionBlue.TabIndex = 20;
            this.pictureBoxPotionBlue.TabStop = false;
            this.pictureBoxPotionBlue.Visible = false;
            // 
            // pictureBoxPotionRed
            // 
            this.pictureBoxPotionRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPotionRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPotionRed.Image")));
            this.pictureBoxPotionRed.Location = new System.Drawing.Point(679, 88);
            this.pictureBoxPotionRed.Name = "pictureBoxPotionRed";
            this.pictureBoxPotionRed.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPotionRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPotionRed.TabIndex = 21;
            this.pictureBoxPotionRed.TabStop = false;
            this.pictureBoxPotionRed.Visible = false;
            // 
            // pictureBoxQuiver
            // 
            this.pictureBoxQuiver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxQuiver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuiver.Image")));
            this.pictureBoxQuiver.Location = new System.Drawing.Point(735, 88);
            this.pictureBoxQuiver.Name = "pictureBoxQuiver";
            this.pictureBoxQuiver.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxQuiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxQuiver.TabIndex = 22;
            this.pictureBoxQuiver.TabStop = false;
            this.pictureBoxQuiver.Visible = false;
            // 
            // pictureBoxShield
            // 
            this.pictureBoxShield.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShield.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShield.Image")));
            this.pictureBoxShield.Location = new System.Drawing.Point(117, 144);
            this.pictureBoxShield.Name = "pictureBoxShield";
            this.pictureBoxShield.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShield.TabIndex = 23;
            this.pictureBoxShield.TabStop = false;
            this.pictureBoxShield.Visible = false;
            // 
            // pictureBoxWizard
            // 
            this.pictureBoxWizard.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWizard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWizard.Image")));
            this.pictureBoxWizard.Location = new System.Drawing.Point(117, 200);
            this.pictureBoxWizard.Name = "pictureBoxWizard";
            this.pictureBoxWizard.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxWizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxWizard.TabIndex = 24;
            this.pictureBoxWizard.TabStop = false;
            this.pictureBoxWizard.Visible = false;
            // 
            // labelWizard
            // 
            this.labelWizard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWizard.AutoSize = true;
            this.labelWizard.Location = new System.Drawing.Point(4, 97);
            this.labelWizard.Name = "labelWizard";
            this.labelWizard.Size = new System.Drawing.Size(65, 22);
            this.labelWizard.TabIndex = 8;
            this.labelWizard.Text = "Wizard";
            this.labelWizard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWizardHP
            // 
            this.labelWizardHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWizardHP.AutoSize = true;
            this.labelWizardHP.Location = new System.Drawing.Point(76, 97);
            this.labelWizardHP.Name = "labelWizardHP";
            this.labelWizardHP.Size = new System.Drawing.Size(99, 22);
            this.labelWizardHP.TabIndex = 9;
            this.labelWizardHP.Text = "enemyHitPoint3";
            this.labelWizardHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TheQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1168, 607);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.pictureBoxWizard);
            this.Controls.Add(this.pictureBoxShield);
            this.Controls.Add(this.pictureBoxQuiver);
            this.Controls.Add(this.pictureBoxPotionRed);
            this.Controls.Add(this.pictureBoxPotionBlue);
            this.Controls.Add(this.pictureBoxMace);
            this.Controls.Add(this.pictureBoxBow);
            this.Controls.Add(this.pictureBoxBomb);
            this.Controls.Add(this.pictureBoxBattleAxe);
            this.Controls.Add(this.pictureBoxGhost);
            this.Controls.Add(this.pictureBoxGhoul);
            this.Controls.Add(this.pictureBoxBat);
            this.Controls.Add(this.pictureBoxSword);
            this.Controls.Add(this.tableLayoutPanelInventory);
            this.Controls.Add(this.tableLayoutPanelStatus);
            this.Controls.Add(this.buttonAttackDown);
            this.Controls.Add(this.buttonAttackRight);
            this.Controls.Add(this.buttonAttackLeft);
            this.Controls.Add(this.buttonAttackUp);
            this.Controls.Add(this.labelAttack);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonMoveUp);
            this.Controls.Add(this.labelMove);
            this.Name = "TheQuestForm";
            this.Text = "TheQuest";
            this.Load += new System.EventHandler(this.TheQuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory2)).EndInit();
            this.tableLayoutPanelStatus.ResumeLayout(false);
            this.tableLayoutPanelStatus.PerformLayout();
            this.tableLayoutPanelInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventory5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattleAxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotionBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWizard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonAttackDown;
        private System.Windows.Forms.Button buttonAttackRight;
        private System.Windows.Forms.Button buttonAttackLeft;
        private System.Windows.Forms.Button buttonAttackUp;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.PictureBox pictureBoxInventory2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatus;
        private System.Windows.Forms.Label labelPlayerHitPoint;
        private System.Windows.Forms.Label labelPlayerStatus;
        private System.Windows.Forms.Label labelGhoul;
        private System.Windows.Forms.Label labelGhoulHP;
        private System.Windows.Forms.Label labelBat;
        private System.Windows.Forms.Label labelGhost;
        private System.Windows.Forms.Label labelBatHP;
        private System.Windows.Forms.Label labelGhostHP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInventory;
        private System.Windows.Forms.PictureBox pictureBoxInventory3;
        private System.Windows.Forms.PictureBox pictureBoxInventory4;
        private System.Windows.Forms.PictureBox pictureBoxInventory1;
        private System.Windows.Forms.PictureBox pictureBoxInventory5;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxSword;
        private System.Windows.Forms.PictureBox pictureBoxBat;
        private System.Windows.Forms.PictureBox pictureBoxGhoul;
        private System.Windows.Forms.PictureBox pictureBoxGhost;
        private System.Windows.Forms.PictureBox pictureBoxBattleAxe;
        private System.Windows.Forms.PictureBox pictureBoxBomb;
        private System.Windows.Forms.PictureBox pictureBoxBow;
        private System.Windows.Forms.PictureBox pictureBoxMace;
        private System.Windows.Forms.PictureBox pictureBoxPotionBlue;
        private System.Windows.Forms.PictureBox pictureBoxPotionRed;
        private System.Windows.Forms.PictureBox pictureBoxQuiver;
        private System.Windows.Forms.PictureBox pictureBoxShield;
        private System.Windows.Forms.PictureBox pictureBoxWizard;
        private System.Windows.Forms.Label labelWizardHP;
        private System.Windows.Forms.Label labelWizard;
    }
}

