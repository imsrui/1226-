using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public interface ICategoryManager
    {
        int CateAdd(Category category);
        int CateEdit(Category category);
        int CateDelete(Guid id);
    }
}
