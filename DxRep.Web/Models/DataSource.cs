using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DxRep.Infrastructure;

namespace DxRep.Web.Models
{
    public class DataSource<T>
    {
        public DataSource(IPagedList<T> list)
        {
            Pagination = new Pagination
            {
                TotalCount = list.TotalCount,
                TotalPages = list.TotalPages,
                Page = list.PageIndex + 1,
                Offset = list.PageSize
            };
        }
        public object ExtraData { get; set; }

        public IEnumerable Data { get; set; }

        public object Errors { get; set; }

        public Pagination Pagination { get; set; }
    }
}