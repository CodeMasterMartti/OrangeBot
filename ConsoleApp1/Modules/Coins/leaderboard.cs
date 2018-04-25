using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class leaderboard : ModuleBase<SocketCommandContext>
    {
        [Command("leaderboard")]
        public async Task leader()
        {
            string path = "C:\\Users\\Aidan Johnsotn\\Desktop\\coins\\";

            //Get array of all file in folder
            var files = Directory.GetFiles($"{path}");

            //Bubble sort array depending on value inside files

            string temp = "";

            for (int i = 0; i < files.Length; i++)
            {
                for (int j = 0; j < files.Length - 1; j++)
                {
                    if (int.Parse(File.ReadAllText(files[i])) > int.Parse(File.ReadAllText(files[j])))
                    {
                        temp = files[j + 1];
                        files[j + 1] = files[j];
                        files[j] = temp;
                    }
                }
            }


            EmbedBuilder builder = new EmbedBuilder();
            builder.AddField("Global Leaderboard", "List top user coin users")
                   .AddField("🥇", $"{Path.GetFileNameWithoutExtension(files[files.Length])}: {int.Parse(File.ReadAllText(files[files.Length]))}")      //First
                   .AddField("🥈", $"{Path.GetFileNameWithoutExtension(files[files.Length-1])}: {int.Parse(File.ReadAllText(files[files.Length-1]))}")      //Second
                   .AddField("🥉", $"{Path.GetFileNameWithoutExtension(files[files.Length-2])}: {int.Parse(File.ReadAllText(files[files.Length-2]))}")
                   .WithColor(Color.Orange);
            await ReplyAsync("", false, builder.Build());


        }
    }
}