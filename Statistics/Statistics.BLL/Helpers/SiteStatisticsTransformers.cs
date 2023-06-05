using Statistics.BLL.Models;
using Statistics.DAL.Entities;

namespace Statistics.BLL.Helpers
{
    public static class SiteStatisticsTransformers
    {
        public static SiteStatisticsResponse ToResponse(this SiteStatistics stats) => 
            new() { 
                LootBoxes = stats.LootBoxes,
                Reviews = stats.Reviews,
                Users = stats.Users,
                WithdrawnFunds = stats.WithdrawnFunds,
                WithdrawnItems = stats.WithdrawnItems
            };
        public static SiteStatisticsAdminResponse ToResponse(this SiteStatisticsAdmin stats) =>
            new()
            {
                BalanceWithdrawn = stats.BalanceWithdrawn,
                SentSites = stats.SentSites,
                TotalReplenished = stats.TotalReplenished,
            };
    }
}
