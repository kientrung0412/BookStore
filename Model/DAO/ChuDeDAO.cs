using System;
using System.Collections.Generic;
using System.Linq;
using Model.EF;

namespace Model.DAO
{
    public class ChuDeDAO
    {
        public BookstoreDbContext DbContext;

        public ChuDeDAO()
        {
            DbContext= new BookstoreDbContext();
        }

        public List<ChuDe> List()
        {
            var list = DbContext.ChuDes.ToList();
            return list;
        }

        // public String ToJson()
        // {
        //     var json = DbContext.ChuDes.
        // }
    }
}