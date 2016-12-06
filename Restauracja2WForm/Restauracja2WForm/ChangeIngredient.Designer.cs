namespace Restauracja2WForm
{
    partial class ChangeIngredient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.normalButton2 = new Restauracja2WForm.normalButton();
            this.normalButton1 = new Restauracja2WForm.normalButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 80);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(13, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 371);
            this.panel2.TabIndex = 3;
            // 
            // normalButton2
            // 
            this.normalButton2.Location = new System.Drawing.Point(12, 490);
            this.normalButton2.Name = "normalButton2";
            this.normalButton2.Size = new System.Drawing.Size(80, 80);
            this.normalButton2.TabIndex = 1;
            this.normalButton2.Text = "ANULUJ";
            this.normalButton2.UseVisualStyleBackColor = true;
            this.normalButton2.Click += new System.EventHandler(this.normalButton2_Click);
            // 
            // normalButton1
            // 
            this.normalButton1.Location = new System.Drawing.Point(843, 490);
            this.normalButton1.Name = "normalButton1";
            this.normalButton1.Size = new System.Drawing.Size(80, 80);
            this.normalButton1.TabIndex = 0;
            this.normalButton1.Text = "DALEJ";
            this.normalButton1.UseVisualStyleBackColor = true;
            this.normalButton1.Click += new System.EventHandler(this.normalButton1_Click);
            // 
            // ChangeIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(935, 582);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.normalButton2);
            this.Controls.Add(this.normalButton1);
            this.Name = "ChangeIngredient";
            this.Text = "ChangeIngredient";
            this.Load += new System.EventHandler(this.ChangeIngredient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private normalButton normalButton1;
        private normalButton normalButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}