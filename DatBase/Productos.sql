CREATE DATABASE  IF NOT EXISTS `productos` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `productos`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: productos
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `codigo` varchar(15) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `stock` int DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `fechaActualizacion` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Laptop ASUS','7501234567890','Laptop para oficina 8GB RAM',15,14500.00,'Activo','2025-10-27 19:39:54'),(2,'Mouse Logitech','7509876543210','Mouse inalámbrico ergonómico',50,450.00,'Activo','2025-10-27 19:39:54'),(3,'Teclado Mecánico','7501112223334','Teclado mecánico para programadores',30,1200.00,'Activo','2025-10-27 19:39:54'),(4,'Monitor Samsung 24\"','7504445556667','Monitor Full HD 24 pulgadas',20,3200.00,'Activo','2025-10-27 19:39:54'),(5,'Impresora HP','7508889990001','Impresora multifuncional WiFi',10,2800.00,'Activo','2025-10-27 19:39:54'),(6,'Auriculares Sony','7502223334448','Auriculares con micrófono',40,650.00,'Activo','2025-10-27 19:39:54'),(7,'Silla Gamer','7505556667772','Silla ergonómica para gaming',12,4200.00,'Activo','2025-10-27 19:39:54'),(8,'Webcam Logitech','7509998887773','Webcam 1080p para streaming',25,1100.00,'Activo','2025-10-27 19:39:54'),(9,'Tablet Samsung','7501239876543','Tablet 10 pulgadas 64GB',18,6800.00,'Activo','2025-10-27 19:39:54'),(10,'Smartwatch Xiaomi','7503216549876','Reloj inteligente con monitor cardíaco',35,2100.00,'Activo','2025-10-27 19:39:54');
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-27 19:54:23
