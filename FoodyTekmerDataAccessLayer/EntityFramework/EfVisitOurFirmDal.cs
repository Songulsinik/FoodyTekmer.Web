using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Repository;
using FoodyTekmerEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerDataAccessLayer.EntityFramework
{
    public class EfVisitOurFirmDal:GenericRepository<VisitOurFirm>,IVisitOurFirmDal
    {
    }
}
