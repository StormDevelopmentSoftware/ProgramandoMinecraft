using System.Threading.Tasks;
using DSharpPlus;
using ProgramandoMinecraft.Configuration;

namespace ProgramandoMinecraft
{
    public class ProgramandoMinecraftBot
    {
        public ConfigurationManager ConfigurationManager;
        public DiscordClient Client;

        public ProgramandoMinecraftBot()
        {
            ConfigurationManager = new ConfigurationManager();
        }

        public async Task InitializeAsync()
        {
            ConfigurationManager.LoadConfiguration();

            var discordConfig = new DiscordConfiguration
            {
                Token = ConfigurationManager.BotConfiguration.Token,
                AutoReconnect = ConfigurationManager.BotConfiguration.AutoReconnect
            };

            Client = new DiscordClient(discordConfig);

            await Client.ConnectAsync();
        }

        public async Task ShutdownAsync()
        {
            await Client.DisconnectAsync();
        }
    }
}
