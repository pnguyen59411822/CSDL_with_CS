namespace Bai1_KetNoi
{
    partial class frm_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_win = new System.Windows.Forms.RadioButton();
            this.rbtn_sql = new System.Windows.Forms.RadioButton();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_access = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_excel2 = new System.Windows.Forms.Button();
            this.btn_connectApp = new System.Windows.Forms.Button();
            this.btn_connectFile = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(291, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 54);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên server";
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(214, 93);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(574, 26);
            this.txt_server.TabIndex = 4;
            // 
            // txt_database
            // 
            this.txt_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_database.Location = new System.Drawing.Point(214, 135);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(574, 26);
            this.txt_database.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên database";
            // 
            // rbtn_win
            // 
            this.rbtn_win.AutoSize = true;
            this.rbtn_win.Checked = true;
            this.rbtn_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_win.ForeColor = System.Drawing.Color.Tomato;
            this.rbtn_win.Location = new System.Drawing.Point(57, 9);
            this.rbtn_win.Name = "rbtn_win";
            this.rbtn_win.Size = new System.Drawing.Size(171, 19);
            this.rbtn_win.TabIndex = 8;
            this.rbtn_win.TabStop = true;
            this.rbtn_win.Text = "Chứng thực bằng Windows";
            this.rbtn_win.UseVisualStyleBackColor = true;
            this.rbtn_win.CheckedChanged += new System.EventHandler(this.rbtn_win_CheckedChanged);
            // 
            // rbtn_sql
            // 
            this.rbtn_sql.AutoSize = true;
            this.rbtn_sql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_sql.ForeColor = System.Drawing.Color.Tomato;
            this.rbtn_sql.Location = new System.Drawing.Point(57, 34);
            this.rbtn_sql.Name = "rbtn_sql";
            this.rbtn_sql.Size = new System.Drawing.Size(145, 19);
            this.rbtn_sql.TabIndex = 9;
            this.rbtn_sql.Text = "Chứng thực bằng SQL";
            this.rbtn_sql.UseVisualStyleBackColor = true;
            this.rbtn_sql.CheckedChanged += new System.EventHandler(this.rbtn_sql_CheckedChanged);
            // 
            // txt_user
            // 
            this.txt_user.Enabled = false;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(214, 249);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(574, 26);
            this.txt_user.TabIndex = 11;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lb_user.Location = new System.Drawing.Point(12, 252);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(80, 17);
            this.lb_user.TabIndex = 10;
            this.lb_user.Text = "Tài khoản";
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(214, 290);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(574, 26);
            this.txt_pass.TabIndex = 13;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_pass.Location = new System.Drawing.Point(12, 293);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(74, 17);
            this.lb_pass.TabIndex = 12;
            this.lb_pass.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_win);
            this.groupBox1.Controls.Add(this.rbtn_sql);
            this.groupBox1.Location = new System.Drawing.Point(214, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 65);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btn_connect
            // 
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(15, 348);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(127, 38);
            this.btn_connect.TabIndex = 16;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_access
            // 
            this.btn_access.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_access.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_access.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_access.Location = new System.Drawing.Point(17, 400);
            this.btn_access.Name = "btn_access";
            this.btn_access.Size = new System.Drawing.Size(125, 38);
            this.btn_access.TabIndex = 17;
            this.btn_access.Text = "Access";
            this.btn_access.UseVisualStyleBackColor = true;
            // 
            // btn_excel
            // 
            this.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.Location = new System.Drawing.Point(148, 348);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(127, 38);
            this.btn_excel.TabIndex = 18;
            this.btn_excel.Text = "Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            // 
            // btn_excel2
            // 
            this.btn_excel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_excel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel2.Location = new System.Drawing.Point(148, 400);
            this.btn_excel2.Name = "btn_excel2";
            this.btn_excel2.Size = new System.Drawing.Size(127, 38);
            this.btn_excel2.TabIndex = 19;
            this.btn_excel2.Text = "Excel 2";
            this.btn_excel2.UseVisualStyleBackColor = true;
            // 
            // btn_connectApp
            // 
            this.btn_connectApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_connectApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connectApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectApp.Location = new System.Drawing.Point(281, 348);
            this.btn_connectApp.Name = "btn_connectApp";
            this.btn_connectApp.Size = new System.Drawing.Size(127, 38);
            this.btn_connectApp.TabIndex = 20;
            this.btn_connectApp.Text = "Connect app";
            this.btn_connectApp.UseVisualStyleBackColor = true;
            // 
            // btn_connectFile
            // 
            this.btn_connectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_connectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectFile.Location = new System.Drawing.Point(281, 400);
            this.btn_connectFile.Name = "btn_connectFile";
            this.btn_connectFile.Size = new System.Drawing.Size(127, 38);
            this.btn_connectFile.TabIndex = 21;
            this.btn_connectFile.Text = "Connect file";
            this.btn_connectFile.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(414, 400);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(127, 38);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_connectFile);
            this.Controls.Add(this.btn_connectApp);
            this.Controls.Add(this.btn_excel2);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_access);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_main";
            this.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_win;
        private System.Windows.Forms.RadioButton rbtn_sql;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_access;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_excel2;
        private System.Windows.Forms.Button btn_connectApp;
        private System.Windows.Forms.Button btn_connectFile;
        private System.Windows.Forms.Button btn_close;
    }
}

