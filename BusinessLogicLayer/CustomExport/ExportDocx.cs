using BusinessLogicLayer.Interface;
using ChamThiTuyenSinh10;
using Entities;
using Novacode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace BusinessLogicLayer
{
    public class ExportDocx : DocxHelper
    {
        public static string CreateClassTemplate(string filename, Dictionary<string, string> dictionaryData, IList<Student> data)
        {
            string res = "";
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].StudentName);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].Brithday.ToString("dd/MM/yyyy"));
                                newRow.Cells[3].Paragraphs.First().Append(data[i].PhoneNumber);
                                newRow.Cells[4].Paragraphs.First().Append(data[i].Address);
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public static string CreateClassTemplate(string filename, Dictionary<string, string> dictionaryData, IList<NhanVien> data)
        {
            string res = "";
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].VaiTro.ToString());
                                newRow.Cells[2].Paragraphs.First().Append(data[i].Hoten);
                                newRow.Cells[3].Paragraphs.First().Append(data[i].Diachi);
                                newRow.Cells[4].Paragraphs.First().Append(data[i].Dienthoai);
                                newRow.Cells[5].Paragraphs.First().Append(data[i].Email);
                                newRow.Cells[6].Paragraphs.First().Append(data[i].Ngaysinh.ToString("dd/MM/yyyy"));
                                newRow.Cells[7].Paragraphs.First().Append(data[i].Gioitinh.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public static string CreateChiTietTemplate(string filename, Dictionary<string, string> dictionaryData, IList<ChiTietHoaDonBan> data)
        {
            string res = "";
            IProductBUL product = new ProductBUL();
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                string tenThuoc = product.getAll().FirstOrDefault(thuoc => thuoc.Mathuoc == data[i].Mathuoc)?.Tenthuoc;
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(tenThuoc);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].Soluong.ToString() + "   X");
                                newRow.Cells[3].Paragraphs.First().Append(data[i].Dongia.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public static string CreateProductTemplate(string filename, Dictionary<string, string> dictionaryData, IList<Product> data)
        {
            string res = "";
            IProviderBUL provider = new ProviderBUL();
            IDonViTinhBUL donvitinh = new DonViTinhBUL();
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                //string tenthuoc =  provider.getAll().FirstOrDefault(t => t.Mancc == data[i].Mancc)?.Tenncc;
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].Tenthuoc);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].Giaban.ToString());
                                newRow.Cells[3].Paragraphs.First().Append(data[i].Hansudung.ToString("dd/MM/yyyy"));
                                //newRow.Cells[4].Paragraphs.First().Append(tenthuoc);
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public static string CreatePhieuNhapTemplate(string filename, Dictionary<string, string> dictionaryData, IList<ChiTietPhieuNhap> data)
        {
            string res = "";
            IProductBUL product = new ProductBUL();
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                string tenThuoc = product.getAll().FirstOrDefault(thuoc => thuoc.Mathuoc == data[i].Mathuoc)?.Tenthuoc;
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(tenThuoc);
                                newRow.Cells[2].Paragraphs.First().Append(data[i].Soluong.ToString() + "   X");
                                newRow.Cells[3].Paragraphs.First().Append(data[i].Dongia.ToString());
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public static string CreateThongKeTemplate(string filename, Dictionary<string, string> dictionaryData, IList<(int Month, float TongHoaDon, float TongHangNhap)> data)
        {
            string res = "";
            IProductBUL product = new ProductBUL();
            try
            {
                using (DocX document = DocX.Load(filename))
                {
                    ReplaceTime(document, null);
                    ReplaceData(dictionaryData, null, document);
                    int cRow = 1;
                    if (data != null && data.Count > 0)
                    {
                        Novacode.Table myTable = FindTableWithText(document.Tables, fTempTableData, out int Row, out int cCell);
                        if (data.Count > 0)
                        {
                            for (int i = 0; i < data.Count; i++)
                            {
                                string doanhsoban = Tools.ChuanHoaTien(data[i].TongHoaDon);
                                string doanhsonhap = Tools.ChuanHoaTien(data[i].TongHangNhap);
                                float loinhuan = data[i].TongHoaDon - data[i].TongHangNhap;
                                string loinhuanconvert = Tools.ChuanHoaTien(loinhuan);
                                Novacode.Row newRow = myTable.InsertRow(myTable.Rows[cRow], cRow + i + 1);
                                newRow.Cells[0].Paragraphs.First().Append((i + 1).ToString()).ReplaceText(fTempTableData, "");
                                newRow.Cells[1].Paragraphs.First().Append(data[i].Month.ToString());
                                newRow.Cells[2].Paragraphs.First().Append(doanhsoban);
                                newRow.Cells[3].Paragraphs.First().Append(doanhsonhap);  
                                newRow.Cells[4].Paragraphs.First().Append(loinhuanconvert);
                            }
                            cRow += 1;
                        }
                        myTable.RemoveRow(1);
                    }
                    document.ReplaceText(fTempTableData, "");
                    document.Save();
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }
    }
}
