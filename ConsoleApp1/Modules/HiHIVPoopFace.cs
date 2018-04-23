using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class HiHIVPoopFace : ModuleBase<SocketCommandContext>
{


    [Command("Hello everyone.")]
    public async Task hi()
    {
        if (Context.User.Username == "HIVpoopface")
            await ReplyAsync($"Hello {Context.User.Username}.");
        //Do nothing
    }
}