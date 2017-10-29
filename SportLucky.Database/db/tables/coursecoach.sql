/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `coursecoach`
-- ----------------------------
DROP TABLE IF EXISTS `coursecoach`;
CREATE TABLE `coursecoach` (
  `CourseCoachID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '记录编号',
  `CourseTypeID` int(10) NOT NULL COMMENT '课程编号',
  `CoachID` int(10) NOT NULL COMMENT '教练编号',
  `IsValid` bit(1) NOT NULL DEFAULT b'1' COMMENT '是否有效,0-无效 1-有效',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '创建时间',
  PRIMARY KEY (`CourseCoachID`),
  KEY `IX_CourseCoach_CoachID` (`CoachID`),
  KEY `IX_CourseCoach_CourseTypeID` (`CourseTypeID`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='课程和教练的关系';

-- ----------------------------
-- Records of coursecoach
-- ----------------------------
