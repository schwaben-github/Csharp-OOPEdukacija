/*using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosudbaApp
{
    // Prijatelji
    // dodavanje prijatelja
    Prijatelji prijatelj = new Prijatelji();
    prijatelj.Ime = "Matko";
prijatelj.Prezime = "Matković";
DBMethods.DodajPrijatelja(prijatelj);

*//*// izmjena prijatelja
Prijatelji prijatelj2 = new Prijatelji();
prijatelj2.PrijateljId = 5;
prijatelj2.Ime = "Igor";
prijatelj2.Prezime = "Igorovski";
DBMethods.IzmjeniPrijatelja(prijatelj2);

// brisanje prijatelja
DBMethods.ObrisiPrijatelja(11);*//*

IspisiPrijatelje();

    // Mediji
    // dodavanje medija
    Mediji mediji = new Mediji();
    mediji.MedijId = 76;
mediji.Naslov = "Šarmeri bez pokrića";
mediji.Tip = "Knjiga";
DBMethods.DodajMedij(mediji);

*//*// izmjena medija
Mediji mediji2 = new Mediji();
mediji2.MedijId = 4;
mediji2.Naslov = "The White Album";
mediji2.Tip = "CD";
DBMethods.IzmjeniMedij(mediji2);

// brisanje medija
DBMethods.ObrisiMedij(99);*//*

IspisiMedije();

    // Posudbe
    // dodavanje posudbe
    Posudbe posudba = new Posudbe();
    posudba.PosudbaId = 9;
posudba.DatumPosudbe = DateTime.Today;
posudba.DatumVracanja = null;
posudba.MedijId = 1;
posudba.PrijateljId = 2;
DBMethods.DodajPosudbu(posudba);

*//*// izmjena posudbe
Posudbe posudba2 = new Posudbe();
posudba2.PosudbaId = 10;
posudba2.DatumVracanja = DateTime.Today;
DBMethods.IzmjeniPosudbu(posudba2);

// brisanje posudbe
DBMethods.ObrisiPosudbu(10);*//*

    partial class Program
    {
        public static void IspisiPrijatelje()
        {
            //ponovni ispis prijatelja
            List<Prijatelji> prijatelji = DBMethods.DohvatiPrijatelje();
            foreach (var item in prijatelji)
            {
                Console.WriteLine($"Id: {item.PrijateljId}, Ime: {item.Ime}, Prezime {item.Prezime}");
            }
            Console.WriteLine("--------------------------------------------");
        }

        public static void IspisiMedije()
        {
            List<Mediji> mediji = DBMethods.DohvatiMedije();
            foreach (var item in mediji)
            {
                Console.WriteLine($"Id: {item.MedijId}, Naslov: {item.Naslov}, Tip: {item.Tip}");
            }
            Console.WriteLine("--------------------------------------------");
        }

        public static void IspisiPosudbe()
        {
            List<Posudbe> posudbe = DBMethods.DohvatiPosudbe();
            foreach (var item in posudbe)
            {
                Console.WriteLine($"Id: {item.PosudbaId}, Datum posudbe: {item.DatumPosudbe}, Datum vraćanja: {item.DatumVracanja}, MedijId: {item.MedijId}, PrijateljId: {item.PrijateljId}");
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
*/