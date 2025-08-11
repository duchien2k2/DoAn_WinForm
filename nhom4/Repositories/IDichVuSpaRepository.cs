using nhom4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom4.Repositories
{
    internal interface IDichVuSpaRepository
    {
        List<DichVuSpa> GetAll();
        DichVuSpa GetById(int id);
        void Add(DichVuSpa spa);
        void Update(DichVuSpa spa);
        void Delete(int id);
    }
}
