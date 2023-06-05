namespace Statistics.DAL.Entities
{
    public class SiteStatistics : BaseEntity
    {
        public int Users { get; set; } = 0;
        public int Reviews { get; set; } = 0;
        public int LootBoxes { get; set; } = 0;
        public int WithdrawnItems { get; set; } = 0;
        public int WithdrawnFunds { get; set; } = 0;
    }
}
