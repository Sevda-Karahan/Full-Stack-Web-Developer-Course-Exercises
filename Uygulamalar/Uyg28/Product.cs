using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg28
{
    class Product
    {
        public int urun_no;
        public string urun_adı, renk;
        public float fiyat;
        
        public float kdvli_fiyat(float fiyat)
        {
            if (fiyat >= 100)
            {
                return fiyat * 1.05f;
            }
            else
            {
                return fiyat * 1.03f;
            }
        }
    }
}
