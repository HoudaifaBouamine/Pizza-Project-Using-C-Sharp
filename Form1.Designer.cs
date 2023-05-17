namespace Win_Pizza
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
            this.lab_main_title = new System.Windows.Forms.Label();
            this.grp_size = new System.Windows.Forms.GroupBox();
            this.rb_size_large = new System.Windows.Forms.RadioButton();
            this.rb_size_medium = new System.Windows.Forms.RadioButton();
            this.rb_size_small = new System.Windows.Forms.RadioButton();
            this.chk_toppings_extra_chees = new System.Windows.Forms.CheckBox();
            this.chk_toppings_tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_toppings_mushrooms = new System.Windows.Forms.CheckBox();
            this.chk_toppings_olives = new System.Windows.Forms.CheckBox();
            this.chk_toppings_green_pappers = new System.Windows.Forms.CheckBox();
            this.chk_toppings_onion = new System.Windows.Forms.CheckBox();
            this.grp_toppings = new System.Windows.Forms.GroupBox();
            this.grp_crust_type = new System.Windows.Forms.GroupBox();
            this.rb_crust_think = new System.Windows.Forms.RadioButton();
            this.rb_crust_thin = new System.Windows.Forms.RadioButton();
            this.grp_where_to_eat = new System.Windows.Forms.GroupBox();
            this.rb_where_to_eat_out = new System.Windows.Forms.RadioButton();
            this.rb_where_to_eat_in = new System.Windows.Forms.RadioButton();
            this.grp_order_summary = new System.Windows.Forms.GroupBox();
            this.txt_summary_toppings = new System.Windows.Forms.TextBox();
            this.lab_summary_total_price = new System.Windows.Forms.Label();
            this.lab_summary_where_to_eat = new System.Windows.Forms.Label();
            this.lab_summary_crust_type = new System.Windows.Forms.Label();
            this.lab_summary_size = new System.Windows.Forms.Label();
            this.lab_summay_title_total_price = new System.Windows.Forms.Label();
            this.lab_summay_title_where_to_eat = new System.Windows.Forms.Label();
            this.lab_summay_title_crust_type = new System.Windows.Forms.Label();
            this.lab_summary_title_toppings = new System.Windows.Forms.Label();
            this.lab_summary_title_size = new System.Windows.Forms.Label();
            this.btn_order_pizza = new System.Windows.Forms.Button();
            this.btn_reset_form = new System.Windows.Forms.Button();
            this.grp_size.SuspendLayout();
            this.grp_toppings.SuspendLayout();
            this.grp_crust_type.SuspendLayout();
            this.grp_where_to_eat.SuspendLayout();
            this.grp_order_summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_main_title
            // 
            this.lab_main_title.AutoSize = true;
            this.lab_main_title.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_main_title.ForeColor = System.Drawing.Color.Red;
            this.lab_main_title.Location = new System.Drawing.Point(298, 9);
            this.lab_main_title.Name = "lab_main_title";
            this.lab_main_title.Size = new System.Drawing.Size(560, 97);
            this.lab_main_title.TabIndex = 0;
            this.lab_main_title.Text = "Make Your Pizza";
            // 
            // grp_size
            // 
            this.grp_size.Controls.Add(this.rb_size_large);
            this.grp_size.Controls.Add(this.rb_size_medium);
            this.grp_size.Controls.Add(this.rb_size_small);
            this.grp_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_size.Location = new System.Drawing.Point(46, 117);
            this.grp_size.Name = "grp_size";
            this.grp_size.Size = new System.Drawing.Size(251, 266);
            this.grp_size.TabIndex = 1;
            this.grp_size.TabStop = false;
            this.grp_size.Text = "Size";
            // 
            // rb_size_large
            // 
            this.rb_size_large.AutoSize = true;
            this.rb_size_large.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_size_large.Location = new System.Drawing.Point(28, 201);
            this.rb_size_large.Name = "rb_size_large";
            this.rb_size_large.Size = new System.Drawing.Size(108, 36);
            this.rb_size_large.TabIndex = 5;
            this.rb_size_large.Text = "Large";
            this.rb_size_large.UseVisualStyleBackColor = true;
            this.rb_size_large.CheckedChanged += new System.EventHandler(this.rb_size_large_CheckedChanged);
            // 
            // rb_size_medium
            // 
            this.rb_size_medium.AutoSize = true;
            this.rb_size_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_size_medium.Location = new System.Drawing.Point(28, 126);
            this.rb_size_medium.Name = "rb_size_medium";
            this.rb_size_medium.Size = new System.Drawing.Size(136, 36);
            this.rb_size_medium.TabIndex = 4;
            this.rb_size_medium.Text = "Medium";
            this.rb_size_medium.UseVisualStyleBackColor = true;
            this.rb_size_medium.CheckedChanged += new System.EventHandler(this.rb_size_medium_CheckedChanged);
            // 
            // rb_size_small
            // 
            this.rb_size_small.AutoSize = true;
            this.rb_size_small.Checked = true;
            this.rb_size_small.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_size_small.Location = new System.Drawing.Point(28, 51);
            this.rb_size_small.Name = "rb_size_small";
            this.rb_size_small.Size = new System.Drawing.Size(107, 36);
            this.rb_size_small.TabIndex = 3;
            this.rb_size_small.TabStop = true;
            this.rb_size_small.Text = "Small";
            this.rb_size_small.UseVisualStyleBackColor = true;
            this.rb_size_small.CheckedChanged += new System.EventHandler(this.rb_size_small_CheckedChanged);
            // 
            // chk_toppings_extra_chees
            // 
            this.chk_toppings_extra_chees.AutoSize = true;
            this.chk_toppings_extra_chees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toppings_extra_chees.Location = new System.Drawing.Point(26, 52);
            this.chk_toppings_extra_chees.Name = "chk_toppings_extra_chees";
            this.chk_toppings_extra_chees.Size = new System.Drawing.Size(191, 36);
            this.chk_toppings_extra_chees.TabIndex = 2;
            this.chk_toppings_extra_chees.Text = "Extra Chees";
            this.chk_toppings_extra_chees.UseVisualStyleBackColor = true;
            this.chk_toppings_extra_chees.CheckedChanged += new System.EventHandler(this.chk_toppings_extra_chees_CheckedChanged);
            // 
            // chk_toppings_tomatoes
            // 
            this.chk_toppings_tomatoes.AutoSize = true;
            this.chk_toppings_tomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toppings_tomatoes.Location = new System.Drawing.Point(26, 201);
            this.chk_toppings_tomatoes.Name = "chk_toppings_tomatoes";
            this.chk_toppings_tomatoes.Size = new System.Drawing.Size(162, 36);
            this.chk_toppings_tomatoes.TabIndex = 3;
            this.chk_toppings_tomatoes.Text = "Tomatoes";
            this.chk_toppings_tomatoes.UseVisualStyleBackColor = true;
            this.chk_toppings_tomatoes.CheckedChanged += new System.EventHandler(this.chk_toppings_tomatoes_CheckedChanged);
            // 
            // chk_toppings_mushrooms
            // 
            this.chk_toppings_mushrooms.AutoSize = true;
            this.chk_toppings_mushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toppings_mushrooms.Location = new System.Drawing.Point(26, 126);
            this.chk_toppings_mushrooms.Name = "chk_toppings_mushrooms";
            this.chk_toppings_mushrooms.Size = new System.Drawing.Size(183, 36);
            this.chk_toppings_mushrooms.TabIndex = 4;
            this.chk_toppings_mushrooms.Text = "Mushrooms";
            this.chk_toppings_mushrooms.UseVisualStyleBackColor = true;
            this.chk_toppings_mushrooms.CheckedChanged += new System.EventHandler(this.chk_toppings_mushrooms_CheckedChanged);
            // 
            // chk_toppings_olives
            // 
            this.chk_toppings_olives.AutoSize = true;
            this.chk_toppings_olives.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toppings_olives.Location = new System.Drawing.Point(230, 126);
            this.chk_toppings_olives.Name = "chk_toppings_olives";
            this.chk_toppings_olives.Size = new System.Drawing.Size(116, 36);
            this.chk_toppings_olives.TabIndex = 7;
            this.chk_toppings_olives.Text = "Olives";
            this.chk_toppings_olives.UseVisualStyleBackColor = true;
            this.chk_toppings_olives.CheckedChanged += new System.EventHandler(this.chk_toppings_olives_CheckedChanged);
            // 
            // chk_toppings_green_pappers
            // 
            this.chk_toppings_green_pappers.AutoSize = true;
            this.chk_toppings_green_pappers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toppings_green_pappers.Location = new System.Drawing.Point(230, 201);
            this.chk_toppings_green_pappers.Name = "chk_toppings_green_pappers";
            this.chk_toppings_green_pappers.Size = new System.Drawing.Size(228, 36);
            this.chk_toppings_green_pappers.TabIndex = 6;
            this.chk_toppings_green_pappers.Text = "Green Pappers";
            this.chk_toppings_green_pappers.UseVisualStyleBackColor = true;
            this.chk_toppings_green_pappers.CheckedChanged += new System.EventHandler(this.chk_toppings_green_pappers_CheckedChanged);
            // 
            // chk_toppings_onion
            // 
            this.chk_toppings_onion.AutoSize = true;
            this.chk_toppings_onion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_toppings_onion.Location = new System.Drawing.Point(230, 52);
            this.chk_toppings_onion.Name = "chk_toppings_onion";
            this.chk_toppings_onion.Size = new System.Drawing.Size(113, 36);
            this.chk_toppings_onion.TabIndex = 5;
            this.chk_toppings_onion.Text = "Onion";
            this.chk_toppings_onion.UseVisualStyleBackColor = true;
            this.chk_toppings_onion.CheckedChanged += new System.EventHandler(this.chk_toppings_onion_CheckedChanged);
            // 
            // grp_toppings
            // 
            this.grp_toppings.Controls.Add(this.chk_toppings_olives);
            this.grp_toppings.Controls.Add(this.chk_toppings_green_pappers);
            this.grp_toppings.Controls.Add(this.chk_toppings_onion);
            this.grp_toppings.Controls.Add(this.chk_toppings_mushrooms);
            this.grp_toppings.Controls.Add(this.chk_toppings_tomatoes);
            this.grp_toppings.Controls.Add(this.chk_toppings_extra_chees);
            this.grp_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grp_toppings.Location = new System.Drawing.Point(333, 117);
            this.grp_toppings.Name = "grp_toppings";
            this.grp_toppings.Size = new System.Drawing.Size(469, 266);
            this.grp_toppings.TabIndex = 8;
            this.grp_toppings.TabStop = false;
            this.grp_toppings.Text = "Toppings";
            // 
            // grp_crust_type
            // 
            this.grp_crust_type.Controls.Add(this.rb_crust_think);
            this.grp_crust_type.Controls.Add(this.rb_crust_thin);
            this.grp_crust_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_crust_type.Location = new System.Drawing.Point(46, 409);
            this.grp_crust_type.Name = "grp_crust_type";
            this.grp_crust_type.Size = new System.Drawing.Size(251, 172);
            this.grp_crust_type.TabIndex = 9;
            this.grp_crust_type.TabStop = false;
            this.grp_crust_type.Text = "Crust Type";
            // 
            // rb_crust_think
            // 
            this.rb_crust_think.AutoSize = true;
            this.rb_crust_think.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_crust_think.Location = new System.Drawing.Point(28, 104);
            this.rb_crust_think.Name = "rb_crust_think";
            this.rb_crust_think.Size = new System.Drawing.Size(179, 36);
            this.rb_crust_think.TabIndex = 4;
            this.rb_crust_think.TabStop = true;
            this.rb_crust_think.Text = "Think Crust";
            this.rb_crust_think.UseVisualStyleBackColor = true;
            this.rb_crust_think.CheckedChanged += new System.EventHandler(this.rb_crust_think_CheckedChanged);
            // 
            // rb_crust_thin
            // 
            this.rb_crust_thin.AutoSize = true;
            this.rb_crust_thin.Checked = true;
            this.rb_crust_thin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_crust_thin.Location = new System.Drawing.Point(28, 52);
            this.rb_crust_thin.Name = "rb_crust_thin";
            this.rb_crust_thin.Size = new System.Drawing.Size(165, 36);
            this.rb_crust_thin.TabIndex = 3;
            this.rb_crust_thin.TabStop = true;
            this.rb_crust_thin.Text = "Thin Crust";
            this.rb_crust_thin.UseVisualStyleBackColor = true;
            this.rb_crust_thin.CheckedChanged += new System.EventHandler(this.rb_crust_thin_CheckedChanged);
            // 
            // grp_where_to_eat
            // 
            this.grp_where_to_eat.Controls.Add(this.rb_where_to_eat_out);
            this.grp_where_to_eat.Controls.Add(this.rb_where_to_eat_in);
            this.grp_where_to_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grp_where_to_eat.Location = new System.Drawing.Point(333, 409);
            this.grp_where_to_eat.Name = "grp_where_to_eat";
            this.grp_where_to_eat.Size = new System.Drawing.Size(469, 116);
            this.grp_where_to_eat.TabIndex = 10;
            this.grp_where_to_eat.TabStop = false;
            this.grp_where_to_eat.Text = "Where To Eat";
            // 
            // rb_where_to_eat_out
            // 
            this.rb_where_to_eat_out.AutoSize = true;
            this.rb_where_to_eat_out.Location = new System.Drawing.Point(230, 53);
            this.rb_where_to_eat_out.Name = "rb_where_to_eat_out";
            this.rb_where_to_eat_out.Size = new System.Drawing.Size(155, 35);
            this.rb_where_to_eat_out.TabIndex = 1;
            this.rb_where_to_eat_out.TabStop = true;
            this.rb_where_to_eat_out.Text = "Take Out";
            this.rb_where_to_eat_out.UseVisualStyleBackColor = true;
            this.rb_where_to_eat_out.CheckedChanged += new System.EventHandler(this.rb_where_to_eat_out_CheckedChanged);
            // 
            // rb_where_to_eat_in
            // 
            this.rb_where_to_eat_in.AutoSize = true;
            this.rb_where_to_eat_in.Checked = true;
            this.rb_where_to_eat_in.Location = new System.Drawing.Point(26, 52);
            this.rb_where_to_eat_in.Name = "rb_where_to_eat_in";
            this.rb_where_to_eat_in.Size = new System.Drawing.Size(112, 35);
            this.rb_where_to_eat_in.TabIndex = 0;
            this.rb_where_to_eat_in.TabStop = true;
            this.rb_where_to_eat_in.Text = "Eat In";
            this.rb_where_to_eat_in.UseVisualStyleBackColor = true;
            this.rb_where_to_eat_in.CheckedChanged += new System.EventHandler(this.rb_where_to_eat_in_CheckedChanged);
            // 
            // grp_order_summary
            // 
            this.grp_order_summary.Controls.Add(this.txt_summary_toppings);
            this.grp_order_summary.Controls.Add(this.lab_summary_total_price);
            this.grp_order_summary.Controls.Add(this.lab_summary_where_to_eat);
            this.grp_order_summary.Controls.Add(this.lab_summary_crust_type);
            this.grp_order_summary.Controls.Add(this.lab_summary_size);
            this.grp_order_summary.Controls.Add(this.lab_summay_title_total_price);
            this.grp_order_summary.Controls.Add(this.lab_summay_title_where_to_eat);
            this.grp_order_summary.Controls.Add(this.lab_summay_title_crust_type);
            this.grp_order_summary.Controls.Add(this.lab_summary_title_toppings);
            this.grp_order_summary.Controls.Add(this.lab_summary_title_size);
            this.grp_order_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_order_summary.Location = new System.Drawing.Point(838, 117);
            this.grp_order_summary.Name = "grp_order_summary";
            this.grp_order_summary.Size = new System.Drawing.Size(330, 505);
            this.grp_order_summary.TabIndex = 12;
            this.grp_order_summary.TabStop = false;
            this.grp_order_summary.Text = "Order Summary";
            // 
            // txt_summary_toppings
            // 
            this.txt_summary_toppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txt_summary_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_summary_toppings.Location = new System.Drawing.Point(43, 129);
            this.txt_summary_toppings.Multiline = true;
            this.txt_summary_toppings.Name = "txt_summary_toppings";
            this.txt_summary_toppings.Size = new System.Drawing.Size(266, 127);
            this.txt_summary_toppings.TabIndex = 10;
            this.txt_summary_toppings.Text = "No Toppings";
            // 
            // lab_summary_total_price
            // 
            this.lab_summary_total_price.AutoSize = true;
            this.lab_summary_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summary_total_price.ForeColor = System.Drawing.Color.ForestGreen;
            this.lab_summary_total_price.Location = new System.Drawing.Point(84, 396);
            this.lab_summary_total_price.Name = "lab_summary_total_price";
            this.lab_summary_total_price.Size = new System.Drawing.Size(192, 91);
            this.lab_summary_total_price.TabIndex = 9;
            this.lab_summary_total_price.Text = "10 $";
            // 
            // lab_summary_where_to_eat
            // 
            this.lab_summary_where_to_eat.AutoSize = true;
            this.lab_summary_where_to_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summary_where_to_eat.Location = new System.Drawing.Point(203, 317);
            this.lab_summary_where_to_eat.Name = "lab_summary_where_to_eat";
            this.lab_summary_where_to_eat.Size = new System.Drawing.Size(73, 29);
            this.lab_summary_where_to_eat.TabIndex = 8;
            this.lab_summary_where_to_eat.Text = "Eat In";
            // 
            // lab_summary_crust_type
            // 
            this.lab_summary_crust_type.AutoSize = true;
            this.lab_summary_crust_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summary_crust_type.Location = new System.Drawing.Point(175, 268);
            this.lab_summary_crust_type.Name = "lab_summary_crust_type";
            this.lab_summary_crust_type.Size = new System.Drawing.Size(123, 29);
            this.lab_summary_crust_type.TabIndex = 7;
            this.lab_summary_crust_type.Text = "Thin Crust";
            // 
            // lab_summary_size
            // 
            this.lab_summary_size.AutoSize = true;
            this.lab_summary_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summary_size.Location = new System.Drawing.Point(95, 51);
            this.lab_summary_size.Name = "lab_summary_size";
            this.lab_summary_size.Size = new System.Drawing.Size(74, 29);
            this.lab_summary_size.TabIndex = 5;
            this.lab_summary_size.Text = "Small";
            // 
            // lab_summay_title_total_price
            // 
            this.lab_summay_title_total_price.AutoSize = true;
            this.lab_summay_title_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summay_title_total_price.Location = new System.Drawing.Point(16, 366);
            this.lab_summay_title_total_price.Name = "lab_summay_title_total_price";
            this.lab_summay_title_total_price.Size = new System.Drawing.Size(162, 29);
            this.lab_summay_title_total_price.TabIndex = 4;
            this.lab_summay_title_total_price.Text = "Total Price : ";
            // 
            // lab_summay_title_where_to_eat
            // 
            this.lab_summay_title_where_to_eat.AutoSize = true;
            this.lab_summay_title_where_to_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summay_title_where_to_eat.Location = new System.Drawing.Point(16, 317);
            this.lab_summay_title_where_to_eat.Name = "lab_summay_title_where_to_eat";
            this.lab_summay_title_where_to_eat.Size = new System.Drawing.Size(194, 29);
            this.lab_summay_title_where_to_eat.TabIndex = 3;
            this.lab_summay_title_where_to_eat.Text = "Where To Eat : ";
            // 
            // lab_summay_title_crust_type
            // 
            this.lab_summay_title_crust_type.AutoSize = true;
            this.lab_summay_title_crust_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summay_title_crust_type.Location = new System.Drawing.Point(15, 268);
            this.lab_summay_title_crust_type.Name = "lab_summay_title_crust_type";
            this.lab_summay_title_crust_type.Size = new System.Drawing.Size(154, 29);
            this.lab_summay_title_crust_type.TabIndex = 2;
            this.lab_summay_title_crust_type.Text = "Crust Type :";
            // 
            // lab_summary_title_toppings
            // 
            this.lab_summary_title_toppings.AutoSize = true;
            this.lab_summary_title_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summary_title_toppings.Location = new System.Drawing.Point(16, 95);
            this.lab_summary_title_toppings.Name = "lab_summary_title_toppings";
            this.lab_summary_title_toppings.Size = new System.Drawing.Size(145, 29);
            this.lab_summary_title_toppings.TabIndex = 1;
            this.lab_summary_title_toppings.Text = "Toppings : ";
            // 
            // lab_summary_title_size
            // 
            this.lab_summary_title_size.AutoSize = true;
            this.lab_summary_title_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_summary_title_size.Location = new System.Drawing.Point(16, 51);
            this.lab_summary_title_size.Name = "lab_summary_title_size";
            this.lab_summary_title_size.Size = new System.Drawing.Size(85, 29);
            this.lab_summary_title_size.TabIndex = 0;
            this.lab_summary_title_size.Text = "Size : ";
            // 
            // btn_order_pizza
            // 
            this.btn_order_pizza.BackColor = System.Drawing.SystemColors.Control;
            this.btn_order_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_pizza.Location = new System.Drawing.Point(333, 557);
            this.btn_order_pizza.Name = "btn_order_pizza";
            this.btn_order_pizza.Size = new System.Drawing.Size(217, 65);
            this.btn_order_pizza.TabIndex = 13;
            this.btn_order_pizza.Text = "Order Pizza";
            this.btn_order_pizza.UseVisualStyleBackColor = false;
            this.btn_order_pizza.Click += new System.EventHandler(this.btn_order_pizza_Click);
            // 
            // btn_reset_form
            // 
            this.btn_reset_form.BackColor = System.Drawing.SystemColors.Control;
            this.btn_reset_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset_form.Location = new System.Drawing.Point(585, 557);
            this.btn_reset_form.Name = "btn_reset_form";
            this.btn_reset_form.Size = new System.Drawing.Size(217, 65);
            this.btn_reset_form.TabIndex = 14;
            this.btn_reset_form.Text = "Reset Form";
            this.btn_reset_form.UseVisualStyleBackColor = false;
            this.btn_reset_form.Click += new System.EventHandler(this.btn_reset_form_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 668);
            this.Controls.Add(this.btn_reset_form);
            this.Controls.Add(this.btn_order_pizza);
            this.Controls.Add(this.grp_order_summary);
            this.Controls.Add(this.grp_where_to_eat);
            this.Controls.Add(this.grp_crust_type);
            this.Controls.Add(this.grp_toppings);
            this.Controls.Add(this.grp_size);
            this.Controls.Add(this.lab_main_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_size.ResumeLayout(false);
            this.grp_size.PerformLayout();
            this.grp_toppings.ResumeLayout(false);
            this.grp_toppings.PerformLayout();
            this.grp_crust_type.ResumeLayout(false);
            this.grp_crust_type.PerformLayout();
            this.grp_where_to_eat.ResumeLayout(false);
            this.grp_where_to_eat.PerformLayout();
            this.grp_order_summary.ResumeLayout(false);
            this.grp_order_summary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_main_title;
        private System.Windows.Forms.GroupBox grp_size;
        private System.Windows.Forms.RadioButton rb_size_large;
        private System.Windows.Forms.RadioButton rb_size_medium;
        private System.Windows.Forms.RadioButton rb_size_small;
        private System.Windows.Forms.CheckBox chk_toppings_extra_chees;
        private System.Windows.Forms.CheckBox chk_toppings_tomatoes;
        private System.Windows.Forms.CheckBox chk_toppings_mushrooms;
        private System.Windows.Forms.CheckBox chk_toppings_olives;
        private System.Windows.Forms.CheckBox chk_toppings_green_pappers;
        private System.Windows.Forms.CheckBox chk_toppings_onion;
        private System.Windows.Forms.GroupBox grp_toppings;
        private System.Windows.Forms.GroupBox grp_crust_type;
        private System.Windows.Forms.RadioButton rb_crust_think;
        private System.Windows.Forms.RadioButton rb_crust_thin;
        private System.Windows.Forms.GroupBox grp_where_to_eat;
        private System.Windows.Forms.RadioButton rb_where_to_eat_out;
        private System.Windows.Forms.RadioButton rb_where_to_eat_in;
        private System.Windows.Forms.GroupBox grp_order_summary;
        private System.Windows.Forms.Label lab_summary_where_to_eat;
        private System.Windows.Forms.Label lab_summary_crust_type;
        private System.Windows.Forms.Label lab_summary_size;
        private System.Windows.Forms.Label lab_summay_title_total_price;
        private System.Windows.Forms.Label lab_summay_title_where_to_eat;
        private System.Windows.Forms.Label lab_summay_title_crust_type;
        private System.Windows.Forms.Label lab_summary_title_toppings;
        private System.Windows.Forms.Label lab_summary_title_size;
        private System.Windows.Forms.Label lab_summary_total_price;
        private System.Windows.Forms.Button btn_order_pizza;
        private System.Windows.Forms.Button btn_reset_form;
        private System.Windows.Forms.TextBox txt_summary_toppings;
    }
}

