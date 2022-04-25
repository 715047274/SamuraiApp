using System.ComponentModel.DataAnnotations.Schema;

namespace SamuraiApp.Domain
{
    public class Horse:BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey(nameof(Samurai))]
        public int SamuraiId { get; set; }
    }
}