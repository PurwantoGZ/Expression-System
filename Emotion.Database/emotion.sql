/*
SQLyog Ultimate v10.42 
MySQL - 5.5.5-10.1.13-MariaDB : Database - emotion
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`emotion` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `emotion`;

/*Table structure for table `coba` */

DROP TABLE IF EXISTS `coba`;

CREATE TABLE `coba` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `a` double DEFAULT NULL,
  `b` double DEFAULT NULL,
  `c` double DEFAULT NULL,
  `d` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `coba` */

insert  into `coba`(`id`,`a`,`b`,`c`,`d`) values (1,1,2,3,4),(2,3,7,8,9),(3,35,37,24,98),(4,2,32,39,78),(5,100,108,198,203);

/*Table structure for table `favorite` */

DROP TABLE IF EXISTS `favorite`;

CREATE TABLE `favorite` (
  `idFavorite` int(9) NOT NULL AUTO_INCREMENT,
  `favoriteName` text,
  `priority` int(3) DEFAULT NULL,
  `idUser` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idFavorite`),
  KEY `idUser` (`idUser`),
  CONSTRAINT `favorite_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`)
) ENGINE=InnoDB AUTO_INCREMENT=258 DEFAULT CHARSET=latin1;

/*Data for the table `favorite` */

/*Table structure for table `output` */

DROP TABLE IF EXISTS `output`;

CREATE TABLE `output` (
  `idOutput` varchar(3) NOT NULL,
  `Output` text,
  PRIMARY KEY (`idOutput`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `output` */

insert  into `output`(`idOutput`,`Output`) values ('0','Sedih'),('1','Senang');

/*Table structure for table `setting` */

DROP TABLE IF EXISTS `setting`;

CREATE TABLE `setting` (
  `idSetting` int(3) NOT NULL AUTO_INCREMENT,
  `Setting` text,
  `Value` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idSetting`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `setting` */

insert  into `setting`(`idSetting`,`Setting`,`Value`) values (1,'increase','1.1'),(2,'neighbors','2'),(3,'scale','10');

/*Table structure for table `testing` */

DROP TABLE IF EXISTS `testing`;

CREATE TABLE `testing` (
  `idTesting` int(9) NOT NULL AUTO_INCREMENT,
  `idOutput` varchar(3) DEFAULT NULL,
  `F1` double NOT NULL,
  `F2` double NOT NULL,
  `F3` double NOT NULL,
  `F4` double NOT NULL,
  `F5` double NOT NULL,
  `F6` double NOT NULL,
  `idUser` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idTesting`),
  KEY `idUser` (`idUser`),
  KEY `idOutput` (`idOutput`),
  CONSTRAINT `testing_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`),
  CONSTRAINT `testing_ibfk_2` FOREIGN KEY (`idOutput`) REFERENCES `output` (`idOutput`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `testing` */

/*Table structure for table `training` */

DROP TABLE IF EXISTS `training`;

CREATE TABLE `training` (
  `idTraining` int(9) NOT NULL AUTO_INCREMENT,
  `idOutput` varchar(3) NOT NULL,
  `F1` double NOT NULL,
  `F2` double NOT NULL,
  `F3` double NOT NULL,
  `F4` double NOT NULL,
  `F5` double NOT NULL,
  `F6` double NOT NULL,
  `idUser` varchar(255) NOT NULL,
  PRIMARY KEY (`idTraining`),
  KEY `idUser` (`idUser`),
  KEY `idOutput` (`idOutput`),
  CONSTRAINT `training_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`),
  CONSTRAINT `training_ibfk_2` FOREIGN KEY (`idOutput`) REFERENCES `output` (`idOutput`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=latin1;

/*Data for the table `training` */

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `idUser` varchar(255) NOT NULL,
  `fullName` text,
  `gender` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user` */

/*Table structure for table `weight` */

DROP TABLE IF EXISTS `weight`;

CREATE TABLE `weight` (
  `idWeight` varchar(10) NOT NULL,
  `wi1` double NOT NULL,
  `wi2` double NOT NULL,
  `wi3` double NOT NULL,
  `wi4` double NOT NULL,
  `wi5` double NOT NULL,
  `wi6` double NOT NULL,
  `wi7` double NOT NULL,
  `wi8` double NOT NULL,
  `wi9` double NOT NULL,
  `wi10` double NOT NULL,
  `wi11` double NOT NULL,
  `wi12` double NOT NULL,
  `wi13` double NOT NULL,
  `wi14` double NOT NULL,
  `wi15` double NOT NULL,
  `wi16` double NOT NULL,
  `wi17` double NOT NULL,
  `wi18` double NOT NULL,
  `bi1` double NOT NULL,
  `bi2` double NOT NULL,
  `bi3` double NOT NULL,
  `wj1` double NOT NULL,
  `wj2` double NOT NULL,
  `wj3` double NOT NULL,
  `bj1` double NOT NULL,
  `kb` double NOT NULL,
  `idUser` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idWeight`),
  KEY `idUser` (`idUser`),
  CONSTRAINT `weight_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `weight` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
