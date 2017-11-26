namespace SnipeSharp.Endpoints.SearchFilters
{
    public interface ISearchFilter
    {
        int? Limit { get; set; }
        int? Offset { get; set; }
        string Search { get; set; }
        string Sort { get; set; }
        string Order { get; set; }
        string GetQueryString();
    }
}
