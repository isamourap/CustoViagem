using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMauiCustoViagem.Models;

namespace AppMauiCustoViagem.Helpers
{
    
    internal class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Pedagio>().Wait();
        }
        public Task<int> Insert(Pedagio p)
        {
            return _conn.InsertAsync(p);
        }
        public Task<List<Pedagio>> Update(Pedagio p)
        {
            string sql = "Update Produto SET  Local=?, Valor=? " +
                         "WHERE Id=?";

            return _conn.QueryAsync<Pedagio>(sql,
                p.Local, p.Valor, p.Id);
        }
        public Task<List<Produto>> GetAll()
        {
            return _conn.Table<Produto>().ToListAsync();
        }
    }
}
