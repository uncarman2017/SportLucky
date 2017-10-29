
-- ----------------------------
-- Procedure structure for `sp_GetMySiteLetter`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_GetMySiteLetter`;
DELIMITER ;;
CREATE PROCEDURE `sp_GetMySiteLetter`(IN P_UserID int)
BEGIN
	SELECT * FROM siteletter Where UserID=P_UserID;
END
;;
DELIMITER ;
