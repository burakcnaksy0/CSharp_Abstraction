using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOdev2.İnterfaces;

namespace CSharpOdev2.Classes
{
    public class Porsche : IHavadaUç , IArabaYakıtDurumu
    {
        public void HavadaUcar()
        {
            Console.WriteLine("havada uçar.");
        }

        public int SaatlikToplamYakıt()
        {
            return 60;
        }
    }
}
