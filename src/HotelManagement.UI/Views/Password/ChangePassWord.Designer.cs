﻿
namespace HotelManagement.UI
{
    partial class ChangePassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassWord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customButton1 = new HotelManagement.UI.Components.CustomButton();
            this.txt_nlmk = new HotelManagement.UI.Components.TextBox();
            this.txt_newMK = new HotelManagement.UI.Components.TextBox();
            this.txt_name = new HotelManagement.UI.Components.TextBox();
            this.txt_mk = new HotelManagement.UI.Components.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.txt_nlmk);
            this.panel1.Controls.Add(this.txt_newMK);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_mk);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 561);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mậu khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(133, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customButton1.Location = new System.Drawing.Point(0, 506);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(476, 50);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "Cập nhật";
            this.customButton1.TextColor = System.Drawing.SystemColors.ControlText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click_1);
            this.customButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customButton1_KeyDown);
            // 
            // txt_nlmk
            // 
            this.txt_nlmk.Background = System.Drawing.SystemColors.Window;
            this.txt_nlmk.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_nlmk.BorderRadius = 10;
            this.txt_nlmk.ErrorMessage = null;
            this.txt_nlmk.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_nlmk.IsError = false;
            this.txt_nlmk.Location = new System.Drawing.Point(95, 412);
            this.txt_nlmk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nlmk.Multiline = false;
            this.txt_nlmk.Name = "txt_nlmk";
            this.txt_nlmk.Padding = new System.Windows.Forms.Padding(7);
            this.txt_nlmk.Password = false;
            this.txt_nlmk.PlaceHolder = "Nhắc lại mật khẩu";
            this.txt_nlmk.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txt_nlmk.Size = new System.Drawing.Size(305, 37);
            this.txt_nlmk.TabIndex = 4;
            this.txt_nlmk.Underline = false;
            // 
            // txt_newMK
            // 
            this.txt_newMK.Background = System.Drawing.SystemColors.Window;
            this.txt_newMK.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_newMK.BorderRadius = 10;
            this.txt_newMK.ErrorMessage = null;
            this.txt_newMK.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_newMK.IsError = false;
            this.txt_newMK.Location = new System.Drawing.Point(95, 367);
            this.txt_newMK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newMK.Multiline = false;
            this.txt_newMK.Name = "txt_newMK";
            this.txt_newMK.Padding = new System.Windows.Forms.Padding(7);
            this.txt_newMK.Password = false;
            this.txt_newMK.PlaceHolder = "Mật khẩu mới";
            this.txt_newMK.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txt_newMK.Size = new System.Drawing.Size(305, 37);
            this.txt_newMK.TabIndex = 3;
            this.txt_newMK.Underline = false;
            // 
            // txt_name
            // 
            this.txt_name.Background = System.Drawing.SystemColors.Window;
            this.txt_name.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_name.BorderRadius = 10;
            this.txt_name.ErrorMessage = null;
            this.txt_name.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_name.IsError = false;
            this.txt_name.Location = new System.Drawing.Point(95, 207);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7);
            this.txt_name.Password = false;
            this.txt_name.PlaceHolder = "Username";
            this.txt_name.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txt_name.Size = new System.Drawing.Size(305, 37);
            this.txt_name.TabIndex = 1;
            this.txt_name.Underline = false;
            // 
            // txt_mk
            // 
            this.txt_mk.Background = System.Drawing.SystemColors.Window;
            this.txt_mk.BorderColor = System.Drawing.Color.BlueViolet;
            this.txt_mk.BorderRadius = 10;
            this.txt_mk.ErrorMessage = null;
            this.txt_mk.FocusedColor = System.Drawing.Color.Aqua;
            this.txt_mk.IsError = false;
            this.txt_mk.Location = new System.Drawing.Point(95, 292);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mk.Multiline = false;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Padding = new System.Windows.Forms.Padding(7);
            this.txt_mk.Password = false;
            this.txt_mk.PlaceHolder = "Mật khẩu hiện tại";
            this.txt_mk.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txt_mk.Size = new System.Drawing.Size(305, 37);
            this.txt_mk.TabIndex = 2;
            this.txt_mk.Underline = false;
            // 
            // ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(503, 573);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Components.CustomButton customButton1;
        private Components.TextBox txt_nlmk;
        private Components.TextBox txt_newMK;
        private Components.TextBox txt_name;
        private Components.TextBox txt_mk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}