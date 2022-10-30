using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ImpulseCS.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ImpulseCS.App());
            host.Run();
        }
    }
}
