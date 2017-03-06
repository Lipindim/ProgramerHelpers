using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerHelpers
{
    public class TableInfo
    {
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsGeneratedDB { get; set; }
        public string DataType { get; set; }
        public bool IsNullable { get; set; }
    }
}
