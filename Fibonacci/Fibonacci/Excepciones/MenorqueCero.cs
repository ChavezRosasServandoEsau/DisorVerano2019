using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Excepciones
{
    class MenorqueCero : Exception
    {

        public MenorqueCero() : base() {
            Console.WriteLine("No se puede obtener numero fibonacci menor que 0");
        
        }
        public MenorqueCero(string message) : base(message) { }
        public MenorqueCero(string message, System.Exception inner) : base(message, inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client. 
        protected MenorqueCero(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }


    }
}
