using ASRFLY.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Data.SqlServer
{
    public class CategoriesEntity : IDataHelper<Categories>
    {

        // Variables

        private DBContext db;
        private Categories table;

        // Constractors

        public CategoriesEntity()
        {

            db = new DBContext();
        }


        #region Methods
        public int Add(Categories table)
        {
            try
            {
                // Check Connection of DB 

                if (db.Database.CanConnect())
                {
                    // Add To DB

                    db.Categories.Add(table);
                    db.SaveChanges();

                    // DB Connected
                    return 1;

                }

                else
                {
                    // DB Not Connected
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }



        public async Task<int> AddAsync(Categories table)
        {
            try
            {
                // Check Connection of DB 

                if (await db.Database.CanConnectAsync())
                {
                    // Add To DB

                    await db.Categories.AddAsync(table);
                    await db.SaveChangesAsync();

                    // DB Connected
                    return 1;

                }

                else
                {
                    // DB Not Connected
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                // Check Connection of DB 

                if (db.Database.CanConnect())
                {
                    // Remove From DB

                    table = Find(Id);
                    db.Categories.Remove(table);
                    db.SaveChanges();

                    // DB Connected
                    return 1;

                }

                else
                {
                    // DB Not Connected
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteAsync(int Id)
        {
            try
            {
                // Check Connection of DB 

                if (await db.Database.CanConnectAsync())
                {
                    // Remove From DB

                    table = await FindAsync(Id);

                    // Remove Async 

                    await Task.Run(() => db.Categories.Remove(table));
                    await db.SaveChangesAsync();

                    // DB Connected
                    return 1;

                }

                else
                {
                    // DB Not Connected
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int Edit(Categories table)
        {
            try
            {
                // Check Connection of DB 

                if (db.Database.CanConnect())
                {

                    // Update Need To Initialize DB

                    db = new DBContext();
                    db.Categories.Update(table);
                    db.SaveChanges();

                    // DB Connected
                    return 1;

                }

                else
                {
                    // DB Not Connected
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> EditAsync(Categories table)
        {
            try
            {
                // Check Connection of DB 

                if (await db.Database.CanConnectAsync())
                {
                    // Update To DB

                    db = new DBContext();
                    await Task.Run(() => db.Categories.Update(table));
                    await db.SaveChangesAsync();

                    // DB Connected
                    return 1;

                }

                else
                {
                    // DB Not Connected
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        public Categories Find(int Id)
        {
            try
            {
                // Check Connection of DB 

                if (db.Database.CanConnect())
                {

                    // Find in DB

                    return db.Categories.Where(x => x.Id == Id).First();

                }

                else
                {
                    // DB Not Connected
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<Categories> FindAsync(int Id)
        {
            try
            {
                // Check Connection of DB 

                if (await db.Database.CanConnectAsync())
                {

                    // Find in DB

                    return await Task.Run(() => db.Categories.Where(x => x.Id == Id).First());

                }

                else
                {
                    // DB Not Connected
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        List<Categories> IDataHelper<Categories>.GetAllData()
        {
            try
            {
                // Check Connection of DB 

                if (db.Database.CanConnect())
                {

                    // Find in DB

                    return db.Categories.ToList();

                }

                else
                {
                    // DB Not Connected
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Categories>> GetAllDataAsync()
        {
            try
            {
                // Check Connection of DB 

                if (await db.Database.CanConnectAsync())
                {

                    // Find in DB

                    return await Task.Run(() => db.Categories.ToList());

                }

                else
                {
                    // DB Not Connected
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        List<Categories> IDataHelper<Categories>.Search(string SearchItem)
        {
            try
            {
                // Check Connection of DB 

                if (db.Database.CanConnect())
                {

                    // Find in DB

                    return db.Categories.Where(x => x.Id.ToString() == SearchItem
                    || x.Name.Contains(SearchItem)
                    || x.Details.Contains(SearchItem)
                    || x.Balance.ToString().Contains(SearchItem)
                    || x.AddedDate.ToString().Contains(SearchItem)
                    )
                        .ToList();

                }

                else
                {
                    // DB Not Connected
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Categories>> SearchAsync(string SearchItem)
        {
            try
            {
                // Check Connection of DB 

                if (await db.Database.CanConnectAsync())
                {

                    // Find in DB

                    return await Task.Run(() => db.Categories.Where(x => x.Id.ToString() == SearchItem
                        || x.Name.Contains(SearchItem)
                        || x.Details.Contains(SearchItem)
                        || x.Balance.ToString().Contains(SearchItem)
                        || x.AddedDate.ToString().Contains(SearchItem)
                        )
                            .ToList());

                }

                else
                {
                    // DB Not Connected
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
