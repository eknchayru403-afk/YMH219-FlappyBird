# YMH 219 - Flappy Bird Oyunu

* **Öğrenci Adı Soyadı:** Hayrunnisa Ekinci
* **Öğrenci Numarası:** 240541043
* **Ders:** YMH 219 - Görsel Programlama / Nesne Yönelimli Programlama

## Proje Hakkında
Bu proje, C# Windows Forms (.NET) kullanılarak geliştirilmiş, yerçekimi fiziği, engel üretimi, çarpışma algılama ve skor takibi mekaniklerini nesne yönelimli programlama (OOP) prensipleriyle modelleyen klasik bir **Flappy Bird** oyunudur.

## Temel Özellikler & OOP Mimarisi
* **Kuş Fiziği (`Bird` Sınıfı):** Dikey konum, yerçekimi ivmesi (`YerCekimiUygula`) ve klavye tetiklemeli zıplama (`Zipla`) davranışları kapsüllenmiştir.
* **Dinamik Engel Sistemi (`PipePair` Sınıfı):** Üst ve alt boru çiftlerinin yatay akışı, rastgele geçiş boşluğu yüksekliği üretimi ve ekran dışı sıfırlama döngüsü yönetilir.
* **Oyun Motoru & Zorluk Artışı (`FlappyGameManager` Sınıfı):** `Rectangle.IntersectsWith` tabanlı çarpışma kontrolü, anlık skor hesaplama ve her 5 puanda boru hızını kademeli artıran dinamik zorluk sistemi içerir.
* **Akıcı Grafik Performansı:** `DoubleBuffered` aktif edilerek 20 ms (`50 FPS`) zamanlayıcı döngüsünde titreşimsiz oyun deneyimi sağlanmıştır.

## Kontroller
* **SPACE (Boşluk):** Oyunu başlatır, kuşu zıplatır ve oyun bittiğinde yeniden başlatır.

## Kurulum ve Çalıştırma
1. Depoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/eknchayru403-afk/YMH219-FlappyBird.git](https://github.com/eknchayru403-afk/YMH219-FlappyBird.git)
