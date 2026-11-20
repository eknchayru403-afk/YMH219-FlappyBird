using System.Drawing;

namespace YMH219_FlappyBird
{
    public class FlappyGameManager
    {
        public Bird Kus { get; }
        public PipePair Borular { get; }
        public int Skor { get; private set; }
        public bool OyunAktif { get; private set; }
        public bool OyunBitti { get; private set; }

        private readonly Rectangle _zeminAlani;

        public FlappyGameManager(Bird kus, PipePair borular, Rectangle zeminAlani)
        {
            Kus = kus;
            Borular = borular;
            _zeminAlani = zeminAlani;
        }

        public void OyunuBaslat()
        {
            Kus.Sifirla();
            Borular.Sifirla();
            Skor = 0;
            OyunBitti = false;
            OyunAktif = true;
            Kus.Zipla();
        }

        public void KusZiplama()
        {
            if (OyunAktif && !OyunBitti)
            {
                Kus.Zipla();
            }
        }

        public void KareGuncelle()
        {
            if (!OyunAktif || OyunBitti) return;

            Kus.YerCekimiUygula();
            Borular.SolaKaydir();

            // Boruyu geçtiyse skor artır
            if (!Borular.SkorAlindi && Borular.X + Borular.Genislik < Kus.X)
            {
                Skor++;
                Borular.SkorAlindi = true;

                // Her 5 puanda boru hızını kademeli artır
                if (Skor % 5 == 0 && Borular.BoruHizi < 14)
                {
                    Borular.BoruHizi++;
                }
            }

            // Çarpışma kontrolü
            if (CarpismaVarMi())
            {
                OyunAktif = false;
                OyunBitti = true;
            }
        }

        private bool CarpismaVarMi()
        {
            Rectangle kusKutu = Kus.SinirKutusu();

            return kusKutu.IntersectsWith(_zeminAlani) ||
                   kusKutu.IntersectsWith(Borular.UstSinirKutusu()) ||
                   kusKutu.IntersectsWith(Borular.AltSinirKutusu());
        }
    }
}