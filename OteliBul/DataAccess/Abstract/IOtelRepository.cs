using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOtelRepository
    {
        List<Otel> GetAllOtels(); //Liste türündeki otelleri döndürecek

        Otel GetOtelById(int id); //id parametre verdik

        Otel CreateOtel(Otel otel); //Otel ekleyecek

        Otel UpdateOtel(Otel otel);

        void DeleteOtel(int id);
    }
}
