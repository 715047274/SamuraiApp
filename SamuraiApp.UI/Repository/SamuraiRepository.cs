using System;
using SamuraiApp.Data;
using SamuraiApp.Domain;

namespace SamuraiApp.UI.Repository
{
    public class SamuraiRepository
    {
        private readonly SamuraiContext _context;

        public SamuraiRepository(SamuraiContext context)
        {
            _context = context;
        }

        public Samurai GetById(int samuraiId)
        {
            throw new NotImplementedException();
        }

        public string UpdateSamuraiInfo()
        {
            throw new NotImplementedException();
        }

        public void Save(Samurai samurai)
        {
            _context.Samurais.Attach(samurai);
        }
    }
}