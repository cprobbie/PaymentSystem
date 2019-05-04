using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystem.Models.Repository
{
    public interface IPaymentDataRepo<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(long id);
        Task AddAsync(TEntity payment);
        void Delete(TEntity payment);
    }
}
