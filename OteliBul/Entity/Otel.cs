using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Otel
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string City { get; set; }
    }
}