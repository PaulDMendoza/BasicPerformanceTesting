namespace Tester
{
    public interface ITester
    {
        void Run();
        string Description { get; }
    }
}