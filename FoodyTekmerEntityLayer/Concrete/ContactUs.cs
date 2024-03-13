using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerEntityLayer.Concrete
{
    public class ContactUs
    {
        public int ContactUsId { get; set; }
        public string? ContactUsName { get; set; }
        public string? ContactUsEmail { get; set;}
        public string? ContactUsSubject { get; set;}
        public string? ContactUsMessage { get; set;}
    }
}
