/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:00
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `article`
-- ----------------------------
DROP TABLE IF EXISTS `article`;
CREATE TABLE `article` (
  `ArticleID` bigint(20) NOT NULL COMMENT '文章ID',
  `UserID` int(11) NOT NULL COMMENT '发表人用户ID',
  `Title` varchar(100) NOT NULL,
  `Content` varchar(2000) NOT NULL,
  `PublishTime` datetime NOT NULL COMMENT '文章发布时间',
  `IsHomeRecommended` bit(1) NOT NULL DEFAULT b'0' COMMENT '是否首页引荐',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`ArticleID`),
  KEY `IX_Article_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='用户发表的文章记录';

-- ----------------------------
-- Records of article
-- ----------------------------
