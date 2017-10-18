namespace Objectivity.Bot.Tests.Stories.Recorder
{
    using Objectivity.Bot.Tests.Stories.Stories;

    public interface IStoryRecorder
    {
        IBotRecorder Bot { get; }

        IUserRecorder User { get; }

        IStory Rewind();
    }
}