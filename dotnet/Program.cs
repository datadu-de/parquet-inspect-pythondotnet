namespace parquet_inspect_pythondotnet;

using Python.Runtime;



class Program
{

    static string pyPackages = @"/Users/frank/Code/parquet-inspect-pythondotnet/.venv/lib/python3.11/site-packages";

    public static void ReadSchema(string deltaTablePath)
    {
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
        using (Py.GIL())
        {
            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());
            sys.path.append(pyPackages);

            dynamic dl = Py.Import("deltalake");
            dynamic dt = dl.DeltaTable(deltaTablePath);
            dynamic result = dt.history(1);

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

        ReadSchema(deltaTablePath);
        ReadHistory(deltaTablePath);
    }
}