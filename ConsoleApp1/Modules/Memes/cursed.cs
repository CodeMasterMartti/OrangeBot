﻿using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class cursed : ModuleBase<SocketCommandContext>
    {
        [Command("cursed")] // second word of command
        public async Task curse()
        {

            if (Context.Channel.Name == "memes")
            {

                var rand = new Random();
                var files = Directory.GetFiles("C:\\Users\\Aidan Johnsotn\\Dropbox\\IFTTT\\reddit\\shit");



                //Generating random number that favors being closer to 0;
                int i = rand.Next(files.Length);

                //Printing out random number in console
                Console.WriteLine(i);

                //Set message to contence of file, convert to type int
                string message = File.ReadAllText(files[i]);


                EmbedBuilder builder = new EmbedBuilder();
                builder.WithTitle(Path.GetFileNameWithoutExtension(files[i]))
                       .WithImageUrl(message)
                       .WithColor(Color.Orange);


                await ReplyAsync("", false, builder.Build());
            }
            else await ReplyAsync("Please use the channel #memes");
        }
    }
}
