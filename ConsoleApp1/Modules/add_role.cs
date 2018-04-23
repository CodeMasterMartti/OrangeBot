using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("add_role")]
    public class add_role : ModuleBase<SocketCommandContext>
    {
        [Command("sub")]
        public async Task sub()
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "sub");
            if (Context.Channel.Name == "role-assignment")
            {

                await (Context.User as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"The role sub was given to {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }

        [Command("NSFW")]
        public async Task forbiden()
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "NSFW");
            if (Context.Channel.Name == "role-assignment")
            {

                await (Context.User as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"The role NSFW was given to {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
        [Command("friends")]
        public async Task friends()
        {

            var role = Context.Guild.Roles.FirstOrDefault(x => x.Name.ToString() == "Friends");
            if (Context.Channel.Name == "role-assignment")
            {

                await (Context.User as IGuildUser).AddRoleAsync(role);
                await ReplyAsync($"The role friends was given to {Context.User.Username}.");
            }
            else await ReplyAsync("Please use the channel #role-assignment");

        }
    }
}
