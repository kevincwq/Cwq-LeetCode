using System.Collections.Generic;

namespace DownloadProblems
{
    public class TopicTag
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string TranslatedName { get; set; }
    }

    public class CodeSnippet
    {
        public string Lang { get; set; }
        public string LangSlug { get; set; }
        public string Code { get; set; }
    }

    public class Solution
    {
        public string Id { get; set; }
        public bool CanSeeDetail { get; set; }
        public bool PaidOnly { get; set; }
    }

    public class Question
    {
        public string QuestionId { get; set; }
        public string QuestionFrontendId { get; set; }
        public string BoundTopicId { get; set; }
        public string Title { get; set; }
        public string TitleSlug { get; set; }
        public string Content { get; set; }
        public string TranslatedTitle { get; set; }
        public string TranslatedContent { get; set; }
        public bool IsPaidOnly { get; set; }
        public string Difficulty { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string SimilarQuestions { get; set; }
        public List<object> Contributors { get; set; }
        public List<TopicTag> TopicTags { get; set; }
        public string CompanyTagStats { get; set; }
        public List<CodeSnippet> CodeSnippets { get; set; }
        public string Stats { get; set; }
        public List<string> Hints { get; set; }
        public Solution Solution { get; set; }
        public string Status { get; set; }
        public string SampleTestCase { get; set; }
        public string MetaData { get; set; }
        public bool JudgerAvailable { get; set; }
        public string JudgeType { get; set; }
        public List<string> MysqlSchemas { get; set; }
        public bool EnableRunCode { get; set; }
        public bool EnableTestMode { get; set; }
        public bool EnableDebugger { get; set; }
        public string EnvInfo { get; set; }
        public string LibraryUrl { get; set; }
        public string AdminUrl { get; set; }
    }

    public class Data
    {
        public Question Question { get; set; }
    }

    public class Problem
    {
        public Data Data { get; set; }
    }
}
