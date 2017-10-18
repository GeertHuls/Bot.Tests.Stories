namespace Objectivity.Bot.Tests.Stories.Recorder
{
    using System;
    using Newtonsoft.Json.Linq;

    public interface IBotRecorder : IBaseActorRecorder
    {
        IStoryRecorder ListsOptions(Predicate<JObject> listPredicate = null);

        IStoryRecorder ListsOptionsIncluding(params string[] options);
    }
}