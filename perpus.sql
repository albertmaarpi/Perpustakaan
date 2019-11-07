/*
SQLyog Ultimate v12.5.1 (64 bit)
MySQL - 10.4.6-MariaDB : Database - perpustakaan
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`perpustakaan` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `perpustakaan`;

/*Table structure for table `buku` */

DROP TABLE IF EXISTS `buku`;

CREATE TABLE `buku` (
  `judul` varchar(255) NOT NULL,
  `sub_judul` varchar(255) DEFAULT NULL,
  `nomor_panggil` varchar(20) DEFAULT NULL,
  `nama_DDC` varchar(255) DEFAULT NULL,
  `subjek` varchar(255) DEFAULT NULL,
  `pengarang` varchar(255) DEFAULT NULL,
  `penerbit` varchar(255) DEFAULT NULL,
  `kota_terbit` varchar(255) DEFAULT NULL,
  `tahun_terbit` datetime DEFAULT NULL,
  `edisi` varchar(255) DEFAULT NULL,
  `volume` varchar(255) DEFAULT NULL,
  `ISBN` varchar(255) DEFAULT NULL,
  `kode` varchar(255) DEFAULT NULL,
  `harga` varchar(255) DEFAULT NULL,
  `bahasa` varchar(255) DEFAULT NULL,
  `halaman_romawi` varchar(255) DEFAULT NULL,
  `halaman_arab` varchar(255) DEFAULT NULL,
  `tinggi` varchar(255) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  `keaslian` varchar(255) DEFAULT NULL,
  `kondisi` varchar(255) DEFAULT NULL,
  `id_buku` int(30) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`judul`,`id_buku`),
  KEY `id_buku` (`id_buku`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `buku` */

/*Table structure for table `buku_ta` */

DROP TABLE IF EXISTS `buku_ta`;

CREATE TABLE `buku_ta` (
  `id_bukuta` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `judul` varchar(255) DEFAULT NULL,
  `pengarang` varchar(255) DEFAULT NULL,
  `NRP` varchar(20) DEFAULT NULL,
  `pembimbing` varchar(255) DEFAULT NULL,
  `co_pembimbing` varchar(255) DEFAULT NULL,
  `tahun` datetime DEFAULT NULL,
  `abstrak` varchar(255) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  `kondisi` varchar(255) DEFAULT NULL,
  `penguji1` varchar(255) DEFAULT NULL,
  `penguji2` varchar(255) DEFAULT NULL,
  `penguji3` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_bukuta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `buku_ta` */

/*Table structure for table `cd` */

DROP TABLE IF EXISTS `cd`;

CREATE TABLE `cd` (
  `id_cd` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `judul` varchar(255) DEFAULT NULL,
  `jenis` varchar(255) DEFAULT NULL,
  `harga` varchar(255) DEFAULT NULL,
  `keterangan` varchar(255) DEFAULT NULL,
  `kode` varchar(255) DEFAULT NULL,
  `kondisi` varchar(255) DEFAULT NULL,
  `rak` varchar(255) DEFAULT NULL,
  `tanggal` datetime DEFAULT NULL,
  PRIMARY KEY (`id_cd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `cd` */

/*Table structure for table `userperpus` */

DROP TABLE IF EXISTS `userperpus`;

CREATE TABLE `userperpus` (
  `id_user` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `status` tinyint(1) NOT NULL DEFAULT 1,
  `jabatan` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `userperpus` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
