namespace Statistics.BLL.Models
{
    public class SiteStatisticsAdminResponse
    {
        public decimal BalanceWithdrawn { get; set; } = 0;
        public decimal TotalReplenished { get; set; } = 0;
        public decimal SentSites { get; set; } = 0;
    }
}
