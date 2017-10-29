/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:33
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `siteletter`
-- ----------------------------
DROP TABLE IF EXISTS `siteletter`;
CREATE TABLE `siteletter` (
  `LetterID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '站内信ID',
  `UserID` int(11) NOT NULL COMMENT '收信人用户ID',
  `Title` varchar(20) CHARACTER SET utf8 NOT NULL COMMENT '标题',
  `Content` varchar(300) CHARACTER SET utf8 NOT NULL COMMENT '内容',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`LetterID`),
  KEY `IX_SiteLetter_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='站内信';

-- ----------------------------
-- Records of siteletter
-- ----------------------------
