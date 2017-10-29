/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : sportlucky

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-10-13 19:31:32
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `cmu_notecomment`
-- ----------------------------
DROP TABLE IF EXISTS `cmu_notecomment`;
CREATE TABLE `cmu_notecomment` (
  `NoteCommentID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '帖子评论记录ID',
  `NoteID` bigint(20) NOT NULL COMMENT '帖子ID',
  `UserID` int(11) NOT NULL COMMENT '评论者用户ID',
  `Content` varchar(300) NOT NULL COMMENT '评论内容',
  `IsAgreed` bit(1) DEFAULT b'0' COMMENT '是否点赞,0-否  1-是',
  `DataChange_LastTime` timestamp NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP COMMENT '更新时间',
  PRIMARY KEY (`NoteCommentID`),
  KEY `IX_CmuNoteComment_NoteID` (`NoteID`),
  KEY `IX_CmuNoteComment_UserID` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='帖子评论记录';

-- ----------------------------
-- Records of cmu_notecomment
-- ----------------------------
