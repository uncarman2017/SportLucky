/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:26
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `pointsgainhistory`
-- ----------------------------
DROP TABLE IF EXISTS `pointsgainhistory`;
CREATE TABLE `pointsgainhistory` (
  `RecID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '记录ID',
  `UserID` int(11) NOT NULL COMMENT '用户ID',
  `Points` smallint(6) NOT NULL COMMENT '获得的积分',
  `GainWay` smallint(6) NOT NULL DEFAULT '0' COMMENT '获取途径:0-其他 1-签到 2-新增场馆 3-场馆首评 4-私教绑定 5-课后评论 6-私教反馈',
  `GainDate` datetime NOT NULL COMMENT '获得积分的时间',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '记录更新时间',
  PRIMARY KEY (`RecID`),
  KEY `IX_PointsGainHistory_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='肌点获取历史记录';

-- ----------------------------
-- Records of pointsgainhistory
-- ----------------------------
