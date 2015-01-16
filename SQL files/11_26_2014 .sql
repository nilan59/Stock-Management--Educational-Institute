-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 26, 2014 at 12:21 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `infortecstock`
--

-- --------------------------------------------------------

--
-- Table structure for table `addi`
--

CREATE TABLE IF NOT EXISTS `addi` (
  `userId` int(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `locationId` int(11) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `description` varchar(500) NOT NULL,
  PRIMARY KEY (`userId`,`itemId`,`date`),
  KEY `itemId` (`itemId`),
  KEY `locationId` (`locationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `addi`
--

INSERT INTO `addi` (`userId`, `itemId`, `locationId`, `amount`, `date`, `description`) VALUES
(0, 97, 55, 22, '2014-11-26 07:38:53', 'Initial Insert'),
(0, 98, 53, 64, '2014-11-26 11:17:22', 'Initial Insert'),
(0, 99, 50, 34, '2014-11-26 06:06:48', 'Initial Insert'),
(0, 99, 54, 47, '2014-11-26 06:09:52', 'Initial Insert'),
(0, 99, 51, 25, '2014-11-26 09:19:04', 'Initial Insert'),
(0, 100, 55, 1, '2014-11-26 07:44:59', 'Initial Insert'),
(0, 100, 52, 6, '2014-11-26 07:45:19', 'Initial Insert'),
(0, 101, 50, 40, '2014-11-26 06:06:11', 'Initial Insert'),
(0, 101, 55, 1, '2014-11-26 07:40:25', 'Initial Insert'),
(0, 101, 52, 1, '2014-11-26 07:45:34', 'Initial Insert'),
(0, 101, 51, 31, '2014-11-26 09:18:49', 'Initial Insert'),
(0, 102, 55, 6, '2014-11-26 07:39:22', 'Initial Insert'),
(0, 106, 50, 30, '2014-11-26 06:05:12', 'Initial Insert'),
(0, 106, 51, 25, '2014-11-26 09:17:25', 'Initial Insert'),
(0, 107, 50, 30, '2014-11-26 06:05:42', 'Initial Insert'),
(0, 107, 51, 25, '2014-11-26 09:16:59', 'Initial Insert'),
(0, 108, 50, 30, '2014-11-26 06:04:48', 'Initial Insertion'),
(0, 108, 51, 25, '2014-11-26 09:16:28', 'Initial Insert\r\n'),
(0, 109, 50, 30, '2014-11-26 06:05:32', 'Initial Insert'),
(0, 109, 51, 25, '2014-11-26 09:16:47', 'Initial Insert');

-- --------------------------------------------------------

--
-- Table structure for table `deduct`
--

CREATE TABLE IF NOT EXISTS `deduct` (
  `userId` int(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `locationId` int(11) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `description` varchar(500) NOT NULL,
  PRIMARY KEY (`userId`,`itemId`,`date`),
  KEY `itemId` (`itemId`),
  KEY `locationId` (`locationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `deletelog`
--

CREATE TABLE IF NOT EXISTS `deletelog` (
  `userId` int(11) NOT NULL,
  `locationId` int(11) NOT NULL,
  `itemId` int(11) NOT NULL,
  `description` varchar(200) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `amount` int(11) NOT NULL,
  PRIMARY KEY (`locationId`,`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE IF NOT EXISTS `item` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(40) NOT NULL,
  `description` varchar(400) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=110 ;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`id`, `name`, `description`) VALUES
(93, 'HDCS T-Shirt', '""'),
(94, 'HDEL T-Shirt', '""'),
(95, 'BCS T-Shirt', '""'),
(96, 'Staff T-Shirt', '""'),
(97, 'New cushion chair', '""'),
(98, 'Handrest chair', '""'),
(99, 'Normal chair', '""'),
(100, 'Rotating Chair', '""'),
(101, 'Computer Tables', '""'),
(102, 'Long wooden tables', '""'),
(106, 'Keyboard', '""'),
(107, 'Mouse', '""'),
(108, 'CPU', '""'),
(109, 'Monitor', '""');

-- --------------------------------------------------------

--
-- Table structure for table `located_in`
--

CREATE TABLE IF NOT EXISTS `located_in` (
  `itemId` int(11) NOT NULL,
  `locationId` int(11) NOT NULL,
  `amount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`itemId`,`locationId`),
  KEY `locationId` (`locationId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `located_in`
--

INSERT INTO `located_in` (`itemId`, `locationId`, `amount`) VALUES
(97, 55, 22),
(98, 53, 64),
(99, 50, 34),
(99, 51, 25),
(99, 54, 47),
(100, 52, 6),
(100, 55, 1),
(101, 50, 40),
(101, 51, 31),
(101, 52, 1),
(101, 55, 1),
(102, 55, 6),
(106, 50, 30),
(106, 51, 25),
(107, 50, 30),
(107, 51, 25),
(108, 50, 30),
(108, 51, 25),
(109, 50, 30),
(109, 51, 25);

-- --------------------------------------------------------

--
-- Table structure for table `location`
--

CREATE TABLE IF NOT EXISTS `location` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=57 ;

--
-- Dumping data for table `location`
--

INSERT INTO `location` (`id`, `name`) VALUES
(50, 'Lab 1'),
(51, 'Lab 2'),
(52, 'Lab 3'),
(53, 'Lecture Hall 1'),
(54, 'Lecture Hall 2'),
(55, 'BCS Hall'),
(56, 'General');

-- --------------------------------------------------------

--
-- Table structure for table `semesters`
--

CREATE TABLE IF NOT EXISTS `semesters` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `semesters`
--

INSERT INTO `semesters` (`id`, `name`) VALUES
(1, 'Semester 1'),
(2, 'Semester 2 Management'),
(3, 'Semester 2 Programming'),
(4, 'Other');

-- --------------------------------------------------------

--
-- Table structure for table `study_packs`
--

CREATE TABLE IF NOT EXISTS `study_packs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `semester` int(11) NOT NULL DEFAULT '3',
  `amount` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `semester` (`semester`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=72 ;

--
-- Dumping data for table `study_packs`
--

INSERT INTO `study_packs` (`id`, `name`, `semester`, `amount`) VALUES
(45, 'E - Commerce', 2, 92),
(47, 'Project Management', 2, 25),
(48, 'Diploma in english book 1', 4, 19),
(49, 'Diploma in english book 2', 4, 20),
(50, 'Managment Information Systems', 2, 57),
(51, 'HRM', 2, 144),
(52, 'DITEC', 4, 38),
(53, 'Finance', 2, 121),
(54, 'Web Designing', 1, 11),
(55, 'Supportive English Course', 4, 54),
(56, 'Javascript', 3, 39),
(57, 'Lab exercises', 1, 9),
(58, 'Operating Systems', 1, 19),
(59, 'MS Office 2010', 1, 22),
(60, 'Hardware and Networking', 1, 54),
(61, 'DBMS', 1, 38),
(62, 'Maths', 3, 18),
(63, 'PIIS', 2, 0),
(64, 'Software Engineering', 3, 16),
(65, 'Java', 3, 18),
(66, 'PHP', 3, 16),
(67, 'BCS Advance DBMS', 4, 2),
(68, 'BCS Computer Networks', 4, 9),
(69, 'BCS DBMS', 4, 13),
(70, 'BCS Professional issues in IS', 4, 16),
(71, 'BCS Information Systems', 4, 6);

-- --------------------------------------------------------

--
-- Table structure for table `study_packs_log`
--

CREATE TABLE IF NOT EXISTS `study_packs_log` (
  `userId` int(11) NOT NULL,
  `bookId` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `type` varchar(10) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `description` varchar(800) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) CHARACTER SET latin1 NOT NULL,
  `password` varchar(30) CHARACTER SET latin1 NOT NULL,
  `access_level` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `access_level` (`access_level`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_bin AUTO_INCREMENT=34 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `password`, `access_level`) VALUES
(24, 'nilan', '"?+cRp?%g???m??"', 1),
(30, 'kasun', '"??d???n???? ?"', 0),
(31, 'ushantha', '"?;I?H??b??d"', 0),
(32, 'mapalagama', '"???C???????????"', 0);

-- --------------------------------------------------------

--
-- Table structure for table `user_level`
--

CREATE TABLE IF NOT EXISTS `user_level` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_level`
--

INSERT INTO `user_level` (`id`, `name`) VALUES
(0, 'General User'),
(1, 'Administrator'),
(2, 'Other');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `addi`
--
ALTER TABLE `addi`
  ADD CONSTRAINT `addi_ibfk_3` FOREIGN KEY (`locationId`) REFERENCES `location` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `addi_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `item` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `deduct`
--
ALTER TABLE `deduct`
  ADD CONSTRAINT `deduct_ibfk_3` FOREIGN KEY (`locationId`) REFERENCES `location` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deduct_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `item` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `located_in`
--
ALTER TABLE `located_in`
  ADD CONSTRAINT `located_in_ibfk_2` FOREIGN KEY (`locationId`) REFERENCES `location` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `located_in_ibfk_1` FOREIGN KEY (`itemId`) REFERENCES `item` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `study_packs`
--
ALTER TABLE `study_packs`
  ADD CONSTRAINT `study_packs_ibfk_1` FOREIGN KEY (`semester`) REFERENCES `semesters` (`id`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`access_level`) REFERENCES `user_level` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
