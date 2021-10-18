using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Candies;

namespace T0317
{
    public partial class FormAddCandy : Form
    {
        Form1 parent_form;
        public FormAddCandy(Form1 parent_form)
        {
            InitializeComponent();

            this.parent_form = parent_form;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BaseCandy candy = null;
            int weight = Convert.ToInt32(numericUpDownWeight.Value);
            int sugar = Convert.ToInt32(numericUpDownSugar.Value);
            ChocolateCandy.Chocolate_types type;
            try
            {
                type = (ChocolateCandy.Chocolate_types)Enum.Parse(typeof(ChocolateCandy.Chocolate_types), comboBoxChocolateType.SelectedItem.ToString(), true);
            }
            catch
            {
                type = ChocolateCandy.Chocolate_types.White;
            }
            bool nuts = checkBoxNuts.Checked;
            bool caramel = checkBoxCaramel.Checked;
            int alc_grad = Convert.ToInt32(numericUpDownAlcGrad.Value);
            string shell = textBoxShell.Text, jam = textBoxJam.Text;

            switch ((comboBoxCandyClass.SelectedItem).ToString()) 
            {
                case "Chocolate Candy":
                    candy = new ChocolateCandy(weight, sugar, type, nuts, caramel);
                    break;
                case "Alcohol Candy":
                    candy = new AlcoholCandy(weight, sugar, type, alc_grad);
                    break;
                case "Marmalade Candy":
                    candy = new MarmaladeCandy(weight, sugar, shell, jam);
                    break;
            }

            parent_form.AddCandy(candy);
            this.Close();
        }

        private void CandyClassChanged(object sender, EventArgs e)
        {
            switch ((comboBoxCandyClass.SelectedItem).ToString())
            {
                case "Chocolate Candy":
                    comboBoxChocolateType.Visible = comboBoxChocolateType.Enabled = label4.Visible = true;
                    checkBoxCaramel.Visible = checkBoxCaramel.Enabled = true;
                    checkBoxNuts.Visible = checkBoxNuts.Enabled = true;
                    numericUpDownAlcGrad.Visible = numericUpDownAlcGrad.Enabled = label5.Visible = false;
                    textBoxShell.Visible = textBoxShell.Enabled = label7.Visible = false;
                    textBoxJam.Visible = textBoxJam.Enabled = label6.Visible = false;
                    break;
                case "Alcohol Candy":
                    comboBoxChocolateType.Visible = comboBoxChocolateType.Enabled = label4.Visible = true;
                    checkBoxCaramel.Visible = checkBoxCaramel.Enabled = false;
                    checkBoxNuts.Visible = checkBoxNuts.Enabled = false;
                    numericUpDownAlcGrad.Visible = numericUpDownAlcGrad.Enabled = label5.Visible = true;
                    textBoxShell.Visible = textBoxShell.Enabled = label7.Visible = false;
                    textBoxJam.Visible = textBoxJam.Enabled = label6.Visible = false;
                    break;
                case "Marmalade Candy":
                    comboBoxChocolateType.Visible = comboBoxChocolateType.Enabled = label4.Visible = false;
                    checkBoxCaramel.Visible = checkBoxCaramel.Enabled = false;
                    checkBoxNuts.Visible = checkBoxNuts.Enabled = false;
                    numericUpDownAlcGrad.Visible = numericUpDownAlcGrad.Enabled = label5.Visible = false;
                    textBoxShell.Visible = textBoxShell.Enabled = label7.Visible = true;
                    textBoxJam.Visible = textBoxJam.Enabled = label6.Visible = true;
                    break;
            }
        }

    }
}
