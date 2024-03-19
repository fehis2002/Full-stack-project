using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Voetbal.Services.interfaces
{
    public interface IService<T> where T : class
    {
       Task<IEnumerable<T>?> GetAllAsync();
 
    }
}
