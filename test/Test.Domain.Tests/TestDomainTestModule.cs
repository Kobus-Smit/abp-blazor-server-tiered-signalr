using Test.MongoDB;
using Volo.Abp.Modularity;

namespace Test
{
    [DependsOn(
        typeof(TestMongoDbTestModule)
        )]
    public class TestDomainTestModule : AbpModule
    {

    }
}