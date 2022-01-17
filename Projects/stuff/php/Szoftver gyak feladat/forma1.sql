-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Okt 01. 15:23
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
-- Adatbázis: `forma1`
--

DELIMITER $$
--
-- Eljárások
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_CheckRajtszam` (IN `rajtszam` INT)  BEGIN
	SELECT COUNT(versenyzok.nev) AS 'van'
	FROM versenyzok
	WHERE versenyzok.rajtszam = rajtszam;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_Csapatok` ()  BEGIN
	SELECT 
		nev,
    	azon
	FROM csapatok;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_NemUjoncVersenyzok` ()  BEGIN
	SELECT
		versenyzok.rajtszam		AS 'vRajt',
	    versenyzok.nev			AS 'vNev',
	    versenyzok.nemzetiseg	AS 'vNemz',
	    csapatok.nev			AS 'csNev'
	FROM
		versenyzok
	    LEFT JOIN kapcsolat ON versenyzok.rajtszam=kapcsolat.VersenyAzon
	    LEFT JOIN csapatok ON kapcsolat.CsapatAzon=csapatok.azon
	WHERE versenyzok.ujonc <> 1
	ORDER BY versenyzok.nev;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_UjVersenyzo` (IN `vNev` VARCHAR(60), IN `vRajt` INT, IN `csAzon` INT, IN `ujonc` INT(1), IN `belep` DATE)  BEGIN
    INSERT INTO versenyzok(nev, rajtszam, ujonc, belepes)
    VALUES (vNev, vRajt, ujonc, belep);

    INSERT INTO kapcsolat(csapatAzon, versenyAzon)
    VALUES (csAzon, vRajt);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `csapatok`
--

CREATE TABLE `csapatok` (
  `nev` varchar(60) DEFAULT NULL,
  `azon` int(11) NOT NULL,
  `motor` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `csapatok`
--

INSERT INTO `csapatok` (`nev`, `azon`, `motor`) VALUES
('Mercedes-AMG Petronas Motorsport', 1, 'Mercedes'),
('Scuderia Ferrari Mission Winnow', 2, 'Ferrari'),
('Red Bull Racing', 3, 'Honda'),
('McLaren F1 Team', 4, 'Mercedes'),
('Alpine F1 Team', 5, 'Renault'),
('Scuderia Alpha Tauri Honda', 6, 'Honda'),
('Aston Martin Cognization F1 Team', 7, 'Mercedes'),
('Williams Racing', 8, 'Mercedes'),
('Haas F1 Team', 9, 'Ferrari'),
('Alfa Romeo Racing Orlen', 10, 'Ferrari');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kapcsolat`
--

CREATE TABLE `kapcsolat` (
  `VersenyAzon` int(11) DEFAULT NULL,
  `CsapatAzon` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `kapcsolat`
--

INSERT INTO `kapcsolat` (`VersenyAzon`, `CsapatAzon`) VALUES
(44, 1),
(77, 1),
(55, 2),
(16, 2),
(33, 3),
(11, 3),
(3, 4),
(4, 4),
(31, 5),
(14, 5),
(22, 6),
(10, 6),
(5, 7),
(18, 7),
(7, 10),
(99, 10),
(47, 9),
(9, 9),
(63, 8),
(6, 8);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `versenyzok`
--

CREATE TABLE `versenyzok` (
  `nev` varchar(60) DEFAULT NULL,
  `rajtszam` int(11) NOT NULL,
  `nemzetiseg` varchar(40) DEFAULT NULL,
  `ujonc` int(1) DEFAULT NULL,
  `belepes` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `versenyzok`
--

INSERT INTO `versenyzok` (`nev`, `rajtszam`, `nemzetiseg`, `ujonc`, `belepes`) VALUES
('Daniel Ricciardo', 3, 'ausztrál', 0, '2021-01-18'),
('Lando Norris', 4, 'brit', 0, '2019-01-09'),
('Sebastion Vettel', 5, 'német', 0, '2020-12-30'),
('Nicholas Latifi', 6, 'kanadai', 0, '2020-01-07'),
('Kimi Raikonen', 7, 'finn', 0, '2019-01-16'),
('Nikita Mazepin', 9, 'orosz', 1, '2021-01-06'),
('Pierre Gasly', 10, 'francia', 0, '2019-08-24'),
('Sergio Perez', 11, 'mexikói', 0, '2021-02-03'),
('Fernando Alonso', 14, 'spanyol', 0, '2021-02-28'),
('Charles Leclerc', 16, 'monacói', 0, '2019-01-03'),
('Lance Stroll', 18, 'kanadai', 0, '2019-01-05'),
('Yuki Tsunoda', 22, 'japán', 1, '2021-02-14'),
('Esteban Ocon', 31, 'francia', 0, '2019-12-02'),
('Max Verstappen', 33, 'holland', 0, '2016-01-01'),
('Lewis Hamilton', 44, 'brit', 0, '2012-12-01'),
('Mick Schumaher', 47, 'német', 1, '2021-01-02'),
('Carlos Sainz Jnr', 55, 'spanyol', 0, '2020-12-28'),
('George Russel ', 63, 'brit', 0, '2019-02-01'),
('Valtteri Bottas', 77, 'finn', 0, '2017-01-08'),
('Antonio Giovinazzi', 99, 'olasz', 0, '2019-01-16');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `csapatok`
--
ALTER TABLE `csapatok`
  ADD PRIMARY KEY (`azon`);

--
-- A tábla indexei `kapcsolat`
--
ALTER TABLE `kapcsolat`
  ADD KEY `VersenyAzon` (`VersenyAzon`),
  ADD KEY `CsapatAzon` (`CsapatAzon`);

--
-- A tábla indexei `versenyzok`
--
ALTER TABLE `versenyzok`
  ADD PRIMARY KEY (`rajtszam`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kapcsolat`
--
ALTER TABLE `kapcsolat`
  ADD CONSTRAINT `kapcsolat_ibfk_1` FOREIGN KEY (`VersenyAzon`) REFERENCES `versenyzok` (`rajtszam`),
  ADD CONSTRAINT `kapcsolat_ibfk_2` FOREIGN KEY (`CsapatAzon`) REFERENCES `csapatok` (`azon`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
