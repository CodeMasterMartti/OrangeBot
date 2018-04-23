using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

public class f : ModuleBase<SocketCommandContext>
{
    

    [Command("f")] //First word of command
    public async Task theletterf()
    {
        int count = 0; // count to zero
        
        //Open fcount.txt
        using (TextReader reader = File.OpenText("fcount.txt"))
        {
            //Set count equal to contents of file, converted to type int
           count = int.Parse(reader.ReadLine());
        }
        //Incriment count
        count++;

        //Convert count to string type
        string[] stringcount;
        stringcount = new string[1];

        //Convert to string array because File.WriteAllLines() takes in string[] not string
        stringcount[0] = count.ToString();

        File.WriteAllLines("fcount.txt", stringcount);

    }
}