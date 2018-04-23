using System;
using Discord.Net;
using Discord;
using System.Threading.Tasks;
using Discord.WebSocket;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OrangeBot
{
    class Program
    {
        static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;


        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            string Bottoken = "NDM3MDgxODEwMDU3NTYwMDY3.Db6jNQ.lrK53YtZXlk6dApJ2a_d6mNxD-Y";



            //Event Subscriptions

            _client.Log += Log;



            await RegisterCommandsAsync();

            await _client.LoginAsync(TokenType.Bot, Bottoken);
            await _client.StartAsync();
            int a = 0;
            while (a == 0) {
                await Task.Delay(10000);
                await _client.SetGameAsync("with my dad");
                await Task.Delay(10000);
                await _client.SetGameAsync("!help");
            }
            await Task.Delay(-1);
        }

        private Task Log(LogMessage arg)
        {
            Console.WriteLine(arg);

            return Task.CompletedTask;
        }

        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());


        }

        private async Task HandCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            if (message is null || message.Author.IsBot) return;

            int argpos = 0;

            if(message.HasStringPrefix("!", ref argpos) || message.HasMentionPrefix(_client.CurrentUser, ref argpos) || message.HasStringPrefix("", ref argpos))
            {
                var context = new SocketCommandContext(_client, message);

                var result = await _commands.ExecuteAsync(context, argpos, _services);

                if (!result.IsSuccess)
                {
                    Console.WriteLine(result.ErrorReason);
                }

            }
        }
    }
}
