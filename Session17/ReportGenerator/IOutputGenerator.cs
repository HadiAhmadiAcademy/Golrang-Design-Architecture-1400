using System.Text;

namespace ReportGenerator
{
    public interface IOutputGenerator
    {
        public void AddTitle(string title);
        public void Row(string row);
        public void Text(string text);
        public Report GenerateReport();
    }

    public class HtmlGenerator : IOutputGenerator
    {
        private StringBuilder _html = new StringBuilder();
        public void AddTitle(string title)
        {
            _html.Append($"<Head>{title}</Head>");
        }

        public void Row(string row)
        {
            throw new System.NotImplementedException();
        }

        public void Text(string text)
        {
            throw new System.NotImplementedException();
        }

        public Report GenerateReport()
        {
            throw new System.NotImplementedException();
        }
    }
}