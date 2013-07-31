-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Anamakine: localhost
-- Üretim Zamanı: 31 Tem 2013, 18:18:46
-- Sunucu sürümü: 5.5.24-log
-- PHP Sürümü: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Veritabanı: `otel`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `rezervasyon`
--

CREATE TABLE IF NOT EXISTS `rezervasyon` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `isim` varchar(100) NOT NULL,
  `fiyat` int(11) NOT NULL,
  `bos` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2031 ;

--
-- Tablo döküm verisi `rezervasyon`
--

INSERT INTO `rezervasyon` (`id`, `isim`, `fiyat`, `bos`) VALUES
(1, 'Esenboga Airport Hotel', 1000, 3),
(20, 'Best Apart Otel', 500, 0),
(21, 'Surmeli Otel', 500, 7),
(23, 'Teb Otel', 700, 2),
(33, 'Buyuk Ankara Otel', 800, 5),
(36, 'Baskent Hotel', 400, 5),
(2016, 'Dedeman Ankara Hotel', 200, 10),
(2017, 'Ankara Plaza Hotel', 700, 9),
(2024, 'Latifoglu Hotel', 300, 7);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
