
-- ----------------------------
-- Procedure structure for `sp_UpdateCourseBooking`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_UpdateCourseBooking`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_UpdateCourseBooking` (IN P_CourseBookingID int, IN P_CourseBeginTime datetime, IN P_CourseEndTime datetime, IN P_CoachID int, IN P_Hours int)
BEGIN
    UPDATE coursebooking
    SET CourseBookingID = P_CourseBookingID,
        CourseBeginTime = P_CourseBeginTime,
        CourseEndTime = P_CourseEndTime,
        CoachID = P_CoachID,
        Hours = P_Hours,
        DataChange_LastTime = NOW()
    WHERE CourseBookingID = P_CourseBookingID;

END;;
DELIMITER ;;