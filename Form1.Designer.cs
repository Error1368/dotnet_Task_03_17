
namespace T0317
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.buttonAddCandy = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxMarmalade = new System.Windows.Forms.CheckBox();
            this.checkBoxAlchohol = new System.Windows.Forms.CheckBox();
            this.checkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeightMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeightMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSugarMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSugarMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSugar = new System.Windows.Forms.Label();
            this.comboBoxOrdering = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugarMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugarMin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.groupBox1.Location = new System.Drawing.Point(253, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candies List";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(280, 3);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 425);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScroll_Value_Changed);
            // 
            // buttonAddCandy
            // 
            this.buttonAddCandy.Location = new System.Drawing.Point(13, 13);
            this.buttonAddCandy.Name = "buttonAddCandy";
            this.buttonAddCandy.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCandy.TabIndex = 1;
            this.buttonAddCandy.Text = "Add Candy";
            this.buttonAddCandy.UseVisualStyleBackColor = true;
            this.buttonAddCandy.Click += new System.EventHandler(this.buttonAddCandy_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(95, 13);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(75, 23);
            this.buttonClearList.TabIndex = 2;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxMarmalade);
            this.groupBox2.Controls.Add(this.checkBoxAlchohol);
            this.groupBox2.Controls.Add(this.checkBoxChocolate);
            this.groupBox2.Controls.Add(this.numericUpDownWeightMax);
            this.groupBox2.Controls.Add(this.numericUpDownWeightMin);
            this.groupBox2.Controls.Add(this.numericUpDownSugarMax);
            this.groupBox2.Controls.Add(this.numericUpDownSugarMin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelWeight);
            this.groupBox2.Controls.Add(this.labelSugar);
            this.groupBox2.Controls.Add(this.comboBoxOrdering);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.groupBox2.Location = new System.Drawing.Point(13, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 395);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // checkBoxMarmalade
            // 
            this.checkBoxMarmalade.AutoSize = true;
            this.checkBoxMarmalade.Checked = true;
            this.checkBoxMarmalade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMarmalade.Location = new System.Drawing.Point(10, 215);
            this.checkBoxMarmalade.Name = "checkBoxMarmalade";
            this.checkBoxMarmalade.Size = new System.Drawing.Size(124, 19);
            this.checkBoxMarmalade.TabIndex = 13;
            this.checkBoxMarmalade.Text = "Show Marmalade";
            this.checkBoxMarmalade.UseVisualStyleBackColor = true;
            this.checkBoxMarmalade.CheckedChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // checkBoxAlchohol
            // 
            this.checkBoxAlchohol.AutoSize = true;
            this.checkBoxAlchohol.Checked = true;
            this.checkBoxAlchohol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlchohol.Location = new System.Drawing.Point(10, 189);
            this.checkBoxAlchohol.Name = "checkBoxAlchohol";
            this.checkBoxAlchohol.Size = new System.Drawing.Size(100, 19);
            this.checkBoxAlchohol.TabIndex = 12;
            this.checkBoxAlchohol.Text = "Show Alcohol";
            this.checkBoxAlchohol.UseVisualStyleBackColor = true;
            this.checkBoxAlchohol.CheckedChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // checkBoxChocolate
            // 
            this.checkBoxChocolate.AutoSize = true;
            this.checkBoxChocolate.Checked = true;
            this.checkBoxChocolate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxChocolate.Location = new System.Drawing.Point(10, 163);
            this.checkBoxChocolate.Name = "checkBoxChocolate";
            this.checkBoxChocolate.Size = new System.Drawing.Size(115, 19);
            this.checkBoxChocolate.TabIndex = 11;
            this.checkBoxChocolate.Text = "Show Chocolate";
            this.checkBoxChocolate.UseVisualStyleBackColor = true;
            this.checkBoxChocolate.CheckedChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // numericUpDownWeightMax
            // 
            this.numericUpDownWeightMax.Location = new System.Drawing.Point(170, 126);
            this.numericUpDownWeightMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeightMax.Name = "numericUpDownWeightMax";
            this.numericUpDownWeightMax.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownWeightMax.TabIndex = 10;
            this.numericUpDownWeightMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeightMax.ValueChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // numericUpDownWeightMin
            // 
            this.numericUpDownWeightMin.Location = new System.Drawing.Point(82, 126);
            this.numericUpDownWeightMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeightMin.Name = "numericUpDownWeightMin";
            this.numericUpDownWeightMin.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownWeightMin.TabIndex = 9;
            this.numericUpDownWeightMin.ValueChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // numericUpDownSugarMax
            // 
            this.numericUpDownSugarMax.Location = new System.Drawing.Point(170, 100);
            this.numericUpDownSugarMax.Name = "numericUpDownSugarMax";
            this.numericUpDownSugarMax.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownSugarMax.TabIndex = 8;
            this.numericUpDownSugarMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSugarMax.ValueChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // numericUpDownSugarMin
            // 
            this.numericUpDownSugarMin.Location = new System.Drawing.Point(82, 100);
            this.numericUpDownSugarMin.Name = "numericUpDownSugarMin";
            this.numericUpDownSugarMin.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownSugarMin.TabIndex = 7;
            this.numericUpDownSugarMin.ValueChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "weight  min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "  sugar  min";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(7, 74);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(46, 15);
            this.labelWeight.TabIndex = 4;
            this.labelWeight.Text = "weight:";
            // 
            // labelSugar
            // 
            this.labelSugar.AutoSize = true;
            this.labelSugar.Location = new System.Drawing.Point(7, 50);
            this.labelSugar.Name = "labelSugar";
            this.labelSugar.Size = new System.Drawing.Size(41, 15);
            this.labelSugar.TabIndex = 3;
            this.labelSugar.Text = "sugar:";
            // 
            // comboBoxOrdering
            // 
            this.comboBoxOrdering.FormattingEnabled = true;
            this.comboBoxOrdering.Items.AddRange(new object[] {
            "no order",
            "sugar ascending",
            "sugar descending",
            "weight ascending",
            "weight descending"});
            this.comboBoxOrdering.Location = new System.Drawing.Point(72, 20);
            this.comboBoxOrdering.Name = "comboBoxOrdering";
            this.comboBoxOrdering.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdering.TabIndex = 1;
            this.comboBoxOrdering.Text = "no order";
            this.comboBoxOrdering.TextChanged += new System.EventHandler(this.update_candies_list_filters);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordering:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.buttonAddCandy);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeightMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugarMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugarMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button buttonAddCandy;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxOrdering;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWeightMax;
        private System.Windows.Forms.NumericUpDown numericUpDownWeightMin;
        private System.Windows.Forms.NumericUpDown numericUpDownSugarMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSugarMin;
        private System.Windows.Forms.CheckBox checkBoxMarmalade;
        private System.Windows.Forms.CheckBox checkBoxAlchohol;
        private System.Windows.Forms.CheckBox checkBoxChocolate;
    }
}

