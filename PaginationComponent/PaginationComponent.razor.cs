using Microsoft.AspNetCore.Components;
using BlazorPaginationComponent.Helpers;

namespace BlazorPaginationComponent
{
    public class PaginationComponentCode : ComponentBase
    {
        [Parameter] public int TotalItems { get; set; }
        [Parameter] public int CurrentPage { get; set; }
        [Parameter] public int PageSize { get; set; }
        [Parameter] public EventCallback<int> OnPageChange { get; set; }
        [Parameter] public string CustomClass { get; set; }

        public int LastPage { get; set; }

        protected override void OnInitialized()
        {
            LastPage = PaginationHelper.CalculateNumberOfPages(TotalItems, PageSize);
        }

        public string DisableBackwardNavigation()
        {
            return PaginationHelper.DisableBackwardNavigation(CurrentPage);
        }

        public string DisableForwardNavigation()
        {
            return PaginationHelper.DisableForwardNavigation(CurrentPage, LastPage);
        }

        public int GetNextPage()
        {
            return PaginationHelper.GetNextPage(CurrentPage, LastPage);
        }

        public int GetPreviousPage()
        {
            return PaginationHelper.GetPreviousPage(CurrentPage);
        }
    }
}
