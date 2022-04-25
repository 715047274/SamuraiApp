namespace SamuraiApp.Domain
{
    public class SamuraiBattleStat : BaseEntity
    {
        public string Name { get; set; }
        public int? NumOfBattles { get; set; }
        public string EarliestBatte { get; set; }
    }
}