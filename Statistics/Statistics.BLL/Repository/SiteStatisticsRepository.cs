using MongoDB.Driver;
using Statistics.DAL.Entities;

namespace Statistics.BLL.Repository
{
    public class SiteStatisticsRepository : ISiteStatisticsRepository
    {
        private readonly IMongoCollection<SiteStatistics> _siteStatistics;
        private readonly IMongoCollection<SiteStatisticsAdmin> _siteStatisticsAdmin;

        public SiteStatisticsRepository(IMongoClient client)
        {
            IMongoDatabase database = client.GetDatabase("InCaseStatistics");

            _siteStatistics = database
                .GetCollection<SiteStatistics>("Site");
            _siteStatisticsAdmin = database
                .GetCollection<SiteStatisticsAdmin>("AdminSite");
        }

        public async Task<SiteStatistics> GetAsync()
        {
            SiteStatistics? statistics = await _siteStatistics
                .Find("{}")
                .FirstOrDefaultAsync();

            if (statistics is null)
                await _siteStatistics.InsertOneAsync(new SiteStatistics());

            return statistics ?? new();
        }

        public async Task<SiteStatisticsAdmin> GetAdminAsync()
        {
            SiteStatisticsAdmin? statistics = await _siteStatisticsAdmin
                .Find("{}")
                .FirstOrDefaultAsync();

            if (statistics is null)
                await _siteStatisticsAdmin.InsertOneAsync(new SiteStatisticsAdmin());

            return statistics ?? new();
        }
    }
}
