using System;
using System.IO;
using System.Reflection;

namespace DotNetResourceRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = MethodBase.GetCurrentMethod().DeclaringType;
            string _namespace = type.Namespace;
            Assembly _assembly = Assembly.GetExecutingAssembly();
            string resourceName = _namespace + ".Files.Test.txt";
            Stream stream = _assembly.GetManifestResourceStream(resourceName);

            Console.WriteLine(stream.StreamToString());

        }
    }
}
