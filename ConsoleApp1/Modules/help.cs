using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("help")]
    public class help : ModuleBase<SocketCommandContext>
    {
        [Command("")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("OrangeBot Help")
                .WithDescription("!add_role [role name]\n" + 
                                 "!compliment\n" +
                                 "!remove_role [role name]\n" + 
                                 "!quote\n" + 
                                 "!respectcounter\n" +
                                 "!help [command]\n")

                .WithColor(Color.Orange);
            await ReplyAsync("", false, builder.Build());

        }
        [Command("add_role")]
        public async Task add_role_help()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Add Role", "The add role command adds certain roles to the user. Currently the avaiable role to add are:")
                   .AddInlineField("Friends", "*Gives access to most of the server*")
                   .AddInlineField("Sub", "*Subs for the team, gives access to #subs*")
                   .AddInlineField("NSFW", "*Gives access to the NSFW channel*")
                   .WithColor(Color.Orange);

            await ReplyAsync("", false, builder.Build());
        }
        [Command("remove_role")]
        public async Task remove_role_help()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Remove Role", "The remove role command removes certain roles from the user.  The avalible roles to remove are:")
                   .AddInlineField("Friends", "*Gives access to most of the server*")
                   .AddInlineField("Sub", "*Subs for the team, gives access to #subs*")
                   .AddInlineField("NSFW", "*Gives access to the NSFW channel*")
                   .WithColor(Color.Orange);

            await ReplyAsync("", false, builder.Build());
        }
        [Command("quote")]
        public async Task quote_help()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Quote", "Provide a pleasen quote from your local BC9 team")
                   .WithColor(Color.Orange);
            await ReplyAsync("", false , builder.Build());

        }

    }
}
