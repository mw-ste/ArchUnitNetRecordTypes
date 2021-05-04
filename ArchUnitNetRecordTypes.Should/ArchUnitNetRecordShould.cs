using ArchUnitNET.Loader;
using Xunit;

namespace ArchUnitNetRecordTypes.Should
{
    public class ArchUnitNetRecordShould
    {
        [Fact]
        public void WorkWithRecordTypes()
        {
            var rootAssembly = typeof(ProductIdentityBase).Assembly;
            var assemblies = new ArchLoader().LoadAssembliesIncludingDependencies(rootAssembly);
            var _ = assemblies.Build();
        }
    }
}