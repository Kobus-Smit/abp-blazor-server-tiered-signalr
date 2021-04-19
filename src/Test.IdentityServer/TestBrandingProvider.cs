using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Test
{
    [Dependency(ReplaceServices = true)]
    public class TestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Test";
    }
}
