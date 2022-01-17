-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Szerver verzió:               10.4.20-MariaDB - mariadb.org binary distribution
-- Szerver OS:                   Win64
-- HeidiSQL Verzió:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Adatbázis struktúra mentése a danix.
CREATE DATABASE IF NOT EXISTS `danix` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `danix`;

-- Struktúra mentése tábla danix. dolgozok
CREATE TABLE IF NOT EXISTS `dolgozok` (
  `azonosito` int(11) NOT NULL AUTO_INCREMENT,
  `fonok` int(11) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `jelszo` varchar(50) NOT NULL,
  `nev` varchar(80) NOT NULL,
  `beosztas` varchar(50) DEFAULT NULL,
  `kep` varchar(50) DEFAULT NULL,
  `oneletrajz` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`azonosito`),
  UNIQUE KEY `UNIQUE_EMAIL` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COMMENT='A dolgozók listája';

TRUNCATE TABLE dolgozok;

-- Tábla adatainak mentése danix.dolgozok: ~8 rows (hozzávetőleg)
/*!40000 ALTER TABLE `dolgozok` DISABLE KEYS */;
INSERT INTO `dolgozok` (`azonosito`, `fonok`, `email`, `jelszo`, `nev`, `beosztas`, `kep`, `oneletrajz`) VALUES
	(1, 0, 'ldani@gmail.com', 'sasa', 'Lendvai Dániel', 'nagyfőnök', './images/1.jpg', ''),
	(2, 1, 'a@b.c', 'sasa', 'Valaki #1', 'alkalmazott', NULL, NULL),
	(3, 1, 'b@b.c', 'sasa', 'Valaki #2', 'alkalmazott', NULL, NULL),
	(4, 1, 'c@b.c', 'sasa', 'Fonok #1', 'kisfonok', NULL, NULL),
	(5, 4, 'd@b.c', 'sasa', 'Valaki #3', 'alkalmazott', NULL, NULL),
	(6, 4, 'e@b.c', 'sasa', 'Valaki #4', 'alkalmazott', NULL, NULL),
	(7, 1, 'f@b.c', 'sasa', 'Valaki #5', 'alkalmazott', NULL, NULL),
	(8, 4, 'szgt64@gmail.com', 'sasa', 'Lendvai Ferenc', 'programozó', NULL, NULL);
/*!40000 ALTER TABLE `dolgozok` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
