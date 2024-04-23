namespace PokeAPI_Week_13
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
            this.txbSpecies = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBaseHappiness = new System.Windows.Forms.Label();
            this.lblCaptureRate = new System.Windows.Forms.Label();
            this.lblHabitat = new System.Windows.Forms.Label();
            this.lblGrowthRate = new System.Windows.Forms.Label();
            this.lblFlavorText = new System.Windows.Forms.Label();
            this.lblEggGroup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSpecies
            // 
            this.txbSpecies.Location = new System.Drawing.Point(36, 170);
            this.txbSpecies.Name = "txbSpecies";
            this.txbSpecies.Size = new System.Drawing.Size(158, 20);
            this.txbSpecies.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find Pokemon by ID:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // lblBaseHappiness
            // 
            this.lblBaseHappiness.AutoSize = true;
            this.lblBaseHappiness.Location = new System.Drawing.Point(98, 81);
            this.lblBaseHappiness.Name = "lblBaseHappiness";
            this.lblBaseHappiness.Size = new System.Drawing.Size(35, 13);
            this.lblBaseHappiness.TabIndex = 3;
            this.lblBaseHappiness.Text = "label2";
            // 
            // lblCaptureRate
            // 
            this.lblCaptureRate.AutoSize = true;
            this.lblCaptureRate.Location = new System.Drawing.Point(84, 121);
            this.lblCaptureRate.Name = "lblCaptureRate";
            this.lblCaptureRate.Size = new System.Drawing.Size(35, 13);
            this.lblCaptureRate.TabIndex = 4;
            this.lblCaptureRate.Text = "label3";
            // 
            // lblHabitat
            // 
            this.lblHabitat.AutoSize = true;
            this.lblHabitat.Location = new System.Drawing.Point(51, 161);
            this.lblHabitat.Name = "lblHabitat";
            this.lblHabitat.Size = new System.Drawing.Size(35, 13);
            this.lblHabitat.TabIndex = 5;
            this.lblHabitat.Text = "label4";
            // 
            // lblGrowthRate
            // 
            this.lblGrowthRate.AutoSize = true;
            this.lblGrowthRate.Location = new System.Drawing.Point(75, 201);
            this.lblGrowthRate.Name = "lblGrowthRate";
            this.lblGrowthRate.Size = new System.Drawing.Size(35, 13);
            this.lblGrowthRate.TabIndex = 6;
            this.lblGrowthRate.Text = "label5";
            // 
            // lblFlavorText
            // 
            this.lblFlavorText.AutoSize = true;
            this.lblFlavorText.Location = new System.Drawing.Point(75, 240);
            this.lblFlavorText.Name = "lblFlavorText";
            this.lblFlavorText.Size = new System.Drawing.Size(35, 13);
            this.lblFlavorText.TabIndex = 7;
            this.lblFlavorText.Text = "label6";
            // 
            // lblEggGroup
            // 
            this.lblEggGroup.AutoSize = true;
            this.lblEggGroup.Location = new System.Drawing.Point(73, 341);
            this.lblEggGroup.Name = "lblEggGroup";
            this.lblEggGroup.Size = new System.Drawing.Size(35, 13);
            this.lblEggGroup.TabIndex = 8;
            this.lblEggGroup.Text = "label7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pokemon Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Base Happiness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Capture Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Growth Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Flavor Text:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Egg Group:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Habitat:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEggGroup);
            this.groupBox1.Controls.Add(this.lblFlavorText);
            this.groupBox1.Controls.Add(this.lblGrowthRate);
            this.groupBox1.Controls.Add(this.lblHabitat);
            this.groupBox1.Controls.Add(this.lblCaptureRate);
            this.groupBox1.Controls.Add(this.lblBaseHappiness);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(249, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 383);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pokemon Information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbSpecies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSpecies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBaseHappiness;
        private System.Windows.Forms.Label lblCaptureRate;
        private System.Windows.Forms.Label lblHabitat;
        private System.Windows.Forms.Label lblGrowthRate;
        private System.Windows.Forms.Label lblFlavorText;
        private System.Windows.Forms.Label lblEggGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

