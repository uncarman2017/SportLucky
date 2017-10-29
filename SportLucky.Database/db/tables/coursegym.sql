/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:15
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `coursegym`
-- ----------------------------
DROP TABLE IF EXISTS `coursegym`;
CREATE TABLE `coursegym` (
  `CourseGymID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '记录编号',
  `CourseTypeID` int(10) NOT NULL COMMENT '课程类型编号',
  `GymID` int(10) NOT NULL COMMENT '场馆编号',
  `IsValid` bit(1) NOT NULL DEFAULT b'1' COMMENT '是否有效,0-无效 1-有效',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`CourseGymID`),
  KEY `IX_Gym_GymID` (`GymID`),
  KEY `IX_Gym_CourseTypeID` (`CourseTypeID`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='场馆和课程类型的关系';

-- ----------------------------
-- Records of coursegym
-- ----------------------------
