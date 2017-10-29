/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:48
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `gymapproval`
-- ----------------------------
DROP TABLE IF EXISTS `gymapproval`;
CREATE TABLE `gymapproval` (
  `GymApprovalID` bigint(11) NOT NULL AUTO_INCREMENT COMMENT '场馆审核记录ID',
  `GymName` varchar(200) CHARACTER SET utf8 NOT NULL COMMENT '场馆名称',
  `GymAddress` varchar(200) CHARACTER SET utf8 NOT NULL COMMENT '场馆地址',
  `GymDesc` varchar(500) CHARACTER SET utf8 NOT NULL,
  `Longitude` decimal(12,4) DEFAULT NULL COMMENT '场馆坐标经度',
  `Latitude` decimal(12,4) DEFAULT NULL COMMENT '场馆坐标纬度',
  `Photos` varchar(500) CHARACTER SET utf8 DEFAULT NULL COMMENT '包含场馆图片URL的JSON字符串',
  `ApproveTime` datetime NOT NULL COMMENT '最后一次审批时间',
  `ApproveStatus` tinyint(4) NOT NULL DEFAULT '1' COMMENT '审批状态,1-审批中 2-审批通过 3-审批拒绝',
  `ApproverUserID` bigint(20) DEFAULT NULL,
  `GymID` int(11) DEFAULT NULL COMMENT '场馆ID',
  `GymType` tinyint(4) DEFAULT '0' COMMENT '场馆类型，0-政府场馆 1-私人场馆',
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
  PRIMARY KEY (`GymApprovalID`),
  KEY `IX_GymApproval_GymID` (`GymID`),
  KEY `IX_GymApproval_ApproverUserID` (`ApproverUserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='场馆审核信息';

-- ----------------------------
-- Records of gymapproval
-- ----------------------------
