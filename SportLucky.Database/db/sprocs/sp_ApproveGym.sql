
-- ----------------------------
-- Procedure structure for `sp_ApproveGym`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_ApproveGym`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ApproveGym`(IN P_GymApprovalID int,IN P_ApproveStatus int, IN P_ApproverUserID int)
BEGIN
	Declare @GymID int;
	SET @GymID=0;
	IF NOT EXISTS(SELECT NULL FROM gymapproval WHERE GymApprovalID=P_GymApprovalID AND ApproveStatus=2)
	THEN
		IF P_ApproveStatus=1
		THEN
			INSERT INTO gym (GymType,CityID,DistrictID,GymName,GymAddress,GymDesc,Phone,Longitude,Latitude,Photos,StarLevel,AdditionalService,IsFree,HasWifi,HasShower,HasParking,HasDrink,HasEquipmentRented,HasEquipmentSale,PrincipalID) 
			SELECT GymType,CityID,DistrictID,GymName,GymAddress,GymDesc,Phone,Longitude,Latitude,Photos,StarLevel,AdditionalService,IsFree,HasWifi,HasShower,HasParking,HasDrink,HasEquipmentRented,HasEquipmentSale,PrincipalID FROM gymapproval
			WHERE GymApprovalID=P_GymApprovalID;

			SET @GymID=(SELECT AUTO_INCREMENT-1 AS CoachID FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='sportlucky' AND TABLE_NAME='gym');
		END IF;

		UPDATE gymapproval SET ApproveTime=NOW(),ApproverUserID=P_ApproverUserID,GymID=@GymID,ApproveStatus=P_ApproveStatus WHERE GymApprovalID=P_GymApprovalID;
	END IF;
	return @GymID;

END;;
DELIMITER;;
