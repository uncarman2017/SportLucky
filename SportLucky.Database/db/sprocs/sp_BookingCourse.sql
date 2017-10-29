
-- ----------------------------
-- Procedure structure for `sp_BookingCourse`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_BookingCourse`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_BookingCourse` (IN P_UserID int, IN P_CourseTypeID int, IN P_CoachID int, IN P_CourseDate datetime, IN P_Hours int(11), IN P_GymAddress varchar(200), IN P_Remark varchar(300))
BEGIN
    INSERT INTO coursebooking (UserID, CourseTypeID, CoachID, BookingTime, CourseDate, Hours, GymAddress, Remark,DataChange_CreateTime)
        VALUES (P_UserID, P_CourseTypeID, P_CoachID, NOW(), P_CourseDate, P_Hours, P_GymAddress, P_Remark,NOW());

    SELECT
        AUTO_INCREMENT - 1 AS CourseBookingID
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'sportlucky'
    AND TABLE_NAME = 'coursebooking';
END;;
DELIMITER ;;