using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
     //First word of command
    public class Question : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        [Command("ask")] // second word of command
        public async Task one(string ask)
        {
            int ran = rand.Next(1, 2);
            if (ran == 1) await ReplyAsync("yes");
            if (ran == 2) await ReplyAsync("no");





        }

        

    }
}
