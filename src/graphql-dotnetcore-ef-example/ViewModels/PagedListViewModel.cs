using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLCMS.Database.Entities;

namespace GraphQLCMS.ViewModels
{
    public class PagedListViewModel<TViewModel>
    {
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
        public int IndexFrom { get; set; }
        public IEnumerable<TViewModel> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
    }
}
