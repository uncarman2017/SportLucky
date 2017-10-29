/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:07
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `checkin`
-- ----------------------------
DROP TABLE IF EXISTS `checkin`;
CREATE TABLE `checkin` (
  `CheckInID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '签到记录ID',
  `UserID` int(11) DEFAULT NULL COMMENT '签到人用户ID',
  `CheckInTime` datetime DEFAULT NULL COMMENT '签到时间',
  `Points` int(11) DEFAULT NULL COMMENT '本次签到肌点数',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '记录更新时间',
  PRIMARY KEY (`CheckInID`),
  KEY `IX_CheckIn_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='签到记录';

-- ----------------------------
-- Records of checkin
-- ----------------------------
