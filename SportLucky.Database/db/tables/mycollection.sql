/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:10
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `mycollection`
-- ----------------------------
DROP TABLE IF EXISTS `mycollection`;
CREATE TABLE `mycollection` (
  `CollectionID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '收藏记录ID',
  `UserID` bigint(11) NOT NULL COMMENT '收藏者的用户ID',
  `CollectionType` tinyint(4) NOT NULL COMMENT '收藏类型 1-教练 2-场馆 3-文章',
  `ObjectID` bigint(20) NOT NULL COMMENT '根据收藏类型，对应Coach.CoachID, Gym.GymID,Article.ArticleID',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`CollectionID`),
  KEY `IX_MyCollection_UserID` (`UserID`),
  KEY `IX_MyCollection_ObjectID` (`ObjectID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='我的收藏记录';

-- ----------------------------
-- Records of mycollection
-- ----------------------------
