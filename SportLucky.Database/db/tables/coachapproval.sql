/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:48
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `coachapproval`
-- ----------------------------
DROP TABLE IF EXISTS `coachapproval`;
CREATE TABLE `coachapproval` (
  `CoachApprovalID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '教练审批记录ID',
  `UserID` bigint(20) NOT NULL COMMENT '用户ID',
  `Level` tinyint(4) NOT NULL COMMENT '教练级别,1-初级教练 2-中级教练 3-高级教练 4-培训师',
  `ContactInfo` varchar(200) CHARACTER SET utf8 NOT NULL COMMENT '联系方式',
  `PersonalSign` varchar(200) DEFAULT NULL COMMENT '个性签名',
  `BriefIntroduction` varchar(300) CHARACTER SET utf8 DEFAULT NULL COMMENT '个人简介',
  `HonorDesc` varchar(300) CHARACTER SET utf8 DEFAULT NULL COMMENT '所获得的荣誉描述',
  `IsFree` bit(1) NOT NULL DEFAULT b'0' COMMENT '是否公益教练,0-否 1-是',
  `Certificates` varchar(500) CHARACTER SET utf8 DEFAULT NULL COMMENT '存放证书图片路径的JSON字符串',
  `CourseDesc` varchar(500) DEFAULT NULL COMMENT '课程安排',
  `GymDesc` varchar(500) DEFAULT NULL,
  `AreaDesc` varchar(500) DEFAULT NULL COMMENT '活动区域描述',
  `Photos` varchar(500) CHARACTER SET utf8 DEFAULT NULL COMMENT '存放教练照片路径的JSON字符串',
  `ApproveStatus` tinyint(4) NOT NULL DEFAULT '1' COMMENT '审批状态,1-审批中 2-审批通过 3-审批拒绝',
  `ApproveTime` datetime NOT NULL COMMENT '最后一次审批时间',
  `ApproverUserID` bigint(20) DEFAULT NULL COMMENT '审核者用户ID',
  `CoachID` int(11) DEFAULT NULL COMMENT '教练ID',
  `IsHomeRecommended` bit(1) DEFAULT b'0' COMMENT '是否首页推荐',
  `RecommendDate` datetime DEFAULT NULL COMMENT '推荐日期',
  `Years` smallint(6) DEFAULT NULL COMMENT '教龄',
  `DataChange_CreateTime` datetime DEFAULT NULL COMMENT '创建时间',
  `DataChange_LastTime` datetime DEFAULT NULL COMMENT '更新时间',
  PRIMARY KEY (`CoachApprovalID`),
  KEY `IX_CoachApproval_UserID` (`UserID`),
  KEY `IX_CoachApproval_CoachID` (`CoachID`),
  KEY `IX_CoachApproval_ApproverUserID` (`ApproverUserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='私教入驻审核记录';

-- ----------------------------
-- Records of coachapproval
-- ----------------------------
