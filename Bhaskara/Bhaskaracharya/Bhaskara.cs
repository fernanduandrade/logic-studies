using System.Numerics;
using System;

namespace Bhaskaracharya
{
    public class Bhaskara
    {
        private int _coeficienteA {get;}
        private int _coeficienteB {get;}
        private int _coeficienteC {get;}
        public Bhaskara(int coeficienteA, int coeficienteB, int coeficienteC)
        {
            _coeficienteA = coeficienteA;
            _coeficienteB = coeficienteB;
            _coeficienteC = coeficienteC;
        }

        public int[] calcularRaizaes(int delta) 
        {
            
            int xPositivo = (-(_coeficienteB) + (int)Math.Sqrt(delta)) / (2 * _coeficienteA);
            int xNegativo = (-(_coeficienteB) - (int)Math.Sqrt(delta)) / (2 * _coeficienteA);

            return new int[] {xPositivo, xNegativo};
        }

        public int discritante() 
        {
            int delta = (_coeficienteB * _coeficienteB) - (4 * _coeficienteA * _coeficienteC);

            return delta;
        }

        public int[] resultadoNegativo(int delta)
        {
            int valorDefault = 0;
        
            return new int[] {valorDefault};
        }
    }
}