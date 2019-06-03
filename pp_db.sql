-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: pp_db
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agerating`
--

DROP TABLE IF EXISTS `agerating`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `agerating` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agerating`
--

LOCK TABLES `agerating` WRITE;
/*!40000 ALTER TABLE `agerating` DISABLE KEYS */;
INSERT INTO `agerating` VALUES (1,'12'),(2,'18'),(3,'16'),(4,'14'),(5,'6'),(6,'3');
/*!40000 ALTER TABLE `agerating` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `clients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fullname` varchar(60) NOT NULL,
  `address` varchar(60) NOT NULL,
  `contact` varchar(20) NOT NULL,
  `blackliststatus` tinyint(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (7,'Дьяконов Аркадий','Общага','89141111111',0),(9,'Огр','Болото','89140000000',1),(14,'Жирков Александр','ДСК 1','89242222222',1),(16,'Дьяконов Аркадий','Марха','89643333333',1),(17,'Захаров Борис','Авторынок','89148289050',0),(18,'Винокуров Сандал','Общага','89244444444',0),(22,'Зверьков Денис','Марха','89146666666',0),(23,'Дима','Общага','442013',1),(24,'Деулина Марина','Жатай','89447777777',0),(25,'Пирожков Александр','Сунтар','89118888888',1),(26,'Фёдорова Саша','Манньыаттаах','89649999999',0),(27,'Шамаев Semen','Якутск','444444',0),(69,'Рожин Донат','Якутск','424242',1),(70,'Местникова Евгения','Якутск','414141',1),(71,'Скрябин Андрей','Якутск','353535',0),(72,'Габышев Антон','Якутск','151515',1);
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `country`
--

DROP TABLE IF EXISTS `country`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `country` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `country`
--

LOCK TABLES `country` WRITE;
/*!40000 ALTER TABLE `country` DISABLE KEYS */;
INSERT INTO `country` VALUES (1,'Россия'),(2,'США'),(3,'Франция'),(4,'СССР');
/*!40000 ALTER TABLE `country` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genres`
--

DROP TABLE IF EXISTS `genres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `genres` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genres`
--

LOCK TABLES `genres` WRITE;
/*!40000 ALTER TABLE `genres` DISABLE KEYS */;
INSERT INTO `genres` VALUES (3,'Боевик'),(4,'Комедия'),(5,'Мелодрама'),(6,'Драма');
/*!40000 ALTER TABLE `genres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movies`
--

DROP TABLE IF EXISTS `movies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `movies` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(60) NOT NULL,
  `count` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `synopsis` varchar(100) DEFAULT NULL,
  `agerating` varchar(10) DEFAULT NULL,
  `genres` varchar(60) DEFAULT NULL,
  `year` varchar(4) DEFAULT NULL,
  `director` varchar(60) DEFAULT NULL,
  `country` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movies`
--

LOCK TABLES `movies` WRITE;
/*!40000 ALTER TABLE `movies` DISABLE KEYS */;
INSERT INTO `movies` VALUES (18,'Шрек',941490,100,'','12','Комедия','','','США'),(19,'Спасатели Малибу',3085,40,'','16','Комедия','','','США'),(20,'Дракула',123063,5,'','','','','',''),(22,'Мстители',10,200,'','12','Боевик','','','Россия');
/*!40000 ALTER TABLE `movies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `client` varchar(60) NOT NULL,
  `status` varchar(60) NOT NULL,
  `date` date DEFAULT NULL,
  `rent` date DEFAULT NULL,
  `disklist` varchar(255) NOT NULL,
  `deposit` varchar(60) NOT NULL,
  `closed_date` date DEFAULT NULL,
  `clid` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'Скрябин Андрей','2','2019-05-27','2019-05-30','18 2 ','200',NULL,71),(2,'Скрябин Андрей','0','2019-05-27','2019-06-16','18 3 19 2 20 1 ','385','2019-06-03',71),(3,'Шамаев Semen','1','2019-05-27','2019-06-19','18 12 19 3 ','1320',NULL,27),(4,'Винокуров Сандал','0','2019-06-03','2019-06-10','19 1 ','40','2019-06-03',18),(5,'Винокуров Сандал','0','2019-06-03','2019-06-06','19 1 20 1 ','45','2019-06-03',18);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-03 15:28:22
