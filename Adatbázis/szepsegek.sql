-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Okt 10. 09:11
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `szepsegek`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `dolgozók`
--

CREATE TABLE `dolgozók` (
  `dolgozo_id` int(11) NOT NULL,
  `dolgozo_v_nev` varchar(255) DEFAULT NULL,
  `dolgozo_k_nev` varchar(255) DEFAULT NULL,
  `szolgaltatas_id` int(11) DEFAULT NULL,
  `dolgozo_tel` varchar(255) DEFAULT NULL,
  `dolgozo_mail` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `dolgozók`
--

INSERT INTO `dolgozók` (`dolgozo_id`, `dolgozo_v_nev`, `dolgozo_k_nev`, `szolgaltatas_id`, `dolgozo_tel`, `dolgozo_mail`) VALUES
(1, 'Alma', 'Dalma', 1, '+36201234567', 'alma.dalma@asd.com'),
(2, 'Bab', 'Zsuzsanna', 2, '+36330455963', 'bab.zsuzsanna@asd.com'),
(3, 'Vincs', 'Eszter', 3, '+36888039496', 'vincs.eszter@asd.com'),
(4, 'Gomba', 'Gitta', 4, '+36887505836', 'gomba.gitta@asd.com'),
(5, 'Kapor', 'Karola', 5, '+36707304822', 'kapor.karola@asd.com'),
(6, 'Kefir', 'Ilona', 6, '+36283722161', 'kefir.ilona@asd.com');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `foglalas`
--

CREATE TABLE `foglalas` (
  `foglalas_id` int(11) NOT NULL,
  `szolgaltatas_id` int(11) DEFAULT NULL,
  `dolgozo_id` int(11) DEFAULT NULL,
  `vendeg_id` int(11) DEFAULT NULL,
  `foglalas_kezdes_idop` datetime DEFAULT NULL,
  `foglalas_befejezes_idop` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szolgaltatas`
--

CREATE TABLE `szolgaltatas` (
  `szolgaltatas_id` int(11) NOT NULL,
  `szolgaltatas_kategoria` varchar(255) DEFAULT NULL,
  `szolgaltatas_idotartam` int(11) DEFAULT NULL,
  `szolgaltatas_ar` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `szolgaltatas`
--

INSERT INTO `szolgaltatas` (`szolgaltatas_id`, `szolgaltatas_kategoria`, `szolgaltatas_idotartam`, `szolgaltatas_ar`) VALUES
(1, 'Géllakkozás', 60, 5000),
(2, 'Műköröm építés', 150, 7500),
(3, 'Manikűr', 60, 3500),
(4, 'Pedikűr', 60, 3500),
(5, 'Műszempilla töltés', 150, 8500),
(6, 'Műszempilla (teljes szett)', 180, 9500);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vendeg`
--

CREATE TABLE `vendeg` (
  `vendeg_id` int(11) NOT NULL,
  `vendeg_v_nev` varchar(255) DEFAULT NULL,
  `vendeg_k_nev` varchar(255) DEFAULT NULL,
  `vendeg_tel` varchar(255) DEFAULT NULL,
  `vendeg_mail` varchar(255) DEFAULT NULL,
  `vendeg_pontok` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vendeg`
--

INSERT INTO `vendeg` (`vendeg_id`, `vendeg_v_nev`, `vendeg_k_nev`, `vendeg_tel`, `vendeg_mail`, `vendeg_pontok`) VALUES
(0, 'Citrom', 'Cecília', '+36708025493', 'citrom.cecilia@sdf.com', 7),
(1, 'Birka', 'Borbála', '+36262705455', 'birka.borbala@sdf.com', 0),
(2, 'Radiátor', 'Réka', '+36260094341', 'radiator.reka@sdf.com', 1),
(3, 'Birs', 'Alma', '+36260553807', 'birs.alma@sddf.com', 5),
(4, 'Narancs', 'Piroska', '+36701086593', 'narancs.piroska@sdf.com', 3),
(5, 'Citrom', 'Cecília', '+36708025493', 'citrom.cecilia@sdf.com', 7);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `dolgozók`
--
ALTER TABLE `dolgozók`
  ADD PRIMARY KEY (`dolgozo_id`);

--
-- A tábla indexei `foglalas`
--
ALTER TABLE `foglalas`
  ADD PRIMARY KEY (`foglalas_id`),
  ADD KEY `szolgaltatas_id` (`szolgaltatas_id`),
  ADD KEY `dolgozo_id` (`dolgozo_id`),
  ADD KEY `vendeg_id` (`vendeg_id`);

--
-- A tábla indexei `vendeg`
--
ALTER TABLE `vendeg`
  ADD PRIMARY KEY (`vendeg_id`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `foglalas`
--
ALTER TABLE `foglalas`
  ADD CONSTRAINT `foglalas_ibfk_1` FOREIGN KEY (`szolgaltatas_id`) REFERENCES `szolgaltatas` (`szolgaltatas_id`),
  ADD CONSTRAINT `foglalas_ibfk_2` FOREIGN KEY (`dolgozo_id`) REFERENCES `dolgozók` (`dolgozo_id`),
  ADD CONSTRAINT `foglalas_ibfk_3` FOREIGN KEY (`vendeg_id`) REFERENCES `vendeg` (`vendeg_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
