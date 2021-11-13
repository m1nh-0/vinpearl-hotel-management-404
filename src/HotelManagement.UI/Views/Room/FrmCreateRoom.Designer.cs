﻿
using System.Windows.Forms;

namespace HotelManagement.UI.Views.Room
{
    partial class FrmCreateRoom
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
            this.TbxRoomType = new HotelManagement.UI.Components.TextBox();
            this.BtnAddRoomType = new HotelManagement.UI.Components.CustomButton();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxQuantity = new HotelManagement.UI.Components.TextBox();
            this.CmbRoomType = new System.Windows.Forms.ComboBox();
            this.BtnAddToQueue = new HotelManagement.UI.Components.CustomButton();
            this.BtnRemove = new HotelManagement.UI.Components.CustomButton();
            this.BtnCancel = new HotelManagement.UI.Components.CustomButton();
            this.BtnSave = new HotelManagement.UI.Components.CustomButton();
            this.CmbFloor = new System.Windows.Forms.ComboBox();
            this.TbxFloor = new HotelManagement.UI.Components.TextBox();
            this.BtnAddFloor = new HotelManagement.UI.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxRoomType
            // 
            this.TbxRoomType.BorderColor = System.Drawing.Color.Silver;
            this.TbxRoomType.BorderRadius = 7;
            this.TbxRoomType.ErrorMessage = null;
            this.TbxRoomType.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxRoomType.IsError = false;
            this.TbxRoomType.Location = new System.Drawing.Point(445, 13);
            this.TbxRoomType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxRoomType.Multiline = false;
            this.TbxRoomType.Name = "TbxRoomType";
            this.TbxRoomType.Padding = new System.Windows.Forms.Padding(7);
            this.TbxRoomType.Password = false;
            this.TbxRoomType.PlaceHolder = "Thêm loại phòng mới";
            this.TbxRoomType.Size = new System.Drawing.Size(222, 37);
            this.TbxRoomType.TabIndex = 0;
            this.TbxRoomType.Underline = false;
            // 
            // BtnAddRoomType
            // 
            this.BtnAddRoomType.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddRoomType.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddRoomType.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddRoomType.BorderRadius = 7;
            this.BtnAddRoomType.BorderSize = 2;
            this.BtnAddRoomType.FlatAppearance.BorderSize = 0;
            this.BtnAddRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddRoomType.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoomType.Location = new System.Drawing.Point(675, 13);
            this.BtnAddRoomType.Name = "BtnAddRoomType";
            this.BtnAddRoomType.Size = new System.Drawing.Size(94, 39);
            this.BtnAddRoomType.TabIndex = 1;
            this.BtnAddRoomType.Text = "Thêm";
            this.BtnAddRoomType.TextColor = System.Drawing.Color.White;
            this.BtnAddRoomType.UseVisualStyleBackColor = false;
            this.BtnAddRoomType.Click += new System.EventHandler(this.BtnAddRoomType_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(2, 84);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 29;
            this.GridView.Size = new System.Drawing.Size(370, 191);
            this.GridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phòng sẽ được thêm";
            // 
            // TbxQuantity
            // 
            this.TbxQuantity.BorderColor = System.Drawing.Color.Silver;
            this.TbxQuantity.BorderRadius = 5;
            this.TbxQuantity.ErrorMessage = null;
            this.TbxQuantity.FocusedColor = System.Drawing.Color.LightSeaGreen;
            this.TbxQuantity.IsError = false;
            this.TbxQuantity.Location = new System.Drawing.Point(692, 102);
            this.TbxQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxQuantity.Multiline = false;
            this.TbxQuantity.Name = "TbxQuantity";
            this.TbxQuantity.Padding = new System.Windows.Forms.Padding(7);
            this.TbxQuantity.Password = false;
            this.TbxQuantity.PlaceHolder = "Số lượng";
            this.TbxQuantity.Size = new System.Drawing.Size(94, 37);
            this.TbxQuantity.TabIndex = 4;
            this.TbxQuantity.Underline = false;
            // 
            // CmbRoomType
            // 
            this.CmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbRoomType.FormattingEnabled = true;
            this.CmbRoomType.Location = new System.Drawing.Point(378, 108);
            this.CmbRoomType.Name = "CmbRoomType";
            this.CmbRoomType.Size = new System.Drawing.Size(196, 33);
            this.CmbRoomType.TabIndex = 5;
            // 
            // BtnAddToQueue
            // 
            this.BtnAddToQueue.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddToQueue.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddToQueue.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddToQueue.BorderRadius = 7;
            this.BtnAddToQueue.BorderSize = 2;
            this.BtnAddToQueue.FlatAppearance.BorderSize = 0;
            this.BtnAddToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddToQueue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddToQueue.ForeColor = System.Drawing.Color.White;
            this.BtnAddToQueue.Location = new System.Drawing.Point(385, 155);
            this.BtnAddToQueue.Name = "BtnAddToQueue";
            this.BtnAddToQueue.Size = new System.Drawing.Size(120, 45);
            this.BtnAddToQueue.TabIndex = 6;
            this.BtnAddToQueue.Text = "Thêm Phòng";
            this.BtnAddToQueue.TextColor = System.Drawing.Color.White;
            this.BtnAddToQueue.UseVisualStyleBackColor = false;
            this.BtnAddToQueue.Click += new System.EventHandler(this.BtnAddToQueue_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Red;
            this.BtnRemove.BackgroundColor = System.Drawing.Color.Red;
            this.BtnRemove.BorderColor = System.Drawing.Color.Red;
            this.BtnRemove.BorderRadius = 7;
            this.BtnRemove.BorderSize = 2;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(567, 155);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(120, 45);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "Xóa";
            this.BtnRemove.TextColor = System.Drawing.Color.White;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.BackgroundColor = System.Drawing.Color.Red;
            this.BtnCancel.BorderColor = System.Drawing.Color.Red;
            this.BtnCancel.BorderRadius = 7;
            this.BtnCancel.BorderSize = 2;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(567, 227);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(120, 45);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Hủy";
            this.BtnCancel.TextColor = System.Drawing.Color.White;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderRadius = 7;
            this.BtnSave.BorderSize = 2;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(385, 227);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 45);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CmbFloor
            // 
            this.CmbFloor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbFloor.FormattingEnabled = true;
            this.CmbFloor.Location = new System.Drawing.Point(581, 108);
            this.CmbFloor.Name = "CmbFloor";
            this.CmbFloor.Size = new System.Drawing.Size(103, 33);
            this.CmbFloor.TabIndex = 11;
            // 
            // TbxFloor
            // 
            this.TbxFloor.BorderColor = System.Drawing.Color.Silver;
            this.TbxFloor.BorderRadius = 7;
            this.TbxFloor.ErrorMessage = null;
            this.TbxFloor.FocusedColor = System.Drawing.Color.Aqua;
            this.TbxFloor.IsError = false;
            this.TbxFloor.Location = new System.Drawing.Point(540, 60);
            this.TbxFloor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TbxFloor.Multiline = false;
            this.TbxFloor.Name = "TbxFloor";
            this.TbxFloor.Padding = new System.Windows.Forms.Padding(7);
            this.TbxFloor.Password = false;
            this.TbxFloor.PlaceHolder = "Thêm tầng";
            this.TbxFloor.Size = new System.Drawing.Size(127, 37);
            this.TbxFloor.TabIndex = 12;
            this.TbxFloor.Underline = false;
            // 
            // BtnAddFloor
            // 
            this.BtnAddFloor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddFloor.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddFloor.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.BtnAddFloor.BorderRadius = 7;
            this.BtnAddFloor.BorderSize = 2;
            this.BtnAddFloor.FlatAppearance.BorderSize = 0;
            this.BtnAddFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddFloor.ForeColor = System.Drawing.Color.White;
            this.BtnAddFloor.Location = new System.Drawing.Point(675, 60);
            this.BtnAddFloor.Name = "BtnAddFloor";
            this.BtnAddFloor.Size = new System.Drawing.Size(94, 39);
            this.BtnAddFloor.TabIndex = 13;
            this.BtnAddFloor.Text = "Thêm";
            this.BtnAddFloor.TextColor = System.Drawing.Color.White;
            this.BtnAddFloor.UseVisualStyleBackColor = false;
            this.BtnAddFloor.Click += new System.EventHandler(this.BtnAddFloor_Click);
            // 
            // FrmCreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.BtnAddFloor);
            this.Controls.Add(this.TbxFloor);
            this.Controls.Add(this.CmbFloor);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAddToQueue);
            this.Controls.Add(this.CmbRoomType);
            this.Controls.Add(this.TbxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.BtnAddRoomType);
            this.Controls.Add(this.TbxRoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCreateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateRoom";
            this.Load += new System.EventHandler(this.FrmCreateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.TextBox TbxRoomType;
        private Components.CustomButton BtnAddRoomType;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label1;
        private Components.TextBox TbxQuantity;
        private System.Windows.Forms.ComboBox CmbRoomType;
        private Components.CustomButton BtnAddToQueue;
        private Components.CustomButton BtnRemove;
        private Components.CustomButton BtnCancel;
        private Components.CustomButton BtnSave;
        private ComboBox CmbFloor;
        private Components.TextBox TbxFloor;
        private Components.CustomButton BtnAddFloor;
    }
}