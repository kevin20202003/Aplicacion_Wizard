using Aplicacion_Wizard.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Wizard.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Car>().Wait();
        }

        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        public Task<int> SaveCarAsync(Car car)
        {
            return _database.InsertAsync(car);
        }

        public Task<List<Car>> GetCarsByUserAsync(int userId)
        {
            return _database.Table<Car>().Where(c => c.UserID == userId).ToListAsync();
        }
    }
}
