using Test.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Test.Blazor
{
    public abstract class TestComponentBase : AbpComponentBase
    {
        protected TestComponentBase()
        {
            LocalizationResource = typeof(TestResource);
        }
    }
}
