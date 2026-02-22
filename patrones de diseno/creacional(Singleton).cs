public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() { } // Constructor privado para evitar 'new' externo

    public static Logger Instance
    {
        get
        {
            lock (_lock) // Hilo seguro
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }
        }
    }

    public void Log(string message) => Console.WriteLine(message);
}

