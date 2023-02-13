namespace Assignment1
{
    partial class Zoo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.animalSpecsBox = new System.Windows.Forms.TextBox();
            this.animalSpecsLabel = new System.Windows.Forms.Label();
            this.addAnimalButton = new System.Windows.Forms.Button();
            this.animallistbox = new System.Windows.Forms.ListBox();
            this.specieslistbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genderlistbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.ageBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.addAnimalButton);
            this.groupBox1.Controls.Add(this.animallistbox);
            this.groupBox1.Controls.Add(this.specieslistbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.genderlistbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1848, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(244, 120);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(200, 39);
            this.ageBox.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.animalSpecsBox);
            this.groupBox3.Controls.Add(this.animalSpecsLabel);
            this.groupBox3.Location = new System.Drawing.Point(515, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 293);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Specifications";
            // 
            // animalSpecsBox
            // 
            this.animalSpecsBox.Location = new System.Drawing.Point(201, 54);
            this.animalSpecsBox.Name = "animalSpecsBox";
            this.animalSpecsBox.Size = new System.Drawing.Size(200, 39);
            this.animalSpecsBox.TabIndex = 12;
            // 
            // animalSpecsLabel
            // 
            this.animalSpecsLabel.AutoSize = true;
            this.animalSpecsLabel.ForeColor = System.Drawing.Color.Black;
            this.animalSpecsLabel.Location = new System.Drawing.Point(21, 57);
            this.animalSpecsLabel.Name = "animalSpecsLabel";
            this.animalSpecsLabel.Size = new System.Drawing.Size(162, 32);
            this.animalSpecsLabel.TabIndex = 12;
            this.animalSpecsLabel.Text = "Num of Teeth";
            // 
            // addAnimalButton
            // 
            this.addAnimalButton.Location = new System.Drawing.Point(63, 396);
            this.addAnimalButton.Name = "addAnimalButton";
            this.addAnimalButton.Size = new System.Drawing.Size(1496, 73);
            this.addAnimalButton.TabIndex = 9;
            this.addAnimalButton.Text = "ADD ANIMAL";
            this.addAnimalButton.UseVisualStyleBackColor = true;
            this.addAnimalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // animallistbox
            // 
            this.animallistbox.FormattingEnabled = true;
            this.animallistbox.ItemHeight = 32;
            this.animallistbox.Location = new System.Drawing.Point(1342, 120);
            this.animallistbox.Name = "animallistbox";
            this.animallistbox.Size = new System.Drawing.Size(217, 228);
            this.animallistbox.TabIndex = 8;
            // 
            // specieslistbox
            // 
            this.specieslistbox.FormattingEnabled = true;
            this.specieslistbox.ItemHeight = 32;
            this.specieslistbox.Location = new System.Drawing.Point(1019, 120);
            this.specieslistbox.Name = "specieslistbox";
            this.specieslistbox.Size = new System.Drawing.Size(228, 228);
            this.specieslistbox.TabIndex = 7;
            this.specieslistbox.SelectedIndexChanged += new System.EventHandler(this.specieslistbox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1342, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Animal Type";
            // 
            // genderlistbox
            // 
            this.genderlistbox.FormattingEnabled = true;
            this.genderlistbox.ItemHeight = 32;
            this.genderlistbox.Location = new System.Drawing.Point(63, 220);
            this.genderlistbox.Name = "genderlistbox";
            this.genderlistbox.Size = new System.Drawing.Size(414, 132);
            this.genderlistbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1019, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Species Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(244, 59);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 39);
            this.nameBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(12, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1836, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal Registration";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(32, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 283);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animal Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tail Length: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 32);
            this.label10.TabIndex = 3;
            this.label10.Text = "Gender:  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "Teeth: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Age: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID: ";
            // 
            // Zoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 850);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Zoo";
            this.Text = "Eric Malmstrom Animal Zoo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox ageBox;
        private GroupBox groupBox3;
        private TextBox animalSpecsBox;
        private Label animalSpecsLabel;
        private Button addAnimalButton;
        private ListBox animallistbox;
        private ListBox specieslistbox;
        private Label label5;
        private ListBox genderlistbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nameBox;
        private GroupBox groupBox4;
        private Label label12;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
    }
}