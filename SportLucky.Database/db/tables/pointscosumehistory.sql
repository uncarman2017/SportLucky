/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:19
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `pointscosumehistory`
-- ----------------------------
DROP TABLE IF EXISTS `pointscosumehistory`;
CREATE TABLE `pointscosumehistory` (
  `RecID` bigint(20) NOT NULL COMMENT '记录ID',
  `UserID` int(11) NOT NULL COMMENT '用户ID',
  `Points` smallint(6) NOT NULL COMMENT '获得的积分',
  `CosumeWay` smallint(6) NOT NULL DEFAULT '0' COMMENT '消费途径:0-其他 1-公益课 2-公开课 3-教练等级提升培训课程',
  `ConsumeDate` datetime NOT NULL COMMENT '消费积分的时间',
  `CourseBookingID` bigint(20) DEFAULT NULL COMMENT '课程预订记录ID',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '记录更新时间',
  PRIMARY KEY (`RecID`),
  KEY `IX_PointsConsumeHistory_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='肌点消费历史记录';

-- ----------------------------
-- Records of pointscosumehistory
-- ----------------------------
