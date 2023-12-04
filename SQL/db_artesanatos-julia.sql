-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 04, 2023 at 04:24 PM
-- Server version: 5.6.13
-- PHP Version: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_artesanatos-julia`
--
CREATE DATABASE IF NOT EXISTS `db_artesanatos-julia` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `db_artesanatos-julia`;

-- --------------------------------------------------------

--
-- Table structure for table `tb_clients`
--

CREATE TABLE IF NOT EXISTS `tb_clients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `CEP` char(9) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tb_clients`
--

INSERT INTO `tb_clients` (`id`, `name`, `CEP`) VALUES
(1, '2Berto', '00000-000'),
(3, 'João', '11111111'),
(6, 'Macunaima', '00000111');

-- --------------------------------------------------------

--
-- Table structure for table `tb_products`
--

CREATE TABLE IF NOT EXISTS `tb_products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `unit_value` decimal(4,2) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tb_products`
--

INSERT INTO `tb_products` (`id`, `name`, `unit_value`) VALUES
(1, 'Lorem ipsum', '69.69');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pss`
--

CREATE TABLE IF NOT EXISTS `tb_pss` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `wrk_name` varchar(100) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL,
  `psswd` varchar(128) NOT NULL,
  `salt` varchar(128) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `wrk_name_UNIQUE` (`wrk_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `tb_pss`
--

INSERT INTO `tb_pss` (`id`, `wrk_name`, `psswd`, `salt`) VALUES
(2, 'gerentegenerico', '641e2dcd93e35d6439821d601694853afc393bdca0b3b958c7c58f33', '510200b7b1bccb13adea60fc8cf6edca624e178abba4be7be027daf7'),
(4, 'gerente', '702bdaaa7c49458bbd3aa47fcde1ec093074d154ecce506b4a4597e5', 'dB2MxZFTXqTHrxPMcXlEMrYLasMuAkCXjNtfiIvCzVcUBkivIEbjFRVxztqAXGZVXdoBMzWcGjrZOiqRtVdRfUTZMiMEnSoAMTfQLvTxizlWPqYnWftQVJxopYqGTMWr'),
(5, 'caixa', '465433a128426d9886c0f0c22bc2a244f0057401fbf3e6ab523c50c5', 'jA0MFxCQMldtoGjrzWQyAFAtWpEGdmkpiVuChHbbxGOBouyEHhnuhRijgjCNQtqDRZURxsbABCIpQSshJqAgPVXoLgqibhaTvqcnOBpUdPEqSrEnDeVVrOkQnyagIHQM'),
(6, 'contador', 'e2850a2cd49875c8bfeb9502c79d889c397b1377c57bc3ea1bc310d9', 'yF5dAqNUbOqDqVaSUdlYJqDWATtoKJJZhtsYtYBAZmvqUUPoBiEZrQeMUseQKjvnbtEtdssMdVonuliPdbZSRcqgPzMyTqSYmcSBfmfqdMyWFdZXmQjZfSvOprDIMjki'),
(8, 'a', '1c7d1ed6e39fd40f68e72b096b0a10edf047f7e4ed6e40ed8d002c50', 'bF4OXIVEmYiTSAGFPakFimmDNTYjRmYNPDqsTbhLobEVCkaNrNLZxXzirdXUtHtyxLBRFTrqCpJMTeMQvOuZsodjxivvfAIIBoUaJyfrdAgrVcnqAEVpKAjYZMTkOdfB');

-- --------------------------------------------------------

--
-- Table structure for table `tb_sales`
--

CREATE TABLE IF NOT EXISTS `tb_sales` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `clt_name` varchar(100) NOT NULL,
  `prod_name` varchar(45) NOT NULL,
  `req_date` date DEFAULT NULL,
  `prod_qtd` int(11) NOT NULL,
  `is_request` tinyint(4) DEFAULT '0',
  `is_finished` tinyint(4) DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `client_idx` (`clt_name`),
  KEY `product_idx` (`prod_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `tb_sales`
--

INSERT INTO `tb_sales` (`id`, `clt_name`, `prod_name`, `req_date`, `prod_qtd`, `is_request`, `is_finished`) VALUES
(11, '2Berto', 'Lorem ipsum', '2023-12-02', 2, 0, 1),
(12, 'Macunaima', 'Lorem ipsum', '2023-12-02', 8, 0, 1),
(13, 'João', 'Lorem ipsum', '2023-12-02', 3, 0, 1),
(14, 'João', 'Lorem ipsum', '2023-12-02', 2, 1, 1),
(15, '2Berto', 'Lorem ipsum', '2023-12-04', 3, 0, 1),
(16, '2Berto', 'Lorem ipsum', '2023-12-04', 4, 0, 1),
(17, 'João', 'Lorem ipsum', '2023-12-04', 2, 0, 1),
(24, '2Berto', 'Lorem ipsum', '2023-12-04', 2, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tb_stock`
--

CREATE TABLE IF NOT EXISTS `tb_stock` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `prod_name` varchar(45) NOT NULL,
  `qtd` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `product_idx` (`prod_name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tb_stock`
--

INSERT INTO `tb_stock` (`id`, `prod_name`, `qtd`) VALUES
(2, 'Lorem ipsum', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tb_workers`
--

CREATE TABLE IF NOT EXISTS `tb_workers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) CHARACTER SET latin1 COLLATE latin1_bin NOT NULL,
  `occupation` varchar(10) NOT NULL,
  `entry` date NOT NULL,
  `on_leave` tinyint(4) NOT NULL,
  `resignation` date DEFAULT NULL,
  `active` tinyint(4) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `tb_workers`
--

INSERT INTO `tb_workers` (`id`, `name`, `occupation`, `entry`, `on_leave`, `resignation`, `active`) VALUES
(2, 'gerentegenerico', 'GERENCIA', '2023-11-18', 1, NULL, 1),
(14, 'gerente', 'GERENCIA', '2023-12-02', 0, NULL, 1),
(15, 'caixa', 'CAIXA', '2023-12-02', 0, NULL, 1),
(16, 'contador', 'CONTADOR', '2023-12-02', 0, NULL, 1),
(24, 'a', 'GERENCIA', '2023-12-04', 0, NULL, 1);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_pss`
--
ALTER TABLE `tb_pss`
  ADD CONSTRAINT `name` FOREIGN KEY (`wrk_name`) REFERENCES `tb_workers` (`name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tb_sales`
--
ALTER TABLE `tb_sales`
  ADD CONSTRAINT `client` FOREIGN KEY (`clt_name`) REFERENCES `tb_clients` (`name`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `prod` FOREIGN KEY (`prod_name`) REFERENCES `tb_products` (`name`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tb_stock`
--
ALTER TABLE `tb_stock`
  ADD CONSTRAINT `product` FOREIGN KEY (`prod_name`) REFERENCES `tb_products` (`name`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
