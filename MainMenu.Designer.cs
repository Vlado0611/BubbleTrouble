
namespace BubbleTrouble
{
    partial class MainMenu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnScoreboard = new System.Windows.Forms.Button();
            this.pboxTorch2 = new System.Windows.Forms.PictureBox();
            this.pboxTorch1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTorch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTorch1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkRed;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.Orange;
            this.btnStart.Location = new System.Drawing.Point(295, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(223, 84);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnScoreboard
            // 
            this.btnScoreboard.BackColor = System.Drawing.Color.DarkRed;
            this.btnScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnScoreboard.ForeColor = System.Drawing.Color.Orange;
            this.btnScoreboard.Location = new System.Drawing.Point(295, 246);
            this.btnScoreboard.Name = "btnScoreboard";
            this.btnScoreboard.Size = new System.Drawing.Size(223, 84);
            this.btnScoreboard.TabIndex = 1;
            this.btnScoreboard.Text = "Scoreboard";
            this.btnScoreboard.UseVisualStyleBackColor = false;
            this.btnScoreboard.Click += new System.EventHandler(this.btnScoreboard_Click);
            // 
            // pboxTorch2
            // 
            this.pboxTorch2.Image = global::BubbleTrouble.Properties.Resources.torch;
            this.pboxTorch2.Location = new System.Drawing.Point(524, 78);
            this.pboxTorch2.Name = "pboxTorch2";
            this.pboxTorch2.Size = new System.Drawing.Size(282, 324);
            this.pboxTorch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTorch2.TabIndex = 3;
            this.pboxTorch2.TabStop = false;
            // 
            // pboxTorch1
            // 
            this.pboxTorch1.Image = global::BubbleTrouble.Properties.Resources.torch;
            this.pboxTorch1.Location = new System.Drawing.Point(1, 78);
            this.pboxTorch1.Name = "pboxTorch1";
            this.pboxTorch1.Size = new System.Drawing.Size(288, 324);
            this.pboxTorch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTorch1.TabIndex = 2;
            this.pboxTorch1.TabStop = false;
            this.pboxTorch1.Click += new System.EventHandler(this.pboxTorch1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pboxTorch2);
            this.Controls.Add(this.pboxTorch1);
            this.Controls.Add(this.btnScoreboard);
            this.Controls.Add(this.btnStart);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTorch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTorch1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnScoreboard;
        private System.Windows.Forms.PictureBox pboxTorch1;
        private System.Windows.Forms.PictureBox pboxTorch2;
    }
}