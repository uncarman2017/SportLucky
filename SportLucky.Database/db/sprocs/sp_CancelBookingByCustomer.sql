
-- ----------------------------
-- Procedure structure for `sp_CancelBookingByCustomer`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_CancelBookingByCustomer`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_CancelBookingByCustomer` (IN P_CourseBookingID int, IN P_CancelReason varchar(200))
BEGIN
    
    Update coursebooking SET BookingStatus=3,CancelReason=P_CancelReason,DataChange_LastTime=NOW() WHERE CourseBookingID=P_CourseBookingID AND BookingStatus<2;

END;;
DELIMITER ;;