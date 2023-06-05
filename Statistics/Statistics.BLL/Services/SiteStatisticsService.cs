using Statistics.BLL.Helpers;
using Statistics.BLL.Models;
using Statistics.BLL.Repository;
using Statistics.DAL.Entities;

namespace Statistics.BLL.Services
{
    public class SiteStatisticsService : ISiteStatisticsService
    {
        private readonly ISiteStatisticsRepository _siteStatisticsRepository;

        public SiteStatisticsService(ISiteStatisticsRepository siteStatisticsRepository)
        {
            _siteStatisticsRepository = siteStatisticsRepository;
        }

        public async Task<SiteStatisticsResponse> GetAsync()
        {
            SiteStatistics statistics = await _siteStatisticsRepository.GetAsync();

            return statistics.ToResponse();
        }

        public async Task<SiteStatisticsAdminResponse> GetAdminAsync()
        {
            SiteStatisticsAdmin statisticsAdmin = await _siteStatisticsRepository.GetAdminAsync();

            return statisticsAdmin.ToResponse();
        }
    }
}
