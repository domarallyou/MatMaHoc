namespace RC4_1_
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
            this.DES = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Text_lb = new System.Windows.Forms.Label();
            this.PLT_lb = new System.Windows.Forms.Label();
            this.Key_lb = new System.Windows.Forms.Label();
            this.GM_button = new System.Windows.Forms.Button();
            this.mh_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_CPGM = new System.Windows.Forms.TextBox();
            this.bt_GiaiMa = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_GiaiMa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_GMD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_GMN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_KBM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_KCK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_CPtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_E = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PhiN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_PlaintextRSA = new System.Windows.Forms.TextBox();
            this.tb_sont2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sont1 = new System.Windows.Forms.TextBox();
            this.HASH = new System.Windows.Forms.TabPage();
            this.tb_name = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.bt_dangky = new System.Windows.Forms.Button();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_dnPass = new System.Windows.Forms.TextBox();
            this.tb_dnuser = new System.Windows.Forms.TextBox();
            this.tb_hash2 = new System.Windows.Forms.TextBox();
            this.tb_hash1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DES.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.HASH.SuspendLayout();
            this.SuspendLayout();
            // 
            // DES
            // 
            this.DES.Controls.Add(this.tabPage1);
            this.DES.Controls.Add(this.tabPage2);
            this.DES.Controls.Add(this.HASH);
            this.DES.Location = new System.Drawing.Point(0, 0);
            this.DES.Name = "DES";
            this.DES.SelectedIndex = 0;
            this.DES.Size = new System.Drawing.Size(948, 417);
            this.DES.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Text_lb);
            this.tabPage1.Controls.Add(this.PLT_lb);
            this.tabPage1.Controls.Add(this.Key_lb);
            this.tabPage1.Controls.Add(this.GM_button);
            this.tabPage1.Controls.Add(this.mh_button);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RC4";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Text_lb
            // 
            this.Text_lb.AutoSize = true;
            this.Text_lb.Location = new System.Drawing.Point(28, 168);
            this.Text_lb.Name = "Text_lb";
            this.Text_lb.Size = new System.Drawing.Size(39, 20);
            this.Text_lb.TabIndex = 15;
            this.Text_lb.Text = "Text";
            // 
            // PLT_lb
            // 
            this.PLT_lb.AutoSize = true;
            this.PLT_lb.Location = new System.Drawing.Point(28, 102);
            this.PLT_lb.Name = "PLT_lb";
            this.PLT_lb.Size = new System.Drawing.Size(73, 20);
            this.PLT_lb.TabIndex = 14;
            this.PLT_lb.Text = "PlainText";
            // 
            // Key_lb
            // 
            this.Key_lb.AutoSize = true;
            this.Key_lb.Location = new System.Drawing.Point(28, 38);
            this.Key_lb.Name = "Key_lb";
            this.Key_lb.Size = new System.Drawing.Size(35, 20);
            this.Key_lb.TabIndex = 13;
            this.Key_lb.Text = "Key";
            // 
            // GM_button
            // 
            this.GM_button.Location = new System.Drawing.Point(534, 218);
            this.GM_button.Name = "GM_button";
            this.GM_button.Size = new System.Drawing.Size(86, 32);
            this.GM_button.TabIndex = 12;
            this.GM_button.Text = "GiaiMa";
            this.GM_button.UseVisualStyleBackColor = true;
            this.GM_button.Click += new System.EventHandler(this.GM_button_Click_1);
            // 
            // mh_button
            // 
            this.mh_button.Location = new System.Drawing.Point(387, 218);
            this.mh_button.Name = "mh_button";
            this.mh_button.Size = new System.Drawing.Size(86, 32);
            this.mh_button.TabIndex = 11;
            this.mh_button.Text = "MaHoa";
            this.mh_button.UseVisualStyleBackColor = true;
            this.mh_button.Click += new System.EventHandler(this.mh_button_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(110, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(552, 26);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(552, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "HELLO WORLD!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(552, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "KEY";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tb_CPGM);
            this.tabPage2.Controls.Add(this.bt_GiaiMa);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tb_GiaiMa);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tb_GMD);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tb_GMN);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb_KBM);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tb_KCK);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_CPtext);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lb_E);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_PhiN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_N);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_PlaintextRSA);
            this.tabPage2.Controls.Add(this.tb_sont2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tb_sont1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RSA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(582, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "CiperText";
            // 
            // tb_CPGM
            // 
            this.tb_CPGM.Location = new System.Drawing.Point(676, 55);
            this.tb_CPGM.Name = "tb_CPGM";
            this.tb_CPGM.Size = new System.Drawing.Size(227, 26);
            this.tb_CPGM.TabIndex = 42;
            // 
            // bt_GiaiMa
            // 
            this.bt_GiaiMa.Location = new System.Drawing.Point(675, 237);
            this.bt_GiaiMa.Name = "bt_GiaiMa";
            this.bt_GiaiMa.Size = new System.Drawing.Size(86, 32);
            this.bt_GiaiMa.TabIndex = 41;
            this.bt_GiaiMa.Text = "Giai Ma";
            this.bt_GiaiMa.UseVisualStyleBackColor = true;
            this.bt_GiaiMa.Click += new System.EventHandler(this.bt_GiaiMa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(593, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "PlainText";
            // 
            // tb_GiaiMa
            // 
            this.tb_GiaiMa.Location = new System.Drawing.Point(675, 183);
            this.tb_GiaiMa.Name = "tb_GiaiMa";
            this.tb_GiaiMa.Size = new System.Drawing.Size(228, 26);
            this.tb_GiaiMa.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(599, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Key BM";
            // 
            // tb_GMD
            // 
            this.tb_GMD.Location = new System.Drawing.Point(676, 140);
            this.tb_GMD.Name = "tb_GMD";
            this.tb_GMD.Size = new System.Drawing.Size(110, 26);
            this.tb_GMD.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "N";
            // 
            // tb_GMN
            // 
            this.tb_GMN.Location = new System.Drawing.Point(675, 108);
            this.tb_GMN.Name = "tb_GMN";
            this.tb_GMN.Size = new System.Drawing.Size(111, 26);
            this.tb_GMN.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "GIAI MA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Key BM";
            // 
            // tb_KBM
            // 
            this.tb_KBM.Location = new System.Drawing.Point(162, 222);
            this.tb_KBM.Name = "tb_KBM";
            this.tb_KBM.Size = new System.Drawing.Size(110, 26);
            this.tb_KBM.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Key CK";
            // 
            // tb_KCK
            // 
            this.tb_KCK.Location = new System.Drawing.Point(163, 190);
            this.tb_KCK.Name = "tb_KCK";
            this.tb_KCK.Size = new System.Drawing.Size(110, 26);
            this.tb_KCK.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "CiperText";
            // 
            // tb_CPtext
            // 
            this.tb_CPtext.Location = new System.Drawing.Point(163, 260);
            this.tb_CPtext.Name = "tb_CPtext";
            this.tb_CPtext.Size = new System.Drawing.Size(280, 26);
            this.tb_CPtext.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "MaHoa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_E
            // 
            this.lb_E.AutoSize = true;
            this.lb_E.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_E.Location = new System.Drawing.Point(280, 182);
            this.lb_E.Name = "lb_E";
            this.lb_E.Size = new System.Drawing.Size(33, 20);
            this.lb_E.TabIndex = 26;
            this.lb_E.Text = "      ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phi(N)";
            // 
            // tb_PhiN
            // 
            this.tb_PhiN.Location = new System.Drawing.Point(163, 149);
            this.tb_PhiN.Name = "tb_PhiN";
            this.tb_PhiN.Size = new System.Drawing.Size(111, 26);
            this.tb_PhiN.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "N";
            // 
            // tb_N
            // 
            this.tb_N.Location = new System.Drawing.Point(333, 55);
            this.tb_N.Name = "tb_N";
            this.tb_N.Size = new System.Drawing.Size(111, 26);
            this.tb_N.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "MA HOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "PlainText";
            // 
            // tb_PlaintextRSA
            // 
            this.tb_PlaintextRSA.Location = new System.Drawing.Point(163, 111);
            this.tb_PlaintextRSA.Name = "tb_PlaintextRSA";
            this.tb_PlaintextRSA.Size = new System.Drawing.Size(280, 26);
            this.tb_PlaintextRSA.TabIndex = 17;
            this.tb_PlaintextRSA.Text = "32";
            // 
            // tb_sont2
            // 
            this.tb_sont2.Location = new System.Drawing.Point(231, 52);
            this.tb_sont2.Name = "tb_sont2";
            this.tb_sont2.Size = new System.Drawing.Size(43, 26);
            this.tb_sont2.TabIndex = 16;
            this.tb_sont2.Text = "7";
            this.tb_sont2.TextChanged += new System.EventHandler(this.tb_sont2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "So NT";
            // 
            // tb_sont1
            // 
            this.tb_sont1.Location = new System.Drawing.Point(163, 52);
            this.tb_sont1.Name = "tb_sont1";
            this.tb_sont1.Size = new System.Drawing.Size(41, 26);
            this.tb_sont1.TabIndex = 14;
            this.tb_sont1.Text = "3";
            this.tb_sont1.TextChanged += new System.EventHandler(this.tb_sont1_TextChanged);
            // 
            // HASH
            // 
            this.HASH.Controls.Add(this.label18);
            this.HASH.Controls.Add(this.label19);
            this.HASH.Controls.Add(this.tb_hash2);
            this.HASH.Controls.Add(this.tb_hash1);
            this.HASH.Controls.Add(this.label14);
            this.HASH.Controls.Add(this.label17);
            this.HASH.Controls.Add(this.tb_dnPass);
            this.HASH.Controls.Add(this.tb_dnuser);
            this.HASH.Controls.Add(this.bt_dangnhap);
            this.HASH.Controls.Add(this.bt_dangky);
            this.HASH.Controls.Add(this.tb_name);
            this.HASH.Controls.Add(this.label15);
            this.HASH.Controls.Add(this.label16);
            this.HASH.Controls.Add(this.textBox4);
            this.HASH.Controls.Add(this.tb_pass);
            this.HASH.Controls.Add(this.tb_user);
            this.HASH.Location = new System.Drawing.Point(4, 29);
            this.HASH.Name = "HASH";
            this.HASH.Padding = new System.Windows.Forms.Padding(3);
            this.HASH.Size = new System.Drawing.Size(940, 384);
            this.HASH.TabIndex = 2;
            this.HASH.Text = "HASH";
            this.HASH.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            this.tb_name.AutoSize = true;
            this.tb_name.Location = new System.Drawing.Point(41, 160);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(80, 20);
            this.tb_name.TabIndex = 21;
            this.tb_name.Text = "Full Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "User";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(123, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 26);
            this.textBox4.TabIndex = 18;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(123, 96);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(240, 26);
            this.tb_pass.TabIndex = 17;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(123, 32);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(240, 26);
            this.tb_user.TabIndex = 16;
            // 
            // bt_dangky
            // 
            this.bt_dangky.Location = new System.Drawing.Point(123, 204);
            this.bt_dangky.Name = "bt_dangky";
            this.bt_dangky.Size = new System.Drawing.Size(86, 32);
            this.bt_dangky.TabIndex = 28;
            this.bt_dangky.Text = "Dang Ky";
            this.bt_dangky.UseVisualStyleBackColor = true;
            this.bt_dangky.Click += new System.EventHandler(this.bt_dangky_Click);
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Location = new System.Drawing.Point(646, 148);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(138, 32);
            this.bt_dangnhap.TabIndex = 29;
            this.bt_dangnhap.Text = "Dang Nhap";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(564, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(564, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "User";
            // 
            // tb_dnPass
            // 
            this.tb_dnPass.Location = new System.Drawing.Point(646, 96);
            this.tb_dnPass.Name = "tb_dnPass";
            this.tb_dnPass.Size = new System.Drawing.Size(240, 26);
            this.tb_dnPass.TabIndex = 31;
            // 
            // tb_dnuser
            // 
            this.tb_dnuser.Location = new System.Drawing.Point(646, 32);
            this.tb_dnuser.Name = "tb_dnuser";
            this.tb_dnuser.Size = new System.Drawing.Size(240, 26);
            this.tb_dnuser.TabIndex = 30;
            // 
            // tb_hash2
            // 
            this.tb_hash2.Location = new System.Drawing.Point(510, 274);
            this.tb_hash2.Name = "tb_hash2";
            this.tb_hash2.Size = new System.Drawing.Size(376, 26);
            this.tb_hash2.TabIndex = 35;
            // 
            // tb_hash1
            // 
            this.tb_hash1.Location = new System.Drawing.Point(510, 210);
            this.tb_hash1.Name = "tb_hash1";
            this.tb_hash1.Size = new System.Drawing.Size(376, 26);
            this.tb_hash1.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(431, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "DATA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(431, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "PASS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 417);
            this.Controls.Add(this.DES);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DES.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.HASH.ResumeLayout(false);
            this.HASH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DES;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Text_lb;
        private System.Windows.Forms.Label PLT_lb;
        private System.Windows.Forms.Label Key_lb;
        private System.Windows.Forms.Button GM_button;
        private System.Windows.Forms.Button mh_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_PlaintextRSA;
        private System.Windows.Forms.TextBox tb_sont2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_sont1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_N;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PhiN;
        private System.Windows.Forms.Label lb_E;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_CPtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_KBM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_KCK;
        private System.Windows.Forms.Button bt_GiaiMa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_GiaiMa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_GMD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_GMN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_CPGM;
        private System.Windows.Forms.TabPage HASH;
        private System.Windows.Forms.Label tb_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button bt_dangky;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_dnPass;
        private System.Windows.Forms.TextBox tb_dnuser;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_hash2;
        private System.Windows.Forms.TextBox tb_hash1;
    }
}

