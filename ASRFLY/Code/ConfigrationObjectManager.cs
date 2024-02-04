using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Code
{
    public static class ConfigrationObjectManager
    {
        private static Dictionary<string,object> ObjectList = new Dictionary<string,object>();

        public static void Register(string ObjName , object ObjValue)
        {
            ObjectList.Add(ObjName, ObjValue);
        }

        public static object GetObject(string ObjName)
        {
            return ObjectList[ObjName];
        }
    }
}
