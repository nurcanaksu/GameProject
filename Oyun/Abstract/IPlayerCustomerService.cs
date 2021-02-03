using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public interface IPlayerCustomerService
    {
        void KayitOl(Player player);
        void Guncelle(Player player);
        void Sil(Player player);
    }
}
