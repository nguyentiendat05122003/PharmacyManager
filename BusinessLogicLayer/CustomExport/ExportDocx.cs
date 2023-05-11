using ChamThiTuyenSinh10;
using Entities;
using Novacode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
