
-- ----------------------------
-- Procedure structure for `AddGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_Login`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Login`(P_Mobile varchar(20), P_Pwd varchar(200))
BEGIN	
	SELECT * from `user` where Mobile=P_Mobile AND LoginPwd=P_Pwd;
END
;;
DELIMITER ;
