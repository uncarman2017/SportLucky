/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:23
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `cmu_note`
-- ----------------------------
DROP TABLE IF EXISTS `cmu_note`;
CREATE TABLE `cmu_note` (
  `NoteID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '帖子记录ID',
  `UserID` int(11) NOT NULL COMMENT '发帖人的用户ID',
  `Content` varchar(300) NOT NULL COMMENT '帖子内容',
  `Imgs` varchar(2000) DEFAULT NULL COMMENT '帖子图片集，存放图片URL的JSON字符串\r\n格式如 {["Url":"images/Notes/1/img1.png","Url":"images/Notes/1/img2.png"]}',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`NoteID`),
  KEY `IX_CmnNote_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='运动缘发帖记录';

-- ----------------------------
-- Records of cmu_note
-- ----------------------------
