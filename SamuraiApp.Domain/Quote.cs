using System.ComponentModel.DataAnnotations.Schema;

namespace SamuraiApp.Domain
{
    public class Quote: BaseEntity
    {
        public string quote { get; set; }
        
        [ForeignKey(nameof(Samurai))]
        public int SamuraiId { get; set; }
        public virtual Samurai Samurai { get; set; }
    }
}