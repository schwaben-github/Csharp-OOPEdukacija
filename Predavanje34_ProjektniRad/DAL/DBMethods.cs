using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DbMethods
    {
        //CRUD operacije - Create, Read, Update, Delete

        #region Prijatelji
        //READ
        public static List<Prijatelji> DohvatiPrijatelje()
        {
            List<Prijatelji> prijatelji = new List<Prijatelji>();
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    prijatelji.AddRange(context.Prijatelji);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
            return prijatelji;
        }

        public static int DohvatiIdPrijatelja(string ime, string prezime)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Prijatelji prijateljIzBaze = context.Prijatelji.FirstOrDefault(
                        x => x.Ime == ime && x.Prezime == prezime);
                    if (prijateljIzBaze != default)
                    {
                        return prijateljIzBaze.PrijateljId;
                    }
                    else
                    {
                        throw new Exception("Prijatelj nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
                return -1;
            }
        }

        //CREATE
        public static void DodajPrijatelja(Prijatelji prijatelj)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    context.Prijatelji.Add(prijatelj);
                    context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }

        //UPDATE
        public static void IzmjeniPrijatelja(Prijatelji prijatelj)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Prijatelji prijateljIzBaze = context.Prijatelji.FirstOrDefault(
                        x => x.PrijateljId == prijatelj.PrijateljId);
                    if (prijateljIzBaze != default)
                    {
                        prijateljIzBaze.Ime = prijatelj.Ime;
                        prijateljIzBaze.Prezime = prijatelj.Prezime;
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Prijatelj nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }

        //brisanje prijatelja
        public static void ObrisiPrijatelja(int id)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Prijatelji prijateljIzBaze = context.Prijatelji.FirstOrDefault(
                        x => x.PrijateljId == id);
                    if (prijateljIzBaze != default)
                    {
                        context.Prijatelji.Remove(prijateljIzBaze);
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Prijatelj nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }
        #endregion

        #region Mediji
        public static List<Mediji> DohvatiKolekcije()
        {
            List<Mediji> kolekcije = new List<Mediji>();
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    kolekcije.AddRange(context.Mediji);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
            return kolekcije;
        }

        public static int DohvatiIdKolekcije(string naslov)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Mediji kolekcijaIzBaze = context.Mediji.FirstOrDefault(
                        x => x.Naslov == naslov);
                    if (kolekcijaIzBaze != default)
                    {
                        return kolekcijaIzBaze.MedijId;
                    }
                    else
                    {
                        throw new Exception("Naslov nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
                return -1;
            }
        }

        public static void DodajKolekciju(Mediji kolekcija)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    context.Mediji.Add(kolekcija);
                    context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }

        public static void IzmjeniKolekciju(Mediji kolekcija)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Mediji kolekcijaIzBaze = context.Mediji.FirstOrDefault(
                        x => x.MedijId == kolekcija.MedijId);
                    if (kolekcijaIzBaze != default)
                    {
                        kolekcijaIzBaze.Naslov = kolekcija.Naslov;
                        kolekcijaIzBaze.Tip = kolekcija.Tip;
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Naslov nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }

        public static void ObrisiKolekciju(int id)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Mediji kolekcijaIzBaze = context.Mediji.FirstOrDefault(
                        x => x.MedijId == id);
                    if (kolekcijaIzBaze != default)
                    {
                        context.Mediji.Remove(kolekcijaIzBaze);
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Naslov nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }

        }
        #endregion

        #region Posudbe
        // CREATE
        public static void DodajPosudbu(Posudbe posudba)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    context.Posudbe.Add(posudba);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Došlo je do pogreške: " + e.Message);
            }
        }

        // READ
        public static List<Posudbe> DohvatiPosudbu()
        {
            List<Posudbe> posudbe = new List<Posudbe>();

            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    posudbe.AddRange(context.Posudbe.Select(x => x).Include(x => x.Prijatelj).Include(x => x.Medij));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Došlo je do pogreške: " + e.Message);
            }

            return posudbe;
        }

        // UPDATE
        public static void IzmjeniPosudbu(Posudbe posudba)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Posudbe posudbaIzBaze = context.Posudbe.FirstOrDefault(
                        x => x.PosudbaId == posudba.PosudbaId);
                    if (posudbaIzBaze != default)
                    {
                        posudbaIzBaze.DatumPosudbe = posudba.DatumPosudbe;
                        posudbaIzBaze.DatumVracanja = posudba.DatumVracanja;
                        posudbaIzBaze.MedijId = posudba.MedijId;
                        posudbaIzBaze.PrijateljId = posudba.PrijateljId;
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Posudba nije pronađena u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }

        // DELETE
        public static void ObrisiPosudbu(int posudbaId)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Posudbe posudba = context.Posudbe.FirstOrDefault(x => x.PosudbaId == posudbaId);
                    if (posudba != default)
                    {
                        context.Posudbe.Remove(posudba);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Posudba nije pronađena u bazi!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }
        #endregion

    }
}