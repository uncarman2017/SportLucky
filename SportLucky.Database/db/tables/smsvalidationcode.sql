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
-- Table structure for `smsvalidationcode`
-- ----------------------------
DROP TABLE IF EXISTS `smsvalidationcode`;
CREATE TABLE `smsvalidationcode` (
  `Mobile` varchar(20) NOT NULL COMMENT '手机号码',
  `ValidationCode` varchar(100) COMMENT '短信验证码',
  `ExpireTime` datetime COMMENT '过期时间',
  PRIMARY KEY (`Mobile`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='短信验证码';

-- ----------------------------
-- Records of user
-- ----------------------------
