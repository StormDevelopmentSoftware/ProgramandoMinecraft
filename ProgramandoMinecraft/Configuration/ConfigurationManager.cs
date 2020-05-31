using System;
using System.IO;
using Newtonsoft.Json;

namespace ProgramandoMinecraft.Configuration
{
    public class ConfigurationManager
    {
        public ProgBotConfiguration BotConfiguration;

        protected readonly string path = Directory.GetCurrentDirectory() + "/config.json";

        public ConfigurationManager()
        {
            
        }

        public void LoadConfiguration()
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("O ficheiro de configuração do bot não existe! Foi criado um ficheiro em " + path);
                File.WriteAllText(path, JsonConvert.SerializeObject(new ProgBotConfiguration(), Formatting.Indented));
                Environment.Exit(0);
            }
            BotConfiguration = JsonConvert.DeserializeObject<ProgBotConfiguration>(File.ReadAllText(path));
            Console.WriteLine("O ficheiro de configuração foi carregado");
        }
    }
}
