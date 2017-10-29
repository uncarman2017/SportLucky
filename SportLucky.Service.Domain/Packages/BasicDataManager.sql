#AddGymDetail
DROP PROCEDURE IF EXISTS AddGymDetail;
CREATE PROCEDURE AddGymDetail(CityID int, DistrictID int, GymName varchar(200),GymAddress varchar(200),GymDesc varchar(200),Phone varchar(200),Longitude decimal(12,6),Latitude decimal(12,6))
BEGIN
	INSERT INTO Gym
	 (CityID,DistrictID,GymName,GymAddress,GymDesc,Phone,Longitude,Latitude,StarLevel,DataChange_CreateTime,DataChange_LastTime) VALUES 
	 (CityID,DistrictID,GymName,GymAddress,GymDesc,Phone,Longitude,Latitude,StarLevel,CURDATE(),CURDATE());

	 SELECT AUTO_INCREMENT-1 AS GymID
		FROM  INFORMATION_SCHEMA.TABLES
		WHERE TABLE_SCHEMA = 'sportlucky'
		AND   TABLE_NAME   = 'gym';
END;

#GetGymDetail
DROP PROCEDURE IF EXISTS c;
CREATE PROCEDURE GetGymDetail(GymID int)
BEGIN
	SELECT * FROM Gym Where GymID=GymID;
END;