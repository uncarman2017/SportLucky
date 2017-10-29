
-- ----------------------------
-- Procedure structure for `sp_CheckIn`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_CheckIn`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_CheckIn` (IN P_UserID int, IN P_IsCoachMobilePublic varchar(200))
BEGIN
    INSERT INTO checkIn (UserID,CheckInTime) VALUES(P_UserID,NOW());
END;;
DELIMITER ;;