using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Xunit;

namespace Abp.Elasticsearch.Tests
{
    public class ElasticsearchTests
    {
        [Fact]
        public void Elasticsearch_Service_Test()
        {
            var service = GetElasticsearchService();

            //service...

            Assert.NotNull(service);
        }

        private static IElasticsearchService GetElasticsearchService()
        {
            var application = AbpApplicationFactory.Create<TestModule>();
            application.Initialize();

            return application.ServiceProvider.GetService<IElasticsearchService>();
        }
    }
}