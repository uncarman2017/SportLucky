/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:22
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `coursetype`
-- ----------------------------
DROP TABLE IF EXISTS `coursetype`;
CREATE TABLE `coursetype` (
  `CourseTypeID` int(11) NOT NULL COMMENT '课程类型ID',
  `ChargeType` tinyint(4) NOT NULL COMMENT '收费类型, 0-公益课 1-公开课 2-教练提升等级培训课程 3-免费体验  4-限时折扣',
  `CourseTypeName` varchar(200) CHARACTER SET utf8 NOT NULL COMMENT '课程类型名称',
  PRIMARY KEY (`CourseTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='课程类型信息';

-- ----------------------------
-- Records of coursetype
-- ----------------------------
INSERT INTO `coursetype` VALUES ('1', '0', '自由器械');
INSERT INTO `coursetype` VALUES ('2', '0', '瑜伽');
INSERT INTO `coursetype` VALUES ('3', '0', '舞蹈');
INSERT INTO `coursetype` VALUES ('4', '0', '动感单车');
INSERT INTO `coursetype` VALUES ('5', '0', '团体课');
INSERT INTO `coursetype` VALUES ('6', '0', '游泳');
INSERT INTO `coursetype` VALUES ('7', '0', '武术');
INSERT INTO `coursetype` VALUES ('8', '1', '自由器械');
INSERT INTO `coursetype` VALUES ('9', '1', '瑜伽');
INSERT INTO `coursetype` VALUES ('10', '1', '舞蹈');
INSERT INTO `coursetype` VALUES ('11', '1', '动感单车');
INSERT INTO `coursetype` VALUES ('12', '1', '团体课');
INSERT INTO `coursetype` VALUES ('13', '1', '游泳');
INSERT INTO `coursetype` VALUES ('14', '1', '武术');
INSERT INTO `coursetype` VALUES ('999', '0', '其他');
INSERT INTO `coursetype` VALUES ('1999', '1', '其他');
