/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:33:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `sms`
-- ----------------------------
DROP TABLE IF EXISTS `sms`;
CREATE TABLE `sms` (
  `SMSID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '短信记录ID',
  `Mobile` varchar(200) NOT NULL COMMENT '逗号分隔的接收人手机号码',
  `Content` varchar(300) NOT NULL COMMENT '短信内容',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`SMSID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='短信内容';

-- ----------------------------
-- Records of sms
-- ----------------------------
