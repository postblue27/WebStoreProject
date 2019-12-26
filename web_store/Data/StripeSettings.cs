using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace web_store.Data
{
    public class StripeSettings 
    {
       public string SecretKey {get; set; }
       public string PublishableKey { get; set; }
    }
}
