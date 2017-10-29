
-- ----------------------------
-- Procedure structure for `AddGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_Register`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_Register`(P_Mobile varchar(20), P_MobileInfo varchar(1000),P_LoginPwd varchar(200),P_UserType tinyint(4),P_NickName varchar(20),P_Sex tinyint(4),P_Age tinyint(4),P_PersonalSign varchar(200),P_HeadPortraitUri varchar(200),P_Height float,P_Weight float,P_UserStatus tinyint(4))
BEGIN	
	INSERT INTO `user` (Mobile,MobileInfo,LoginPwd,UserType,NickName,Sex,Age,PersonalSign,HeadPortraitUri,Height,`Weight`,DataChange_CreateTime,DataChange_LastTime) VALUES 
	 (P_Mobile,P_MobileInfo,P_LoginPwd,P_UserType,P_NickName,P_Sex,P_Age,P_PersonalSign,P_HeadPortraitUri,P_Height,P_Weight,NOW(),NOW());

	 SELECT AUTO_INCREMENT-1 AS UserID
		FROM  INFORMATION_SCHEMA.TABLES
		WHERE TABLE_SCHEMA = 'sportlucky'
		AND   TABLE_NAME   = 'user';
END
;;
DELIMITER ;
