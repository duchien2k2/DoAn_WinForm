using System.Collections.Generic;
using System.Linq;
using nhom4.Models;

namespace nhom4.Repositories
{
    public class DichVuSpaRepository : IDichVuSpaRepository
    {
        private readonly PetShopContextDB db = new PetShopContextDB();

        public List<DichVuSpa> GetAll()
        {
            return db.DichVuSpas.Include("DanhMucDichVu").ToList();
        }

        public DichVuSpa GetById(int id)
        {
            return db.DichVuSpas.Find(id);
        }

        public void Add(DichVuSpa spa)
        {
            db.DichVuSpas.Add(spa);
            db.SaveChanges();
        }

        public void Update(DichVuSpa spa)
        {
            var existing = db.DichVuSpas.Find(spa.ID_DichVu);
            if (existing != null)
            {
                existing.TenDichVu = spa.TenDichVu;
                existing.Gia = spa.Gia;
                existing.MoTa = spa.MoTa;
                existing.IDLoaiDV = spa.IDLoaiDV;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var spa = db.DichVuSpas.Find(id);
            if (spa != null)
            {
                db.DichVuSpas.Remove(spa);
                db.SaveChanges();
            }
        }
    }
}
