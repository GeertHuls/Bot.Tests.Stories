namespace Objectivity.Bot.Tests.Stories.Stories
{
    using System.Collections.Generic;

    public interface IStory
    {
        IList<IStoryFrame> StoryFrames { get; }

        void AddStoryFrame(IStoryFrame storyFrame);
    }
}