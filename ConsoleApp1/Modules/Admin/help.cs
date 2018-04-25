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
            builder.AddField("🍊OrangeBot Help", "This is the help hot line for help with OrangeBot Commands.  Type !help [command] for more information on certain commands")          //Set Title
                   .AddField("Role Commands", "!add_role, !remove_role")
                   .AddField("🤔Text Commands ", "!compliment, !insult, !quote, !respectcounter")
                   .AddField("🅱️Memes ", "!cat, !dankmeme, !meme, !surrealmeme")
                   .WithColor(Color.Orange);                                                                                                                                            //Set color to orange



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

        [Command("insult")] // Second word of command
        public async Task insult_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Insult", "OrangeBot drops the thiccest salt on you.")                                                             //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }

        [Command("compliment")] // Second word of command
        public async Task compliment_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Compliment", "OrangeBot tries to boosts your confidence.")                                                        //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }

        [Command("dankmeme")] // Second word of command
        public async Task dankmeme_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Dankmeme", "OrangeBot sends you the dankest of memes.")                                                           //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }

        [Command("cat")] // Second word of command
        public async Task cat_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Cat", "OrangeBot sends you some cute cats.")                                                                      //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }

        [Command("surrealmeme")] // Second word of command
        public async Task surrealmeme_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Surrealmeme", "O̥̙r͔̣̳̫̱̲̠a̼̝ͅņg̗̦͚̠e͎̟͕͈̪̝B̷͉o̧̦̤̦͈t̫̠ ̵̬̙s̶̬̞͕͚͔͇̩e̗͉n͙̫̬͔d͙͈s̱ ̥̪y̙͎̝̪̙̯̥o̰̯ụ̹̥̜ ̮̲̟̦͉̳ͅt̫̫̰͕̙̗͎͘o̠̙̰̫͔̞̮ ͕̟̙͝ͅt͕͔̜͓͢h̘e͏͉ ̙̲̮̜v̺͔̹͡o̧̦̞̘i̳̣̤d͉̬̰̪")                                                                  //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }

        [Command("respectcounter")] // Second word of command
        public async Task respectcounter_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Respect", "Displays the amount of respects paided")                                                             //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                  //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }


        [Command("meme")] // Second word of command
        public async Task meme_help()
        {
            //Set up Embed Builder
            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("OrangeBot Help: Meme", "Post a spicey meme")                                                                                      //Added Field to builder.  Title, Description
                   .WithColor(Color.Orange);                                                                                                                    //set color to orange
            await ReplyAsync("", false, builder.Build());     //Print EmbedBuilder, ReplyAsync takes in string, bool for TTS t/f, EmbedBuillder   

        }
    }
}
