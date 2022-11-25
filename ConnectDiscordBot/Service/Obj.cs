using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDiscordBot.Service
{
    internal class Obj
    {
     public  static DiscordSocketClient _Client = new DiscordSocketClient();
     public static  CommandService _Command = new CommandService();
     public static  IServiceProvider? _Provider;
        
    }
}
