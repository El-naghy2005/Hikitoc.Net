using System.ComponentModel.DataAnnotations;

namespace hikitocAPI.Models.Domain
{
    public class Planet
    {
        [Key]
        public Guid PlanetId { get; set; }

        [StringLength(20)]
        public string Name { get; set; } = null!;

        //[StringLength(1000)]
        public string Description { get; set; }
        public double DiameterKm { get; set; }

        [StringLength(0)]
        public string? Image { get; set; }
        public Guid SplarSystemId { get; set; }
        public Guid WaterId { get; set; }

        public SolarSystem  SolarSystem { get; set; }
        public Water Water { get; set; }

    }
}

//  planetId This is primary key in Entity framework and قاعده البيانات المقابله
// planetId contain also forign key make relation between planet and others
// ستصبح هذه الفئات اعمده في هذه الجداول