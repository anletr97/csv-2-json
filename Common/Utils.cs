using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2AutoTestGenerator.Common
{
        public static class Utils
        {
        #region Export JSON
        public static void ExportJson(object fields)
            {
                using (StreamWriter file = File.CreateText(Constant.SAVE_TEMP_FILE_PATH))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, fields);
                }
            }
        }
        #endregion
}
