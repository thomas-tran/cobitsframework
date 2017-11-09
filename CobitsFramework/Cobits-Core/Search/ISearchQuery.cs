namespace Cobits.Core.Search
{
    public interface ISearchQuery
    {
        string Query { get; set; }

        int PageSize { get; set; }

        int PageNumber { get; set; }
    }
}
