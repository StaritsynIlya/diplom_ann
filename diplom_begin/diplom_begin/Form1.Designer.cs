﻿namespace diplom_begin
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button12 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.input_osad = new System.Windows.Forms.TextBox();
            this.label_osad = new System.Windows.Forms.Label();
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
            this.labelSafe = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.labelDanger = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.input_length = new System.Windows.Forms.TextBox();
            this.input_width = new System.Windows.Forms.TextBox();
            this.input_height = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.periodicity_safe_input = new System.Windows.Forms.TextBox();
            this.periodicity_normal_input = new System.Windows.Forms.TextBox();
            this.periodicity_danger_input = new System.Windows.Forms.TextBox();
            this.wave_safe_input = new System.Windows.Forms.TextBox();
            this.wave_normal_input = new System.Windows.Forms.TextBox();
            this.wave_danger_input = new System.Windows.Forms.TextBox();
            this.label_periodicity_safe = new System.Windows.Forms.Label();
            this.label_periodicity_normal = new System.Windows.Forms.Label();
            this.label_periodicity_danger = new System.Windows.Forms.Label();
            this.label_wave_safe = new System.Windows.Forms.Label();
            this.label_wave_normal = new System.Windows.Forms.Label();
            this.label_wave_dander = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.baseFuel = new System.Windows.Forms.TextBox();
            this.baseSpeedOfShip = new System.Windows.Forms.TextBox();
            this.label_base_fuel = new System.Windows.Forms.Label();
            this.label_base_speed_of_ship = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1119, 826);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1159, 815);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
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
            this.button12.Location = new System.Drawing.Point(12, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 17;
            this.button12.Text = "открыть";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1156, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Осадка, м";
            // 
            // input_osad
            // 
            this.input_osad.Location = new System.Drawing.Point(1323, 190);
            this.input_osad.MaxLength = 3;
            this.input_osad.Name = "input_osad";
            this.input_osad.Size = new System.Drawing.Size(100, 22);
            this.input_osad.TabIndex = 21;
            this.input_osad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.input_osad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label_osad
            // 
            this.label_osad.AutoSize = true;
            this.label_osad.Location = new System.Drawing.Point(1320, 193);
            this.label_osad.Name = "label_osad";
            this.label_osad.Size = new System.Drawing.Size(75, 16);
            this.label_osad.TabIndex = 24;
            this.label_osad.Text = "label_osad";
            this.label_osad.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 139);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1133, 818);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Предупреждение пользователя";
            this.label4.Visible = false;
            // 
            // north
            // 
            this.north.Location = new System.Drawing.Point(1225, 50);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(60, 30);
            this.north.TabIndex = 31;
            this.north.Text = "🡹";
            this.north.UseVisualStyleBackColor = true;
            this.north.Click += new System.EventHandler(this.north_Click);
            // 
            // south
            // 
            this.south.Location = new System.Drawing.Point(1225, 122);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(60, 30);
            this.south.TabIndex = 32;
            this.south.Text = "🡻";
            this.south.UseVisualStyleBackColor = true;
            this.south.Click += new System.EventHandler(this.south_Click);
            // 
            // east
            // 
            this.east.Location = new System.Drawing.Point(1291, 86);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(60, 30);
            this.east.TabIndex = 33;
            this.east.Text = "🡺";
            this.east.UseVisualStyleBackColor = true;
            this.east.Click += new System.EventHandler(this.east_Click);
            // 
            // west
            // 
            this.west.Location = new System.Drawing.Point(1159, 86);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(60, 30);
            this.west.TabIndex = 34;
            this.west.Text = "\t🡸";
            this.west.UseVisualStyleBackColor = true;
            this.west.Click += new System.EventHandler(this.west_Click);
            // 
            // northeast
            // 
            this.northeast.Location = new System.Drawing.Point(1291, 50);
            this.northeast.Name = "northeast";
            this.northeast.Size = new System.Drawing.Size(60, 30);
            this.northeast.TabIndex = 35;
            this.northeast.Text = "🡽";
            this.northeast.UseVisualStyleBackColor = true;
            this.northeast.Click += new System.EventHandler(this.northeast_Click);
            // 
            // northwest
            // 
            this.northwest.Location = new System.Drawing.Point(1159, 50);
            this.northwest.Name = "northwest";
            this.northwest.Size = new System.Drawing.Size(60, 30);
            this.northwest.TabIndex = 36;
            this.northwest.Text = "🡼";
            this.northwest.UseVisualStyleBackColor = true;
            this.northwest.Click += new System.EventHandler(this.northwest_Click);
            // 
            // southwest
            // 
            this.southwest.Location = new System.Drawing.Point(1159, 122);
            this.southwest.Name = "southwest";
            this.southwest.Size = new System.Drawing.Size(60, 30);
            this.southwest.TabIndex = 37;
            this.southwest.Text = "🡿";
            this.southwest.UseVisualStyleBackColor = true;
            this.southwest.Click += new System.EventHandler(this.southwest_Click);
            // 
            // southeast
            // 
            this.southeast.Location = new System.Drawing.Point(1291, 122);
            this.southeast.Name = "southeast";
            this.southeast.Size = new System.Drawing.Size(60, 30);
            this.southeast.TabIndex = 38;
            this.southeast.Text = "🡾";
            this.southeast.UseVisualStyleBackColor = true;
            this.southeast.Click += new System.EventHandler(this.southeast_Click);
            // 
            // calm
            // 
            this.calm.Location = new System.Drawing.Point(1225, 86);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1156, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Направление ветра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1156, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Скорость ветра, м/с";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1156, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Скорость ветра, м/с";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1156, 690);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Скорость ветра, м/с";
            // 
            // safeWind
            // 
            this.safeWind.Location = new System.Drawing.Point(1323, 437);
            this.safeWind.Name = "safeWind";
            this.safeWind.Size = new System.Drawing.Size(100, 22);
            this.safeWind.TabIndex = 44;
            this.safeWind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.safeWind_KeyDown);
            this.safeWind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.safeWind_KeyPress);
            // 
            // normalWind
            // 
            this.normalWind.Location = new System.Drawing.Point(1326, 568);
            this.normalWind.Name = "normalWind";
            this.normalWind.Size = new System.Drawing.Size(100, 22);
            this.normalWind.TabIndex = 45;
            this.normalWind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.normalWind_KeyDown);
            this.normalWind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.normalWind_KeyPress);
            // 
            // dangerWind
            // 
            this.dangerWind.Location = new System.Drawing.Point(1326, 687);
            this.dangerWind.Name = "dangerWind";
            this.dangerWind.Size = new System.Drawing.Size(100, 22);
            this.dangerWind.TabIndex = 46;
            this.dangerWind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dangerWind_KeyDown);
            // 
            // labelSafe
            // 
            this.labelSafe.AutoSize = true;
            this.labelSafe.Location = new System.Drawing.Point(1320, 440);
            this.labelSafe.Name = "labelSafe";
            this.labelSafe.Size = new System.Drawing.Size(70, 16);
            this.labelSafe.TabIndex = 47;
            this.labelSafe.Text = "label_safe";
            this.labelSafe.Visible = false;
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(1320, 571);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(85, 16);
            this.labelNormal.TabIndex = 48;
            this.labelNormal.Text = "label_normal";
            this.labelNormal.Visible = false;
            // 
            // labelDanger
            // 
            this.labelDanger.AutoSize = true;
            this.labelDanger.Location = new System.Drawing.Point(1320, 690);
            this.labelDanger.Name = "labelDanger";
            this.labelDanger.Size = new System.Drawing.Size(87, 16);
            this.labelDanger.TabIndex = 49;
            this.labelDanger.Text = "label_danger";
            this.labelDanger.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1156, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Технические характеристики судна";
            // 
            // input_length
            // 
            this.input_length.Location = new System.Drawing.Point(1323, 223);
            this.input_length.Name = "input_length";
            this.input_length.Size = new System.Drawing.Size(100, 22);
            this.input_length.TabIndex = 51;
            this.input_length.KeyDown += new System.Windows.Forms.KeyEventHandler(this.length_KeyDown);
            this.input_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.length_KeyPress);
            // 
            // input_width
            // 
            this.input_width.Location = new System.Drawing.Point(1323, 257);
            this.input_width.Name = "input_width";
            this.input_width.Size = new System.Drawing.Size(100, 22);
            this.input_width.TabIndex = 52;
            this.input_width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.width_KeyDown);
            this.input_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.width_KeyPress);
            // 
            // input_height
            // 
            this.input_height.Location = new System.Drawing.Point(1323, 288);
            this.input_height.Name = "input_height";
            this.input_height.Size = new System.Drawing.Size(100, 22);
            this.input_height.TabIndex = 53;
            this.input_height.KeyDown += new System.Windows.Forms.KeyEventHandler(this.height_KeyDown);
            this.input_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1156, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 54;
            this.label13.Text = "Длина, м";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1156, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Ширина, м";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1156, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "Высота, м";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(1320, 226);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(80, 16);
            this.labelLength.TabIndex = 57;
            this.labelLength.Text = "label_length";
            this.labelLength.Visible = false;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(1320, 260);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(74, 16);
            this.labelWidth.TabIndex = 58;
            this.labelWidth.Text = "label_width";
            this.labelWidth.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(1320, 291);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(80, 16);
            this.labelHeight.TabIndex = 59;
            this.labelHeight.Text = "label_height";
            this.labelHeight.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1156, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Частота";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1156, 601);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Частота";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1156, 722);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Частота";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1156, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Высота волны, м";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1156, 631);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 16);
            this.label16.TabIndex = 64;
            this.label16.Text = "Высота волны, м";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1156, 756);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 16);
            this.label17.TabIndex = 65;
            this.label17.Text = "Высота волны, м";
            // 
            // periodicity_safe_input
            // 
            this.periodicity_safe_input.Location = new System.Drawing.Point(1323, 471);
            this.periodicity_safe_input.Name = "periodicity_safe_input";
            this.periodicity_safe_input.Size = new System.Drawing.Size(100, 22);
            this.periodicity_safe_input.TabIndex = 66;
            this.periodicity_safe_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.periodicity_safe_KeyDown);
            this.periodicity_safe_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.periodicity_safe_KeyPress);
            // 
            // periodicity_normal_input
            // 
            this.periodicity_normal_input.Location = new System.Drawing.Point(1326, 598);
            this.periodicity_normal_input.Name = "periodicity_normal_input";
            this.periodicity_normal_input.Size = new System.Drawing.Size(100, 22);
            this.periodicity_normal_input.TabIndex = 67;
            this.periodicity_normal_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.periodicity_normal_KeyDown);
            this.periodicity_normal_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.periodicity_normal_KeyPress);
            // 
            // periodicity_danger_input
            // 
            this.periodicity_danger_input.Location = new System.Drawing.Point(1326, 719);
            this.periodicity_danger_input.Name = "periodicity_danger_input";
            this.periodicity_danger_input.Size = new System.Drawing.Size(100, 22);
            this.periodicity_danger_input.TabIndex = 68;
            this.periodicity_danger_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.periodicity_danger_KeyDown);
            this.periodicity_danger_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.periodicity_danger_KeyPress);
            // 
            // wave_safe_input
            // 
            this.wave_safe_input.Location = new System.Drawing.Point(1322, 504);
            this.wave_safe_input.Name = "wave_safe_input";
            this.wave_safe_input.Size = new System.Drawing.Size(100, 22);
            this.wave_safe_input.TabIndex = 69;
            this.wave_safe_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.safe_wave_KeyDown);
            this.wave_safe_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.safe_wave_KeyPress);
            // 
            // wave_normal_input
            // 
            this.wave_normal_input.Location = new System.Drawing.Point(1326, 628);
            this.wave_normal_input.Name = "wave_normal_input";
            this.wave_normal_input.Size = new System.Drawing.Size(100, 22);
            this.wave_normal_input.TabIndex = 70;
            this.wave_normal_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.normal_wave_KeyDown);
            this.wave_normal_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.normal_wave_KeyPress);
            // 
            // wave_danger_input
            // 
            this.wave_danger_input.Location = new System.Drawing.Point(1326, 753);
            this.wave_danger_input.Name = "wave_danger_input";
            this.wave_danger_input.Size = new System.Drawing.Size(100, 22);
            this.wave_danger_input.TabIndex = 71;
            this.wave_danger_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.danger_wave_KeyDown);
            this.wave_danger_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.danger_wave_KeyPress);
            // 
            // label_periodicity_safe
            // 
            this.label_periodicity_safe.AutoSize = true;
            this.label_periodicity_safe.Location = new System.Drawing.Point(1320, 474);
            this.label_periodicity_safe.Name = "label_periodicity_safe";
            this.label_periodicity_safe.Size = new System.Drawing.Size(139, 16);
            this.label_periodicity_safe.TabIndex = 72;
            this.label_periodicity_safe.Text = "label_periodicity_safe";
            this.label_periodicity_safe.Visible = false;
            // 
            // label_periodicity_normal
            // 
            this.label_periodicity_normal.AutoSize = true;
            this.label_periodicity_normal.Location = new System.Drawing.Point(1320, 601);
            this.label_periodicity_normal.Name = "label_periodicity_normal";
            this.label_periodicity_normal.Size = new System.Drawing.Size(154, 16);
            this.label_periodicity_normal.TabIndex = 73;
            this.label_periodicity_normal.Text = "label_periodicity_normal";
            this.label_periodicity_normal.Visible = false;
            // 
            // label_periodicity_danger
            // 
            this.label_periodicity_danger.AutoSize = true;
            this.label_periodicity_danger.Location = new System.Drawing.Point(1320, 722);
            this.label_periodicity_danger.Name = "label_periodicity_danger";
            this.label_periodicity_danger.Size = new System.Drawing.Size(156, 16);
            this.label_periodicity_danger.TabIndex = 74;
            this.label_periodicity_danger.Text = "label_periodicity_danger";
            this.label_periodicity_danger.Visible = false;
            // 
            // label_wave_safe
            // 
            this.label_wave_safe.AutoSize = true;
            this.label_wave_safe.Location = new System.Drawing.Point(1320, 507);
            this.label_wave_safe.Name = "label_wave_safe";
            this.label_wave_safe.Size = new System.Drawing.Size(109, 16);
            this.label_wave_safe.TabIndex = 75;
            this.label_wave_safe.Text = "label_wave_safe";
            this.label_wave_safe.Visible = false;
            // 
            // label_wave_normal
            // 
            this.label_wave_normal.AutoSize = true;
            this.label_wave_normal.Location = new System.Drawing.Point(1320, 631);
            this.label_wave_normal.Name = "label_wave_normal";
            this.label_wave_normal.Size = new System.Drawing.Size(124, 16);
            this.label_wave_normal.TabIndex = 76;
            this.label_wave_normal.Text = "label_wave_normal";
            this.label_wave_normal.Visible = false;
            // 
            // label_wave_dander
            // 
            this.label_wave_dander.AutoSize = true;
            this.label_wave_dander.Location = new System.Drawing.Point(1320, 756);
            this.label_wave_dander.Name = "label_wave_dander";
            this.label_wave_dander.Size = new System.Drawing.Size(126, 16);
            this.label_wave_dander.TabIndex = 77;
            this.label_wave_dander.Text = "label_wave_dander";
            this.label_wave_dander.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1156, 404);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 16);
            this.label18.TabIndex = 78;
            this.label18.Text = "Безопасная зона";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(1156, 540);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 16);
            this.label19.TabIndex = 79;
            this.label19.Text = "Зона средней опасности";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(1156, 661);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 16);
            this.label20.TabIndex = 80;
            this.label20.Text = "Опасная зона";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1156, 326);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(155, 16);
            this.label21.TabIndex = 81;
            this.label21.Text = "Б. расход топлива т/км";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1156, 356);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 16);
            this.label22.TabIndex = 82;
            this.label22.Text = "Б. скорость судна км/ч";
            // 
            // baseFuel
            // 
            this.baseFuel.Location = new System.Drawing.Point(1322, 323);
            this.baseFuel.Name = "baseFuel";
            this.baseFuel.Size = new System.Drawing.Size(100, 22);
            this.baseFuel.TabIndex = 83;
            this.baseFuel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.baseFuel_KeyDown);
            this.baseFuel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baseFuel_KeyPress);
            // 
            // baseSpeedOfShip
            // 
            this.baseSpeedOfShip.Location = new System.Drawing.Point(1323, 356);
            this.baseSpeedOfShip.Name = "baseSpeedOfShip";
            this.baseSpeedOfShip.Size = new System.Drawing.Size(100, 22);
            this.baseSpeedOfShip.TabIndex = 84;
            this.baseSpeedOfShip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.baseSpeedOfShip_KeyDown);
            this.baseSpeedOfShip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baseSpeedOfShip_KeyPress);
            // 
            // label_base_fuel
            // 
            this.label_base_fuel.AutoSize = true;
            this.label_base_fuel.Location = new System.Drawing.Point(1320, 326);
            this.label_base_fuel.Name = "label_base_fuel";
            this.label_base_fuel.Size = new System.Drawing.Size(103, 16);
            this.label_base_fuel.TabIndex = 85;
            this.label_base_fuel.Text = "label_base_fuel";
            this.label_base_fuel.Visible = false;
            // 
            // label_base_speed_of_ship
            // 
            this.label_base_speed_of_ship.AutoSize = true;
            this.label_base_speed_of_ship.Location = new System.Drawing.Point(1320, 359);
            this.label_base_speed_of_ship.Name = "label_base_speed_of_ship";
            this.label_base_speed_of_ship.Size = new System.Drawing.Size(171, 16);
            this.label_base_speed_of_ship.TabIndex = 86;
            this.label_base_speed_of_ship.Text = "label_base_speed_of_ship";
            this.label_base_speed_of_ship.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1486, 850);
            this.Controls.Add(this.label_base_speed_of_ship);
            this.Controls.Add(this.label_base_fuel);
            this.Controls.Add(this.baseSpeedOfShip);
            this.Controls.Add(this.baseFuel);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label_wave_dander);
            this.Controls.Add(this.label_wave_normal);
            this.Controls.Add(this.label_wave_safe);
            this.Controls.Add(this.label_periodicity_danger);
            this.Controls.Add(this.label_periodicity_normal);
            this.Controls.Add(this.label_periodicity_safe);
            this.Controls.Add(this.wave_danger_input);
            this.Controls.Add(this.wave_normal_input);
            this.Controls.Add(this.wave_safe_input);
            this.Controls.Add(this.periodicity_danger_input);
            this.Controls.Add(this.periodicity_normal_input);
            this.Controls.Add(this.periodicity_safe_input);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.input_height);
            this.Controls.Add(this.input_width);
            this.Controls.Add(this.input_length);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelDanger);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.labelSafe);
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
            this.Controls.Add(this.label_osad);
            this.Controls.Add(this.input_osad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Формирование маршрута судна";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_osad;
        private System.Windows.Forms.Label label_osad;
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
        private System.Windows.Forms.Label labelSafe;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label labelDanger;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox input_length;
        private System.Windows.Forms.TextBox input_width;
        private System.Windows.Forms.TextBox input_height;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox periodicity_safe_input;
        private System.Windows.Forms.TextBox periodicity_normal_input;
        private System.Windows.Forms.TextBox periodicity_danger_input;
        private System.Windows.Forms.TextBox wave_safe_input;
        private System.Windows.Forms.TextBox wave_normal_input;
        private System.Windows.Forms.TextBox wave_danger_input;
        private System.Windows.Forms.Label label_periodicity_safe;
        private System.Windows.Forms.Label label_periodicity_normal;
        private System.Windows.Forms.Label label_periodicity_danger;
        private System.Windows.Forms.Label label_wave_safe;
        private System.Windows.Forms.Label label_wave_normal;
        private System.Windows.Forms.Label label_wave_dander;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox baseFuel;
        private System.Windows.Forms.TextBox baseSpeedOfShip;
        private System.Windows.Forms.Label label_base_fuel;
        private System.Windows.Forms.Label label_base_speed_of_ship;
    }
}

