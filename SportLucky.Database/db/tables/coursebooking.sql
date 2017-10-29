/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:55
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `coursebooking`
-- ----------------------------
DROP TABLE IF EXISTS `coursebooking`;
CREATE TABLE `coursebooking` (
  `CourseBookingID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '记录ID',
  `UserID` bigint(20) NOT NULL COMMENT '用户编号',
  `CourseTypeID` int(10) NOT NULL COMMENT '课程类型',
  `CoachID` int(10) NOT NULL COMMENT '教练编号',
  `BookingTime` datetime NOT NULL COMMENT '预订时间即下单时间',
  `CourseDate` datetime NOT NULL COMMENT '上课日期',
  `CourseBeginTime` time DEFAULT NULL COMMENT '课程开始时间',
  `CourseEndTime` time DEFAULT NULL COMMENT '课程结束时间',
  `Hours` int(11) NOT NULL COMMENT '课时，单位节',
  `BookingStatus` tinyint(4) NOT NULL DEFAULT '0' COMMENT '预订状态,0-新订 1-教练已确认 2-完成 3-取消 4-过期',
  `GymAddress` varchar(200) NOT NULL COMMENT '场馆地址',
  `Remark` varchar(300) DEFAULT NULL COMMENT '备注',
  `IsCoachMobilePublic` bit(1) DEFAULT NULL COMMENT '教练手机号是否公开',
  `CancelReason` varchar(200) DEFAULT NULL COMMENT '取消原因',
  `DataChange_CreateTime` datetime DEFAULT NULL,
  `DataChange_LastTime` datetime DEFAULT NULL,
  PRIMARY KEY (`CourseBookingID`),
  KEY `IX_CourseBooking_UserID` (`UserID`),
  KEY `IX_CourseBooking_CoachID` (`CoachID`),
  KEY `IX_CourseBooking_CourseTypeID` (`CourseTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='课程预订信息';

-- ----------------------------
-- Records of coursebooking
-- ----------------------------
