using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class OtelRepository : IOtelRepository
    {
        public Otel CreateOtel(Otel otel)
        {
            using (var otelDbContext = new OtelDbContext())
            {
                otelDbContext.Otels.Add(otel);
                otelDbContext.SaveChanges();
                return otel;

            }
        }

        public void DeleteOtel(int id)
        {
            using (var otelDbContext = new OtelDbContext())
            {
                var deleteOtel = GetOtelById(id);
                otelDbContext.Otels.Remove(deleteOtel);
                otelDbContext.SaveChanges();
            }
        }

        public List<Otel> GetAllOtels()
        {
            using (var otelDbContext = new OtelDbContext())
            {
                return otelDbContext.Otels.ToList();
            }
        }

        public Otel GetOtelById(int id)
        {
            using (var otelDbContext = new OtelDbContext())
            {
                return otelDbContext.Otels.Find(id);
            }
        }

        public Otel UpdateOtel(Otel otel)
        {
            using (var otelDbContext = new OtelDbContext())
            {
                otelDbContext.Otels.Update(otel);
                otelDbContext.SaveChanges();
                return otel;
            }
        }
    }
}
