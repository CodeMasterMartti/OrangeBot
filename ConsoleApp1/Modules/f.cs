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
        string stringcount = count.ToString();

        // Write new count to file
        await File.WriteAllTextAsync("fcount.txt", stringcount);

    }
}