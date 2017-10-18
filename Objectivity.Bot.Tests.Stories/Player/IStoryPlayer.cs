namespace Objectivity.Bot.Tests.Stories.Player
{
    using System.Threading;
    using System.Threading.Tasks;
    using Objectivity.Bot.Tests.Stories.Stories;

    public interface IStoryPlayer
    {
        Task<IStoryResult> Play(IStory story, CancellationToken cancellationToken = default(CancellationToken));
    }
}