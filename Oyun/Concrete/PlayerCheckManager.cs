using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    public class PlayerCheckManager : PlayerCheckService
    {
        public bool Kontrol(Player player)
        {

            if (player.Ad == "Nurcan" && player.SoyAd == "AKSU" && player.TcNo == "19777905432" && player.Date == new DateTime(2001, 3, 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
