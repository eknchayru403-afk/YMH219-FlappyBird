using System.Drawing;

namespace YMH219_FlappyBird
{
    public class Bird
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Genislik { get; }
        public int Yukseklik { get; }

        public int DikeyHiz { get; private set; }
        public int YerCekimi { get; set; } = 2;
        public int ZiplamaGucu { get; set; } = -14;

        private readonly int _baslangicX;
        private readonly int _baslangicY;

        public Bird(int x, int y, int genislik, int yukseklik)
        {
            _baslangicX = x;
            _baslangicY = y;
            X = x;
            Y = y;
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public void Zipla()
        {
            DikeyHiz = ZiplamaGucu;
        }

        public void YerCekimiUygula()
        {
            DikeyHiz += YerCekimi;
            Y += DikeyHiz;

            if (Y < 0)
            {
                Y = 0;
                DikeyHiz = 0;
            }
        }

        public void Sifirla()
        {
            X = _baslangicX;
            Y = _baslangicY;
            DikeyHiz = 0;
        }

        public Rectangle SinirKutusu()
        {
            return new Rectangle(X, Y, Genislik, Yukseklik);
        }
    }
}