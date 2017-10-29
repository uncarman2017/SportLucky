
-- ----------------------------
-- Procedure structure for `sp_GetSmsValidationCode`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_GetSmsValidationCode`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_GetSmsValidationCode`(P_Mobile varchar(20))
BEGIN
	select ValidationCode from smsvalidationcode where Mobile=P_Mobile AND ExpireTime>=NOW();
END
;;
DELIMITER ;
