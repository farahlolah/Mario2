namespace Mario2
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.mario = new System.Windows.Forms.PictureBox();
            this.mushroom = new System.Windows.Forms.PictureBox();
            this.evilMushroom = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evilMushroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::Mario2.Properties.Resources.mario_ground;
            this.ground.Location = new System.Drawing.Point(-6, 281);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(559, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // mario
            // 
            this.mario.Image = global::Mario2.Properties.Resources.mario2_removebg_preview;
            this.mario.Location = new System.Drawing.Point(-6, 224);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(83, 60);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 1;
            this.mario.TabStop = false;
            // 
            // mushroom
            // 
            this.mushroom.Image = global::Mario2.Properties.Resources.mushroom_removebg_preview;
            this.mushroom.Location = new System.Drawing.Point(259, 234);
            this.mushroom.Name = "mushroom";
            this.mushroom.Size = new System.Drawing.Size(70, 50);
            this.mushroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mushroom.TabIndex = 4;
            this.mushroom.TabStop = false;
            // 
            // evilMushroom
            // 
            this.evilMushroom.Image = global::Mario2.Properties.Resources.goomba_removebg_preview;
            this.evilMushroom.Location = new System.Drawing.Point(464, 242);
            this.evilMushroom.Name = "evilMushroom";
            this.evilMushroom.Size = new System.Drawing.Size(44, 42);
            this.evilMushroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evilMushroom.TabIndex = 5;
            this.evilMushroom.TabStop = false;
            // 
            // cloud3
            // 
            this.cloud3.Image = global::Mario2.Properties.Resources.mario_cloud;
            this.cloud3.Location = new System.Drawing.Point(350, 26);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(100, 50);
            this.cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud3.TabIndex = 6;
            this.cloud3.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.Image = global::Mario2.Properties.Resources.mario_cloud;
            this.cloud2.Location = new System.Drawing.Point(154, 74);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(124, 70);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud2.TabIndex = 7;
            this.cloud2.TabStop = false;
            // 
            // cloud1
            // 
            this.cloud1.Image = global::Mario2.Properties.Resources.mario_cloud;
            this.cloud1.Location = new System.Drawing.Point(27, 31);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(100, 50);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cloud1.TabIndex = 8;
            this.cloud1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.scoreLabel.Location = new System.Drawing.Point(176, 26);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(148, 27);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Text = "score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(520, 327);
            this.Controls.Add(this.mushroom);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.evilMushroom);
            this.Controls.Add(this.mario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evilMushroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox mario;
        private System.Windows.Forms.PictureBox mushroom;
        private System.Windows.Forms.PictureBox evilMushroom;
        private System.Windows.Forms.PictureBox cloud3;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
    }
}

