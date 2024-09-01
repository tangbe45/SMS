using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Domain.Exceptions
{
    class InternalServerException : Exception
    {
        public InternalServerException() :base("Internal Server Error") { }
    }
}
