
-- ----------------------------
-- Procedure structure for `AddGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_UpdatePwd`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UpdatePwd`(P_UserID bigint(20), P_NewPwd varchar(200))
BEGIN	
	update `user` SET LoginPwd=P_NewPwd,DataChange_LastTime=SYSDATE() WHERE UserID=P_UserID;
END
;;
DELIMITER ;
