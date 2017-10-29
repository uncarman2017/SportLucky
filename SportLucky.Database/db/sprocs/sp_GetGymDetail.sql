
-- ----------------------------
-- Procedure structure for `GetGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_GetGymDetail`;
DELIMITER ;;
CREATE PROCEDURE `sp_GetGymDetail`(P_GymID int)
BEGIN
	SELECT * FROM Gym Where GymID=P_GymID;
END
;;
DELIMITER ;
