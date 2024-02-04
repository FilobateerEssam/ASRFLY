using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Data
{
    public interface IDataHelper<Table>
    {
        // Read



        // All Data when read will Read as List

        /// <summary>Gets all data.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        
        List<Table>GetAllData();


        /// <summary>Searches the specified search item.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Searched Data</returns>
        /// 
        List<Table> Search(string SearchItem);


        /// <summary>Finds the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Table When id == ID</returns>
        Table Find(int Id);

        // Write


        /// <summary>Adds the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 When the Task Success , 0 When Failed</returns>
        int Add(Table table);


        /// <summary>Edits the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 When the Task Success , 0 When Failed</returns>
        int Edit(Table table);


        /// <summary>Deletes the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 When the Task Success , 0 When Failed</returns>
        int Delete(int Id);


        // Read Async

        // All Data when read will Read as List


        Task<List<Table>> GetAllDataAsync();


        Task<List<Table>> SearchAsync(string SearchItem);


        Task<Table> FindAsync(int Id);

        // Write Async

        Task<int> AddAsync(Table table);


        Task<int> EditAsync(Table table);

        Task<int> DeleteAsync(int Id);
    }
}
