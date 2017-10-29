/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:15
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `citydistrict`
-- ----------------------------
DROP TABLE IF EXISTS `citydistrict`;
CREATE TABLE `citydistrict` (
  `RecID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '记录ID',
  `CityID` int(11) NOT NULL COMMENT '城市ID',
  `DistrictID` int(11) NOT NULL COMMENT '行政区ID',
  PRIMARY KEY (`RecID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of citydistrict
-- ----------------------------
