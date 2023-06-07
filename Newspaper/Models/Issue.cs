using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; } = new();

        public int ArticleCount()
        {
            int articleCount = Articles.Count();
            return articleCount;
        }

        public int ReporterCount()
        {
            List<string> reporters = new List<string>();
            foreach(var article in Articles)
            {
                reporters.Add(article.Reporter.Name);
            }
            return reporters.Count;
        }

        public List<string> ReporterNames()
        {
            List<string> reporters = new List<string>();
            foreach (var article in Articles)
            {
                reporters.Add(article.Reporter.Name);
            }
            return reporters;
        }
    }
}
