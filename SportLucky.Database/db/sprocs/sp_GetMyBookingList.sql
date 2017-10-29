
-- ----------------------------
-- Procedure structure for `sp_GetMyBookingList`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_GetMyBookingList`;
DELIMITER ;;
CREATE PROCEDURE `sp_GetMyBookingList`(IN P_UserID int,IN P_BeginDate datetime, IN P_EndDate datetime)
BEGIN
	SELECT * FROM coursebooking Where UserID=P_UserID AND CourseDate>=DATE(P_BeginDate) AND CourseDate<=DATE(P_EndDate);
END
;;
DELIMITER ;
