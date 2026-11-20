using System;
using System.Drawing;
using System.Windows.Forms;

namespace YMH219_FlappyBird
{
    public partial class Form1 : Form
    {
        private FlappyGameManager _oyunYoneticisi;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            OyunuHazirla();
        }

        private void OyunuHazirla()
        {
            Bird kus = new Bird(pbKus.Left, pbKus.Top, pbKus.Width, pbKus.Height);
            PipePair borular = new PipePair(pbBoruUst.Left, pbBoruUst.Width, ClientSize.Width, pbZemin.Top);
            _oyunYoneticisi = new FlappyGameManager(kus, borular, pbZemin.Bounds);

            ArayuzuGuncelle();
        }

        private void tmrOyun_Tick(object sender, EventArgs e)
        {
            _oyunYoneticisi.KareGuncelle();
            ArayuzuGuncelle();

            if (_oyunYoneticisi.OyunBitti)
            {
                tmrOyun.Stop();
                lblMesaj.Text = $"Oyun Bitti! Skorunuz: {_oyunYoneticisi.Skor}\nTekrar oynamak için SPACE tuşuna basın";
                lblMesaj.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!_oyunYoneticisi.OyunAktif)
                {
                    lblMesaj.Visible = false;
                    _oyunYoneticisi.OyunuBaslat();
                    tmrOyun.Start();
                }
                else
                {
                    _oyunYoneticisi.KusZiplama();
                }
            }
        }

        private void ArayuzuGuncelle()
        {
            // Kuş konumunu güncelle
            pbKus.Left = _oyunYoneticisi.Kus.X;
            pbKus.Top = _oyunYoneticisi.Kus.Y;

            // Üst ve alt boru konum/boyutlarını güncelle
            pbBoruUst.Left = _oyunYoneticisi.Borular.X;
            pbBoruUst.Height = _oyunYoneticisi.Borular.UstBoruYukseklik;

            pbBoruAlt.Left = _oyunYoneticisi.Borular.X;
            pbBoruAlt.Top = _oyunYoneticisi.Borular.AltBoruY;
            pbBoruAlt.Height = _oyunYoneticisi.Borular.AltBoruYukseklik;

            // Skoru güncelle
            lblSkor.Text = $"Skor: {_oyunYoneticisi.Skor}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}