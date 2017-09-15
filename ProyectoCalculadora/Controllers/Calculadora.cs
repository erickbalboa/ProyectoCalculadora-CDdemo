using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalculadora.Controllers
{
    public interface ICalculadora
    {
        int Suma(int a, int b);
    }

    public class Calculadora: ICalculadora
    {
        public int Suma(int a, int b)
        {
            return 3;
        }

        public int Division(int a, int b)
        {
            throw new Exception("Division entre 0");
        }
    }
}