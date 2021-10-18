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
    public partial class Form1 : Form
    {
        private List<CandyState> candies_to_view = new List<CandyState>();
        private List<BaseCandy> candies = new List<BaseCandy>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCandy_Click(object sender, EventArgs e)
        {
            new FormAddCandy(this).ShowDialog();
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            this.candies.Clear();
            foreach (CandyState cs in this.candies_to_view)
            {
                cs.Visible = false;
            }
            this.candies_to_view.Clear();
            change_v_scroller();
        }
        private void vScroll_Value_Changed(object sender, EventArgs e)
        {
            for (int i = 0; i < this.candies_to_view.Count; i++)
            {
                CandyState cs = this.candies_to_view[i];
                cs.Location = new Point(5, 20 + 60 * i - vScrollBar1.Value);
            }
        }
        private void update_candies_list_filters(object sender, EventArgs e)
        {
            foreach (CandyState cs in this.candies_to_view)
            {
                cs.Visible = false;
            }
            this.candies_to_view.Clear();

            foreach (BaseCandy candy in this.candies)
            {
                int index = position_in_statelist(candy);
                if (index >= 0)
                {
                    
                    this.candies_to_view.Insert(index, new CandyState(candy, this));
                    
                    for (int i = index; i < this.candies_to_view.Count; i++)
                    {
                        CandyState cs = this.candies_to_view[i];
                        cs.Location = new Point(5, 20 + 60 * i - vScrollBar1.Value);
                    }
                    change_v_scroller();
                }
            }
        }

        private void removeCandy(CandyState state)
        {
            this.candies_to_view.Remove(state);
            this.candies.Remove(state.candy);
            state.Visible = false;
            for (int i = 0; i < this.candies_to_view.Count; i++)
            {
                CandyState cs = this.candies_to_view[i];
                cs.Location = new Point(5, 20 + 60 * i - vScrollBar1.Value);
            }
            change_v_scroller();
        }

        public void AddCandy(BaseCandy candy)
        {
            this.candies.Add(candy);
            int index = position_in_statelist(candy);
            if (index >= 0)
            {
                this.candies_to_view.Insert(index, new CandyState(candy, this));
                for (int i = index; i < this.candies_to_view.Count; i++)
                {
                    CandyState cs = this.candies_to_view[i];
                    cs.Location = new Point(5, 20 + 60 * i - vScrollBar1.Value);
                }
                change_v_scroller();
            }
        }

        private int position_in_statelist(BaseCandy candy) {
            //if returns -1, then been refused.
            if (candy is ChocolateCandy && !(candy is AlcoholCandy) && !checkBoxChocolate.Checked)
                return -1;
            else if (candy is AlcoholCandy && !checkBoxAlchohol.Checked)
                return -1;
            else if (candy is MarmaladeCandy && !checkBoxMarmalade.Checked)
                return -1;

            if (candy.Sugar_percentage > Convert.ToInt32(numericUpDownSugarMax.Value) ||
               candy.Sugar_percentage < Convert.ToInt32(numericUpDownSugarMin.Value) ||
               candy.Weight_in_gramms > Convert.ToInt32(numericUpDownWeightMax.Value) ||
               candy.Weight_in_gramms < Convert.ToInt32(numericUpDownWeightMin.Value))
                return -1;

            if ("no order".Equals(comboBoxOrdering.Text))
                return 0;

            int i = 0;
            foreach (CandyState cs in this.candies_to_view)
            {
                if ("sugar ascending".Equals(comboBoxOrdering.Text) && candy.Sugar_percentage <= cs.candy.Sugar_percentage ||
                    "sugar descending".Equals(comboBoxOrdering.Text) && candy.Sugar_percentage >= cs.candy.Sugar_percentage ||
                    "weight ascending".Equals(comboBoxOrdering.Text) && candy.Weight_in_gramms <= cs.candy.Weight_in_gramms ||
                    "weight descending".Equals(comboBoxOrdering.Text) && candy.Weight_in_gramms >= cs.candy.Weight_in_gramms
                    )
                    break;
                i++;
            }
            return i;
        }

        private void change_v_scroller()
        {
            this.vScrollBar1.Minimum = 0;
            if (this.candies_to_view.Count <= 5)
            {
                this.vScrollBar1.Value = 0;
                this.vScrollBar1.Maximum = 0;
            }
            else
            {
                int max = (this.candies_to_view.Count - 5) * 60;
                if(this.vScrollBar1.Value > max)
                    this.vScrollBar1.Value = max;
                this.vScrollBar1.Maximum = max;
            }
                
        }
        

        private class CandyState: Panel
        {
            internal BaseCandy candy;
            private Label desc_label = new Label();
            private Button removeButton = new Button();
            private Form1 parent_form;

            private void removeButton_Click(object sender, EventArgs e) {
                this.parent_form.removeCandy(this);
            }

            public CandyState(BaseCandy candy, Form1 parent_form)
            {
                this.candy = candy;
                this.parent_form = parent_form;
                string description = "Unkown Candy.";
                if (candy is ChocolateCandy) 
                {
                    description = string.Format(" Chocolate: Weight-{0}, Sugar-{1},\n Type-{2}, Nuts-{3}, Caramel-{4}.",
                                         candy.Weight_in_gramms, candy.Sugar_percentage, ((ChocolateCandy)candy).Chocolate_type,
                                         ((ChocolateCandy)candy).Has_nuts, ((ChocolateCandy)candy).Has_caramel);
                }
                if (candy is AlcoholCandy)
                {
                    description = string.Format(" Alcohol: Weight-{0}, Sugar-{1},\n Type-{2}, Alc grad-{3}.",
                                         candy.Weight_in_gramms, candy.Sugar_percentage, ((AlcoholCandy)candy).Chocolate_type,
                                         ((AlcoholCandy)candy).Alc_grad);
                }
                if (candy is MarmaladeCandy)
                {
                    description = string.Format(" Marmalade: Weight-{0}, Sugar-{1},\n Shell-{2}, Jam-{3}.",
                                            candy.Weight_in_gramms, candy.Sugar_percentage, ((MarmaladeCandy)candy).Shell,
                                         ((MarmaladeCandy)candy).Jam);
                }

                this.desc_label.AutoSize = true;
                this.desc_label.Text = description;
                this.Controls.Add(this.desc_label);

                this.removeButton.AutoSize = true;
                this.removeButton.Text = "Remove.";
                this.removeButton.Click += new EventHandler(this.removeButton_Click);
                this.removeButton.Location = new Point(0, 30);
                this.Controls.Add(this.removeButton);
               

                parent_form.groupBox1.Controls.Add(this);
                this.Size = new Size(250, 60);


            }
        }

        
    }
}
