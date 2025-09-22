-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-09-2025 a las 03:28:18
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `imc`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `acceso`
--

CREATE TABLE `acceso` (
  `Num_paciente` int(5) NOT NULL,
  `Usuario` varchar(25) NOT NULL,
  `Género` varchar(10) NOT NULL,
  `Contraseña` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `acceso`
--

INSERT INTO `acceso` (`Num_paciente`, `Usuario`, `Género`, `Contraseña`) VALUES
(0, '1', 'Hombre', '1'),
(0, 'Noe', 'Hombre', '12'),
(0, 'Noe', 'Hombre', 'hola');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `info_paciente`
--

CREATE TABLE `info_paciente` (
  `Num_paciente` int(5) NOT NULL,
  `Masa_kg` double NOT NULL,
  `Estatura_m` double NOT NULL,
  `IMC` float NOT NULL,
  `Género` varchar(10) NOT NULL,
  `Edad` int(3) NOT NULL,
  `Edo_Salud` text DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `info_paciente`
--

INSERT INTO `info_paciente` (`Num_paciente`, `Masa_kg`, `Estatura_m`, `IMC`, `Género`, `Edad`, `Edo_Salud`, `nombre`) VALUES
(0, 80, 3.0276, 26.4236, 'Hombre', 1, NULL, '1'),
(0, 75, 1.75, 24.4898, 'Hombre', 16, NULL, 'Noe');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
