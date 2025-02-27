﻿using System;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;

namespace HotelManagement.UI.Views.Customer
{
    public partial class FrmCustomer : Form
    {
        private readonly ICustomerService _Customer;
        private readonly IUnitOfWork _worker;
        public FrmCustomer(ICustomerService customer, IUnitOfWork worker)
        {
            InitializeComponent();
            _Customer = customer;
            _worker = worker;
            loadData();
        }
        public async void loadData()
        {
            var name = await _Customer.Get();

            dgrid_customer.ColumnCount = 7;
            dgrid_customer.Columns[0].Name = "Số giấy tờ";
            dgrid_customer.Columns[1].Name = "Tên khách hàng";
            dgrid_customer.Columns[2].Name = "Điện Thoại";
            dgrid_customer.Columns[3].Name = "Giới Tính";
            dgrid_customer.Columns[4].Name = "Trạng Thái";
            dgrid_customer.Columns[5].Name = "Trạng Thái";
            dgrid_customer.Columns[6].Name = "Giấy tờ";
            dgrid_customer.Columns[6].Visible = false;
            dgrid_customer.Rows.Clear();
            foreach (var x in name.ToList())
            {
                var type = await _worker.Identifications.Get(c => c.Id == x.Type);
                dgrid_customer.Rows.Add(x.IdentityNumber, x.Name, x.PhoneNumber, x.Gender == true ? "Nam" : "Nữ",
                    x.Status == true ? "Hoạt Động" : "Không Hoạt Động", type.Name);
            }
        }
        public async void loadSeach(string dv)
        {
            var name = await _Customer.Find(dv);

            dgrid_customer.ColumnCount = 6;
            dgrid_customer.Columns[0].Name = "Số";
            dgrid_customer.Columns[1].Name = "Tên Khách Hàng";
            dgrid_customer.Columns[2].Name = "Điện Thoại";
            dgrid_customer.Columns[3].Name = "Giới Tính";
            dgrid_customer.Columns[4].Name = "Trạng Thái";
            dgrid_customer.Columns[5].Name = "Id";
            dgrid_customer.Columns[5].Visible = false;
            dgrid_customer.Rows.Clear();
            foreach (var x in name.ToList())
            {
                var cust = await _Customer.Get();
                var type = await _worker.Identifications.Get(c => c.Id == x.Type);
                dgrid_customer.Rows.Add(x.IdentityNumber, x.Name, x.PhoneNumber, x.Gender == true ? "Nam" : "Nữ",
                    x.Status == true ? "Hoạt Động" : "Không Hoạt Động",type.Name);
            }
        }
        private void txb_search__TextChanged(object sender, EventArgs e)
        {
            loadSeach(txb_search.Text);
        }
    }
}
