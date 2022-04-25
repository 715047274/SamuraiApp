using System;
using System.Collections.Generic;
using System.Linq;

namespace SamuraiApp.Domain
{
    public class Samurai : BaseEntity
    {
        public string Name { get; set; }
        public Horse? horse { get; set; }
        // private IList<Quote> _quotes = new List<Quote>();
        // private IList<Battle> _battles = new List<Battle>();
        // public virtual IReadOnlyList<Battle> Battles => _battles.ToList();
        // public virtual IReadOnlyList<Quote> Quotes => _quotes.ToList();
    }
    
    
}
