
namespace Project_Countries_Frank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.PictureBox();
            this.countries = new System.Windows.Forms.PictureBox();
            this.capitals = new System.Windows.Forms.PictureBox();
            this.flags = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_score = new System.Windows.Forms.PictureBox();
            this.comboBox_playes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_registration = new System.Windows.Forms.PictureBox();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_registration)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(243, 61);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(157, 22);
            this.textBox_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Countries, Capitals and Flags Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Player:";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(243, 563);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(170, 117);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start.TabIndex = 6;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // countries
            // 
            this.countries.BackColor = System.Drawing.Color.Transparent;
            this.countries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countries.Image = ((System.Drawing.Image)(resources.GetObject("countries.Image")));
            this.countries.Location = new System.Drawing.Point(37, 415);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(170, 109);
            this.countries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.countries.TabIndex = 7;
            this.countries.TabStop = false;
            this.countries.Click += new System.EventHandler(this.select_game_form_click);
            // 
            // capitals
            // 
            this.capitals.BackColor = System.Drawing.Color.Transparent;
            this.capitals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capitals.Image = ((System.Drawing.Image)(resources.GetObject("capitals.Image")));
            this.capitals.Location = new System.Drawing.Point(243, 415);
            this.capitals.Name = "capitals";
            this.capitals.Size = new System.Drawing.Size(170, 109);
            this.capitals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capitals.TabIndex = 8;
            this.capitals.TabStop = false;
            this.capitals.Click += new System.EventHandler(this.select_game_form_click);
            // 
            // flags
            // 
            this.flags.BackColor = System.Drawing.Color.Transparent;
            this.flags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flags.Image = ((System.Drawing.Image)(resources.GetObject("flags.Image")));
            this.flags.Location = new System.Drawing.Point(449, 415);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(170, 109);
            this.flags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flags.TabIndex = 9;
            this.flags.TabStop = false;
            this.flags.Click += new System.EventHandler(this.select_game_form_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "COUNTRIES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(284, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "CAPITALS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(505, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "FLAGS";
            // 
            // button_score
            // 
            this.button_score.BackColor = System.Drawing.Color.Transparent;
            this.button_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button_score.Image = ((System.Drawing.Image)(resources.GetObject("button_score.Image")));
            this.button_score.InitialImage = null;
            this.button_score.Location = new System.Drawing.Point(542, 653);
            this.button_score.Name = "button_score";
            this.button_score.Size = new System.Drawing.Size(100, 76);
            this.button_score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_score.TabIndex = 13;
            this.button_score.TabStop = false;
            this.button_score.Click += new System.EventHandler(this.score_Click);
            // 
            // comboBox_playes
            // 
            this.comboBox_playes.FormattingEnabled = true;
            this.comboBox_playes.Location = new System.Drawing.Point(243, 187);
            this.comboBox_playes.Name = "comboBox_playes";
            this.comboBox_playes.Size = new System.Drawing.Size(157, 24);
            this.comboBox_playes.TabIndex = 15;
            this.comboBox_playes.SelectedValueChanged += new System.EventHandler(this.comboBox_playes_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Select Player:";
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.Transparent;
            this.button_registration.Image = ((System.Drawing.Image)(resources.GetObject("button_registration.Image")));
            this.button_registration.InitialImage = null;
            this.button_registration.Location = new System.Drawing.Point(263, 98);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(111, 34);
            this.button_registration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_registration.TabIndex = 17;
            this.button_registration.TabStop = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(270, 296);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(104, 24);
            this.label_Welcome.TabIndex = 18;
            this.label_Welcome.Text = "Welcome!";
            this.label_Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(89, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(474, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Please select what kind of Quiz you want to make.";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(268, 247);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 36);
            this.label_name.TabIndex = 20;
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 741);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_playes);
            this.Controls.Add(this.button_score);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flags);
            this.Controls.Add(this.capitals);
            this.Controls.Add(this.countries);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_registration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox countries;
        private System.Windows.Forms.PictureBox capitals;
        private System.Windows.Forms.PictureBox flags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox button_score;
        private System.Windows.Forms.ComboBox comboBox_playes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox button_registration;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_name;
    }
}

