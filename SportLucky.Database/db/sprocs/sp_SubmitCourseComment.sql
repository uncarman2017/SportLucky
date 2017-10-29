
-- ----------------------------
-- Procedure structure for `sp_SubmitCourseComment`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_SubmitCourseComment`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_SubmitCourseComment` (IN P_UserID int, IN P_CourseBookingID int, IN P_Comment varchar(500))
BEGIN
    INSERT INTO coursecomment (UserID, CourseBookingID, CommentDate, Comment)
        VALUES (P_UserID, P_CourseBookingID, NOW(), P_Comment);
    SELECT
        AUTO_INCREMENT - 1 AS CommentID
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'sportlucky'
    AND TABLE_NAME = 'coursecomment';
END;;
DELIMITER ;;