using System;
using System.Drawing;

namespace YMH219_FlappyBird
{
    public class PipePair
    {
        public int X { get; private set; }
        public int Genislik { get; }
        public int UstBoruYukseklik { get; private set; }
        public int AltBoruY { get; private set; }
        public int AltBoruYukseklik { get; private set; }

        public int BoruHizi { get; set; } = 7;
        public int BoslukAraligi { get; set; } = 165;
        public bool SkorAlindi { get; set; }

        private readonly int _ekranGenisligi;
        private readonly int _zeminY;
        private readonly int _baslangicX;
        private readonly Random _rastgele = new Random();

        public PipePair(int baslangicX, int genislik, int ekranGenisligi, int zeminY)
        {
            _baslangicX = baslangicX;
            Genislik = genislik;
            _ekranGenisligi = ekranGenisligi;
            _zeminY = zeminY;
            Sifirla();
        }

        public void SolaKaydir()
        {
            X -= BoruHizi;

            if (X + Genislik < 0)
            {
                X = _ekranGenisligi;
                YukseklikleriYenile();
                SkorAlindi = false;
            }
        }

        public void Sifirla()
        {
            X = _baslangicX;
            YukseklikleriYenile();
            SkorAlindi = false;
        }

        private void YukseklikleriYenile()
        {
            int minUst = 60;
            int maxUst = _zeminY - BoslukAraligi - 60;
            UstBoruYukseklik = _rastgele.Next(minUst, maxUst);
            AltBoruY = UstBoruYukseklik + BoslukAraligi;
            AltBoruYukseklik = _zeminY - AltBoruY;
        }

        public Rectangle UstSinirKutusu()
        {
            return new Rectangle(X, 0, Genislik, UstBoruYukseklik);
        }

        public Rectangle AltSinirKutusu()
        {
            return new Rectangle(X, AltBoruY, Genislik, AltBoruYukseklik);
        }
    }
}