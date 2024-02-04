using ASRFLY.Core;
using ASRFLY.Data;
using ASRFLY.Data.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.TEST
{
    
    [TestClass]
    public class CategoriesEntityTest
    {
        IDataHelper<Categories> dataHelper;

        public CategoriesEntityTest()
        {
            dataHelper = new CategoriesEntity();    
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange ( Set )

            Categories categories = new Categories {
            
                Name = "تحليل المشروع ",
                Details = "الصنف الخاص فى تحليل المشروع ",
                Type = "صرف" ,
                Balance = 1000 ,
                AddedDate = DateTime.Now,
            };
             
            // Act and expt ( Get )

            int act = dataHelper.Add(categories);
            int expt = 1;

            // Assert ( Test )

            Assert.AreEqual(expt, act);
        }


        [TestMethod]
        public void EditTest()
        {
            // Arrange (Set)

            Categories categories = new Categories
            {
                Id = 1,
                Name = "تصميم المشروع ",
                Details = "الصنف الخاص فى تصميم المشروع ",
                Type = "قبض",
                Balance = 2000,
                AddedDate = DateTime.Now,
            };

            // Act and expt (Get)

            int act = dataHelper.Edit(categories);
            int expt = 1;

            // Assert 

            Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void GetALLDataTest()
        {
            // Arrange (Set)



            // Act & Expt (Get)

            var act = dataHelper.GetAllData();

            // Assert

            Assert.IsNotNull(act);
        }

        [TestMethod]
        public void SearchTest()
        {
            // Arrange (Set)

            string searchItem = "قبض";

            // Act & Expt (Get)

            var act = dataHelper.Search(searchItem);

            // Assert

            Assert.IsNotNull(act);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Arrange (Set)

            var Id = 1;

            // Act & Expt (Get)

            var act = dataHelper.Delete(Id);
            int expt = 1;

            // Assert

            Assert.AreEqual(expt,act);
        }
    }

}
    
