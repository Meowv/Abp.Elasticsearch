using Volo.Abp.Modularity;

namespace Abp.Elasticsearch.Tests
{
    [DependsOn(typeof(AbpElasticsearchModule))]
    public class TestModule : AbpModule
    {
    }
}