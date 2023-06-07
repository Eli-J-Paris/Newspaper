using Newspaper.Models;

namespace Newspaper.Tests
{
    public class NewspaperTests
    {
        [Fact]
        public void CheckReporterProptiesAreCreated()
        {
            Issue issue1 = new Issue { Date = DateTime.Now, Articles = new List<Article> { } };
            Article article1 = new Article { Content = "world peace has arrived", Title = "World Peace", Issue = issue1 };
            Reporter lester = new Reporter { Name = "Lester", Speciality = "National", Articles = new List<Article> { article1 } };

            Assert.Equal("Lester", lester.Name);
            Assert.Equal("National", lester.Speciality);
            Assert.Equal(new List<Article> { article1 }, lester.Articles);
        }

        [Fact]
        public void CheckIssueProperitesAreCreated()
        {
            
            Issue issue1 = new Issue { Date = DateTime.Now, Articles = new List<Article> { } };
            DateTime time = issue1.Date;

            Assert.Equal(new List<Article>(), issue1.Articles);
            Assert.Equal(time, issue1.Date);

        }
        [Fact]
        public void CheckArticlePropertiesAreCreated()
        {
            Issue issue1 = new Issue { Date = DateTime.Now, Articles = new List<Article> { } };
            Article article1 = new Article { Content = "world peace has arrived", Title = "World Peace", Issue = issue1 };

            Assert.Equal("world peace has arrived", article1.Content);
            Assert.Equal("World Peace", article1.Title);
            Assert.Equal(issue1, article1.Issue);

        }
    }
}