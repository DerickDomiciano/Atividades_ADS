-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2021 at 02:39 AM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `biblioteca`
--

-- --------------------------------------------------------

--
-- Table structure for table `livro`
--

CREATE TABLE `livro` (
  `idLivro` int(11) NOT NULL,
  `tituloLivro` varchar(200) NOT NULL,
  `autorLivro` varchar(100) NOT NULL,
  `categoriaLivro` varchar(100) NOT NULL,
  `precoLivro` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `livro`
--

INSERT INTO `livro` (`idLivro`, `tituloLivro`, `autorLivro`, `categoriaLivro`, `precoLivro`) VALUES
(1, 'Harry Potter', 'J.K.Rowling', 'Ficção Científica, Fantasia', 25),
(2, 'A Escrita da História', 'Peter Burke', 'História', 40),
(3, 'As Vantagens de ser Invisível', 'Stephen Chbosky', 'Romance', 25),
(4, 'A dominação masculina', 'Pierre Bourdieu', 'História', 30),
(5, 'Minha História das Mulheres', 'Michelle Perrot', 'História', 30);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `livro`
--
ALTER TABLE `livro`
  ADD PRIMARY KEY (`idLivro`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `livro`
--
ALTER TABLE `livro`
  MODIFY `idLivro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
