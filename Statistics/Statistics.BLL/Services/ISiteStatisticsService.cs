using Statistics.BLL.Models;

namespace Statistics.BLL.Services
{
    public interface ISiteStatisticsService
    {
        public Task<SiteStatisticsResponse> GetAsync();
        public Task<SiteStatisticsAdminResponse> GetAdminAsync();
    }
}
