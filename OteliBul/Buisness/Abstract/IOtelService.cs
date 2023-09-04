using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IOtelService
    {
        List<Otel> GetAllOtels();
        Otel GetOtelById(int id);
        Otel CreateOtel(Otel otel);
        Otel UpdateOtel(Otel otel);
        void DeleteOtel(int id);
    }
}
