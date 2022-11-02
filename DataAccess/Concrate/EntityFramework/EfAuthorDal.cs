using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, SaphiraContext>, IAuthorDal
    {


    }
}