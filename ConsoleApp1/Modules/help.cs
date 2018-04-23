using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    [Group("help")] // First word of command
    public class help : ModuleBase<SocketCommandContext>
    {
        [Command("")] // Second word of command, for when user enters just !help
        public async Task PingAsync()
        {
            //Create Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("OrangeBot Help")                 //Set Title
                .WithDescription("!add_role [role name]\n" +    //Set Description
                                 "!compliment\n" +
                                 "!remove_role [role name]\n" + 
                                 "!quote\n" + 
                                 "!respectcounter\n" +
                                 "!help [command]\n")

                .WithColor(Color.Orange);                       //Set color to orange
            await ReplyAsync("", false, builder.Build());       //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder

        }

        [Command("add_role")] // Second Word of command
        public async Task add_role_help()
        {
            //Create Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Add Role", "The add role command adds certain roles to the user. Currently the avaiable role to add are:")        //First line.  Title, Description//First line.  Title, Description
                   .AddInlineField("Friends", "*Gives access to most of the server*")                                                                           //Create and Inline Field.  Title, Decription
                   .AddInlineField("Sub", "*Subs for the team, gives access to #subs*")                                                                         //Create and Inline Field.  Title, Decription
                   .AddInlineField("NSFW", "*Gives access to the NSFW channel*")                                                                                //Create and Inline Field.  Title, Decription
                   .WithColor(Color.Orange);                                                                                                                    //Set color to orange
                
            await ReplyAsync("", false, builder.Build());       //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder
        }

        [Command("remove_role")] // Second word of command
        public async Task remove_role_help()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Remove Role", "The remove role command removes certain roles from the user.  The avalible roles to remove are:")  //First line.  Title, Description
                   .AddInlineField("Sub", "*Subs for the team, gives access to #subs*")                                                                         //Create and Inline Field.  Title, Decription
                   .AddInlineField("NSFW", "*Gives access to the NSFW channel*")                                                                                //Create and Inline Field.  Title, Decription
                   .AddInlineField("Friends", "*Removes access to server, don't remove this*")                                                                  //Create and Inline Field.  Title, Decription
                   .WithColor(Color.Orange);                                                                                                                    //Set color to orange

            await ReplyAsync("", false, builder.Build());       //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   
        }

        [Command("quote")] // Second word of command
        public async Task quote_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Quote", "Provide a pleasen quote from your local BC9 team")                                                       //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false , builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }

    }
}
