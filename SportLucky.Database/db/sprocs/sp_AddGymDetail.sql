
-- ----------------------------
-- Procedure structure for `AddGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_AddGymDetail`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_AddGymDetail`(P_CityID int, P_DistrictID int, P_GymName varchar(200),P_GymAddress varchar(200),P_GymDesc varchar(200),P_Phone varchar(200),P_Longitude decimal(12,6),P_Latitude decimal(12,6),P_Photos_Json varchar(500))
BEGIN
	INSERT INTO GymApproval (CityID,DistrictID,GymName,GymAddress,GymDesc,Phone,Longitude,Latitude,StarLevel,Photos_Json,DataChange_CreateTime,DataChange_LastTime) VALUES 
	 (P_CityID,P_DistrictID,P_GymName,P_GymAddress,P_GymDesc,P_Phone,P_Longitude,P_Latitude,P_StarLevel,P_Photos_Json,CURDATE(),CURDATE());

	 SELECT AUTO_INCREMENT-1 AS GymID
		FROM  INFORMATION_SCHEMA.TABLES
		WHERE TABLE_SCHEMA = 'sportlucky'
		AND   TABLE_NAME   = 'gym';
END
;;
DELIMITER ;
