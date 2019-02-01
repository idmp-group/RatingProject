using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    interface IDataBase<TEntity>
    {
        bool Create(TEntity newRecord);
        TEntity Read(int id);
        List<TEntity> Read();
        bool Update(TEntity newRecord);
        bool Delete(int id);
        bool Save();
    }
}
