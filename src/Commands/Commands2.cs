using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscoB.Commands
{
    public class Commands2 : BaseCommandModule
    {
        [Command("join")]
        public async Task Join(CommandContext commandContext)
        {
           

            var joinMessage = await commandContext.Channel.SendMessageAsync(new DiscordEmbedBuilder
            {
                Title = "would u like to join?",
                Url = commandContext.Client.CurrentUser.AvatarUrl,
                Color = DiscordColor.Green
            }
            .ToString())
            .ConfigureAwait(false);

            

            await joinMessage.CreateReactionAsync(DiscordEmoji.FromName(commandContext.Client, ":+1:"))
                .ConfigureAwait(false);
            await joinMessage.CreateReactionAsync(DiscordEmoji.FromName(commandContext.Client, ":-1:"))
                .ConfigureAwait(false);
        }
    }
}
