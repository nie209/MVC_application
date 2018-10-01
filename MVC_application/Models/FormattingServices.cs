using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_application.Models
{
    public class FormattingServices
    {
        public string ReadableDate(DateTime date)
        {
            return date.ToString("d");
        }

    }
}
