-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Nov 20. 22:31
-- Kiszolgáló verziója: 10.1.36-MariaDB
-- PHP verzió: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `witcher`
--
CREATE DATABASE IF NOT EXISTS `witcher` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `witcher`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `wfaj`
--

CREATE TABLE `wfaj` (
  `id` int(10) NOT NULL,
  `faj` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `wfaj`
--

INSERT INTO `wfaj` (`id`, `faj`) VALUES
(1, 'állat'),
(2, 'átkozott'),
(3, 'sárkány'),
(4, 'elementál'),
(5, 'hibrid'),
(6, 'rovar'),
(7, 'élőhalott'),
(8, 'ogroid'),
(9, 'szellem');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `wkarakterek`
--

CREATE TABLE `wkarakterek` (
  `id` int(10) NOT NULL,
  `nev` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `ero` int(10) NOT NULL DEFAULT '0',
  `nem` enum('férfi','nő') COLLATE utf8_hungarian_ci NOT NULL,
  `gyengeseg` varchar(30) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `kep` varchar(50) COLLATE utf8_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `wkarakterek`
--

INSERT INTO `wkarakterek` (`id`, `nev`, `ero`, `nem`, `gyengeseg`, `kep`) VALUES
(1, 'Ríviai Geralt', 1000, 'férfi', 'nők', 'Ríviai Geralt.jpg'),
(2, 'Vengerbergi Yennefer', 1000, 'nő', 'Ríviai Geralt', 'Vengerbergi Yennefer.jpg'),
(3, 'Ciri hercegnő', 700, 'nő', NULL, 'Ciri hercegnő.jpg'),
(4, 'Tissaia de Vries', 850, 'nő', 'hatalomvágy', 'Tissaia de Vries.jpg'),
(5, 'Vilgefortz', 500, 'férfi', 'sütemény', 'Vilgefortz.jpg'),
(6, 'Fringilla', 830, 'nő', 'kígyók', 'Fringilla.jpg'),
(7, 'Cahir', 700, 'férfi', 'méreg', 'Cahir.jpg'),
(8, 'Kökörcsin', 1, 'férfi', 'csend', NULL),
(9, 'Stregobor', 430, 'férfi', 'bor', 'Stregobor.jpg'),
(10, 'Renfri hercegnő', 10, 'nő', 'férfiak', 'Renfri hercegnő.jpg'),
(11, 'Erszényes', 660, 'férfi', 'közelharc', NULL),
(12, 'Eist király', 15, 'férfi', 'bor', 'Eist király.jpg'),
(13, 'Eithne', 630, 'nő', 'tűz', 'Eithne.jpg'),
(14, 'Triss Merigold', 900, 'nő', 'Ríviai Geralt', 'Triss Merigold.jpg'),
(15, 'Borch, az aranysárkány', 890, 'férfi', 'íjászok', 'Borch az aranysárkány.jpg'),
(16, 'Fletcher', 200, 'férfi', 'nők', 'Fletcher.jpg'),
(17, 'Berengar', 910, 'férfi', 'méreg', 'Berengar.jpg'),
(18, 'Klef', 1000, 'férfi', 'mágia', NULL),
(19, 'Rennes', 1200, 'férfi', 'méreg', NULL),
(20, 'Varin', 940, 'férfi', 'sör', NULL);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `wkarakterek_felszerelese`
--

CREATE TABLE `wkarakterek_felszerelese` (
  `targy_id` int(10) NOT NULL,
  `karakter_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `wkarakterek_felszerelese`
--

INSERT INTO `wkarakterek_felszerelese` (`targy_id`, `karakter_id`) VALUES
(1, 1),
(1, 3),
(1, 7),
(1, 15),
(1, 18),
(1, 19),
(1, 20),
(2, 1),
(2, 7),
(2, 11),
(2, 17),
(2, 19),
(3, 1),
(3, 3),
(3, 16),
(3, 18),
(3, 19),
(3, 20),
(4, 2),
(4, 4),
(4, 5),
(4, 6),
(4, 7),
(4, 9),
(4, 14),
(4, 19);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `wkuldetes`
--

CREATE TABLE `wkuldetes` (
  `karakter_id` int(10) NOT NULL,
  `szorny_id` int(10) NOT NULL,
  `jutalom_arany` int(10) NOT NULL,
  `jutalom_targy` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `wkuldetes`
--

INSERT INTO `wkuldetes` (`karakter_id`, `szorny_id`, `jutalom_arany`, `jutalom_targy`) VALUES
(1, 5, 30, '-'),
(7, 2, 150, '-'),
(14, 10, 200, '-'),
(2, 1, 0, 'lámpás'),
(8, 2, 5, 'kabát'),
(1, 7, 400, 'Jégkockatartó'),
(6, 9, 350, '-'),
(17, 10, 0, 'Hamutartó'),
(1, 15, 1000, '-'),
(3, 6, 50, 'Fejdísz'),
(2, 5, 200, '-'),
(8, 4, 0, 'Pörkölt'),
(1, 1, 0, 'lámpás'),
(14, 9, 120, '-'),
(3, 3, 80, '-'),
(1, 4, 0, 'Pörkölt'),
(2, 11, 250, '-'),
(6, 12, 0, 'Páncél'),
(5, 3, 60, '-'),
(4, 8, 3, '-'),
(1, 6, 50, '-'),
(9, 14, 0, '-'),
(2, 4, 0, 'Pörkölt'),
(4, 7, 200, 'Jégkockatartó'),
(20, 8, 3, '-'),
(14, 6, 30, '-'),
(3, 5, 0, 'Ló'),
(2, 2, 5, 'Cipő'),
(20, 2, 80, '-');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `wszornyek`
--

CREATE TABLE `wszornyek` (
  `id` int(10) NOT NULL,
  `nev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `ero` int(10) NOT NULL,
  `gyengeseg` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `faj_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `wszornyek`
--

INSERT INTO `wszornyek` (`id`, `nev`, `ero`, `gyengeseg`, `faj_id`) VALUES
(1, 'Dzsinn', 1000, 'lámpás', 4),
(2, 'Medve', 230, 'tűz', 1),
(3, 'Kikimore', 500, 'kard', 6),
(4, 'Vaddisznó', 180, 'kard', 1),
(5, 'Ghoul', 320, 'ezüst', 7),
(6, 'Hárpia', 300, 'nyílpuska', 5),
(7, 'Jégóriás', 2000, 'tűz', 8),
(8, 'Három kicsi malac', 3, 'méreg', 1),
(9, 'Ezüst baziliszkusz', 800, 'kard', 3),
(10, 'Gólem', 600, 'kalapács', 4),
(11, 'Hym', 450, 'ezüst', 9),
(12, 'Arachnomorf', 680, 'tűz', 6),
(13, 'Küklopsz', 900, 'nyílpuska', 8),
(14, 'Botchling', 100, 'ezüst', 2),
(15, 'Banya', 730, 'ezüst', 7);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `wtargyak`
--

CREATE TABLE `wtargyak` (
  `id` int(10) NOT NULL,
  `nev` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `anyag` varchar(30) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `wtargyak`
--

INSERT INTO `wtargyak` (`id`, `nev`, `anyag`) VALUES
(1, 'kard', 'vas'),
(2, 'nyílpuska', 'fa'),
(3, 'kard', 'ezüst'),
(4, 'varázsbot', 'fa');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `wfaj`
--
ALTER TABLE `wfaj`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `wkarakterek`
--
ALTER TABLE `wkarakterek`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A tábla indexei `wkarakterek_felszerelese`
--
ALTER TABLE `wkarakterek_felszerelese`
  ADD KEY `targy_id` (`targy_id`,`karakter_id`),
  ADD KEY `karakter_id` (`karakter_id`);

--
-- A tábla indexei `wkuldetes`
--
ALTER TABLE `wkuldetes`
  ADD KEY `karakter_id` (`karakter_id`,`szorny_id`),
  ADD KEY `szorny_id` (`szorny_id`);

--
-- A tábla indexei `wszornyek`
--
ALTER TABLE `wszornyek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `faj_id` (`faj_id`);

--
-- A tábla indexei `wtargyak`
--
ALTER TABLE `wtargyak`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `wfaj`
--
ALTER TABLE `wfaj`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT a táblához `wkarakterek`
--
ALTER TABLE `wkarakterek`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT a táblához `wszornyek`
--
ALTER TABLE `wszornyek`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT a táblához `wtargyak`
--
ALTER TABLE `wtargyak`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `wkarakterek_felszerelese`
--
ALTER TABLE `wkarakterek_felszerelese`
  ADD CONSTRAINT `wkarakterek_felszerelese_ibfk_1` FOREIGN KEY (`karakter_id`) REFERENCES `wkarakterek` (`id`),
  ADD CONSTRAINT `wkarakterek_felszerelese_ibfk_2` FOREIGN KEY (`targy_id`) REFERENCES `wtargyak` (`id`);

--
-- Megkötések a táblához `wkuldetes`
--
ALTER TABLE `wkuldetes`
  ADD CONSTRAINT `wkuldetes_ibfk_1` FOREIGN KEY (`karakter_id`) REFERENCES `wkarakterek` (`id`),
  ADD CONSTRAINT `wkuldetes_ibfk_2` FOREIGN KEY (`szorny_id`) REFERENCES `wszornyek` (`id`);

--
-- Megkötések a táblához `wszornyek`
--
ALTER TABLE `wszornyek`
  ADD CONSTRAINT `wszornyek_ibfk_1` FOREIGN KEY (`faj_id`) REFERENCES `wfaj` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
