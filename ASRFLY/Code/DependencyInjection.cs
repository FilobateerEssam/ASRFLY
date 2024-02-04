using ASRFLY.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Code
{
    public static class DependencyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigrationObjectManager.Register("Categories", new CategoriesEntity());
        }
    }
}
