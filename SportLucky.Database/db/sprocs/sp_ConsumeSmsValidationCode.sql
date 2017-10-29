
-- ----------------------------
-- Procedure structure for `sp_ConsumeSmsValidationCode`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_ConsumeSmsValidationCode`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ConsumeSmsValidationCode`(P_Mobile varchar(20))
BEGIN
	declare P_ValidationCode varchar(100);
	set P_ValidationCode = (select ValidationCode from smsvalidationcode where Mobile=P_Mobile AND ExpireTime>=NOW());
	DELETE FROM smsvalidationcode where Mobile=P_Mobile;
	select P_ValidationCode;
END
;;
DELIMITER ;
