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
    public class ContactUsManager:IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetAllList()
        {
            return _contactUsDal.GetAllList();  
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactUs entity)
        {
            throw new NotImplementedException();
        }
    }
}
