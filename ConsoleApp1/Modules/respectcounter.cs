using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class respectcounter : ModuleBase<SocketCommandContext>
{
    

    [Command("respectcounter")]
    public async Task theletter()
    {
        int count = 0;

        using (TextReader reader = File.OpenText("fcount.txt"))
        {
            count = int.Parse(reader.ReadLine());
        }

        await ReplyAsync($"{count} respects have been paid");

       

    }
}