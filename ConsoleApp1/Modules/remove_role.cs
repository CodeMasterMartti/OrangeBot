using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("remove_role")]
    public class remove_role : ModuleBase<SocketCommandContext>
    {
        [Command("sub")]
        public async Task sub()
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "Sub");
            if (Context.Channel.Name == "role-assignment")
            {

                await (Context.User as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync($"The role Sub was removed from {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }

        [Command("NSFW")]
        public async Task forbiden()
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "NSFW");
            if (Context.Channel.Name == "role-assignment")
            {

                await (Context.User as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync($"The role NSFW was removed from {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
        [Command("friends")]
        public async Task friends()
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "friends");
            if (Context.Channel.Name == "role-assignment")
            {

                await (Context.User as IGuildUser).RemoveRoleAsync(role);
                await ReplyAsync($"The role friends was removed from {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
    }
}
