/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:54
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `gymcomment`
-- ----------------------------
DROP TABLE IF EXISTS `gymcomment`;
CREATE TABLE `gymcomment` (
  `CommentID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '评论记录ID',
  `UserID` bigint(11) NOT NULL COMMENT '评论人用户ID',
  `GymID` int(20) NOT NULL COMMENT '场馆ID',
  `CommentDate` datetime DEFAULT NULL COMMENT '评论时间',
  `TotalAssessment` tinyint(4) DEFAULT '1' COMMENT '整体评价,1-5表示1~5星',
  `EnviromentAssessment` tinyint(4) DEFAULT '1' COMMENT '场馆环境评价,1-5表示1~5星',
  `ServiceAssessment` tinyint(4) DEFAULT '1' COMMENT '服务态度评价,1-5表示1~5星',
  `EquipmentAssessment` tinyint(4) DEFAULT '1' COMMENT '设备新旧评价,1-5表示1~5星',
  `Comment` varchar(500) CHARACTER SET latin1 NOT NULL COMMENT '评论内容',
  `Photos_Json` varchar(500) DEFAULT NULL COMMENT '包含场馆图片URL的JSON字符串',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`CommentID`),
  KEY `IX_GymComment_UserID` (`UserID`),
  KEY `IX_GymComment_GymID` (`GymID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='场馆评论记录';


-- ----------------------------
-- Records of gymcomment
-- ----------------------------
