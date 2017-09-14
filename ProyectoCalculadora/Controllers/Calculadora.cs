using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalculadora.Controllers
{
    public class Calculadora
    {   
        public int Suma(int a, int b)
        {
            return (a + b);
        }

        public int Division(int a, int b)
        {
            if (b == 0)
                throw new Exception("mesage");
            return 0;  
        }
    }
}