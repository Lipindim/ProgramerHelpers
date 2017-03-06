using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerHelpers
{
    public static class DataBaseOperation
    {
        private static Dictionary<string, string> typeMap;
        public static Dictionary<string, string> TypeMap
        {
            get
            {
                if(typeMap == null)
                {
                    typeMap = new Dictionary<string, string>();
                    typeMap["nvarchar"] = "string";
                    typeMap["varchar"] = "string";
                    typeMap["char"] = "string";
                    typeMap["text"] = "string";
                    typeMap["ntext"] = "string";
                    typeMap["nchar"] = "string";

                }
                return typeMap;
            }
            private set { }
        }
        private static Dictionary<string, string> typeMapNullable;
        public static Dictionary<string, string> TypeMapNullable
        {
            get
            {
                if (typeMapNullable == null)
                {
                    typeMapNullable = new Dictionary<string, string>();
                    typeMapNullable["bigint"] = "Int64";
                    typeMapNullable["int"] = "int";
                    typeMapNullable["smallint"] = "short";
                    typeMapNullable["bit"] = "bool";
                    typeMapNullable["date"] = "DateTime";
                    typeMapNullable["datetime"] = "DateTime";
                    typeMapNullable["smalldatetime"] = "DateTime";
                    typeMapNullable["float"] = "float";
                }
                return typeMapNullable;
            }
            private set { }
        }


    }
}
