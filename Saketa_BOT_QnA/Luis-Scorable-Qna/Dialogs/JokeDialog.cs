using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace Scorable.Dialogs
{
    [Serializable]
    public class JokeDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            // Confirmation that we're in the JokeDialog, forwarded from the LUIS dialog
            string response = "Who stole the Marker?  Marker Chor!!";

            context.PostAsync(response);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
        }
    }
}