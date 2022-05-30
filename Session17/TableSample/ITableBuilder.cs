using System;

namespace TableSample
{
    public interface ITableBuilder
    {
        IRowBuilder AddRow();
        string Build();
    }

    public interface IRowBuilder : ITableBuilder
    {
        ICellBuilder AddCell();
    }

    public interface ICellBuilder
    {
        IRowBuilder AddText(string text);
    }
}
