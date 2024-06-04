namespace diplom_begin
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.north = new System.Windows.Forms.Button();
            this.south = new System.Windows.Forms.Button();
            this.east = new System.Windows.Forms.Button();
            this.west = new System.Windows.Forms.Button();
            this.northeast = new System.Windows.Forms.Button();
            this.northwest = new System.Windows.Forms.Button();
            this.southwest = new System.Windows.Forms.Button();
            this.southeast = new System.Windows.Forms.Button();
            this.calm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.safeWind = new System.Windows.Forms.TextBox();
            this.normalWind = new System.Windows.Forms.TextBox();
            this.dangerWind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(43, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1085, 675);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1159, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(0, 1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 17;
            this.button12.Text = "открыть";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1156, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Осадка, м";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(1225, 207);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 22);
            this.textBox2.TabIndex = 21;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1222, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1156, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Погодные зоны:";
            this.label4.Visible = false;
            // 
            // north
            // 
            this.north.Location = new System.Drawing.Point(1225, 90);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(60, 30);
            this.north.TabIndex = 31;
            this.north.Text = "🡹";
            this.north.UseVisualStyleBackColor = true;
            this.north.Click += new System.EventHandler(this.north_Click);
            // 
            // south
            // 
            this.south.Location = new System.Drawing.Point(1225, 162);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(60, 30);
            this.south.TabIndex = 32;
            this.south.Text = "🡻";
            this.south.UseVisualStyleBackColor = true;
            this.south.Click += new System.EventHandler(this.south_Click);
            // 
            // east
            // 
            this.east.Location = new System.Drawing.Point(1291, 126);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(60, 30);
            this.east.TabIndex = 33;
            this.east.Text = "🡺";
            this.east.UseVisualStyleBackColor = true;
            this.east.Click += new System.EventHandler(this.east_Click);
            // 
            // west
            // 
            this.west.Location = new System.Drawing.Point(1159, 126);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(60, 30);
            this.west.TabIndex = 34;
            this.west.Text = "\t🡸";
            this.west.UseVisualStyleBackColor = true;
            this.west.Click += new System.EventHandler(this.west_Click);
            // 
            // northeast
            // 
            this.northeast.Location = new System.Drawing.Point(1291, 90);
            this.northeast.Name = "northeast";
            this.northeast.Size = new System.Drawing.Size(60, 30);
            this.northeast.TabIndex = 35;
            this.northeast.Text = "🡽";
            this.northeast.UseVisualStyleBackColor = true;
            this.northeast.Click += new System.EventHandler(this.northeast_Click);
            // 
            // northwest
            // 
            this.northwest.Location = new System.Drawing.Point(1159, 90);
            this.northwest.Name = "northwest";
            this.northwest.Size = new System.Drawing.Size(60, 30);
            this.northwest.TabIndex = 36;
            this.northwest.Text = "🡼";
            this.northwest.UseVisualStyleBackColor = true;
            this.northwest.Click += new System.EventHandler(this.northwest_Click);
            // 
            // southwest
            // 
            this.southwest.Location = new System.Drawing.Point(1159, 162);
            this.southwest.Name = "southwest";
            this.southwest.Size = new System.Drawing.Size(60, 30);
            this.southwest.TabIndex = 37;
            this.southwest.Text = "🡿";
            this.southwest.UseVisualStyleBackColor = true;
            this.southwest.Click += new System.EventHandler(this.southwest_Click);
            // 
            // southeast
            // 
            this.southeast.Location = new System.Drawing.Point(1291, 162);
            this.southeast.Name = "southeast";
            this.southeast.Size = new System.Drawing.Size(60, 30);
            this.southeast.TabIndex = 38;
            this.southeast.Text = "🡾";
            this.southeast.UseVisualStyleBackColor = true;
            this.southeast.Click += new System.EventHandler(this.southeast_Click);
            // 
            // calm
            // 
            this.calm.Location = new System.Drawing.Point(1225, 126);
            this.calm.Name = "calm";
            this.calm.Size = new System.Drawing.Size(60, 30);
            this.calm.TabIndex = 39;
            this.calm.Text = "🢝";
            this.calm.UseVisualStyleBackColor = true;
            this.calm.Click += new System.EventHandler(this.calm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1156, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Направление ветра:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1156, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Зона средней опасности";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1156, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Безопасная зона";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1156, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Опасная зона";
            // 
            // safeWind
            // 
            this.safeWind.Location = new System.Drawing.Point(1159, 302);
            this.safeWind.Name = "safeWind";
            this.safeWind.Size = new System.Drawing.Size(100, 22);
            this.safeWind.TabIndex = 44;
            this.safeWind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.safeWind_KeyDown);
            this.safeWind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.safeWind_KeyPress);
            // 
            // normalWind
            // 
            this.normalWind.Location = new System.Drawing.Point(1159, 372);
            this.normalWind.Name = "normalWind";
            this.normalWind.Size = new System.Drawing.Size(100, 22);
            this.normalWind.TabIndex = 45;
            this.normalWind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.normalWind_KeyDown);
            this.normalWind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.normalWind_KeyPress);
            // 
            // dangerWind
            // 
            this.dangerWind.Location = new System.Drawing.Point(1159, 452);
            this.dangerWind.Name = "dangerWind";
            this.dangerWind.Size = new System.Drawing.Size(100, 22);
            this.dangerWind.TabIndex = 46;
            this.dangerWind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dangerWind_KeyDown);
            this.dangerWind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dangerWind_KeyPress);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1384, 717);
            this.Controls.Add(this.dangerWind);
            this.Controls.Add(this.normalWind);
            this.Controls.Add(this.safeWind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calm);
            this.Controls.Add(this.southeast);
            this.Controls.Add(this.southwest);
            this.Controls.Add(this.northwest);
            this.Controls.Add(this.northeast);
            this.Controls.Add(this.west);
            this.Controls.Add(this.east);
            this.Controls.Add(this.south);
            this.Controls.Add(this.north);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " Моделирование пожара в лесу";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button north;
        private System.Windows.Forms.Button south;
        private System.Windows.Forms.Button east;
        private System.Windows.Forms.Button west;
        private System.Windows.Forms.Button northeast;
        private System.Windows.Forms.Button northwest;
        private System.Windows.Forms.Button southwest;
        private System.Windows.Forms.Button southeast;
        private System.Windows.Forms.Button calm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox safeWind;
        private System.Windows.Forms.TextBox normalWind;
        private System.Windows.Forms.TextBox dangerWind;
    }
}

