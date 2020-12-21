namespace _16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBG = new System.Windows.Forms.PictureBox();
            this.pictureBoxDish = new System.Windows.Forms.PictureBox();
            this.pictureBoxFruit = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFruit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBG
            // 
            this.pictureBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBG.BackgroundImage")));
            this.pictureBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBG.Location = new System.Drawing.Point(-3, 21);
            this.pictureBG.Name = "pictureBG";
            this.pictureBG.Size = new System.Drawing.Size(1105, 906);
            this.pictureBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBG.TabIndex = 0;
            this.pictureBG.TabStop = false;
            // 
            // pictureBoxDish
            // 
            this.pictureBoxDish.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDish.Image")));
            this.pictureBoxDish.Location = new System.Drawing.Point(460, 840);
            this.pictureBoxDish.Name = "pictureBoxDish";
            this.pictureBoxDish.Size = new System.Drawing.Size(211, 87);
            this.pictureBoxDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDish.TabIndex = 1;
            this.pictureBoxDish.TabStop = false;
            // 
            // pictureBoxFruit
            // 
            this.pictureBoxFruit.Location = new System.Drawing.Point(519, 21);
            this.pictureBoxFruit.Name = "pictureBoxFruit";
            this.pictureBoxFruit.Size = new System.Drawing.Size(98, 76);
            this.pictureBoxFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFruit.TabIndex = 2;
            this.pictureBoxFruit.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.стартToolStripMenuItem.Text = "Старт";
            this.стартToolStripMenuItem.Click += new System.EventHandler(this.стартToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 927);
            this.Controls.Add(this.pictureBoxFruit);
            this.Controls.Add(this.pictureBoxDish);
            this.Controls.Add(this.pictureBG);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поймай фрукт тарелкой!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFruit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBG;
        private System.Windows.Forms.PictureBox pictureBoxDish;
        private System.Windows.Forms.PictureBox pictureBoxFruit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

