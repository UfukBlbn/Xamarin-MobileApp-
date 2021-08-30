using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace MobileProjectx
{
   public class SQLiteHelper
    {
        public Task<int> SaveItemAsync(person xperson)
        {
            if (xperson.PersonID != 0)
            {
                return db.UpdateAsync(xperson);
            }
            else
            {
                return db.InsertAsync(xperson);
            }
        }
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<person>().Wait();
        }
        public Task<List<person>> GetItemsAsync()
        {
            return db.Table<person>().ToListAsync();
        }
        public Task<person> GetItemAsync(int personId)
        {
            return db.Table<person>().Where(i => i.PersonID == personId).FirstOrDefaultAsync();
        }
        public Task<int> DeleteItemAsync(person xperson)
        {
            return db.DeleteAsync(xperson);
        }

        
    }
}
