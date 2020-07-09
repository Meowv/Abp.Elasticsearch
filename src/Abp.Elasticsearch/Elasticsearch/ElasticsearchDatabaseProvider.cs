using Elasticsearch.Net;
using Nest;
using System;
using System.Linq;

namespace Abp.Elasticsearch.Elasticsearch
{
    public class ElasticsearchDatabaseProvider : IElasticsearchDatabaseProvider
    {
        private readonly IElasticsearchSettings _settings;

        public ElasticsearchDatabaseProvider(IElasticsearchSettings settings)
        {
            _settings = settings;
        }

        ElasticClient _cachedClient = null;

        public ElasticClient GetClient()
        {
            if (_cachedClient != null)
                return _cachedClient;

            if (_settings.Nodes.Count == 0)
                throw new Exception("Elasticsearch 配置有误");

            if (_settings.Nodes.Count > 1)
            {
                var nodes = _settings.Nodes.Select(x => new Uri(x)).ToArray();
                var pool = new StaticConnectionPool(nodes);

                var settings = new ConnectionSettings(pool);
                _cachedClient = new ElasticClient(settings);
            }
            else
            {
                var node = _settings.Nodes.Select(x => new Uri(x)).FirstOrDefault();

                var settings = new ConnectionSettings(node);
                _cachedClient = new ElasticClient(settings);
            }
            return _cachedClient;
        }
    }
}