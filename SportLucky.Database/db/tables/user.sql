/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:49
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `UserID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '用户编号',
  `Mobile` varchar(20) NOT NULL COMMENT '手机号码',
  `MobileInfo` varchar(1000) DEFAULT NULL COMMENT 'JSON格式的手机信息',
  `LoginPwd` varchar(200) NOT NULL COMMENT '登陆密码，AES加密',
  `UserType` tinyint(4) NOT NULL COMMENT '用户类型 1: 教练 2: 客人',
  `NickName` varchar(20) NOT NULL COMMENT '昵称',
  `Sex` tinyint(4) NOT NULL COMMENT '性别,1-男 2-女',
  `Age` tinyint(4) NOT NULL COMMENT '年龄',
  `PersonalSign` varchar(200) DEFAULT NULL COMMENT '个性签名',
  `HeadPortraitUri` varchar(200) DEFAULT NULL COMMENT '头像图片路径',
  `Height` float DEFAULT NULL COMMENT '身高',
  `Weight` float DEFAULT NULL COMMENT '体重',
  `UserStatus` tinyint(4) NOT NULL DEFAULT '1' COMMENT '用户状态 0: 待审核 1: 有效 2: 注销',
  `DataChange_CreateTime` datetime DEFAULT NULL COMMENT '创建时间',
  `DataChange_LastTime` datetime DEFAULT NULL COMMENT '更新时间',
  PRIMARY KEY (`UserID`),
  KEY `IX_User_Mobile` (`Mobile`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COMMENT='用户信息';

-- ----------------------------
-- Records of user
-- ----------------------------
