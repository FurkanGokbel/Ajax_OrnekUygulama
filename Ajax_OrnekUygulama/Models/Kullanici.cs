using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyAjax.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public static class KullaniciIslem
    {
        private static List<Kullanici> kullanicilar = new List<Kullanici>()
        {
            new Kullanici{Id=1,Ad="kullanici1"},
            new Kullanici{Id=2,Ad="kullanici2"}
        };


        public static List<Kullanici> GetirHepsi()
        {
            return kullanicilar;
        }

        public static Kullanici GetirIdile(int id)
        {
            return kullanicilar.FirstOrDefault(I => I.Id == id);
        }

        public static void Ekle(Kullanici kullanici)
        {
            kullanicilar.Add(kullanici);
        }

    }
}
