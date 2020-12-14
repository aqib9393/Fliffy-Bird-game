namespace Flappy_Bird
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
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(40, 182);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(45, 34);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 4;
            this.Bird.TabStop = false;
            // 
            // Down
            // 
            this.Down.Image = global::Flappy_Bird.Properties.Resources.Up;
            this.Down.Location = new System.Drawing.Point(274, 321);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(88, 190);
            this.Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Down.TabIndex = 3;
            this.Down.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_Bird.Properties.Resources.Background;
            this.Ground.Location = new System.Drawing.Point(-12, 517);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(542, 104);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // Top
            // 
            this.Top.Image = global::Flappy_Bird.Properties.Resources.Dwon;
            this.Top.Location = new System.Drawing.Point(366, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(88, 191);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 1;
            this.Top.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:  0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(506, 599);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyispress);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Down;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
    }
}

