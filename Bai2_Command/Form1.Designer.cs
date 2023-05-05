namespace Bai2_Command
{
    partial class Frm_main
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
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lv_data = new System.Windows.Forms.ListView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_rmv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(267, 24);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(612, 23);
            this.txt_maKH.TabIndex = 1;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Location = new System.Drawing.Point(267, 70);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(612, 23);
            this.txt_tenKH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(267, 116);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(612, 23);
            this.txt_diaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(47, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(267, 159);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(612, 23);
            this.txt_SDT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(47, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại";
            // 
            // lv_data
            // 
            this.lv_data.FullRowSelect = true;
            this.lv_data.GridLines = true;
            this.lv_data.HideSelection = false;
            this.lv_data.Location = new System.Drawing.Point(50, 206);
            this.lv_data.MultiSelect = false;
            this.lv_data.Name = "lv_data";
            this.lv_data.Size = new System.Drawing.Size(829, 207);
            this.lv_data.TabIndex = 14;
            this.lv_data.UseCompatibleStateImageBehavior = false;
            this.lv_data.View = System.Windows.Forms.View.Details;
            this.lv_data.SelectedIndexChanged += new System.EventHandler(this.lv_data_SelectedIndexChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_exit.Location = new System.Drawing.Point(50, 442);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(115, 38);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_load
            // 
            this.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_load.Location = new System.Drawing.Point(171, 442);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(112, 38);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Load data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.Location = new System.Drawing.Point(410, 442);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 38);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_view
            // 
            this.btn_view.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_view.Location = new System.Drawing.Point(289, 442);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(115, 38);
            this.btn_view.TabIndex = 12;
            this.btn_view.Text = "Xem";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.Location = new System.Drawing.Point(649, 442);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 38);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.Location = new System.Drawing.Point(528, 442);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 38);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_rmv
            // 
            this.btn_rmv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_rmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rmv.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_rmv.Location = new System.Drawing.Point(767, 442);
            this.btn_rmv.Name = "btn_rmv";
            this.btn_rmv.Size = new System.Drawing.Size(112, 38);
            this.btn_rmv.TabIndex = 16;
            this.btn_rmv.Text = "Xóa";
            this.btn_rmv.UseVisualStyleBackColor = true;
            this.btn_rmv.Click += new System.EventHandler(this.btn_rmv_Click);
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 554);
            this.Controls.Add(this.btn_rmv);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lv_data);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_main";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lv_data;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_rmv;
    }
}

