using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IProductManager
    {
        int Add(Product product );
        int Edit(Product product);
        int Delete(Guid id);
    }
}
