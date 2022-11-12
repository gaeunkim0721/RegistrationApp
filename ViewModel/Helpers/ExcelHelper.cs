/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQLite.TableMapping;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace RegistrationApp.ViewModel.Helpers
{
    public class ExcelHelper
    {
        private static void WriteExcelData()
        {
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            string ExcelPath = "C:\\Users\\User\\source\\repos\\RegistrationApp\\จองที่พักต่างชาติ อยู่ยาว.xlsx";

            try
            {
                excelApp = new Excel.Application();

                wb = excelApp.Workbooks.Open(ExcelPath);
                // 엑셀파일을 엽니다.
                // ExcelPath 대신 문자열도 가능합니다
                // 예. Open(@"D:\test\test.xlsx");

                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;
                // 첫번째 Worksheet를 선택합니다.

                Excel.Range rng = ws.Range["A46", "BS46"];
                // 해당 Worksheet에서 저장할 범위를 정합니다.
                // 지금은 저장할 행렬의 크기만큼 지정합니다.
                // 다른 예시 Excel.Range rng = ws.Range["B2", "G8"];
                int row = 1;
                int column = 71;

                object[,] data = new object[1, 71];
                // 저장할 때 사용할 object 행렬

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < column; c++)
                    {
                        if (ws.Cells[1, column] != null)
                        {
                            data[row,column]=
                        }
                        else
                        {
                            continue;
                        }
                        
                        // data[r , c] = Data[r, c] 저장할 데이터
                    }
                }
                // for문이 아니더라도 object[,] 형으로 저장된다면 저장이 가능합니다.

                rng.Value = data;
                // data를 불러온 엑셀파일에 적용시킵니다. 아직 완료 X

                if (ExcelPath != null)
                    // path는 새로 저장될 엑셀파일의 경로입니다.
                    // 따로 지정해준다면, "다른이름으로 저장" 의 역할을 합니다.
                    // 상대경로도 가능합니다. (예. "secondExcel.xlsx")
                    wb.SaveCopyAs(ExcelPath);
                else
                    // 따로 저장하지 않는다면 지금 파일에 그대로 저장합니다.
                    wb.Save();

                wb.Close();
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
        }
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
*/