using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscoB.Commands
{
    public class Commands1 : BaseCommandModule
    {
        [Command("ping")]
        [Description("returns pong")]
        public async Task Ping(CommandContext commandContext)
        {
            await commandContext.Channel.SendMessageAsync("pong")
                .ConfigureAwait(false);
        }

        [Command("response")]
        public async Task RespondMessage(CommandContext commandContext)
        {
            var interactivity = commandContext.Client.GetInteractivity();
            var message = await interactivity.WaitForMessageAsync(x => x.Channel == commandContext.Channel)
                .ConfigureAwait(false);
            await commandContext.Channel.SendMessageAsync(message.Result.Content);
        }

        [Command("respondemoji")]
        public async Task RespondEmoji(CommandContext commandContext)
        {
            var interactivity = commandContext.Client.GetInteractivity();
            var message = await interactivity.WaitForReactionAsync(x => x.Channel == commandContext.Channel)
                .ConfigureAwait(false);
            await commandContext.Channel.SendMessageAsync(message.Result.Emoji);
        }   
    }
}
