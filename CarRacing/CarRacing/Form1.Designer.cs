namespace CarRacing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.playerCar = new System.Windows.Forms.PictureBox();
            this.aiCar2 = new System.Windows.Forms.PictureBox();
            this.aiCar1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.distance = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.playerCar);
            this.panel1.Controls.Add(this.aiCar2);
            this.panel1.Controls.Add(this.aiCar1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 519);
            this.panel1.TabIndex = 0;
            // 
            // award
            // 
            this.award.Image = global::CarRacing.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(76, 201);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 2;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::CarRacing.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(93, 364);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 2;
            this.explosion.TabStop = false;
            // 
            // playerCar
            // 
            this.playerCar.Image = global::CarRacing.Properties.Resources.carYellow;
            this.playerCar.Location = new System.Drawing.Point(219, 377);
            this.playerCar.Name = "playerCar";
            this.playerCar.Size = new System.Drawing.Size(50, 99);
            this.playerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerCar.TabIndex = 2;
            this.playerCar.TabStop = false;
            // 
            // aiCar2
            // 
            this.aiCar2.Image = global::CarRacing.Properties.Resources.carOrange;
            this.aiCar2.Location = new System.Drawing.Point(397, 62);
            this.aiCar2.Name = "aiCar2";
            this.aiCar2.Size = new System.Drawing.Size(50, 100);
            this.aiCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aiCar2.TabIndex = 2;
            this.aiCar2.TabStop = false;
            this.aiCar2.Tag = "carRight";
            // 
            // aiCar1
            // 
            this.aiCar1.Image = global::CarRacing.Properties.Resources.CarRed;
            this.aiCar1.Location = new System.Drawing.Point(76, 62);
            this.aiCar1.Name = "aiCar1";
            this.aiCar1.Size = new System.Drawing.Size(50, 100);
            this.aiCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aiCar1.TabIndex = 2;
            this.aiCar1.TabStop = false;
            this.aiCar1.Tag = "carLeft";
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::CarRacing.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(475, 518);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::CarRacing.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -519);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(475, 519);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.Location = new System.Drawing.Point(175, 583);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(137, 49);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "LET\'S GO!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.restartGame);
            // 
            // distance
            // 
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.Location = new System.Drawing.Point(16, 539);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(468, 34);
            this.distance.TabIndex = 1;
            this.distance.Text = "Score: 0";
            this.distance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(14, 647);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(469, 115);
            this.description.TabIndex = 2;
            this.description.Text = "Press Left and Right key to steer the car.\r\n\r\nAvoid crashing and survive for as l" +
    "ong as you can.\r\n\r\nAnd most importantly, DON\'T DRINK AND DRIVE! ";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 773);
            this.Controls.Add(this.description);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing by Divij";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aiCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox playerCar;
        private System.Windows.Forms.PictureBox aiCar2;
        private System.Windows.Forms.PictureBox aiCar1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer gameTimer;
    }
}

