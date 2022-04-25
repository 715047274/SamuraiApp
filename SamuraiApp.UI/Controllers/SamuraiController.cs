using SamuraiApp.Data;
using SamuraiApp.Domain;
using SamuraiApp.UI.Repository;

namespace SamuraiApp.UI.Controllers
{
    public class SamuraiController
    {
        private readonly SamuraiContext _context;
        private readonly SamuraiRepository _repository;
        public SamuraiController(SamuraiContext context)
        {
            _context = context;
            _repository = new SamuraiRepository(_context);
        }

        public string CreateSamuraiByName(string samuraiName)
        {
            var s = new Samurai {Name = samuraiName};
            _context.Samurais.Add(s);
            _context.SaveChanges();
            return "ok";
        }
        public string CreateSamuraiWithHorseByName(string samuraiName, string horseName)
        {
            var s = new Samurai {Name = samuraiName};
            s.horse = new Horse {Name = horseName};
            _context.Samurais.Add(s);
            _context.SaveChanges();
            return "ok";
        }

        public string UpdateSamurai(int samuraiId, Samurai samuraiDto)
        {
            return "ok";
        }

        public string DeleteSamurai(int samuraiId)
        {
            return "ok";
        }

        public string GetSamurai(int id)
        {
            return "ok";
        }
    }
}