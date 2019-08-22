namespace CompositeMenu.Logging
{
    public interface ICompositeMenuConsole
    {
        void WriteLine(string message);

        string ReadKey();
    }
}