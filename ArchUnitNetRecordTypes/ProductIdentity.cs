namespace ArchUnitNetRecordTypes
{
    public abstract record ProductIdentityBase(string SerialNumber, string Name)
    {
        public ProductIdentityBase CopyWithNewName(string name)
        {
            return this with { Name = name };
        }
    }
}