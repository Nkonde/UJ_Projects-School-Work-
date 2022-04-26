using System;
using System.Collections.Generic;
using System.Text;

namespace TYPMobileApp.Models
{
    public class StripeCard
    {
        public string SCNumber { get; set;  }
        public long SCExpiry { get; set;  }
        public string SCCvc { get; set;  }
    }
}
