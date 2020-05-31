using System.Threading;
using System.Threading.Tasks;

namespace ProgramandoMinecraft
{
    static class Program
    {
        static readonly CancellationTokenSource Cts
            = new CancellationTokenSource();

        static async Task Main(string[] args)
        {
            var bot = new ProgramandoMinecraftBot();
            await bot.InitializeAsync();

            while (!Cts.IsCancellationRequested)
                await Task.Delay(1);

            await bot.ShutdownAsync();
        }
    }
}
