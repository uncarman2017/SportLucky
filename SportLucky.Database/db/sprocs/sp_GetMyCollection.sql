
-- ----------------------------
-- Procedure structure for `sp_GetMyCollection`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_GetMyCollection`;
DELIMITER ;;
CREATE PROCEDURE `sp_GetMyCollection`(IN P_UserID int)
BEGIN
	SELECT * FROM mycollection Where UserID=P_UserID;
END
;;
DELIMITER ;
