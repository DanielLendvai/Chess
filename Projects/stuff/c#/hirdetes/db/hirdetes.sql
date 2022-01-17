-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Okt 04. 15:36
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 7.4.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `hirdetes`
--
CREATE DATABASE IF NOT EXISTS `hirdetes` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `hirdetes`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `hirdetes`
--

DROP TABLE IF EXISTS `hirdetes`;
CREATE TABLE `hirdetes` (
  `id` int(11) NOT NULL,
  `szoveg` text COLLATE utf8mb4_hungarian_ci NOT NULL,
  `userid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `hirdetes`
--

INSERT INTO `hirdetes` (`id`, `szoveg`, `userid`) VALUES
(8, 'Első hirdetés', 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `licitek`
--

DROP TABLE IF EXISTS `licitek`;
CREATE TABLE `licitek` (
  `id` int(11) NOT NULL,
  `hirdetes` int(11) NOT NULL,
  `datum` datetime NOT NULL,
  `licit` decimal(10,0) NOT NULL,
  `user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `licitek`
--

INSERT INTO `licitek` (`id`, `hirdetes`, `datum`, `licit`, `user`) VALUES
(1, 8, '2021-10-04 15:31:53', '6', 1),
(2, 8, '2021-10-04 15:32:14', '7', 2),
(3, 8, '2021-10-04 15:32:47', '7', 2),
(4, 8, '2021-10-04 15:32:55', '12', 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `userid` varchar(80) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `password` varchar(80) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `name` varchar(120) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `admin` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `userid`, `password`, `name`, `admin`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'Admin', 1),
(2, 'user', 'ee11cbb19052e40b07aac0ca060c23ee', 'User', NULL);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `hirdetes`
--
ALTER TABLE `hirdetes`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `licitek`
--
ALTER TABLE `licitek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `hirdetes`
--
ALTER TABLE `hirdetes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT a táblához `licitek`
--
ALTER TABLE `licitek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
