namespace LSPLibrary
{
    public interface IManaged : IEmployee
    {
        public IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}
