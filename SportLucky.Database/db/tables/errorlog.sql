/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:36
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `errorlog`
-- ----------------------------
DROP TABLE IF EXISTS `errorlog`;
CREATE TABLE `errorlog` (
  `LogID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '日志记录ID',
  `ClassName` varchar(50) NOT NULL COMMENT '出错代码所在类的全名(包含命名空间)',
  `MethodName` varchar(50) NOT NULL COMMENT '出错代码所在方法名',
  `ErrorMsg` varchar(1000) NOT NULL COMMENT '错误信息',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '时间戳',
  PRIMARY KEY (`LogID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of errorlog
-- ----------------------------
