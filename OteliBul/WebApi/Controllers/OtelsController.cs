using Buisness.Abstract;
using Buisness.Concrete;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtelsController : ControllerBase
    {
        private IOtelService _otelService;

        public OtelsController(IOtelService otelService)
        {
            _otelService = otelService();
        }
        [HttpGet]
        public List<Otel> Get()
        {
            return _otelService.GetAllOtels();
        }
        [HttpGet("{id}")]
        public Otel Get(int id)
        {
            return _otelService.GetOtelById(id);
        }
        [HttpPost]
        public Otel Post([FromBody]Otel otel) 
        {
            return _otelService.CreateOtel(otel);
        }
        [HttpPut]
        public Otel put([FromBody] Otel otel)
        {
            return _otelService.UpdateOtel(otel);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _otelService.DeleteOtel(id);
        }
    }
}
