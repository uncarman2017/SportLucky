/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:05
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `loginhistory`
-- ----------------------------
DROP TABLE IF EXISTS `loginhistory`;
CREATE TABLE `loginhistory` (
  `LoginHistoryID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '登录记录ID',
  `Mobile` varchar(20) NOT NULL COMMENT '手机号码',
  `UserID` bigint(20) NOT NULL COMMENT '用户编号',
  `ValidationCode` varchar(10) DEFAULT NULL COMMENT '验证码',
  `IsValid` bit(1) DEFAULT NULL COMMENT '验证码是否有效，验证过后就变为无效',
  `DataChange_CreateTime` datetime DEFAULT NULL COMMENT '创建时间',
  `DataChange_LastTime` datetime DEFAULT NULL COMMENT '更新时间',
  PRIMARY KEY (`LoginHistoryID`),
  KEY `IX_LoginHistory_UserID` (`UserID`),
  KEY `IX_LoginHistory_Mobile` (`Mobile`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COMMENT='用户登陆历史记录';

-- ----------------------------
-- Records of loginhistory
-- ----------------------------