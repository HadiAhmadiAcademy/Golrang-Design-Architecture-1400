using System;
using System.IO;
using System.IO.Pipes;
using System.Net.Sockets;

namespace DecoratorSampleDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var bufferedStream = new BufferedStream(new MemoryStream());
        }
    }
}
