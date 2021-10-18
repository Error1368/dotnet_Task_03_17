
namespace T0317
{
    partial class FormAddCandy
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
            this.comboBoxCandyClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSugar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxChocolateType = new System.Windows.Forms.ComboBox();
            this.checkBoxNuts = new System.Windows.Forms.CheckBox();
            this.checkBoxCaramel = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownAlcGrad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxShell = new System.Windows.Forms.TextBox();
            this.textBoxJam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlcGrad)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCandyClass
            // 
            this.comboBoxCandyClass.FormattingEnabled = true;
            this.comboBoxCandyClass.Items.AddRange(new object[] {
            "Chocolate Candy",
            "Alcohol Candy",
            "Marmalade Candy"});
            this.comboBoxCandyClass.Location = new System.Drawing.Point(86, 12);
            this.comboBoxCandyClass.Name = "comboBoxCandyClass";
            this.comboBoxCandyClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCandyClass.TabIndex = 0;
            this.comboBoxCandyClass.SelectedValueChanged += new System.EventHandler(this.CandyClassChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Candy Type:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(191, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(60, 99);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownWeight.TabIndex = 11;
            // 
            // numericUpDownSugar
            // 
            this.numericUpDownSugar.Location = new System.Drawing.Point(60, 68);
            this.numericUpDownSugar.Name = "numericUpDownSugar";
            this.numericUpDownSugar.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownSugar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "sugar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chocolate type:";
            this.label4.Visible = false;
            // 
            // comboBoxChocolateType
            // 
            this.comboBoxChocolateType.Enabled = false;
            this.comboBoxChocolateType.FormattingEnabled = true;
            this.comboBoxChocolateType.Items.AddRange(new object[] {
            "Dark",
            "Milk",
            "White"});
            this.comboBoxChocolateType.Location = new System.Drawing.Point(101, 133);
            this.comboBoxChocolateType.Name = "comboBoxChocolateType";
            this.comboBoxChocolateType.Size = new System.Drawing.Size(106, 21);
            this.comboBoxChocolateType.TabIndex = 15;
            this.comboBoxChocolateType.Visible = false;
            // 
            // checkBoxNuts
            // 
            this.checkBoxNuts.AutoSize = true;
            this.checkBoxNuts.Enabled = false;
            this.checkBoxNuts.Location = new System.Drawing.Point(15, 172);
            this.checkBoxNuts.Name = "checkBoxNuts";
            this.checkBoxNuts.Size = new System.Drawing.Size(70, 17);
            this.checkBoxNuts.TabIndex = 16;
            this.checkBoxNuts.Text = "Has Nuts";
            this.checkBoxNuts.UseVisualStyleBackColor = true;
            this.checkBoxNuts.Visible = false;
            // 
            // checkBoxCaramel
            // 
            this.checkBoxCaramel.AutoSize = true;
            this.checkBoxCaramel.Enabled = false;
            this.checkBoxCaramel.Location = new System.Drawing.Point(121, 172);
            this.checkBoxCaramel.Name = "checkBoxCaramel";
            this.checkBoxCaramel.Size = new System.Drawing.Size(86, 17);
            this.checkBoxCaramel.TabIndex = 17;
            this.checkBoxCaramel.Text = "Has Caramel";
            this.checkBoxCaramel.UseVisualStyleBackColor = true;
            this.checkBoxCaramel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alcohol grad:";
            this.label5.Visible = false;
            // 
            // numericUpDownAlcGrad
            // 
            this.numericUpDownAlcGrad.Enabled = false;
            this.numericUpDownAlcGrad.Location = new System.Drawing.Point(87, 206);
            this.numericUpDownAlcGrad.Name = "numericUpDownAlcGrad";
            this.numericUpDownAlcGrad.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownAlcGrad.TabIndex = 18;
            this.numericUpDownAlcGrad.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Jam:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Shell:";
            this.label7.Visible = false;
            // 
            // textBoxShell
            // 
            this.textBoxShell.Enabled = false;
            this.textBoxShell.Location = new System.Drawing.Point(51, 235);
            this.textBoxShell.Name = "textBoxShell";
            this.textBoxShell.Size = new System.Drawing.Size(100, 20);
            this.textBoxShell.TabIndex = 22;
            this.textBoxShell.Visible = false;
            // 
            // textBoxJam
            // 
            this.textBoxJam.Enabled = false;
            this.textBoxJam.Location = new System.Drawing.Point(51, 266);
            this.textBoxJam.Name = "textBoxJam";
            this.textBoxJam.Size = new System.Drawing.Size(100, 20);
            this.textBoxJam.TabIndex = 23;
            this.textBoxJam.Visible = false;
            // 
            // FormAddCandy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 302);
            this.Controls.Add(this.textBoxJam);
            this.Controls.Add(this.textBoxShell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownAlcGrad);
            this.Controls.Add(this.checkBoxCaramel);
            this.Controls.Add(this.checkBoxNuts);
            this.Controls.Add(this.comboBoxChocolateType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.numericUpDownSugar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCandyClass);
            this.Name = "FormAddCandy";
            this.Text = "FormAddCandy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlcGrad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCandyClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxChocolateType;
        private System.Windows.Forms.CheckBox checkBoxNuts;
        private System.Windows.Forms.CheckBox checkBoxCaramel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownAlcGrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxShell;
        private System.Windows.Forms.TextBox textBoxJam;
    }
}