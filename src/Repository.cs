using Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Class repository to implement the I repository.
/// </summary>
public class Repository : IRepository<Storeble>
{
    IEnumerable<Storeble> IRepository<Storeble>.All()
    {
       
        throw new NotImplementedException();
    }

    void IRepository<Storeble>.Delete(IComparable id)
    {
        throw new NotImplementedException();
    }

    Storeble IRepository<Storeble>.FindById(IComparable id)
    {
        throw new NotImplementedException();
    }

    void IRepository<Storeble>.Save(Storeble item)
    {
        throw new NotImplementedException();
    }
}

