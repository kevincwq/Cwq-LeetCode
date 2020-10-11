using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DownloadProblems
{
    class ProblemTemplate
    {
        private static readonly string UrlFormat = "https://leetcode.com/problems/{0}/";
        private static readonly string ClassNameFormat = "N{0:D4}_{1}";
        private static readonly string ContentLineFormat = "    /// {0}";
        private static readonly string CodeSnippetLineFormat = "        {0}";
        private static readonly string NotImplement = "throw new NotImplementedException();";

        // {0} -- namespace
        // {1} -- content: each line starts with ///
        // {2} -- class name
        // {3} -- class template
        private static readonly string CodeTemplate =
 @"using System;
using System.Collections.Generic;

namespace {0}
{{
    /// <summary>
    /// link: {4}
    /// 
{1}
    /// </summary>
    public class {2}
    {{
{3}
    }}
}}";
        public int Id { get; }

        public string Title { get; }

        public string Name { get; }

        public string Slug { get; }

        public string Url { get; }

        public string Content { get; }

        public string ClassName { get; }

        public string Namespace { get; }

        public string CsFileName { get; }

        public string CodeSnippet { get; }

        public ProblemTemplate(int id, string title, string slug, string rawContent, string codeSnippet, string ns = "CSharpImpl")
        {
            Id = id;
            Title = title;
            Slug = slug;
            Url = string.Format(UrlFormat, slug);
            Content = FormatContent(rawContent);
            Name = FormatName(slug);
            ClassName = string.Format(ClassNameFormat, id, Name);
            CsFileName = ClassName + ".cs";
            CodeSnippet = FormatSnippet(codeSnippet);
            Namespace = ns;
        }

        private string FormatName(string slug)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(slug.ToLower().Replace("-", " ")).Replace(" ", string.Empty);
        }

        private string FormatContent(string rawContent)
        {
            var text = HtmlToText.ConvertHtml(rawContent);
            text = text.Replace("\r\n\r\n", "\r\n");
            var lines = text.Split("\n").Select(l => string.Format(ContentLineFormat, l.Trim()));
            return string.Join("\r\n", lines);
        }

        private string FormatSnippet(string rawSnippet)
        {
            if (string.IsNullOrEmpty(rawSnippet))
            {
                return string.Empty;
            }

            rawSnippet = rawSnippet.Replace("Solution", "Solution1");
            var lines = rawSnippet.Split('\n');
            var newLines = new List<string>();
            if (lines.Length > 0)
            {
                newLines.Add(string.Format(CodeSnippetLineFormat, lines.First()));
                for (int i = 1; i < lines.Length - 1; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i]) && lines[i - 1].Trim().EndsWith("{") && lines[i+1].Trim()=="}")
                    {
                        newLines.Add(string.Format(CodeSnippetLineFormat, lines[i] + NotImplement));
                    }
                    else
                    {
                        newLines.Add(string.Format(CodeSnippetLineFormat, lines[i]));
                    }
                }
                if (lines.Length > 1)
                {
                    newLines.Add(string.Format(CodeSnippetLineFormat, lines.Last()));
                }
            }
            return string.Join("\r\n", newLines);
        }

        public override string ToString()
        {
            return string.Format(CodeTemplate, Namespace, Content, ClassName, CodeSnippet, Url);
        }
    }
}
