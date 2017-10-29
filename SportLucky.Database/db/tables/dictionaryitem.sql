/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:29
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `dictionaryitem`
-- ----------------------------
DROP TABLE IF EXISTS `dictionaryitem`;
CREATE TABLE `dictionaryitem` (
  `DicItemID` int(11) NOT NULL AUTO_INCREMENT COMMENT '字典项ID',
  `DicType` varchar(20) NOT NULL COMMENT '枚举类型\r\nCollectionType-收藏对象的类型\r\nConsumeWay-肌点消费途径\r\nGainWay-肌点获取途径\r\n',
  `ItemText` varchar(20) NOT NULL COMMENT '枚举文本',
  `ItemValue` smallint(6) NOT NULL COMMENT '枚举值',
  PRIMARY KEY (`DicItemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='字典项';

-- ----------------------------
-- Records of dictionaryitem
-- ----------------------------
