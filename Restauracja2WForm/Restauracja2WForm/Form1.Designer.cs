namespace Restauracja2WForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.normalButton4 = new Restauracja2WForm.normalButton();
            this.dowozButton = new Restauracja2WForm.normalButton();
            this.wynosButton = new Restauracja2WForm.normalButton();
            this.lokalButton = new Restauracja2WForm.normalButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.normalButton4);
            this.panel1.Controls.Add(this.dowozButton);
            this.panel1.Controls.Add(this.wynosButton);
            this.panel1.Controls.Add(this.lokalButton);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(218, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restauracja2WForm.Properties.Resources._1423270772;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(218, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 80);
            this.panel3.TabIndex = 2;
            // 
            // normalButton4
            // 
            this.normalButton4.Location = new System.Drawing.Point(3, 517);
            this.normalButton4.Name = "normalButton4";
            this.normalButton4.Size = new System.Drawing.Size(80, 80);
            this.normalButton4.TabIndex = 3;
            this.normalButton4.Text = "KONIEC PRACY";
            this.normalButton4.UseVisualStyleBackColor = true;
            this.normalButton4.Click += new System.EventHandler(this.normalButton4_Click);
            // 
            // dowozButton
            // 
            this.dowozButton.Location = new System.Drawing.Point(3, 172);
            this.dowozButton.Name = "dowozButton";
            this.dowozButton.Size = new System.Drawing.Size(80, 80);
            this.dowozButton.TabIndex = 2;
            this.dowozButton.Text = "DOWOZ";
            this.dowozButton.UseVisualStyleBackColor = true;
            this.dowozButton.Click += new System.EventHandler(this.dowozButton_Click);
            // 
            // wynosButton
            // 
            this.wynosButton.Location = new System.Drawing.Point(3, 86);
            this.wynosButton.Name = "wynosButton";
            this.wynosButton.Size = new System.Drawing.Size(80, 80);
            this.wynosButton.TabIndex = 1;
            this.wynosButton.Text = "WYNOS";
            this.wynosButton.UseVisualStyleBackColor = true;
            // 
            // lokalButton
            // 
            this.lokalButton.Location = new System.Drawing.Point(3, 0);
            this.lokalButton.Name = "lokalButton";
            this.lokalButton.Size = new System.Drawing.Size(80, 80);
            this.lokalButton.TabIndex = 0;
            this.lokalButton.Text = "LOKAL";
            this.lokalButton.UseVisualStyleBackColor = true;
            this.lokalButton.Click += new System.EventHandler(this.lokalButton_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(820, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 600);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAVE\'S ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private normalButton lokalButton;
        private normalButton dowozButton;
        private normalButton wynosButton;
        private normalButton normalButton4;
        private System.Windows.Forms.GroupBox deliveryForm;
        private System.Windows.Forms.GroupBox takeawayForm;
        private System.Windows.Forms.GroupBox actualOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

