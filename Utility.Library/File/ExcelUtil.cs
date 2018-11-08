using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace Common.Library.File
{
    public class ExcelUtil
    {
        /// <summary>
        /// 将DataTable转化成HSSFWorkbook
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static HSSFWorkbook Write(DataTable table)
        {
            #region 初始化工作薄
            //创建工作薄
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            var sheet = hssfworkbook.CreateSheet("Sheet1");
            #endregion

            #region 设置表头
            //设置列名
            var row = sheet.CreateRow(sheet.PhysicalNumberOfRows);
            foreach (DataColumn tc in table.Columns)
            {
                var style = hssfworkbook.CreateCellStyle();
                style.Alignment = HorizontalAlignment.Center;
                var cell = row.CreateCell(table.Columns.IndexOf(tc));
                cell.SetCellValue(tc.ColumnName);
                cell.SetCellType(CellType.String);
                cell.CellStyle = style;
            }
            #endregion

            #region 设置表行
            //设置每一行的数据
            foreach (DataRow tr in table.Rows)
            {
                row = sheet.CreateRow(sheet.PhysicalNumberOfRows);

                #region 设置每列数据
                foreach (DataColumn tc in table.Columns)
                {
                    #region 根据数据类型选择单元格格式
                    var cell = row.CreateCell(table.Columns.IndexOf(tc));
                    var value = tr[tc.ColumnName];
                    if (tc.DataType.IsValueType)
                    {
                        cell.SetCellValue(double.Parse(value.ToString()));
                        cell.SetCellType(CellType.Numeric);
                    }
                    else
                    {
                        cell.SetCellValue(value.ToString());
                        cell.SetCellType(CellType.String);
                    }
                    #endregion
                }
                #endregion
            }
            #endregion

            return hssfworkbook;
        }
        /// <summary>
        /// 保存到本地文件
        /// </summary>
        /// <param name="table"></param>
        /// <param name="filePath"></param>
        public static void WriteToFile(DataTable table, string filePath)
        {
            //保存到本机
            var hssfworkbook = Write(table);
            FileStream stream = new FileStream(filePath, FileMode.CreateNew);
            hssfworkbook.Write(stream);
            stream.Close();
            hssfworkbook.Close();
        }
        /// <summary>
        /// 保存到本地文件
        /// </summary>
        /// <param name="table"></param>
        /// <param name="filePath"></param>
        public static void WriteToFile<T>(List<T> list, string filePath)
        {
            //保存到本机
            var hssfworkbook = Write(ListToDataTable(list));
            FileStream stream = new FileStream(filePath, FileMode.CreateNew);
            hssfworkbook.Write(stream);
            stream.Close();
            hssfworkbook.Close();
        }
        /// <summary>
        /// 响应到浏览器
        /// </summary>
        /// <param name="table"></param>
        public static void WriteToClient(DataTable table)
        {
            var hssfworkbook = Write(table);
            hssfworkbook.Write(HttpContext.Current.Response.OutputStream);
            hssfworkbook.Close();
        }
        /// <summary>
        /// 响应到浏览器
        /// </summary>
        /// <param name="table"></param>
        public static void WriteToClient<T>(List<T> list)
        {
            var hssfworkbook = Write(ListToDataTable(list));
            hssfworkbook.Write(HttpContext.Current.Response.OutputStream);
            hssfworkbook.Close();
        }
        /// <summary>
        /// 将Excel转化成HSSFWorkbook
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="sheetAt">sheet下标</param>
        /// <param name="startRow">开始行</param>
        /// <returns></returns>
        public static DataTable Read(string filePath, int sheetAt, int startRow)
        {
            var table = new DataTable();
            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            IWorkbook workbook = null;

            #region 判断文件类型,并实例化Workbook
            var extension = Path.GetExtension(filePath);
            if (".xls".Equals(extension, System.StringComparison.InvariantCultureIgnoreCase))
            {
                workbook = new HSSFWorkbook(stream);
            }
            else if (".xlsx".Equals(extension, System.StringComparison.InvariantCultureIgnoreCase))
            {
                workbook = new XSSFWorkbook(stream);
            }
            else
            {
                throw new System.Exception("文件类型不合法");
            }
            var sheet = workbook.GetSheetAt(sheetAt);
            #endregion

            #region 初始化DataTable结构
            table.TableName = sheet.SheetName;
            foreach (var cell in sheet.GetRow(startRow).Cells)
            {
                table.Columns.Add(new DataColumn(cell.StringCellValue, cell.CellType == CellType.Numeric ? typeof(double) : typeof(string)));
            }
            #endregion

            #region 设置DataTable数据
            for (int i = startRow + 1; i < sheet.PhysicalNumberOfRows; i++)
            {
                var row = table.NewRow();
                var cells = sheet.GetRow(i).Cells;
                foreach (var cell in cells)
                {
                    if (cell.CellType == CellType.Numeric)
                    {
                        row[cells.IndexOf(cell)] = cell.NumericCellValue;
                    }
                    else
                    {
                        row[cells.IndexOf(cell)] = cell.StringCellValue;
                    }
                }
                table.Rows.Add(row);
            }
            #endregion

            return table;
        }
        /// <summary>
        /// List转DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();
            var properties = typeof(T).GetProperties().ToList().FindAll(f => f.Name != "Fields");
            var columnsMapper = new Dictionary<string, string>();
            //注入列
            foreach (var property in properties)
            {
                //判断是否有描述注解
                var attribute = property.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                var desc = property.Name;
                if (attribute.Length > 0)
                {
                    desc = (attribute[0] as System.ComponentModel.DescriptionAttribute).Description;
                }
                //非空处理
                var name = string.IsNullOrEmpty(desc) ? property.Name : desc;
                //重复备注处理
                name = columnsMapper.ContainsValue(name) ? string.Format("{0}{1}", name, columnsMapper.Values.ToList().FindAll(v => v == name).Count) : name;
                dt.Columns.Add(name, property.PropertyType.IsValueType? typeof(double): typeof(string));
                columnsMapper.Add(property.Name, name);
            }
            //注入值
            foreach (var item in list)
            {
                DataRow row = dt.NewRow();
                foreach (var property in properties)
                {
                    row[columnsMapper[property.Name]] = property.GetValue(item);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
