
-- ----------------------------
-- Procedure structure for `sp_RemoveGymPhoto`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_RemoveGymPhoto`;
DELIMITER ;;
CREATE PROCEDURE `sp_RemoveGymPhoto`(IN P_GymID int)
BEGIN
	SELECT * FROM gym Where GymID=P_GymID;
END
;;
DELIMITER ;
