
namespace ConnectDiscordBot.Service
{
    internal class AppEventHandler
    {

        public static async Task client_Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            await Task.CompletedTask;
        }



        public static async Task client_MessageReceived(SocketMessage arg)
        {
           
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_Client, message);



            int argPos = 0;
            if (message.HasStringPrefix("+", ref argPos))
            {

                var result = await _Command.ExecuteAsync(context, argPos, _Provider);
                if (!result.IsSuccess) Console.WriteLine(result.ErrorReason);
            }
        }


    }
}
