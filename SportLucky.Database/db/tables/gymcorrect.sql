/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:00
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `gymcorrect`
-- ----------------------------
DROP TABLE IF EXISTS `gymcorrect`;
CREATE TABLE `gymcorrect` (
  `CorrectID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '纠错记录ID',
  `UserID` bigint(11) NOT NULL COMMENT '评论人用户ID',
  `GymID` int(20) NOT NULL COMMENT '场馆ID',
  `CorrectDate` datetime NOT NULL COMMENT '纠错提交时间',
  `CorrectType` tinyint(4) NOT NULL DEFAULT '0' COMMENT '纠错类型, 1-电话有误,2-地址有误,3-地图位置有误',
  `Content` varchar(500) CHARACTER SET latin1 NOT NULL COMMENT '纠错内容',
  `Photos_Json` varchar(500) DEFAULT NULL COMMENT '包含场馆图片URL的JSON字符串',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`CorrectID`),
  KEY `IX_GymCorrect_UserID` (`UserID`),
  KEY `IX_GymCorrect_GymID` (`GymID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of gymcorrect
-- ----------------------------
