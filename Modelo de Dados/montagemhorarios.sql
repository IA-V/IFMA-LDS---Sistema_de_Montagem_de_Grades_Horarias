-- MySQL dump 10.16  Distrib 10.1.30-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: montagemhorarios
-- ------------------------------------------------------
-- Server version	10.1.30-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `coordenador`
--

DROP TABLE IF EXISTS `coordenador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `coordenador` (
  `idCoordenador` int(11) NOT NULL AUTO_INCREMENT,
  `vigencia` int(11) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `idProfessor` int(11) NOT NULL,
  PRIMARY KEY (`idCoordenador`),
  KEY `idProfessor` (`idProfessor`),
  CONSTRAINT `coordenador_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `professor` (`idProfessor`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coordenador`
--

LOCK TABLES `coordenador` WRITE;
/*!40000 ALTER TABLE `coordenador` DISABLE KEYS */;
INSERT INTO `coordenador` VALUES (14,1,'985c3c3ba527e3857cf08e1afbb43d43dafa38e173aee8444465d100c9c2966c',5);
/*!40000 ALTER TABLE `coordenador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disciplinatecnica`
--

DROP TABLE IF EXISTS `disciplinatecnica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `disciplinatecnica` (
  `idDisciplinaTecnica` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `cargaHoraria` int(11) NOT NULL,
  `sigla` varchar(5) NOT NULL,
  PRIMARY KEY (`idDisciplinaTecnica`),
  UNIQUE KEY `nome` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disciplinatecnica`
--

LOCK TABLES `disciplinatecnica` WRITE;
/*!40000 ALTER TABLE `disciplinatecnica` DISABLE KEYS */;
INSERT INTO `disciplinatecnica` VALUES (1,'Laboratório de Desenvolvimento de Software',80,'LDS'),(2,'Modelagem de Sistemas',40,'MS');
/*!40000 ALTER TABLE `disciplinatecnica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gradehoraria`
--

DROP TABLE IF EXISTS `gradehoraria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gradehoraria` (
  `idGradeHoraria` int(11) NOT NULL AUTO_INCREMENT,
  `anoSemestre` varchar(10) NOT NULL,
  `idLaboratorio` int(11) NOT NULL,
  `status` int(11) DEFAULT NULL,
  PRIMARY KEY (`idGradeHoraria`),
  KEY `idLaboratorio` (`idLaboratorio`),
  CONSTRAINT `gradehoraria_ibfk_1` FOREIGN KEY (`idLaboratorio`) REFERENCES `laboratorio` (`idLaboratorio`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gradehoraria`
--

LOCK TABLES `gradehoraria` WRITE;
/*!40000 ALTER TABLE `gradehoraria` DISABLE KEYS */;
INSERT INTO `gradehoraria` VALUES (30,'2018.2',1,1);
/*!40000 ALTER TABLE `gradehoraria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario`
--

DROP TABLE IF EXISTS `horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario` (
  `idHorario` int(11) NOT NULL AUTO_INCREMENT,
  `idProfessor` int(11) NOT NULL,
  `idDisciplinaTecnica` int(11) NOT NULL,
  `horario` varchar(30) NOT NULL,
  `diaSemana` varchar(30) NOT NULL,
  `turma` varchar(30) NOT NULL,
  PRIMARY KEY (`idHorario`),
  KEY `idProfessor` (`idProfessor`),
  KEY `idDisciplinaTecnica` (`idDisciplinaTecnica`),
  CONSTRAINT `horario_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `professor` (`idProfessor`),
  CONSTRAINT `horario_ibfk_2` FOREIGN KEY (`idDisciplinaTecnica`) REFERENCES `disciplinatecnica` (`idDisciplinaTecnica`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario`
--

LOCK TABLES `horario` WRITE;
/*!40000 ALTER TABLE `horario` DISABLE KEYS */;
INSERT INTO `horario` VALUES (30,9,1,'08:55 - 10:35','Segunda','602'),(31,9,2,'10:50 - 12:30','Terça','402'),(32,9,2,'10:50 - 12:30','Quinta','402');
/*!40000 ALTER TABLE `horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horario_gradehoraria`
--

DROP TABLE IF EXISTS `horario_gradehoraria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `horario_gradehoraria` (
  `idHorarioGradeHoraria` int(11) NOT NULL AUTO_INCREMENT,
  `idHorario` int(11) NOT NULL,
  `idGradeHoraria` int(11) NOT NULL,
  PRIMARY KEY (`idHorarioGradeHoraria`),
  KEY `idHorario` (`idHorario`),
  KEY `idGradeHoraria` (`idGradeHoraria`),
  CONSTRAINT `horario_gradehoraria_ibfk_1` FOREIGN KEY (`idHorario`) REFERENCES `horario` (`idHorario`),
  CONSTRAINT `horario_gradehoraria_ibfk_2` FOREIGN KEY (`idGradeHoraria`) REFERENCES `gradehoraria` (`idGradeHoraria`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horario_gradehoraria`
--

LOCK TABLES `horario_gradehoraria` WRITE;
/*!40000 ALTER TABLE `horario_gradehoraria` DISABLE KEYS */;
INSERT INTO `horario_gradehoraria` VALUES (27,30,30),(28,31,30),(29,32,30);
/*!40000 ALTER TABLE `horario_gradehoraria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `laboratorio`
--

DROP TABLE IF EXISTS `laboratorio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laboratorio` (
  `idLaboratorio` int(11) NOT NULL AUTO_INCREMENT,
  `numero` int(11) NOT NULL,
  `quantComp` int(11) NOT NULL,
  `localizacao` varchar(70) NOT NULL,
  PRIMARY KEY (`idLaboratorio`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `laboratorio`
--

LOCK TABLES `laboratorio` WRITE;
/*!40000 ALTER TABLE `laboratorio` DISABLE KEYS */;
INSERT INTO `laboratorio` VALUES (1,25,20,'DCOMP');
/*!40000 ALTER TABLE `laboratorio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professor`
--

DROP TABLE IF EXISTS `professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `professor` (
  `idProfessor` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `matricula` varchar(20) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `status` int(11) NOT NULL,
  PRIMARY KEY (`idProfessor`),
  UNIQUE KEY `matricula` (`matricula`),
  UNIQUE KEY `cpf` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professor`
--

LOCK TABLES `professor` WRITE;
/*!40000 ALTER TABLE `professor` DISABLE KEYS */;
INSERT INTO `professor` VALUES (5,'admin','adminn','99104620011',1),(9,'Mauro Lopes','20152a','62571531077',1);
/*!40000 ALTER TABLE `professor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-06 23:45:00
