using System;

namespace ArchUnitNetRecordTypes
{
    public abstract record ProductIdentityBase(string SerialNumber, string Name)
    {
        public ProductIdentityBase CopyWithNewName(string name)
        {
            return this with { Name = name };
        }

        public void HarmlessMethod()
        {
            Console.WriteLine(this);
        }
    }

    public record SomeProduct(string SerialNumber, string Name) : ProductIdentityBase(SerialNumber, Name);
}