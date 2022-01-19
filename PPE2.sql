-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Mer 11 Janvier 2017 à 12:42
-- Version du serveur: 5.6.12-log
-- Version de PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `cinedechdimitrio`
--
CREATE DATABASE IF NOT EXISTS `cinedechdimitrio` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cinedechdimitrio`;

-- --------------------------------------------------------

--
-- Structure de la table `concerner`
--

CREATE TABLE IF NOT EXISTS `concerner` (
  `nofilm` int(11) NOT NULL,
  `nogenre` int(11) NOT NULL,
  PRIMARY KEY (`nofilm`,`nogenre`),
  KEY `nogenre` (`nogenre`),
  KEY `nofilm` (`nofilm`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `film`
--

CREATE TABLE IF NOT EXISTS `film` (
  `nofilm` int(11) NOT NULL AUTO_INCREMENT,
  `titre` varchar(100) NOT NULL,
  `realisateurs` varchar(255) NOT NULL,
  `acteurs` varchar(255) NOT NULL,
  `duree` varchar(10) NOT NULL,
  `synopsis` text NOT NULL,
  `infofilm` text NOT NULL,
  `imgaffiche` varchar(100) NOT NULL,
  `nopublic` int(11) NOT NULL,
  PRIMARY KEY (`nofilm`),
  KEY `nopublic` (`nopublic`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `genre`
--

CREATE TABLE IF NOT EXISTS `genre` (
  `nogenre` int(11) NOT NULL AUTO_INCREMENT,
  `libgenre` varchar(30) NOT NULL,
  PRIMARY KEY (`nogenre`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=103 ;

--
-- Contenu de la table `genre`
--

INSERT INTO `genre` (`nogenre`, `libgenre`) VALUES
(51, 'Action'),
(52, 'Animation'),
(53, 'Arts Martiaux'),
(56, 'Aventure'),
(57, 'Biopic'),
(58, 'Bollywood'),
(59, 'Classique'),
(60, 'Comédie'),
(61, 'Comédie dramatique'),
(62, 'Comédie musicale'),
(63, 'Concert'),
(64, 'Dessin animé'),
(65, 'Divers'),
(70, 'Documentaire'),
(71, 'Drama'),
(72, 'Drame'),
(73, 'Epouvante-horreur'),
(74, 'Erotique'),
(75, 'Espionnage'),
(76, 'Expérimental'),
(77, 'Famille'),
(78, 'Fantastique'),
(79, 'Guerre'),
(83, 'Historique'),
(84, 'Judiciaire'),
(85, 'Movie night'),
(86, 'Musical'),
(87, 'Opera'),
(88, 'Péplum'),
(89, 'Policier'),
(90, 'Romance'),
(91, 'Science fiction'),
(92, 'Show'),
(99, 'Sport event'),
(100, 'Thriller'),
(102, 'Western');

-- --------------------------------------------------------

--
-- Structure de la table `projection`
--

CREATE TABLE IF NOT EXISTS `projection` (
  `noproj` int(11) NOT NULL AUTO_INCREMENT,
  `dateproj` date NOT NULL,
  `heureproj` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `infoproj` varchar(50) DEFAULT NULL,
  `nosalle` varchar(1) NOT NULL,
  `nofilm` int(11) NOT NULL,
  PRIMARY KEY (`noproj`),
  KEY `nosalle` (`nosalle`),
  KEY `nofilm` (`nofilm`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `public`
--

CREATE TABLE IF NOT EXISTS `public` (
  `nopublic` int(11) NOT NULL AUTO_INCREMENT,
  `libpublic` varchar(50) NOT NULL,
  PRIMARY KEY (`nopublic`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Contenu de la table `public`
--

INSERT INTO `public` (`nopublic`, `libpublic`) VALUES
(10, 'Tous publics'),
(11, 'Tous publics avec Avertissement'),
(12, 'Interdit au moins de 12 ans'),
(13, 'Interdit aux moins de 12 ans avec Avertissement'),
(15, 'Interdit aux moins de 16 ans'),
(16, 'Interdit aux moins de 16 ans avec Avertissement'),
(20, 'Interdit aux moins de 18 ans');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE IF NOT EXISTS `reservation` (
  `noresa` int(11) NOT NULL AUTO_INCREMENT,
  `mdpresa` varchar(30) NOT NULL,
  `dateresa` date NOT NULL,
  `nomclient` varchar(30) NOT NULL,
  `nbplacesresa` int(3) DEFAULT NULL,
  `noproj` int(11) NOT NULL,
  PRIMARY KEY (`noresa`),
  KEY `noproj` (`noproj`),
  KEY `noproj_2` (`noproj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `salle`
--

CREATE TABLE IF NOT EXISTS `salle` (
  `nosalle` varchar(1) NOT NULL,
  `nbplaces` int(11) NOT NULL,
  PRIMARY KEY (`nosalle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `salle`
--

INSERT INTO `salle` (`nosalle`, `nbplaces`) VALUES
('A', 400),
('B', 400),
('C', 400),
('D', 300),
('E', 300),
('F', 300),
('G', 200),
('H', 200),
('I', 100),
('J', 100),
('K', 100);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `concerner`
--
ALTER TABLE `concerner`
  ADD CONSTRAINT `film_numero_3` FOREIGN KEY (`nofilm`) REFERENCES `film` (`nofilm`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `genre_numero_1` FOREIGN KEY (`nogenre`) REFERENCES `genre` (`nogenre`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `film`
--
ALTER TABLE `film`
  ADD CONSTRAINT `adapter` FOREIGN KEY (`nopublic`) REFERENCES `public` (`nopublic`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `projection`
--
ALTER TABLE `projection`
  ADD CONSTRAINT `avoirlieu` FOREIGN KEY (`nosalle`) REFERENCES `salle` (`nosalle`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `projeter` FOREIGN KEY (`nofilm`) REFERENCES `film` (`nofilm`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reserver` FOREIGN KEY (`noproj`) REFERENCES `projection` (`noproj`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
