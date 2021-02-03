using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    public  class PlayerManager : IPlayerCustomerService
    {
        PlayerCheckService _playerCheckService; //fake doğrulama 

        public PlayerManager(PlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public virtual void Guncelle(Player player)
        {

            if(_playerCheckService.Kontrol(player)==true)
            {
                Console.WriteLine("Güncellendi yeni isim: " + player.Ad);
            }else
            {
                Console.WriteLine("GÜNCELLENEMEDİ" );
            }
            
        }

        public virtual void KayitOl(Player player)
        {
            if (_playerCheckService.Kontrol(player) == true)
            {
                Console.WriteLine("Kayit olundu : " + player.Ad);
            }
            else
            {
                Console.WriteLine("kayıt olunamadı");
            }
            
        }

        public virtual void Sil(Player player)
        {
            if (_playerCheckService.Kontrol(player) == true)
            {
                Console.WriteLine("Oyuncu silindi: " + player.Ad);
            }
            else
            {
                Console.WriteLine("Silindi");
            }
            
        }
    }
}
