-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Okt 04. 13:03
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 7.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `hataridonaplo`
--
CREATE DATABASE IF NOT EXISTS `hataridonaplo` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `hataridonaplo`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `elfoglaltsagok`
--

DROP TABLE IF EXISTS `elfoglaltsagok`;
CREATE TABLE `elfoglaltsagok` (
  `ID` int(11) NOT NULL,
  `szoveg` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `elfoglaltsagok`
--

INSERT INTO `elfoglaltsagok` (`ID`, `szoveg`) VALUES
(1, 'Megbeszélés'),
(2, 'Üzleti ebéd');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `heti`
--

DROP TABLE IF EXISTS `heti`;
CREATE TABLE `heti` (
  `id` int(11) NOT NULL,
  `datum` date NOT NULL,
  `nap` varchar(15) NOT NULL,
  `elfoglaltsag` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `napi`
--

DROP TABLE IF EXISTS `napi`;
CREATE TABLE `napi` (
  `id` int(11) NOT NULL,
  `datum` date NOT NULL,
  `ora` int(11) NOT NULL,
  `elfoglaltsag` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `elfoglaltsagok`
--
ALTER TABLE `elfoglaltsagok`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `heti`
--
ALTER TABLE `heti`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `napi`
--
ALTER TABLE `napi`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `elfoglaltsagok`
--
ALTER TABLE `elfoglaltsagok`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `heti`
--
ALTER TABLE `heti`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT a táblához `napi`
--
ALTER TABLE `napi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
