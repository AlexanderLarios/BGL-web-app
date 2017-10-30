using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Set_Works_PredictBGL.Models
{
    public class Log
    {
        // Since I am passing these all to http do I keep them as as a string?
        string token { get; set; }
        string value { get; set; }
        string log_type { get; set; }
        string other { get; set; }
        string time { get; set; }
        string notes { get; set; }

    }
}