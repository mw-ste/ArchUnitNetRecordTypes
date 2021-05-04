using ArchUnitNET.Loader;
using Xunit;

namespace ArchUnitNetRecordTypes.Should
{
    public class ArchUnitNetRecordShould
    {
        [Fact]
        public void CreateCopy()
        {
            const string serialNumber = "abc123";
            const string newName = "NewName";
            const string oldName = "OldName";

            var oldProduct = new SomeProduct(serialNumber, oldName);
            var newProduct = oldProduct.CopyWithNewName(newName);

            Assert.Equal(oldName, oldProduct.Name);
            Assert.Equal(newName, newProduct.Name);
            Assert.Equal(serialNumber, newProduct.SerialNumber);
        }

        [Fact]
        public void WorkWithRecordTypes()
        {
            var rootAssembly = typeof(ProductIdentityBase).Assembly;
            var assemblies = new ArchLoader().LoadAssembliesIncludingDependencies(rootAssembly);
            var _ = assemblies.Build();
        }
    }
}