using Test.MongoDB;
using Xunit;

namespace Test
{
    [CollectionDefinition(TestTestConsts.CollectionDefinitionName)]
    public class TestApplicationCollection : TestMongoDbCollectionFixtureBase
    {

    }
}
