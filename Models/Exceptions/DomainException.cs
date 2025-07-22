using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models.Exceptions
{
    public class DomainException : ArgumentException
    {
        public DomainException(string message) : base(message) { }
    }
}

