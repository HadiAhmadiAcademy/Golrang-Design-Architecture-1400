namespace TableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableBuilder = HtmlTableBuilder.Create();

            string table = tableBuilder
                .AddRow()
                    .AddCell().AddText("text 1")
                    .AddCell().AddText("text 2")
                    .AddCell().AddText("text 3")
                .AddRow()
                    .AddCell().AddText("text 4")
                .Build();
        }
    }
}
