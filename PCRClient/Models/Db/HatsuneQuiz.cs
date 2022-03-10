using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneQuiz
    {
        public long EventId { get; set; }
        public long QuizId { get; set; }
        public string QuestionTitle { get; set; } = null!;
        public string Question { get; set; } = null!;
        public string Choice1 { get; set; } = null!;
        public string Choice2 { get; set; } = null!;
        public string Choice3 { get; set; } = null!;
        public string Choice4 { get; set; } = null!;
        public string Choice5 { get; set; } = null!;
        public string Choice6 { get; set; } = null!;
        public long Answer { get; set; }
        public string Hint { get; set; } = null!;
        public long ResourceId { get; set; }
        public long ReleaseQuestId { get; set; }
        public long QuizPositionX { get; set; }
        public long QuizPositionY { get; set; }
        public long QuizIconId { get; set; }
        public string QuizPointName { get; set; } = null!;
        public long AdvIdQuizStart { get; set; }
        public long AdvIdQuizEnd { get; set; }
    }
}
