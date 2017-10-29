/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:55
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `userfeedback`
-- ----------------------------
DROP TABLE IF EXISTS `userfeedback`;
CREATE TABLE `userfeedback` (
  `FeedbackID` bigint(20) NOT NULL DEFAULT '0' COMMENT '客户反馈记录ID',
  `UserID` int(11) NOT NULL COMMENT '用户ID',
  `Title` varchar(20) NOT NULL COMMENT '标题',
  `Content` varchar(300) NOT NULL COMMENT '内容',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`FeedbackID`),
  KEY `IX_UserFeedback_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='用户反馈信息';

-- ----------------------------
-- Records of userfeedback
-- ----------------------------
