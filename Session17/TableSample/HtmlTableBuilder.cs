namespace TableSample
{
    public class HtmlTableBuilder : ITableBuilder, ICellBuilder, IRowBuilder
    {
        private HtmlTableBuilder() { }
        public static ITableBuilder Create()
        {
            return new HtmlTableBuilder();
        }

        public IRowBuilder AddRow()
        {
            return this;
        }
        public IRowBuilder AddText(string text)
        {
            return this;
        }

        public ICellBuilder AddCell()
        {
            return this;
        }
        public string Build()
        {
            return "";
        }

    }
}