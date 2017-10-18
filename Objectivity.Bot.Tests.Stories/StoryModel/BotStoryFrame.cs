namespace Objectivity.Bot.Tests.Stories.Stories
{
    using System;
    using Newtonsoft.Json.Linq;

    public class BotStoryFrame : IStoryFrame
    {
        public BotStoryFrame(
            ComparisonType comparisonType,
            string text = null,
            Predicate<JObject> listPredicate = null)
        {
            this.Actor = Actor.Bot;
            this.ComparisonType = comparisonType;
            this.Text = text;
            this.ListPredicate = listPredicate;
        }

        public Actor Actor { get; }

        public ComparisonType ComparisonType { get; }

        public Predicate<JObject> ListPredicate { get; }

        public int OptionIndex { get; }

        public string OptionOutputPlaceholder { get; }

        public string Text { get; }
    }
}