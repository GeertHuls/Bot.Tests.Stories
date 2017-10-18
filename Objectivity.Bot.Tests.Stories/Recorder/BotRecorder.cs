namespace Objectivity.Bot.Tests.Stories.Recorder
{
    using System;
    using System.Linq;
    using Newtonsoft.Json.Linq;
    using Objectivity.Bot.Tests.Stories.Stories;

    internal class BotRecorder : IBotRecorder
    {
        private readonly StoryRecorder storyRecorder;

        public BotRecorder(StoryRecorder storyRecorder)
        {
            this.storyRecorder = storyRecorder;
        }

        public IStoryRecorder ListsOptions(Predicate<JObject> listPredicate = null)
        {
            this.storyRecorder.Story.AddStoryFrame(
                new BotStoryFrame(ComparisonType.AttachmentListPresent, listPredicate: listPredicate));
            return this.storyRecorder;
        }

        public IStoryRecorder ListsOptionsIncluding(params string[] options)
        {
            this.storyRecorder.Story.AddStoryFrame(
                new BotStoryFrame(
                    ComparisonType.AttachmentListPresent,
                    listPredicate: list =>
                    {
                        var availableOptions = list.SelectToken("buttons").Select(item => item["value"].ToString())
                            .ToList();

                        return options.All(option => availableOptions.Contains(option));
                    }));
            return this.storyRecorder;
        }

        public IStoryRecorder Says(string text)
        {
            this.storyRecorder.Story.AddStoryFrame(new BotStoryFrame(ComparisonType.TextExact, text));
            return this.storyRecorder;
        }
    }
}