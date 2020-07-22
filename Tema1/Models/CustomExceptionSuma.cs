using System;
using System.Runtime.Serialization;

namespace Tema1.Models
{
    
     class CustomExceptionSuma : Exception
    {
        public override string Message
        {
            get { return "suma>0"; }
        }
    }
}