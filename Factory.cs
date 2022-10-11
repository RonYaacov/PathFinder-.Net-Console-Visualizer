
using PathFinder.Models;

namespace PathFinder
{
    public static class Factory
    {
        public static ISearchResponse CreatePathResponse(int distanse,List<int[]> steps,
            bool success, ISearchResponse.SearchTypes searchType,string path)
        {
            return new SearchResponse(distanse, steps, success,searchType, path);
        }
        public static ISearchResponse CreateEmptyResponse()
        {
            return new SearchResponse(0, new List<int[]>(), false, null, "");
        }
    }
}
