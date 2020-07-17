namespace REAL_PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.loselabel = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.gamecube = new System.Windows.Forms.PictureBox();
            this.gamepanel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamecube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.loselabel);
            this.background.Controls.Add(this.Result);
            this.background.Controls.Add(this.gamecube);
            this.background.Controls.Add(this.gamepanel);
            this.background.Controls.Add(this.pictureBox1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // loselabel
            // 
            this.loselabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loselabel.AutoSize = true;
            this.loselabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loselabel.Location = new System.Drawing.Point(437, 144);
            this.loselabel.Name = "loselabel";
            this.loselabel.Size = new System.Drawing.Size(852, 47);
            this.loselabel.TabIndex = 4;
            this.loselabel.Text = "Потрачено! Esc - выход; Space - рестарт;\r\n";
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(611, 18);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(177, 32);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результат: 0";
            // 
            // gamecube
            // 
            this.gamecube.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamecube.Location = new System.Drawing.Point(184, 178);
            this.gamecube.Name = "gamecube";
            this.gamecube.Size = new System.Drawing.Size(50, 50);
            this.gamecube.TabIndex = 2;
            this.gamecube.TabStop = false;
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamepanel.Location = new System.Drawing.Point(243, 297);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(150, 50);
            this.gamepanel.TabIndex = 1;
            this.gamepanel.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamecube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox gamecube;
        private System.Windows.Forms.PictureBox gamepanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label loselabel;
    }
}

