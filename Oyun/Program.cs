using Oyun.Concrete;
using Oyun.Entities;
using System;

namespace Oyun
{
    class Program
    {
        /*
           *********SENARYO********
         Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz.
        Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz.
        Burada amaç yazdığınız kodun kalitesidir. Ödevde gereksinimleri tam anlamadığınız durum benim için önemli değil, 
        kendinize göre mantık geliştirebilirsiniz. Dediğim gibi kod kalitesiyle ilgileniyoruz şu an :)


      Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir
      ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz.
      (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi
      simule etmeniz yeterlidir.)

      Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. 
      Oyuncunun parametre olarak metotta olmasını kastediyorum.)

      Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

      Satışlarda kampanya entegrasyonunu simule ediniz.
         
         */


        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.KayitOl( //güncelle ve sil de var onları da yapabilirsin.
                new Player
                {
                    Date = new DateTime(2001, 3, 3),
                    Ad = "Nurcan",
                    SoyAd = "AKSU",
                    TcNo = "19777905432"
                });
            

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.SatinAl(
               new Player
               {
                   Date = new DateTime(2001, 3, 3),
                   Ad = "Nurcan",
                   SoyAd = "AKSU",
                   TcNo = "19777905432"
               });

            Console.ReadLine();


        }
    }
}

            /*BaseCustomerManager customerManager = new NeroCustomerManager();//bu nero işletmesi için

            //BaseCustomerManager baseCustomer = new StarBucksCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2001, 3, 3),
                FirstName = "Nurcan",
                LastName = "AKSU",
                NationalityId = "19777905432"
            });
            Console.ReadLine();
        }*/

