using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01
{
    public class StripeSecret
    {
        //variavel no ambiente windows
        public static readonly string StripeSecretKey = Environment.GetEnvironmentVariable("STRIPE_SECRET_KEY");
    }
}
