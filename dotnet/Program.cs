namespace parquet_inspect_pythondotnet;

using Python.Runtime;



class Program
{

    static string pyPackages = @"/Users/frank/Code/parquet-inspect-pythondotnet/.venv/lib/python3.11/site-packages";

    public static void ListFiles(string deltaTablePath)
    {
        Console.WriteLine("ListFiles:");

        using (Py.GIL())
        {
            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());
            sys.path.append(pyPackages);

            dynamic dl = Py.Import("deltalake");
            dynamic dt = dl.DeltaTable(deltaTablePath);
            dynamic result = dt.files();

            Console.WriteLine(result);
        }
    }
    public static void ReadSchema(string deltaTablePath)
    {
        Console.WriteLine("ReadHistory:");

        using (Py.GIL())
        {
            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());
            sys.path.append(pyPackages);

            dynamic dl = Py.Import("deltalake");
            dynamic dt = dl.DeltaTable(deltaTablePath);
            dynamic result = dt.schema();

            Console.WriteLine(result);
        }
    }

    public static void ReadHistory(string deltaTablePath)
    {
        Console.WriteLine("ReadHistory:");

        using (Py.GIL())
        {
            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());
            sys.path.append(pyPackages);

            dynamic dl = Py.Import("deltalake");
            dynamic dt = dl.DeltaTable(deltaTablePath);
            dynamic result = dt.history();

            Console.WriteLine(result);
        }
    }
    public static void ReadMetadata(string deltaTablePath)
    {
        Console.WriteLine("ReadMetadata:");

        using (Py.GIL())
        {
            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());
            sys.path.append(pyPackages);

            dynamic dl = Py.Import("deltalake");
            dynamic dt = dl.DeltaTable(deltaTablePath);
            dynamic result = dt.metadata();

            Console.WriteLine(result);
        }
    }
    public static void CurrentAddActions(string deltaTablePath)
    {
        Console.WriteLine("CurrentAddActions:");

        using (Py.GIL())
        {
            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());
            sys.path.append(pyPackages);

            dynamic dl = Py.Import("deltalake");
            dynamic dt = dl.DeltaTable(deltaTablePath);
            dynamic result = dt.get_add_actions(true);

            Console.WriteLine(result);
        }
    }

    public static void Main()
    {
        string pyPath = @"/Users/frank/Code/parquet-inspect-pythondotnet/.venv/bin/python3.11";
        Runtime.PythonDLL = pyPath;

        PythonEngine.Initialize();

        Console.WriteLine("Hello, World!");

        string deltaTablePath = @"../data/delta-tables/sales_salesorderheader.delta";

        ListFiles(deltaTablePath);
        ReadSchema(deltaTablePath);
        ReadHistory(deltaTablePath);
        ReadMetadata(deltaTablePath);
        CurrentAddActions(deltaTablePath);
    }
}