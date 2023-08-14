using System;

namespace UcgenCizmeUygulamasi
{
    class UygulamaCalistirici
    {
        public void Baslat(int boyut)
        {
            UcgenCizdirici ucgenCizdirici = new UcgenCizdirici();
            ucgenCizdirici.UcgenCiz(boyut);
        }
    }
}
