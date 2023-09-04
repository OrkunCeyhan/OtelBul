using Buisness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class OtelManager : IOtelService
    {
        private IOtelRepository _otelRepository;

        public OtelManager(IOtelRepository otelRepository)
        {
            _otelRepository = otelRepository;
        }

        public Otel CreateOtel(Otel otel)
        {
            return _otelRepository.CreateOtel(otel);
        }

        public void DeleteOtel(int id)
        {
            _otelRepository.DeleteOtel(id);
        }

        public List<Otel> GetAllOtels()
        {
            return _otelRepository.GetAllOtels();
        }

        public Otel GetOtelById(int id)
        {
            if (id > 0)
            {

                return _otelRepository.GetOtelById(id);
            }
            throw new Exception("id 1 den kücük olamaz");
        }

        public Otel UpdateOtel(Otel otel)
        {
            return _otelRepository.UpdateOtel(otel);
        }
    }
}
