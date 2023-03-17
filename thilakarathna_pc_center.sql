-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 09, 2019 at 05:23 AM
-- Server version: 5.6.21
-- PHP Version: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `thilakarathna_pc_center`
--

-- --------------------------------------------------------

--
-- Table structure for table `additem`
--

CREATE TABLE IF NOT EXISTS `additem` (
  `productid` varchar(50) NOT NULL,
  `productname` varchar(200) NOT NULL,
  `description` varchar(50) NOT NULL,
  `quantity` int(100) NOT NULL,
  `price` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `additem`
--

INSERT INTO `additem` (`productid`, `productname`, `description`, `quantity`, `price`) VALUES
('ram-12', 'ram', '1gb', 10, 2000),
('ram-12', 'ram', '1gb', 15, 2000),
('ram-12', 'ram', '1gb', 80, 2000),
('ram-12', 'ram', '1gb', 0, 2000),
('pro-i3', 'processor', 'aluth badu', 20, 15000),
('pro-i3', 'processor', 'aluth badu', 0, 15000),
('ram-14', 'ram', '', 2, 3000),
('flash-12', 'flash drive', '', 2, 100),
('', '', '', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `cdetail`
--

CREATE TABLE IF NOT EXISTS `cdetail` (
  `fname` int(50) NOT NULL,
  `lname` int(50) NOT NULL,
  `cnic` varchar(10) NOT NULL,
  `address` varchar(200) NOT NULL,
  `contactno` int(10) NOT NULL,
  `cemail` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer_info`
--

CREATE TABLE IF NOT EXISTS `customer_info` (
`id` int(100) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `address` varchar(50) NOT NULL,
  `tel` int(10) NOT NULL,
  `email` varchar(20) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_info`
--

INSERT INTO `customer_info` (`id`, `fname`, `lname`, `nic`, `address`, `tel`, `email`) VALUES
(1, 'fffff', 'lll', '', 'sdf', 0, ''),
(2, 'fffffff', 'lllllll', '', '', 0, ''),
(3, 'bkj', '', '', 'xcfv', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `edetail`
--

CREATE TABLE IF NOT EXISTS `edetail` (
  `eid` varchar(50) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `enic` varchar(10) NOT NULL,
  `address` varchar(200) NOT NULL,
  `contactno` int(10) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `emailid` varchar(50) NOT NULL,
  `dateoj` date NOT NULL,
  `salary` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employee_detail`
--

CREATE TABLE IF NOT EXISTS `employee_detail` (
`id` int(10) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `tel` int(10) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `email` varchar(20) NOT NULL,
  `doj` varchar(15) NOT NULL,
  `salary` int(8) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=126 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_detail`
--

INSERT INTO `employee_detail` (`id`, `nic`, `fname`, `lname`, `address`, `tel`, `gender`, `email`, `doj`, `salary`) VALUES
(7, '', 'sdds', '', '', 0, '', '', '0000-00-00', 0),
(124, '978555555', 'ravi', 'lak', 'assassassas', 123123123, 'male', 'qwe12', '', 1277),
(125, '12121221', 'mal', 'hans', 'ggggggggg', 111111111, 'male', 'ewqwew', '15', 211);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `userlevel` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sdetail`
--

CREATE TABLE IF NOT EXISTS `sdetail` (
  `sid` varchar(50) NOT NULL,
  `fname` int(50) NOT NULL,
  `lname` int(50) NOT NULL,
  `snic` varchar(10) NOT NULL,
  `address` varchar(200) NOT NULL,
  `contactno` int(10) NOT NULL,
  `emailid` varchar(50) NOT NULL,
  `sof` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `supplier_detail`
--

CREATE TABLE IF NOT EXISTS `supplier_detail` (
`id` int(10) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `fname` varchar(20) NOT NULL,
  `lname` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `tel` int(10) NOT NULL,
  `email` varchar(20) NOT NULL,
  `supply_of` varchar(20) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier_detail`
--

INSERT INTO `supplier_detail` (`id`, `nic`, `fname`, `lname`, `address`, `tel`, `email`, `supply_of`) VALUES
(1, 'sdfsdf', 'sdf', 'sdf', '', 0, '', ''),
(2, '5555555', 'laki', 'nuwa', 'qwqwqwqq', 1123, 'qqq@yahoo.com', 'ramsrams');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
`id` int(2) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `user_level` int(2) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `user_level`) VALUES
(1, 'admin', '10admin', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer_info`
--
ALTER TABLE `customer_info`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee_detail`
--
ALTER TABLE `employee_detail`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier_detail`
--
ALTER TABLE `supplier_detail`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer_info`
--
ALTER TABLE `customer_info`
MODIFY `id` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `employee_detail`
--
ALTER TABLE `employee_detail`
MODIFY `id` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=126;
--
-- AUTO_INCREMENT for table `supplier_detail`
--
ALTER TABLE `supplier_detail`
MODIFY `id` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
MODIFY `id` int(2) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
