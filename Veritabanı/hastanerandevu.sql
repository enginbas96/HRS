-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 08 Haz 2024, 14:35:13
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `hastanerandevu`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

CREATE TABLE `admin` (
  `kullaniciAdi` varchar(32) NOT NULL,
  `Sifre` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `admin`
--

INSERT INTO `admin` (`kullaniciAdi`, `Sifre`) VALUES
('1234', '1234');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `birimler`
--

CREATE TABLE `birimler` (
  `birim` varchar(128) NOT NULL,
  `calisanSayisi` varchar(8) NOT NULL,
  `hastaneAdi` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `birimler`
--

INSERT INTO `birimler` (`birim`, `calisanSayisi`, `hastaneAdi`) VALUES
('Cihaz Bakım', '1', 'İstanbul Özel ABC Hastanesi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `calisan`
--

CREATE TABLE `calisan` (
  `tc` varchar(11) NOT NULL,
  `sifre` varchar(32) NOT NULL,
  `ad` varchar(32) NOT NULL,
  `soyad` varchar(32) NOT NULL,
  `eposta` varchar(128) NOT NULL,
  `birim` varchar(128) NOT NULL,
  `hastaneAdi` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `calisan`
--

INSERT INTO `calisan` (`tc`, `sifre`, `ad`, `soyad`, `eposta`, `birim`, `hastaneAdi`) VALUES
('1234567890', '123', 'Engin', 'Baş', 'engin.bas96@gmail.com', 'Cihaz Bakım', 'İstanbul Özel ABC Hastanesi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `doktorlar`
--

CREATE TABLE `doktorlar` (
  `tc` varchar(11) NOT NULL,
  `sifre` varchar(64) NOT NULL,
  `adsoyad` varchar(64) NOT NULL,
  `eposta` varchar(32) NOT NULL,
  `unvan` varchar(32) NOT NULL,
  `birim` varchar(64) NOT NULL,
  `hastaneAdi` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `doktorlar`
--

INSERT INTO `doktorlar` (`tc`, `sifre`, `adsoyad`, `eposta`, `unvan`, `birim`, `hastaneAdi`) VALUES
('00000000000', '142536asd', 'Mustafa Şahin', '0000@0000', 'Uz.', 'Dahiliye Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('11111111111', '1111', 'Memduha Demircioğlu', '1111@1111', 'Uz.', 'Dahiliye Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('22222222222', '2222', 'Osman Demir', '2222@2222', 'Prof.', 'Nöroloji Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('33333333333', '3333', 'Nalan Aydın', '3333@3333', 'Doç.', 'Kardiyoloji Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('44444444444', '4444', 'Süleyman Aygün', '4444@4444', 'Dr.', 'Kardiyoloji Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('55555555555', '5555', 'Ümit Tutar', '5555@5555', 'Uz.', 'Göğüs Hastalıkları Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('66666666666', '6666', 'Mehmet Kulaç', '6666@6666', 'Prof.', 'Göz Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('77777777777', '7777', 'Ahmet Sayar', '7777@7777', 'Uz.', 'Göz Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('88888888888', '8888', 'Zübeyde Torun', '8888@8888', 'Dr.', 'Kulak Burun Boğaz Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('99999999999', '9999', 'Mustafa Yorgan', '9999@9999', 'Doç.', 'Kulak Burun Boğaz Polikliniği', 'İstanbul Özel ABC Hastanesi'),
('10000000001', '1000', 'Engin Deva', '1000@1000', 'Prof.', 'Göz Polikliniği', 'Ordu Özel ABC Hastanesi'),
('20000000002', '2000', 'Emrah Ton', '2000@2000', 'Uz.', 'Dahiliye Polikliniği', 'Samsun Özel ABC Hastanesi'),
('30000000003', '3000', 'Murat Kaş', '3000@3000', 'Prof.', 'Kulak Burun Boğaz Polikliniği', 'Ordu Özel ABC Hastanesi'),
('40000000004', '4000', 'Tarık Kılıç', '4000@4000', 'Doç.', 'Nöroloji Polikliniği', 'Ordu Özel ABC Hastanesi'),
('50000000005', '5000', 'Kemal Şen', '5000@5000', 'Dr.', 'Kulak Burun Boğaz Polikliniği', 'Ordu Özel ABC Hastanesi'),
('60000000006', '6000', 'Merve Alataş', '6000@6000', 'Doç.', 'Göz Polikliniği', 'Ordu Özel ABC Hastanesi'),
('70000000007', '7000', 'Akın Şentürk', '7000@7000', 'Uz.', 'Göğüs Hastalıkları Polikliniği', 'Samsun Özel ABC Hastanesi'),
('90000000009', '9000', 'Turan Kaya', '9000@9000', 'Prof.', 'Kulak Burun Boğaz Polikliniği', 'Samsun Özel ABC Hastanesi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hasta`
--

CREATE TABLE `hasta` (
  `id` int(11) NOT NULL,
  `tc` varchar(11) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `ad` varchar(32) NOT NULL,
  `soyad` varchar(32) NOT NULL,
  `eposta` varchar(32) NOT NULL,
  `dogumyili` varchar(32) NOT NULL,
  `cinsiyet` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `hasta`
--

INSERT INTO `hasta` (`id`, `tc`, `password`, `ad`, `soyad`, `eposta`, `dogumyili`, `cinsiyet`) VALUES
(1, '10101010101', '10101010101', 'AA', 'BB', 'aa.bb@aa.bb', '1996', 'Erkek'),
(2, '12121212121', '12121212121', 'BB', 'CC', 'bb.cc@bb.cc', '1987', 'Kadın'),
(3, '13131313131', '13131313131', 'CC', 'DD', 'cc.dd@cc.dd', '1999', 'Erkek'),
(4, '14141414141', '14141414141', 'DD', 'EE', 'dd.ee@dd.ee', '2000', 'Erkek'),
(5, '15151515151', '15151515151', 'EE', 'FF', 'ee.ff@ee.ff', '2001', 'Kadın'),
(6, '16161616161', '16161616161', 'FF', 'GG', 'ff.gg@ff.gg', '2000', 'Erkek'),
(7, '17171717171', '17171717171', 'GG', 'HH', 'gg.hh@gg.hh', '2000', 'Kadın'),
(8, '18181818181', '18181818181', 'HH', 'II', 'hh.ii@hh.ii', '1997', 'Kadın'),
(9, '19191919191', '19191919191', 'II', 'JJ', 'ii.jj@ii.jj', '2003', 'Kadın'),
(21, '15935785246', '123456789', 'Qqqq', 'Wwww', 'the_Enqin@hotmail.com.tr', '1996', 'Erkek');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hastaneler`
--

CREATE TABLE `hastaneler` (
  `il` varchar(32) NOT NULL,
  `hastaneAdi` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `hastaneler`
--

INSERT INTO `hastaneler` (`il`, `hastaneAdi`) VALUES
('İstanbul', 'İstanbul Özel ABC Hastanesi'),
('Ordu', 'Ordu Özel ABC Hastanesi'),
('Samsun', 'Samsun Özel ABC Hastanesi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ilaclar`
--

CREATE TABLE `ilaclar` (
  `ilacKod` varchar(11) NOT NULL,
  `ilacAd` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `ilaclar`
--

INSERT INTO `ilaclar` (`ilacKod`, `ilacAd`) VALUES
('B2C123', 'AAAA'),
('ABC123', 'ASPİRİN'),
('BBC123', 'BASDASD');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iller`
--

CREATE TABLE `iller` (
  `il` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `iller`
--

INSERT INTO `iller` (`il`) VALUES
('İstanbul'),
('Ordu'),
('Samsun');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '0001_01_01_000000_create_users_table', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `poliklinikler`
--

CREATE TABLE `poliklinikler` (
  `hastaneAdi` varchar(64) NOT NULL,
  `poliklinikAdi` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `poliklinikler`
--

INSERT INTO `poliklinikler` (`hastaneAdi`, `poliklinikAdi`) VALUES
('İstanbul Özel ABC Hastanesi', 'Dahiliye Polikliniği'),
('İstanbul Özel ABC Hastanesi', 'Nöroloji Polikliniği'),
('İstanbul Özel ABC Hastanesi', 'Kardiyoloji Polikliniği'),
('İstanbul Özel ABC Hastanesi', 'Göğüs Hastalıkları Polikliniği'),
('İstanbul Özel ABC Hastanesi', 'Göz Polikliniği'),
('İstanbul Özel ABC Hastanesi', 'Kulak Burun Boğaz Polikliniği'),
('Ordu Özel ABC Hastanesi', 'Göz Polikliniği'),
('Ordu Özel ABC Hastanesi', 'Kulak Burun Boğaz Polikliniği'),
('Ordu Özel ABC Hastanesi', 'Nöroloji Polikliniği'),
('Samsun Özel ABC Hastanesi', 'Kulak Burun Boğaz Polikliniği'),
('Samsun Özel ABC Hastanesi', 'Dahiliye Polikliniği'),
('Samsun Özel ABC Hastanesi', 'Göğüs Hastalıkları Polikliniği');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `randevular`
--

CREATE TABLE `randevular` (
  `hastaTC` varchar(11) NOT NULL,
  `doktorTC` varchar(11) NOT NULL,
  `hastaneAdi` varchar(64) NOT NULL,
  `tarih` varchar(16) NOT NULL,
  `saat` varchar(8) NOT NULL,
  `poliklinik` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `receteler`
--

CREATE TABLE `receteler` (
  `hastaTC` varchar(11) NOT NULL,
  `doktorTC` varchar(11) NOT NULL,
  `ilaclar` varchar(64) NOT NULL,
  `aciklama` varchar(1024) NOT NULL,
  `tarih` varchar(16) NOT NULL,
  `receteKodu` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sessions`
--

CREATE TABLE `sessions` (
  `id` varchar(255) NOT NULL,
  `user_id` bigint(20) UNSIGNED DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `user_agent` text DEFAULT NULL,
  `payload` longtext NOT NULL,
  `last_activity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `sessions`
--

INSERT INTO `sessions` (`id`, `user_id`, `ip_address`, `user_agent`, `payload`, `last_activity`) VALUES
('bOC2g6KboQFbB1IPOEm2DsWqbRyY74MlpBM3QVDO', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoiaEhxTkY2dTFFNGhQMkRmS2xiMmExQTE3SFJHRGZneUhhVnlPRThWSSI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6Mzc6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMC9TaWZyZW1pLVVudXR0dW0iO31zOjY6Il9mbGFzaCI7YToyOntzOjM6Im9sZCI7YTowOnt9czozOiJuZXciO2E6MDp7fX19', 1717849654),
('L1aT7aCqDI2Dg01S6ZGyt12PWypQA4J7BVvmZ5AD', 1, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YTo0OntzOjY6Il90b2tlbiI7czo0MDoiblFWUXpDZkx3V29QRjFkWGc0bGZRVnUyM2VmYTNxQXlWWm1NTlE5USI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6Mjc6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMC9HaXJpcyI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fXM6NTA6ImxvZ2luX3dlYl81OWJhMzZhZGRjMmIyZjk0MDE1ODBmMDE0YzdmNThlYTRlMzA5ODlkIjtpOjE7fQ==', 1717843991),
('zqfyCyL71RMX6dudO1NP4t4iquwFsmeJVcLGSz52', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YToyOntzOjY6Il90b2tlbiI7czo0MDoic1JPRXc0YWNya0NSRHJlcVc2ODNWR1Nwamk5Y050REZzaFhLc1hNWSI7czo2OiJfZmxhc2giO2E6Mjp7czozOiJvbGQiO2E6MDp7fXM6MzoibmV3IjthOjA6e319fQ==', 1717844056);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sorunbildirim`
--

CREATE TABLE `sorunbildirim` (
  `tc` varchar(11) NOT NULL,
  `bildirimMetni` varchar(1024) NOT NULL,
  `cozulduMu` varchar(16) NOT NULL,
  `cozumRaporu` varchar(1024) NOT NULL,
  `hastaneAdi` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `unvanlar`
--

CREATE TABLE `unvanlar` (
  `unvan` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `unvanlar`
--

INSERT INTO `unvanlar` (`unvan`) VALUES
('Doç.'),
('Dr.'),
('Prof.'),
('Uz.');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `birimler`
--
ALTER TABLE `birimler`
  ADD KEY `birim_index` (`birim`);

--
-- Tablo için indeksler `calisan`
--
ALTER TABLE `calisan`
  ADD KEY `hastaneAdi` (`hastaneAdi`),
  ADD KEY `birim` (`birim`);

--
-- Tablo için indeksler `doktorlar`
--
ALTER TABLE `doktorlar`
  ADD KEY `doktorlar_index` (`tc`),
  ADD KEY `unvan` (`unvan`),
  ADD KEY `hastaneAdi` (`hastaneAdi`);

--
-- Tablo için indeksler `hasta`
--
ALTER TABLE `hasta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `hasta_index` (`tc`);

--
-- Tablo için indeksler `hastaneler`
--
ALTER TABLE `hastaneler`
  ADD KEY `hastaneler_index` (`hastaneAdi`) USING BTREE,
  ADD KEY `il_index` (`il`);

--
-- Tablo için indeksler `ilaclar`
--
ALTER TABLE `ilaclar`
  ADD PRIMARY KEY (`ilacKod`),
  ADD KEY `ilac_index` (`ilacAd`);

--
-- Tablo için indeksler `iller`
--
ALTER TABLE `iller`
  ADD KEY `iller_index` (`il`);

--
-- Tablo için indeksler `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `poliklinikler`
--
ALTER TABLE `poliklinikler`
  ADD KEY `hastaneAdi` (`hastaneAdi`) USING BTREE,
  ADD KEY `poliklinik_index` (`poliklinikAdi`);

--
-- Tablo için indeksler `randevular`
--
ALTER TABLE `randevular`
  ADD KEY `hastaTC` (`hastaTC`),
  ADD KEY `doktorTC` (`doktorTC`),
  ADD KEY `hastaneAdi` (`hastaneAdi`),
  ADD KEY `poliklinik` (`poliklinik`);

--
-- Tablo için indeksler `receteler`
--
ALTER TABLE `receteler`
  ADD KEY `recete_index` (`hastaTC`),
  ADD KEY `doktorTC` (`doktorTC`),
  ADD KEY `ilaclar` (`ilaclar`);

--
-- Tablo için indeksler `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sessions_user_id_index` (`user_id`),
  ADD KEY `sessions_last_activity_index` (`last_activity`);

--
-- Tablo için indeksler `sorunbildirim`
--
ALTER TABLE `sorunbildirim`
  ADD KEY `hastaneAdi` (`hastaneAdi`);

--
-- Tablo için indeksler `unvanlar`
--
ALTER TABLE `unvanlar`
  ADD KEY `unvan_index` (`unvan`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `hasta`
--
ALTER TABLE `hasta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Tablo için AUTO_INCREMENT değeri `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `birimler`
--
ALTER TABLE `birimler`
  ADD CONSTRAINT `birimler_ibfk_1` FOREIGN KEY (`hastaneAdi`) REFERENCES `hastaneler` (`hastaneAdi`);

--
-- Tablo kısıtlamaları `calisan`
--
ALTER TABLE `calisan`
  ADD CONSTRAINT `calisan_ibfk_1` FOREIGN KEY (`hastaneAdi`) REFERENCES `hastaneler` (`hastaneAdi`),
  ADD CONSTRAINT `calisan_ibfk_2` FOREIGN KEY (`birim`) REFERENCES `birimler` (`birim`);

--
-- Tablo kısıtlamaları `doktorlar`
--
ALTER TABLE `doktorlar`
  ADD CONSTRAINT `doktorlar_ibfk_1` FOREIGN KEY (`unvan`) REFERENCES `unvanlar` (`unvan`),
  ADD CONSTRAINT `doktorlar_ibfk_2` FOREIGN KEY (`hastaneAdi`) REFERENCES `hastaneler` (`hastaneAdi`);

--
-- Tablo kısıtlamaları `hastaneler`
--
ALTER TABLE `hastaneler`
  ADD CONSTRAINT `hastaneler_ibfk_1` FOREIGN KEY (`il`) REFERENCES `iller` (`il`),
  ADD CONSTRAINT `hastaneler_ibfk_2` FOREIGN KEY (`il`) REFERENCES `iller` (`il`);

--
-- Tablo kısıtlamaları `poliklinikler`
--
ALTER TABLE `poliklinikler`
  ADD CONSTRAINT `poliklinikler_ibfk_1` FOREIGN KEY (`hastaneAdi`) REFERENCES `hastaneler` (`hastaneAdi`);

--
-- Tablo kısıtlamaları `randevular`
--
ALTER TABLE `randevular`
  ADD CONSTRAINT `randevular_ibfk_1` FOREIGN KEY (`hastaTC`) REFERENCES `hasta` (`tc`),
  ADD CONSTRAINT `randevular_ibfk_2` FOREIGN KEY (`doktorTC`) REFERENCES `doktorlar` (`tc`),
  ADD CONSTRAINT `randevular_ibfk_3` FOREIGN KEY (`hastaneAdi`) REFERENCES `hastaneler` (`hastaneAdi`),
  ADD CONSTRAINT `randevular_ibfk_4` FOREIGN KEY (`poliklinik`) REFERENCES `poliklinikler` (`poliklinikAdi`);

--
-- Tablo kısıtlamaları `receteler`
--
ALTER TABLE `receteler`
  ADD CONSTRAINT `receteler_ibfk_1` FOREIGN KEY (`hastaTC`) REFERENCES `hasta` (`tc`),
  ADD CONSTRAINT `receteler_ibfk_2` FOREIGN KEY (`doktorTC`) REFERENCES `doktorlar` (`tc`),
  ADD CONSTRAINT `receteler_ibfk_3` FOREIGN KEY (`ilaclar`) REFERENCES `ilaclar` (`ilacAd`),
  ADD CONSTRAINT `receteler_ibfk_4` FOREIGN KEY (`ilaclar`) REFERENCES `ilaclar` (`ilacAd`);

--
-- Tablo kısıtlamaları `sorunbildirim`
--
ALTER TABLE `sorunbildirim`
  ADD CONSTRAINT `sorunbildirim_ibfk_1` FOREIGN KEY (`hastaneAdi`) REFERENCES `hastaneler` (`hastaneAdi`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
