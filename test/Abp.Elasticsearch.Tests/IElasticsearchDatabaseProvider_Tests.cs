using Abp.Elasticsearch.Elasticsearch;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Xunit;

namespace Abp.Elasticsearch.Tests
{
    public class IElasticsearchDatabaseProvider_Tests
    {
        [Fact]
        public void GetClient()
        {
            using (var application = AbpApplicationFactory.Create<TestModule>())
            {
                application.Initialize();

                var provider = application.ServiceProvider.GetService<IElasticsearchDatabaseProvider>();

                var client = provider.GetClient();
                Assert.NotNull(client);
            }
        }
    }
}