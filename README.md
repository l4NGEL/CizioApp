# Cizio - Çizim ve Tahmin Oyunu

Cizio, iki oyunculu bir çizim ve tahmin oyunudur. Oyuncular sırayla kelimeler çizer ve diğer oyuncu bu çizimleri tahmin etmeye çalışır.

## 🎮 Oyun Özellikleri

- **İki Oyunculu Mod**: İki oyuncu sırayla çizim yapar ve tahmin eder
- **Çizim Araçları**: Serbest çizim, şekiller (dikdörtgen, üçgen, daire) ve renk seçenekleri
- **Zaman Sınırı**: Her çizim için 60 saniye süre
- **Puan Sistemi**: Doğru tahminler için puan kazanma
- **Çoklu Dil Desteği**: Kelime çeviri özelliği
- **Görsel Arayüz**: Kullanıcı dostu Windows Forms arayüzü

## 🚀 Kurulum

### Gereksinimler

- .NET 8.0 veya üzeri
- Windows işletim sistemi
- Visual Studio 2022 (önerilen) veya Visual Studio Code

### Kurulum Adımları

1. Projeyi klonlayın:
```bash
git clone [repository-url]
cd CizioApp-main
```

2. Visual Studio'da projeyi açın:
   - `Cizio.sln` dosyasını Visual Studio'da açın
   - Veya terminal'de `dotnet restore` komutunu çalıştırın

3. Projeyi derleyin ve çalıştırın:
   - Visual Studio'da F5 tuşuna basın
   - Veya terminal'de `dotnet run` komutunu çalıştırın

## 🎯 Nasıl Oynanır

1. **Oyun Başlatma**:
   - Ana menüden "Giriş Yap" butonuna tıklayın
   - İki oyuncunun adını girin
   - "Oyuna Başla" butonuna tıklayın

2. **Kelime Seçimi**:
   - Çizim yapacak oyuncu kelime seçer
   - Kelime 10 saniye görünür, sonra gizlenir

3. **Çizim Aşaması**:
   - Seçilen kelimeyi çizmek için 60 saniye süre
   - Çizim araçları: serbest çizim, şekiller, renkler
   - "Bitir" butonuna tıklayarak çizimi tamamlayın

4. **Tahmin Aşaması**:
   - Diğer oyuncu çizimi görür ve tahmin etmeye çalışır
   - Her yanlış tahmin 2 puan düşürür
   - Doğru tahmin için kalan puanı kazanır

5. **Puan Sistemi**:
   - Başlangıç puanı: 10
   - Her yanlış tahmin: -2 puan
   - Minimum puan: 4

## 🛠️ Teknik Detaylar

### Proje Yapısı

```
CizioApp/
├── Form1.cs                 # Ana menü formu
├── Form2.cs                 # Oyuncu giriş formu
├── SelectWordPage.cs        # Kelime seçim sayfası
├── PaintForm.cs            # Çizim formu
├── GuessPageForm.cs        # Tahmin formu
├── CorrectAnswerForm.cs    # Doğru cevap formu
├── WrongAnswerForm.cs      # Yanlış cevap formu
├── PointStatusForm.cs      # Puan durumu formu
├── TranslationResponse.cs  # Çeviri API yanıt modeli
└── Properties/             # Proje özellikleri
```

### Kullanılan Teknolojiler

- **.NET 8.0**: Ana framework
- **Windows Forms**: Kullanıcı arayüzü
- **System.Drawing**: Çizim işlemleri
- **HttpClient**: API çağrıları (çeviri)
- **JSON**: Veri formatı

### Özellikler

- **Çizim Araçları**:
  - Serbest çizim
  - Şekiller (dikdörtgen, üçgen, daire)
  - Renk paleti
  - Canvas temizleme

- **Oyun Mekanikleri**:
  - Zamanlayıcı sistemi
  - Puan hesaplama
  - Oyuncu sırası
  - Kelime gizleme

- **Kullanıcı Deneyimi**:
  - Türkçe arayüz
  - Görsel geri bildirimler
  - Kolay navigasyon
 
### Ekran Görüntüleri
-Giriş Ekranı
![WhatsApp Image 2025-08-06 at 16 10 01](https://github.com/user-attachments/assets/81347b87-6fbb-45be-805e-56fb312cbeae)
-Oyun İçi Kullanıcı Giriş Ekranı
![WhatsApp Image 2025-08-06 at 16 10 57](https://github.com/user-attachments/assets/0160c8a6-bf0c-4f02-a97d-a82be79d3b57)
-Çizim Tahmin Ekranı 
![WhatsApp Image 2025-08-06 at 16 12 06](https://github.com/user-attachments/assets/98b76723-a5f4-4c87-a164-955e0672f93b)

## 🐛 Bilinen Sorunlar

- Çeviri API'si için internet bağlantısı gereklidir
- Bazı sistemlerde çizim performansı değişebilir



## 👥 Geliştiriciler

- Mustafa YALÇINKAYA
- Beyza Nur KILIÇ
  
---

**Not**: Bu oyun eğlence amaçlı geliştirilmiştir ve eğitimsel değer taşımaktadır.
