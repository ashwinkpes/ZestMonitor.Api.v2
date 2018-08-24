using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ZestMonitor.Api.Helpers;

namespace ZestMonitor.Api.Extensions
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, int currentPage,
        int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}