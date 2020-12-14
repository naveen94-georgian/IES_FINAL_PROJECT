using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Constants
    {
        public const string Issuer = Audiance;
        public const string Audiance = "https://localhost:44388/";
        public const string Secret = "not_too_short_secret_otherwise_it_might_error";
    }
}
