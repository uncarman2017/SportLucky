
-- ----------------------------
-- Procedure structure for `sp_AddSmsValidationCode`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_AddSmsValidationCode`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_AddSmsValidationCode`(P_Mobile varchar(20),P_ValidationCode varchar(100),P_ExpireTime datetime)
BEGIN
	DELETE FROM smsvalidationcode where Mobile=P_Mobile;
	INSERT INTO smsvalidationcode (Mobile,ValidationCode,ExpireTime) VALUES 
	 (P_Mobile,P_ValidationCode,P_ExpireTime);
END 
;;
DELIMITER ;
