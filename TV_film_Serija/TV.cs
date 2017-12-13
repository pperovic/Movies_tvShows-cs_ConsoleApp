using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_film_Serija
{
    public class TV
    {

        public string Naziv { get; set; }
        public double Ocjena { get; set; }


        //Unos metoda
        public object Unos()
        {
            TV film = new TV();

            Console.Write("Naziv: ");
            film.Naziv = Console.ReadLine();
            Console.Write("Ocjena: ");
            film.Ocjena = double.Parse(Console.ReadLine());



            return film;   


           
        }






    }
}
