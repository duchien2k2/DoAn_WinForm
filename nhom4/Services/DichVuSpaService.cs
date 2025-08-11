using System.Collections.Generic;
using nhom4.Models;
using nhom4.Repositories;

namespace nhom4.Services
{
    public class DichVuSpaService
    {
        private readonly IDichVuSpaRepository repository;

        public DichVuSpaService()
        {
            repository = new DichVuSpaRepository();
        }

        public List<DichVuSpa> LayTatCa()
        {
            return repository.GetAll();
        }

        public DichVuSpa LayTheoId(int id)
        {
            return repository.GetById(id);
        }

        public void Them(DichVuSpa spa)
        {
            repository.Add(spa);
        }

        public void CapNhat(DichVuSpa spa)
        {
            repository.Update(spa);
        }

        public void Xoa(int id)
        {
            repository.Delete(id);
        }
    }
}
