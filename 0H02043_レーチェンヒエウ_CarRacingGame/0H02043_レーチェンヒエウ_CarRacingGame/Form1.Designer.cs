namespace _0H02043_レーチェンヒエウ_CarRacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picGameOver);
            this.panel1.Controls.Add(this.Car2);
            this.panel1.Controls.Add(this.Car1);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.Road2);
            this.panel1.Controls.Add(this.Road1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 514);
            this.panel1.TabIndex = 0;
            // 
            // picGameOver
            // 
            this.picGameOver.Image = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.gameover;
            this.picGameOver.Location = new System.Drawing.Point(83, 231);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(340, 97);
            this.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameOver.TabIndex = 1;
            this.picGameOver.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.carPink;
            this.Car2.Location = new System.Drawing.Point(340, 65);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(50, 100);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car2.TabIndex = 1;
            this.Car2.TabStop = false;
            this.Car2.Tag = "carRight";
            // 
            // Car1
            // 
            this.Car1.Image = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.carYellow;
            this.Car1.Location = new System.Drawing.Point(115, 89);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(50, 99);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car1.TabIndex = 1;
            this.Car1.TabStop = false;
            this.Car1.Tag = "carLeft";
            // 
            // Player
            // 
            this.Player.Image = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.carGreen;
            this.Player.Location = new System.Drawing.Point(233, 365);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 101);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Road2
            // 
            this.Road2.Image = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.roadTrack;
            this.Road2.Location = new System.Drawing.Point(0, 0);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(490, 514);
            this.Road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road2.TabIndex = 0;
            this.Road2.TabStop = false;
            // 
            // Road1
            // 
            this.Road1.Image = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.roadTrack;
            this.Road1.Location = new System.Drawing.Point(0, -514);
            this.Road1.Name = "Road1";
            this.Road1.Size = new System.Drawing.Size(490, 514);
            this.Road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road1.TabIndex = 0;
            this.Road1.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtScore.Location = new System.Drawing.Point(15, 529);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(129, 40);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(6, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 124);
            this.label2.TabIndex = 3;
            this.label2.Text = "←と→キーでプレイ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(333, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 111);
            this.label3.TabIndex = 4;
            this.label3.Text = "他の車にぶつからないでサバイバル";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.GameTimer);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.StartButton.BackgroundImage = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.StartButton;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.Location = new System.Drawing.Point(164, 638);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(171, 92);
            this.StartButton.TabIndex = 1;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtLevel.Location = new System.Drawing.Point(332, 529);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(154, 40);
            this.txtLevel.TabIndex = 5;
            this.txtLevel.Text = "Level: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_0H02043_レーチェンヒエウ_CarRacingGame.Properties.Resources.CityBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 752);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtLevel;
    }
}

