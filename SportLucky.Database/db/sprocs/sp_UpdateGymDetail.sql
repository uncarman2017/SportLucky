
-- ----------------------------
-- Procedure structure for `sp_UpdateGymDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_UpdateGymDetail`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_UpdateGymDetail` (IN P_GymID int, IN P_CityID int, IN P_DistrictID int, IN P_GymName varchar(200), IN P_GymAddress varchar(200), IN P_GymDesc varchar(200), IN P_Phone varchar(200), IN P_Longitude decimal(12, 6),IN P_Latitude decimal(12, 6))
BEGIN
    UPDATE Gym
    SET CityID = P_CityID,
        DistrictID = P_DistrictID,
        GymName = P_GymName,
        GymAddress = P_GymAddress,
        GymDesc = P_GymDesc,
        Phone = P_Phone,
        Longitude = P_Longitude,
        Latitude = P_Latitude,
        StarLevel = P_StarLevel,
        DataChange_LastTime = NOW()
    WHERE gymID = P_GymID;
END;;
DELIMITER;;