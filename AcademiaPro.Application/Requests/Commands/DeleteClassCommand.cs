using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Application.Requests.Commands
{
    public class DeleteClassCommand : IRequest
    {
        public int Id  { get; set; }
    }
}
