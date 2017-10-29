
-- ----------------------------
-- Procedure structure for `sp_GetCourseBookingDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_GetCourseBookingDetail`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_GetCourseBookingDetail` (IN P_CourseBookingID int)
BEGIN
    SELECT * FROM coursebooking WHERE CourseBookingID=P_CourseBookingID;
END;;
DELIMITER ;;