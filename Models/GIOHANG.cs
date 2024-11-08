﻿using Lab1.Models;
using System;
using System.Linq;

namespace Lab1.Models
{
    public class Giohang
    {
        // Tạo đối tượng data chứa dữ liệu từ model dbBansach đã tạo.
        QLBANSACHEntities1 data = new QLBANSACHEntities1();

        public int iMasach { get; set; }
        public string sTensach { get; set; }
        public string sAnhbia { get; set; }
        public double dDongia { get; set; }
        public int iSoluong { get; set; }

        public double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }

        // Khởi tạo giỏ hàng theo Masach được truyền vào với iSoluong mặc định là 1.
        public Giohang(int Masach)
        {
            iMasach = Masach;
            SACH sach = data.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Anhbia;
            dDongia = double.Parse(sach.Giaban.ToString());
            iSoluong = 1;
        }
    }
}