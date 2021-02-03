using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    public class KampanyaManager : SiparisManager 
    {
        public override void SatinAl(Player player)
        {
            KampanyaGir();
            Console.WriteLine("Satin Alındı Alan Kişi: " + player.Ad);
        }

        public void KampanyaGir()
        {
            Console.WriteLine("Kampanya girdiniz.." );
        }

        public void KampanyaGuncelle()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        public void KampanyaSil()
        {
            Console.WriteLine("Kampanya Silindi");
        }

        
    }
}
