using System;

namespace BlazorPaginationComponent.Helpers
{
    public static class PaginationHelper
    {
        private const string DisabledClassName = "disabled";

        public static int CalculateNumberOfPages(int totalItems, int pageSize)
        {
            return (int)Math.Ceiling(totalItems / (decimal)pageSize);
        }

        public static int GetPreviousPage(int currentPage)
        {
            return currentPage > 1 ? currentPage - 1 : currentPage;
        }

        public static int GetNextPage(int currentPage, int lastPage)
        {
            return currentPage < lastPage ? currentPage + 1 : currentPage;
        }

        public static string DisableForwardNavigation(int currentPage, int lastPage)
        {
            return currentPage >= lastPage ? DisabledClassName : string.Empty;
        }

        public static string DisableBackwardNavigation(int currentPage)
        {
            return currentPage <= 1 ? DisabledClassName : string.Empty;
        }
    }
}
