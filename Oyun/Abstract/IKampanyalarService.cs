using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    public interface IKampanyalarService
    {
        void KampanyaGir();
        void KampanyaGuncelle();
        void KampanyaSil();
    }
}
