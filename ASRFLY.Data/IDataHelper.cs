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

        List<Table> GetAllData();
        List<Table> Search(string SearchItem);
        Table Find(int Id);

        // Write

        int Add(Table table);
        int Edit(Table table);
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
