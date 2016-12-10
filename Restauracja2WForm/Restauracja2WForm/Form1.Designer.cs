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
            this.panelOfOrderForms = new System.Windows.Forms.Panel();
            this.panelOfMenuContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDeliveryInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOrderTree = new System.Windows.Forms.Panel();
            this.panelAllOrders = new System.Windows.Forms.Panel();
            this.normalButton1 = new Restauracja2WForm.normalButton();
            this.normalButton4 = new Restauracja2WForm.normalButton();
            this.dowozButton = new Restauracja2WForm.normalButton();
            this.wynosButton = new Restauracja2WForm.normalButton();
            this.lokalButton = new Restauracja2WForm.normalButton();
            this.normalButton2 = new Restauracja2WForm.normalButton();
            this.panelOfOrderForms.SuspendLayout();
            this.panelOfMenuContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDeliveryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOfOrderForms
            // 
            this.panelOfOrderForms.BackColor = System.Drawing.Color.Transparent;
            this.panelOfOrderForms.Controls.Add(this.normalButton4);
            this.panelOfOrderForms.Controls.Add(this.dowozButton);
            this.panelOfOrderForms.Controls.Add(this.wynosButton);
            this.panelOfOrderForms.Controls.Add(this.lokalButton);
            this.panelOfOrderForms.Location = new System.Drawing.Point(12, 99);
            this.panelOfOrderForms.Name = "panelOfOrderForms";
            this.panelOfOrderForms.Size = new System.Drawing.Size(200, 600);
            this.panelOfOrderForms.TabIndex = 0;
            // 
            // panelOfMenuContent
            // 
            this.panelOfMenuContent.BackColor = System.Drawing.Color.Transparent;
            this.panelOfMenuContent.Controls.Add(this.normalButton2);
            this.panelOfMenuContent.Controls.Add(this.panelAllOrders);
            this.panelOfMenuContent.Location = new System.Drawing.Point(218, 99);
            this.panelOfMenuContent.Name = "panelOfMenuContent";
            this.panelOfMenuContent.Size = new System.Drawing.Size(600, 600);
            this.panelOfMenuContent.TabIndex = 1;
            this.panelOfMenuContent.Visible = false;
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
            // panelDeliveryInfo
            // 
            this.panelDeliveryInfo.Controls.Add(this.normalButton1);
            this.panelDeliveryInfo.Controls.Add(this.label3);
            this.panelDeliveryInfo.Controls.Add(this.label2);
            this.panelDeliveryInfo.Controls.Add(this.label1);
            this.panelDeliveryInfo.Location = new System.Drawing.Point(218, 12);
            this.panelDeliveryInfo.Name = "panelDeliveryInfo";
            this.panelDeliveryInfo.Size = new System.Drawing.Size(600, 80);
            this.panelDeliveryInfo.TabIndex = 2;
            this.panelDeliveryInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "FORMA PŁATNOŚCI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADRES:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NR TELEFONU:";
            // 
            // panelOrderTree
            // 
            this.panelOrderTree.Location = new System.Drawing.Point(820, 100);
            this.panelOrderTree.Name = "panelOrderTree";
            this.panelOrderTree.Size = new System.Drawing.Size(180, 600);
            this.panelOrderTree.TabIndex = 3;
            // 
            // panelAllOrders
            // 
            this.panelAllOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllOrders.Location = new System.Drawing.Point(0, 0);
            this.panelAllOrders.Name = "panelAllOrders";
            this.panelAllOrders.Size = new System.Drawing.Size(600, 600);
            this.panelAllOrders.TabIndex = 1;
            // 
            // normalButton1
            // 
            this.normalButton1.Location = new System.Drawing.Point(517, 0);
            this.normalButton1.Name = "normalButton1";
            this.normalButton1.Size = new System.Drawing.Size(80, 80);
            this.normalButton1.TabIndex = 3;
            this.normalButton1.Text = "EDYTUJ DANE KLIENTA";
            this.normalButton1.UseVisualStyleBackColor = true;
            this.normalButton1.Click += new System.EventHandler(this.normalButton1_Click_1);
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
            // normalButton2
            // 
            this.normalButton2.Location = new System.Drawing.Point(520, 520);
            this.normalButton2.Name = "normalButton2";
            this.normalButton2.Size = new System.Drawing.Size(80, 80);
            this.normalButton2.TabIndex = 0;
            this.normalButton2.Text = "KONIEC EDYCJI ZAMÓWIENIA";
            this.normalButton2.UseVisualStyleBackColor = true;
            this.normalButton2.Click += new System.EventHandler(this.EndOfTheOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panelOrderTree);
            this.Controls.Add(this.panelDeliveryInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelOfOrderForms);
            this.Controls.Add(this.panelOfMenuContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAVE\'S ";
            this.panelOfOrderForms.ResumeLayout(false);
            this.panelOfMenuContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDeliveryInfo.ResumeLayout(false);
            this.panelDeliveryInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOfOrderForms;
        private System.Windows.Forms.Panel panelOfMenuContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private normalButton lokalButton;
        private normalButton dowozButton;
        private normalButton wynosButton;
        private normalButton normalButton4;
        private System.Windows.Forms.GroupBox deliveryForm;
        private System.Windows.Forms.GroupBox takeawayForm;
        private System.Windows.Forms.GroupBox actualOrder;
        private System.Windows.Forms.Panel panelDeliveryInfo;
        private System.Windows.Forms.Panel panelOrderTree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private normalButton normalButton1;
        private normalButton normalButton2;
        private System.Windows.Forms.Panel panelAllOrders;
    }
}

