using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Pizza
{

    
    public partial class Form1 : Form
    {
        private int size_price = 10;
        private int total_price = 10;
        private void update_price()
        {
            lab_summary_total_price.Text = Convert.ToString(total_price) + " $";
        }
        public Form1()
        {
            InitializeComponent();
        }

        // Size
        private void rb_size_small_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_size_small.Checked )
            {
                lab_summary_size.Text = "Small";
                total_price -= size_price;
                size_price = 10;
                total_price += size_price;
            }

            update_price();
        }

        private void rb_size_medium_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_size_medium.Checked)
            {
                lab_summary_size.Text = "Medium";
                total_price -= size_price;
                size_price = 15;
                total_price += size_price;
            }

            update_price();
        }

        private void rb_size_large_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_size_large.Checked)
            {
                lab_summary_size.Text = "Large";
                total_price -= size_price;
                size_price = 20;
                total_price += size_price;
            }

            update_price();
        }

        // Crust Type
        private void rb_crust_thin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_crust_thin.Checked)
            {
                lab_summary_crust_type.Text = "Thin Crust";
                total_price -= 4;
            }

            update_price();
        }

        private void rb_crust_think_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_crust_think.Checked)
            {
                lab_summary_crust_type.Text = "Think Crust";
                total_price += 4;
            }

            update_price();
        }

        // Toppings

        private void update_toppings_summary()
        {
            string toppings = "";
            int counter = 0;

            if (chk_toppings_extra_chees.Checked)
            {
                if (toppings == "")
                

                    toppings += "Extra Chees";
                
                else
                
                    toppings += ", Extra Chees";
            }

                if (chk_toppings_mushrooms.Checked)
                {
                    if (toppings == "")
                        toppings += "Mushrooms";
                    else
                    {
                        toppings += ", Mushrooms";

                    }

                }

                if (chk_toppings_tomatoes.Checked)
                {
                    if (toppings == "")
                        toppings += "Tomatoes";
                    else
                        toppings += ", Tomatoes";
                }

                if (chk_toppings_onion.Checked)
                {
                    if (toppings == "")
                        toppings += "Onion";
                    else
                        toppings += ", Onion";
                }

                if (chk_toppings_olives.Checked)
                {
                    if (toppings == "")
                        toppings += "Olives";
                    else
                        toppings += ", Olives";
                }

                if (chk_toppings_green_pappers.Checked)
                {
                    if (toppings == "")
                        toppings += "Green Papers";
                    else
                        toppings += ", Green Papers";
                }

            if (toppings != "")
                txt_summary_toppings.Text = toppings;
            else
                txt_summary_toppings.Text = "No Toppings";
        }
        
        private void chk_toppings_extra_chees_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_toppings_extra_chees.Checked)
            {
                total_price += 2;

            }
            else
            {
                total_price -= 2;

            }

            update_toppings_summary();
            update_price();
        }

        private void chk_toppings_mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_toppings_mushrooms.Checked)
            {
                total_price += 3;
            }
            else
            {
                total_price -= 3;
            }

            update_toppings_summary();
            update_price();
        }

        private void chk_toppings_tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_toppings_tomatoes.Checked)
            {
                total_price += 1;
            }
            else
            {
                total_price -= 1;
            }

            update_toppings_summary();
            update_price();
        }

        private void chk_toppings_onion_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_toppings_onion.Checked)
            {
                total_price += 1;
            }
            else
            {
                total_price -= 1;
            }

            update_toppings_summary();
            update_price();
        }

        private void chk_toppings_olives_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_toppings_olives.Checked)
            {
                total_price += 1;
            }
            else
            {
                total_price -= 1;
            }

            update_toppings_summary();
            update_price();
        }

        private void chk_toppings_green_pappers_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_toppings_green_pappers.Checked)
            {
                total_price += 1;
            }
            else
            {
                total_price -= 1;
            }

            update_toppings_summary();
            update_price();
        }

        private void rb_where_to_eat_in_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_where_to_eat_in.Checked)
            {
                lab_summary_where_to_eat.Text = "Eat In";
            }
        }

        private void rb_where_to_eat_out_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_where_to_eat_out.Checked)
            {
                lab_summary_where_to_eat.Text = "Take Out";
            }
        }

        private void btn_order_pizza_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Are You Sure You want to order this PIZZA ?"
                                        , "Order Confermation"
                                        , MessageBoxButtons.YesNo
                                        , MessageBoxIcon.Question);

            if (answer == DialogResult.Yes) {


                grp_crust_type.Enabled = false;
                grp_toppings.Enabled = false;
                grp_where_to_eat.Enabled = false;
                grp_size.Enabled = false;
                btn_order_pizza.Enabled = false;

                MessageBox.Show("Your PIZZA ordered Successfuly"
                                , "Success"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
 
            }
        }

        private void btn_reset_form_Click(object sender, EventArgs e)
        {

            grp_crust_type.Enabled = true;
            grp_toppings.Enabled = true;
            grp_where_to_eat.Enabled = true;
            grp_size.Enabled = true;
            btn_order_pizza.Enabled = true;

            rb_size_small.Checked = true;
            rb_crust_thin.Checked = true;

            chk_toppings_extra_chees.Checked = false;
            chk_toppings_green_pappers.Checked = false;
            chk_toppings_mushrooms.Checked = false;
            chk_toppings_olives.Checked = false;
            chk_toppings_tomatoes.Checked = false;
            chk_toppings_onion.Checked = false;

            rb_where_to_eat_in.Checked = true;
           
        }


    }
}
