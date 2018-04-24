using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrangeBot.Modules
{
    class jail : ModuleBase<SocketCommandContext>
    {
        // Counter for number of times jail has been said
        int jailCount = 0;
        // DateTime for last time 'jail' was said
        DateTime lastJail = DateTime.MinValue;
        // Max TimeSpan between 'jail's, set to 1 minute
        TimeSpan maxTime = new TimeSpan(0, 1, 0);

        [Command("jail")] // Command Trigger
        public async Task Jail()
        {
            // Get current DateTime for 'jail' trigger
            DateTime currJail = DateTime.Now;

            // If 'jail' has been said 3 times, 1 minute apart for one another
            if (jailCount++ == 3 && (currJail - lastJail <= maxTime))
            {
                await ReplyAsync(@"\u1F6A8 JAIL \u1F6A8");
                jailCount = 0;
            }

            // Update lastJail
            lastJail = currJail;
        }
    }
}
