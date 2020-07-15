using Apps.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    public class BaseTable
    {
        protected static SQLiteAsyncConnection db = null;
        protected static SQLiteConnection database = null;
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "User.db3");
        public BaseTable()
        {
            if (db == null)
            {
                db = new SQLiteAsyncConnection(dbPath);
                database = new SQLiteConnection(dbPath);
            }
        }
    }
    public class Datamanager:BaseTable
    {
        public void CreateUserTable()
        {
            try
            {
                db.CreateTableAsync<UserDetail>().Wait();
            }
            catch (Exception ex)
            {
                //exception handling code to go here
                throw;
            }
        }
        public Task<int> SaveUserDetailAsync(UserDetail userDetail)
        {
            return db.InsertAsync(userDetail);
        }
    }
}
