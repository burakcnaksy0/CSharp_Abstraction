using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpOdev2.Classes;

namespace CSharpOdev2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            bmw.CokHızlıGit();  
            bmw.DenizdeYüzer();
            bmw.HavadaUcar();
            int bmw_yakıt = bmw.SaatlikToplamYakıt();

            Mercedes mercedes = new Mercedes();
            mercedes.HavadaUcar();
            mercedes.DenizdeYüzer();
            int mercedes_yakıt = mercedes.SaatlikToplamYakıt();

            Porsche porsche = new Porsche();
            porsche.HavadaUcar();
            int porsche_yakıt = porsche.SaatlikToplamYakıt();

            int toplam_yakıt = bmw_yakıt + mercedes_yakıt + porsche_yakıt;
            Console.WriteLine("toplam yakıt : "+toplam_yakıt);

            Console.WriteLine();

            GenelMüdür gm = new GenelMüdür();
            Müdür md = new Müdür();
            Programcı pc = new Programcı();
            Stajyer st = new Stajyer();

            int gm_maas = gm.maasinizNedir();
            int md_maas = md.maasinizNedir();
            int pc_maas = pc.maasinizNedir();
            int st_maas = st.maasinizNedir();

            int total_maas = gm_maas + md_maas + pc_maas + st_maas;
            Console.WriteLine("toplam maas : "+total_maas);

            Console.ReadLine();
        }
    }
}
