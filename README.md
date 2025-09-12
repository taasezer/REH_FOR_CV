# REH_FOR_CV
just a basic human archive
# 📖 Kişi Rehberi 

**Tam fonksiyonlu, güvenli ve ölçeklenebilir bir kişi rehberi uygulaması.**
Kişileri ekleyin, düzenleyin, haritada görüntüleyin ve filtreleyin.

---

## 📌 Proje Şeması
```bash
rehber-projesi/
│
├── backend/
│   ├── python/
│   │   ├── app.py                # :followup[Flask sunucusu, JWT, PostgreSQL, Geopy]{question="Flask ile JWT ve PostgreSQL entegrasyonu nasıl yapılır?" questionId="8789cfdc-3b4c-4990-9226-3b9afd8cdca5"}
│   │   ├── requirements.txt      # Python bağımlılıkları
│   │   └── Dockerfile            # Docker konfigürasyonu
│   │
│   ├── csharp/
│   │   └── KisiIslemleri.cs      # :followup[C# veri işleme modülü]{question="Bu C# modülü hangi işlevleri yerine getiriyor?" questionId="764eb2b5-ae55-4df6-aa1f-78b028492a90"}
│   │
│   └── cpp/
│       └── kisi_islemleri.cpp    # :followup[C++ veri işleme modülü]{question="C++ modülü hangi avantajlar sağlıyor ve neden Python yerine tercih edilebilir?" questionId="ae2ff110-5b47-4e00-a5e5-683e8e0e008c"}
│
├── frontend/
│   ├── index.html                # HTML arayüzü
│   ├── style.css                 # CSS stilleri
│   └── script.js                 # JavaScript işlemleri
│
├── database/
│   └── init.sql                  # Veritabanı başlangıç scripti
│
├── docker-compose.yml            # :followup[Docker Compose konfigürasyonu]{question="Bu projedeki `docker-compose.yml` dosyası nasıl yapılandırılmış ve hangi servisleri içeriyor?" questionId="d8f734a9-2320-4599-af82-007ae40b75aa"}
│
└── README.md                     # Kurulum ve kullanım talimatları
```
# 🚀 Kurulum
## 📋 Gereksinimler

- Docker 🐳
- Docker Compose
- Tarayıcı (Chrome, Firefox, vb.)

## 🛠 Kurulum Adımları
### 1. Projeyi Klonlayın veya İndirin
````bash
git clone https://github.com/taasezer/REH_FOR_CV.git
cd REH_FOR_CV
````
### 2. Docker ile Projeyi Başlatın
 ```` bash
docker-compose up --build
````
### 3. Veritabanını Başlatın
PostgreSQL konteyneri otomatik olarak init.sql scriptini çalıştıracaktır.
### 4. Uygulamayı Açın
Tarayıcınızda **frontend/index.html** dosyasını açın.

# 🎯 Kullanım
### 🔐 Kullanıcı Kaydı ve Girişi

- Kayıt Ol butonuna tıklayın ve kullanıcı adı/şifre girin.
- Giriş Yap butonuna tıklayın.

### 👤 Kişi İşlemleri

- Kişi Ekle: Formu doldurun ve "Kişi Ekle" butonuna tıklayın.
- Kişi Ara: Arama kutusuna isim girin ve "Ara" butonuna tıklayın.
- Filtreleme: "Filtrele" butonuna tıklayarak kişileri sıralayın.

### 🗺 Harita Görüntüleme

- Kişilerin adresleri otomatik olarak haritada işaretlenir.

# 🔧 Geliştirme
## 📦 Bağımlılıklar
### Python Bağımlılıklarını Yükleme
```` bash
pip install -r backend/python/requirements.txt
````
### C# Bağımlılıklarını Yükleme
```` bash
dotnet add package Npgsql
````
### C++ Bağımlılıklarını Yükleme (Linux)
```` bash
sudo apt-get install :followup[libpqxx-dev]{question="C++ ile PostgreSQL bağlantısı için `libpqxx` dışında hangi alternatif kütüphaneler kullanılabilir?" questionId="5493aa1f-ad86-4121-9db3-4d6bf4dd7f57"}
````
# 🐳 Docker Komutları
## Projeyi Durdurma
 ```` bash
docker-compose down
````
## Veritabanını Sıfırlama
 ```` bash
docker-compose down -v
docker-compose up --build
````

# 🔍 Sorun Giderme
### PostgreSQL Bağlantı Hatası
```` bash
docker ps
````
PostgreSQL konteynerinin çalıştığından emin olun.
### Harita Görüntülenmiyor

- İnternet bağlantınızı kontrol edin.
- Tarayıcı konsolunda hata mesajlarını kontrol edin (F12 → Console).

## Geliştirme ve Katkı
Proje açık kaynak olarak geliştirilmekte olup, katkılarınızı memnuniyetle karşılarım.
Lütfen hata bildirmek veya özellik talep etmek için issue açınız. Pull request göndermekten çekinmeyiniz.

## İletişim
Herhangi bir soru veya destek talebi için aşağıdaki iletişim adresleri kullanılabilir:

## E-posta: [taha.sezer@istun.edu.tr]
