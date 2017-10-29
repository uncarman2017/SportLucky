/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:32:08
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `coursecomment`
-- ----------------------------
DROP TABLE IF EXISTS `coursecomment`;
CREATE TABLE `coursecomment` (
  `CommentID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '评论记录ID',
  `UserID` int(11) NOT NULL COMMENT '评论者的用户ID',
  `CourseBookingID` bigint(20) NOT NULL COMMENT '课程预订记录ID',
  `CommentDate` datetime NOT NULL COMMENT '评论时间',
  `Comment` varchar(500) NOT NULL COMMENT '评论内容',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`CommentID`),
  KEY `IX_CourseComment_UserID` (`UserID`),
  KEY `IX_CourseComment_CourseBookingID` (`CourseBookingID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='课程评论';
-- ----------------------------
-- Records of coursecomment
-- ----------------------------
