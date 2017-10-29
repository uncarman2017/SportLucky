
-- ----------------------------
-- Procedure structure for `AddGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_ValidateRegisterUser`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ValidateRegisterUser`(P_Mobile varchar(20))
BEGIN	
	SELECT COUNT(*) from `user` where Mobile=P_Mobile;
END
;;
DELIMITER ;
