﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IPhieuNhapDAL
    {
        int Insert(int mancc, DateTime ngaynhap, float tongtien, int manhanvien);
        int Delete(int maphieunhap);
        int Update(int maphieunhap, int mancc, DateTime ngaynhap, float tongtien, int manhanvien);
        DataTable getAll();
        int checkPhieuNhap_ID(int maphieunhap);
        float GetDoanhSoNhap(int month, int year);
    }
}
