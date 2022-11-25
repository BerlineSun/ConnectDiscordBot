using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConnectDiscordBot.Service
{
    internal class RunBot
    {

        public static async Task RunBotAsyne()
        {
            
            
             _Provider= new ServiceCollection()
                .AddSingleton(_Client)
                .AddSingleton(_Command)
                .BuildServiceProvider();

            string token = "token";   // <========== Enter Token

            _Client.Log += AppEventHandler.client_Log;

            await RegisterCommand();
            await _Client.LoginAsync(TokenType.Bot, token);
            await _Client.StartAsync();
            await Task.Delay(-1);
        }


        private static async Task RegisterCommand()
        {
            _Client.MessageReceived += AppEventHandler.client_MessageReceived;
            await _Command.AddModulesAsync(Assembly.GetEntryAssembly(), _Provider);
        }
    }
}
