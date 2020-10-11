using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DownloadProblems
{
    class Program
    {
        //export default {
        //    uri: {
        //        us: {
        //            base: "https://leetcode.com/",
        //            login: "https://leetcode.com/accounts/login/",
        //            graphql: "https://leetcode.com/graphql",
        //            problemsAll: "https://leetcode.com/api/problems/all/",
        //            problem: "https://leetcode.com/problems/$slug",
        //            submit: "https://leetcode.com/problems/$slug/submit/",
        //            submission: "https://leetcode.com/submissions/detail/$id/",
        //        },
        //        cn: {
        //            base: "https://leetcode-cn.com/",
        //            login: "https://leetcode-cn.com/accounts/login/",
        //            graphql: "https://leetcode-cn.com/graphql",
        //            problemsAll: "https://leetcode-cn.com/api/problems/all/",
        //            problem: "https://leetcode-cn.com/problems/$slug",
        //            submit: "https://leetcode-cn.com/problems/$slug/submit/",
        //            submission: "https://leetcode-cn.com/submissions/detail/$id/",
        //        }
        //    }
        //};
        static readonly string DocFolder = @"../../../../Doc";
        static readonly string ProblemsFolder = Path.Combine(DocFolder, "Problems");
        static readonly string CShaprFolder = Path.Combine(DocFolder, "CSharp");
        const string ProblemsStatAPI = @"https://leetcode.com/api/problems/all/";
        const string ProblemDetailAPI = @"https://leetcode.com/graphql";

        class ProblemQueryPayload
        {
            public string operationName { get; } = "questionData";
            public object variables { get; }
            public string query { get; } = "query questionData($titleSlug: String!) {\n  question(titleSlug: $titleSlug) {\n    questionId\n    questionFrontendId\n    boundTopicId\n    title\n    titleSlug\n    content\n    translatedTitle\n    translatedContent\n    isPaidOnly\n    difficulty\n    likes\n    dislikes\n    isLiked\n    similarQuestions\n    contributors {\n      username\n      profileUrl\n      avatarUrl\n      __typename\n    }\n    topicTags {\n      name\n      slug\n      translatedName\n      __typename\n    }\n    companyTagStats\n    codeSnippets {\n      lang\n      langSlug\n      code\n      __typename\n    }\n    stats\n    hints\n    solution {\n      id\n      canSeeDetail\n      paidOnly\n      __typename\n    }\n    status\n    sampleTestCase\n    metaData\n    judgerAvailable\n    judgeType\n    mysqlSchemas\n    enableRunCode\n    enableTestMode\n    enableDebugger\n    envInfo\n    libraryUrl\n    adminUrl\n    __typename\n  }\n}\n";

            public ProblemQueryPayload(string slug)
            {
                variables = new { titleSlug = slug };
            }
        }

        static async Task Main(string[] args)
        {
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "-d":
                        await DownloadProblems();
                        break;
                    case "-2cs":
                        await Convert2CS();
                        break;
                    default:
                        Console.WriteLine("Not supported");
                        break;
                }
            }
            Console.ReadKey();
        }

        private static async Task Convert2CS()
        {
            foreach (var file in Directory.EnumerateFiles(ProblemsFolder, "*.json"))
            {
                var jsonContent = File.ReadAllText(file);

                var problem = JsonSerializer.Deserialize<Problem>(jsonContent, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                var question = problem.Data.Question;
                var snippet = question.CodeSnippets?.FirstOrDefault(s => s.LangSlug == "csharp")?.Code ?? string.Empty;
                var template = new ProblemTemplate(
                    int.Parse(question.QuestionFrontendId),
                    question.Title,
                    question.TitleSlug,
                    question.Content ?? string.Empty,
                    snippet
                    );
                var code = template.ToString();
                await File.WriteAllTextAsync(Path.Combine(CShaprFolder, template.CsFileName), code);
            }
        }

        private static async Task DownloadProblems()
        {
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer, UseCookies = true })
            {
                using (var client = new HttpClient(handler))
                {
                    // Step 1: download all problems from
                    var problemsJsonStr = await client.GetStringAsync(ProblemsStatAPI);
                    File.WriteAllText(Path.Combine(DocFolder, "AllProblems.json"), problemsJsonStr);
                    Console.WriteLine($"Problem list downloaded");

                    var problemsJsonDoc = JsonDocument.Parse(problemsJsonStr);
                    foreach (var statElement in problemsJsonDoc.RootElement.GetProperty("stat_status_pairs").EnumerateArray())
                    {
                        var stat = statElement.GetProperty("stat");
                        var title = stat.GetProperty("question__title").GetString();
                        var slug = stat.GetProperty("question__title_slug").GetString();
                        var frontId = stat.GetProperty("frontend_question_id").GetInt32();

                        // Step 2: download detail infor for each problem
                        var jsonFile = Path.Combine(ProblemsFolder, $"{frontId:D4}_{slug}.json");
                        if (!File.Exists(jsonFile))
                        {
                            var payload = new ProblemQueryPayload(slug);
                            var detailResponse = await client.PostAsync(ProblemDetailAPI, new StringContent(JsonSerializer.Serialize(payload), System.Text.Encoding.UTF8, "application/json"));
                            File.WriteAllText(Path.Combine(ProblemsFolder, $"{frontId:D4}_{slug}.json"), await detailResponse.Content.ReadAsStringAsync());
                            Console.WriteLine($"Problem {frontId:D4}_{slug} detail downloaded");
                        }
                    }
                }
            }
        }
    }
}
