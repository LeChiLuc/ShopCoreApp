using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCoreApp.Utilities.Dtos
{
    public abstract class PagedResultBase
    {
        public int CurrentPage { set; get; }

        public int PageCount {
            get {
                var pageCount = (double)RowCount / PageSize;
                return (int)Math.Ceiling(pageCount);
            }
            set
            {
                PageCount = value;
            }
        }

        public int PageSize { set; get; }

        public int RowCount { set; get; }

        public int FirstRowOnPage
        {
            get
            {
                return (CurrentPage - 1) * PageSize + 1;
            }
        }
        public int LastRowOnPage {
            get
            {
                return Math.Min(CurrentPage * PageSize, RowCount);
            } 
        }
    }
}
