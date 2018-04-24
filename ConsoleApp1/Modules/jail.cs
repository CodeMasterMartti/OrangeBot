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
        // Start DateTime of current jail-train
        DateTime jailStart = DateTime.MinValue;
        // Max TimeSpan between jail-trains, set to 1 minute
        TimeSpan maxTime = new TimeSpan(0, 1, 0);

        [Command("jail")] // Command Trigger
        public async Task Jail()
        {
            // Get DateTime of current jail call
            DateTime currJail = DateTime.Now;

            // Start time tracking if first jail call
            if (jailCount == 0)
            {
                // Set jail-train start
                jailStart = currJail;
            }

            // Check if still within max time of jail-train
            if (currJail - jailStart <= maxTime)
            {
                // If 3rd jail call, call cops
                if (jailCount++ == 3)
                {
                    // Call the cops
                    await ReplyAsync("🚨 JAIL 🚨");
                    // Reset counter
                    jailCount = 0;
                }
            }
            else // No longer within time window
            {
                // Reset counter to first jail
                jailCount = 1;
                // Reset time tracking
                jailStart = currJail;
            }
        }
    }
}
