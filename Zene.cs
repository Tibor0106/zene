using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zenesszar
{
    public class Zene
    {
        public static List<Szam> szams = new List<Szam>();
        public static ListBox ls;


        public static void ReadTxt()
        {
            try
            {
                string[] lines = File.ReadAllLines("lista.txt");


                foreach(var i in lines)
                {
                    var line = i.Split(';');
                    szams.Add(new Szam(line[0], line[1], line[2], line[3], line[4]));
                }
            }
            catch (Exception e) {
            }
          
        }

        public static void SaveUpdates()
        {
            List<string> lines = new List<string>();

            foreach(var i in szams) lines.Add($"{i.cim};{i.eloado};{i.mufaj};{i.hossz_min};{i.path}");

            File.WriteAllLines("lista.txt", lines);

        }

        public static void ListBoxLoad()
        {
            ls.Items.Clear();
            ls.Items.Add($"Cim      | Előadó    |  Műfaja   | Hossz   ");
            foreach (var i in szams) { 
                ls.Items.Add($"{i.cim}|{i.eloado}|{i.mufaj}|{i.hossz}");
            }
     
        }
        public struct Szam
        {
            public string cim, eloado,mufaj;
            public string hossz_min;
            public int hossz; //in seconds
            public string path;

            public Szam(string cim, string eloado, string mufaj, string hossz_min, string path)
            {
                this.cim = cim;
                this.eloado = eloado;
                this.mufaj = mufaj;
                this.hossz_min = hossz_min;
                this.hossz = MinToSec(hossz_min);
                this.path = path;

            }
            private int MinToSec(string _min)
            {
                int min = int.Parse(_min.Split(':')[0]);
                int secs = int.Parse(_min.Split(':')[1]);


                return (min * 60 ) + secs;
            }
        }
    }
}
