using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerBusinessLayer.Concrette
{
    public class VisitOurFirmManager : IVisitOurFirmService
    {
        private readonly IVisitOurFirmDal _visitOurFirmDal;
        public VisitOurFirmManager(IVisitOurFirmDal visitOurFirmDal)
        {
            _visitOurFirmDal = visitOurFirmDal;
        }

        public void TAdd(VisitOurFirm entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<VisitOurFirm> TGetAllList()
        {
            return _visitOurFirmDal.GetAllList();
        }

        public VisitOurFirm TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(VisitOurFirm entity)
        {
            throw new NotImplementedException();
        }
    }
}
