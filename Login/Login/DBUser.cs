using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class DBUser
    {
        readonly SQLiteAsyncConnection _database;
        public DBUser(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync()
        {
            return
            _database.Table<User>().ToListAsync();
        }
        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        public Task<User> GetUserByUsername(string Username)
        {
            return _database.Table<User>().FirstOrDefaultAsync(u => u.Username.Equals(Username));
        }
    }
}
