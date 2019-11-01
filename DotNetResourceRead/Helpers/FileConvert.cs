
using System.IO;

namespace DotNetResourceRead
{
    public static class FileConvert
    {
        public static string StreamToString(this Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}