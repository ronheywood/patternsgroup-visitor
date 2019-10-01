namespace StarbuzzBaristaManual.Logging
{
    public interface IConsole
    {
        void WriteLine(string message);

        string ReadKey();
    }
}