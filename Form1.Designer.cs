namespace security_lab2
{
    partial class Form1
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
            p = new Label();
            lat_CAP = new CheckBox();
            generation = new Button();
            v = new Label();
            t = new Label();
            s = new Label();
            a = new Label();
            l = new Label();
            p_print = new TextBox();
            v_print = new TextBox();
            t_print = new TextBox();
            password = new Label();
            password_print = new TextBox();
            s_print = new Label();
            a_print = new Label();
            l_print = new Label();
            lat_small = new CheckBox();
            rus_CAP = new CheckBox();
            rus_small = new CheckBox();
            symbols = new CheckBox();
            numbers = new CheckBox();
            SuspendLayout();
            // 
            // p
            // 
            p.AutoSize = true;
            p.Location = new Point(35, 41);
            p.Name = "p";
            p.Size = new Size(118, 20);
            p.TabIndex = 0;
            p.Text = "P (вероятность)";
            // 
            // lat_CAP
            // 
            lat_CAP.AutoSize = true;
            lat_CAP.Location = new Point(501, 41);
            lat_CAP.Margin = new Padding(3, 4, 3, 4);
            lat_CAP.Name = "lat_CAP";
            lat_CAP.Size = new Size(193, 24);
            lat_CAP.TabIndex = 5;
            lat_CAP.Text = "Латинские ЗАГЛАВНЫЕ";
            lat_CAP.UseVisualStyleBackColor = true;
            // 
            // generation
            // 
            generation.Location = new Point(35, 461);
            generation.Margin = new Padding(3, 4, 3, 4);
            generation.Name = "generation";
            generation.Size = new Size(185, 49);
            generation.TabIndex = 11;
            generation.Text = "Генерировать пароль";
            generation.UseVisualStyleBackColor = true;
            generation.Click += generation_Click;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(35, 79);
            v.Name = "v";
            v.Size = new Size(240, 20);
            v.TabIndex = 0;
            v.Text = "V (скорость перебора в минутах)";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(35, 119);
            t.Name = "t";
            t.Size = new Size(233, 20);
            t.TabIndex = 0;
            t.Text = "T (срок действия пароля в днях)";
            // 
            // s
            // 
            s.AutoSize = true;
            s.Location = new Point(35, 213);
            s.Name = "s";
            s.Size = new Size(217, 20);
            s.TabIndex = 0;
            s.Text = "S* (нижняя граница паролей)";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(35, 254);
            a.Name = "a";
            a.Size = new Size(173, 20);
            a.TabIndex = 0;
            a.Text = "A (мощность алфавита)";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(35, 297);
            l.Name = "l";
            l.Size = new Size(127, 20);
            l.TabIndex = 0;
            l.Text = "L (длина пароля)";
            // 
            // p_print
            // 
            p_print.Location = new Point(297, 38);
            p_print.Margin = new Padding(3, 4, 3, 4);
            p_print.Name = "p_print";
            p_print.Size = new Size(114, 27);
            p_print.TabIndex = 1;
            p_print.TextChanged += p_print_TextChanged;
            p_print.KeyPress += p_print_KeyPress;
            // 
            // v_print
            // 
            v_print.Location = new Point(297, 77);
            v_print.Margin = new Padding(3, 4, 3, 4);
            v_print.Name = "v_print";
            v_print.Size = new Size(114, 27);
            v_print.TabIndex = 2;
            v_print.TextChanged += v_print_TextChanged;
            v_print.KeyPress += v_print_KeyPress;
            // 
            // t_print
            // 
            t_print.Location = new Point(297, 117);
            t_print.Margin = new Padding(3, 4, 3, 4);
            t_print.Name = "t_print";
            t_print.Size = new Size(114, 27);
            t_print.TabIndex = 3;
            t_print.TextChanged += t_print_TextChanged;
            t_print.KeyPress += t_print_KeyPress;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(35, 407);
            password.Name = "password";
            password.Size = new Size(62, 20);
            password.TabIndex = 0;
            password.Text = "Пароль";
            // 
            // password_print
            // 
            password_print.Location = new Point(134, 403);
            password_print.Margin = new Padding(3, 4, 3, 4);
            password_print.Name = "password_print";
            password_print.Size = new Size(121, 27);
            password_print.TabIndex = 15;
            // 
            // s_print
            // 
            s_print.AutoSize = true;
            s_print.Location = new Point(297, 213);
            s_print.Name = "s_print";
            s_print.Size = new Size(17, 20);
            s_print.TabIndex = 0;
            s_print.Text = "0";
            // 
            // a_print
            // 
            a_print.AutoSize = true;
            a_print.Location = new Point(297, 254);
            a_print.Name = "a_print";
            a_print.Size = new Size(17, 20);
            a_print.TabIndex = 0;
            a_print.Text = "0";
            // 
            // l_print
            // 
            l_print.AutoSize = true;
            l_print.Location = new Point(297, 297);
            l_print.Name = "l_print";
            l_print.Size = new Size(17, 20);
            l_print.TabIndex = 0;
            l_print.Text = "0";
            // 
            // lat_small
            // 
            lat_small.AutoSize = true;
            lat_small.Location = new Point(501, 75);
            lat_small.Margin = new Padding(3, 4, 3, 4);
            lat_small.Name = "lat_small";
            lat_small.Size = new Size(175, 24);
            lat_small.TabIndex = 6;
            lat_small.Text = "Латинские строчные";
            lat_small.UseVisualStyleBackColor = true;
            // 
            // rus_CAP
            // 
            rus_CAP.AutoSize = true;
            rus_CAP.Location = new Point(501, 108);
            rus_CAP.Margin = new Padding(3, 4, 3, 4);
            rus_CAP.Name = "rus_CAP";
            rus_CAP.Size = new Size(173, 24);
            rus_CAP.TabIndex = 7;
            rus_CAP.Text = "Русские ЗАГЛАВНЫЕ";
            rus_CAP.UseVisualStyleBackColor = true;
            // 
            // rus_small
            // 
            rus_small.AutoSize = true;
            rus_small.Location = new Point(501, 141);
            rus_small.Margin = new Padding(3, 4, 3, 4);
            rus_small.Name = "rus_small";
            rus_small.Size = new Size(155, 24);
            rus_small.TabIndex = 8;
            rus_small.Text = "Русские строчные";
            rus_small.UseVisualStyleBackColor = true;
            // 
            // symbols
            // 
            symbols.AutoSize = true;
            symbols.Location = new Point(501, 175);
            symbols.Margin = new Padding(3, 4, 3, 4);
            symbols.Name = "symbols";
            symbols.Size = new Size(96, 24);
            symbols.TabIndex = 9;
            symbols.Text = "Символы";
            symbols.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            numbers.AutoSize = true;
            numbers.Location = new Point(501, 208);
            numbers.Margin = new Padding(3, 4, 3, 4);
            numbers.Name = "numbers";
            numbers.Size = new Size(81, 24);
            numbers.TabIndex = 10;
            numbers.Text = "Цифры";
            numbers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 548);
            Controls.Add(s_print);
            Controls.Add(a_print);
            Controls.Add(l_print);
            Controls.Add(generation);
            Controls.Add(numbers);
            Controls.Add(symbols);
            Controls.Add(rus_small);
            Controls.Add(rus_CAP);
            Controls.Add(lat_small);
            Controls.Add(lat_CAP);
            Controls.Add(password_print);
            Controls.Add(t_print);
            Controls.Add(v_print);
            Controls.Add(p_print);
            Controls.Add(password);
            Controls.Add(l);
            Controls.Add(a);
            Controls.Add(s);
            Controls.Add(t);
            Controls.Add(v);
            Controls.Add(p);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Генератор паролей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label p;
        private CheckBox lat_CAP;
        private Button generation;
        private Label v;
        private Label t;
        private Label s;
        private Label a;
        private Label l;
        private TextBox p_print;
        private TextBox v_print;
        private TextBox t_print;
        private Label password;
        private TextBox password_print;
        private Label s_print;
        private Label a_print;
        private Label l_print;
        private CheckBox lat_small;
        private CheckBox rus_CAP;
        private CheckBox rus_small;
        private CheckBox symbols;
        private CheckBox numbers;
    }
}