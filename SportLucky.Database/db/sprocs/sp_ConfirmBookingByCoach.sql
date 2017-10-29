
-- ----------------------------
-- Procedure structure for `sp_ConfirmBookingByCoach`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_ConfirmBookingByCoach`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_ConfirmBookingByCoach` (IN P_CourseBookingID int, IN P_IsCoachMobilePublic varchar(200))
BEGIN
    
    Update coursebooking SET BookingStatus=2,IsCoachMobilePublic=P_IsCoachMobilePublic,DataChange_LastTime=NOW() WHERE CourseBookingID=P_CourseBookingID AND BookingStatus<2;

END;;
DELIMITER ;;