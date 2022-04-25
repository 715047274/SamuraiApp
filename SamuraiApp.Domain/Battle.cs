using System;
using System.Collections.Generic;
using System.Linq;

namespace SamuraiApp.Domain
{
    public class Battle: BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private IList<Samurai> _samurais = new List<Samurai>();
        public IReadOnlyList<Samurai> Samurais => _samurais.ToList();
    }
}