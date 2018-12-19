using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using netCore.Models;

namespace netCore.Persistance
{
    interface IUnitOfWork
    {
        ProductContext _context { get; }
        void Commit();
    }
}
