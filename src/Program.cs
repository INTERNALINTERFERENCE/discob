using System;

namespace DiscoB
{
    class Program
    {
        static void Main(string[] args)
            => new Bot().RunAsync().GetAwaiter().GetResult();
    }
}
