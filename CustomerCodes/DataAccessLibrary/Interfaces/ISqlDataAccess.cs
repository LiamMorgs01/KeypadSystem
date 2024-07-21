using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string SQL, U Parameters);

        Task<T> LoadSingle<T, U>(string SQL, U Parameters);

        Task<T> SaveData<T, U>(string sql, U parameters);
    }
}