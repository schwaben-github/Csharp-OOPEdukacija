using Azure.Core;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBMethods
    {
        // CRUD
        #region Prijatelji
        // CREATE
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

        // READ
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

        // UPDATE
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
                        prijateljIzBaze.Telefon = prijatelj.Telefon;
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

        // DELETE
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
        #endregion

        #region Mediji
        // CREATE
        public static void DodajMedij(Mediji medij)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    context.Mediji.Add(medij);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Došlo je do pogreške: " + e.Message);
            }
        }

        // READ
        public static List<Mediji> DohvatiMedije()
        {
            List<Mediji> mediji = new List<Mediji>();

            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    mediji.AddRange(context.Mediji);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Došlo je do pogreške: " + e.Message);
            }

            return mediji;
        }

        // UPDATE
        public static void IzmjeniMedij(Mediji medij)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Mediji medijIzBaze = context.Mediji.FirstOrDefault(
                        x => x.MedijId == medij.MedijId);
                    if (medijIzBaze != default)
                    {
                        medijIzBaze.Naslov = medij.Naslov;
                        medijIzBaze.Tip = medij.Tip;
                        context.SaveChanges(); //moramo spremiti promjene da bi se one propagirale na bazu
                    }
                    else
                    {
                        throw new Exception("Medij nije pronađen u bazi!");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }

        // DELETE
        public static void ObrisiMedij(int medijId)
        {
            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    Mediji medij = context.Mediji.FirstOrDefault(x => x.MedijId == medijId);
                    if (medij != default)
                    {
                        context.Mediji.Remove(medij);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Medij nije pronađen u bazi!");
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
        public static List<Posudbe> DohvatiPosudbe()
        {
            List<Posudbe> posudbe = new List<Posudbe>();

            try
            {
                using (var context = new CdDvdZbirkaContext())
                {
                    posudbe.AddRange(context.Posudbe);
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
