/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:43
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `gym`
-- ----------------------------
DROP TABLE IF EXISTS `gym`;
CREATE TABLE `gym` (
  `GymID` int(11) NOT NULL AUTO_INCREMENT COMMENT '场馆ID',
  `GymType` tinyint(4) DEFAULT '0' COMMENT '场馆类型，0-政府场馆 1-私人场馆',
  `CityID` int(6) DEFAULT NULL COMMENT '城市ID',
  `DistrictID` int(6) DEFAULT NULL COMMENT '区域ID',
  `GymName` varchar(200) NOT NULL COMMENT '场馆名称',
  `GymAddress` varchar(200) NOT NULL COMMENT '场馆地址',
  `GymDesc` varchar(500) NOT NULL,
  `Phone` varchar(200) DEFAULT NULL COMMENT '逗号分隔的电话号码',
  `Longitude` decimal(12,6) DEFAULT NULL COMMENT '场馆坐标经度',
  `Latitude` decimal(12,6) DEFAULT NULL COMMENT '场馆坐标纬度',
  `Photos_Json` varchar(500) DEFAULT NULL COMMENT '包含场馆图片URL的JSON字符串',
  `StarLevel` tinyint(4) DEFAULT NULL COMMENT '星级，1~5表示1到5级',
  `AdditionalService` varchar(500) DEFAULT NULL COMMENT '附加服务信息',
  `IsFree` bit(1) DEFAULT NULL COMMENT '是否免费',
  `HasWifi` bit(1) DEFAULT b'0' COMMENT '是否有无线',
  `HasShower` bit(1) DEFAULT b'0' COMMENT '是否有淋浴',
  `HasParking` bit(1) DEFAULT b'0' COMMENT '有无停车位',
  `HasDrink` bit(1) DEFAULT b'0' COMMENT '有无饮料',
  `HasEquipmentRented` bit(1) DEFAULT b'0' COMMENT '是否出租器材',
  `HasEquipmentSale` bit(1) DEFAULT b'0' COMMENT '是否售卖器材',
  `PrincipalID` bigint(20) DEFAULT NULL COMMENT '负责人用户ID',
  `DataChange_CreateTime` datetime DEFAULT NULL COMMENT '创建时间',
  `DataChange_LastTime` datetime DEFAULT NULL COMMENT '更新时间',
  PRIMARY KEY (`GymID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COMMENT='场馆信息';
-- ----------------------------
-- Records of gym
-- ----------------------------
