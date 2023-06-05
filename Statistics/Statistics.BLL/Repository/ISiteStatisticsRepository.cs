using Statistics.DAL.Entities;

namespace Statistics.BLL.Repository
{
    public interface ISiteStatisticsRepository
    {
        public Task<SiteStatistics> GetAsync();
        public Task<SiteStatisticsAdmin> GetAdminAsync();
    }
}
