using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class f : ModuleBase<SocketCommandContext>
{
    

    [Command("f")]
    public async Task theletterf()
    {
        int count = 0;
        
        using (TextReader reader = File.OpenText("fcount.txt"))
        {
           count = int.Parse(reader.ReadLine());
        }
        
        count++;


        string[] stringcount;
        stringcount = new string[1];
        stringcount[0] = count.ToString();

        File.WriteAllLines("fcount.txt", stringcount);

    }
}