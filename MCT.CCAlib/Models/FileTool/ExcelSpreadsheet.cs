using System.Collections.Generic;
using System.Data;

namespace MCT.CCAlib.Models.FileTool
{
    public class ExcelSpreadsheet
    {
        public string WorkbookName { get; set; }
        public List<DataTable> Worksheets { get; set; } = new List<DataTable>();
    }
}
