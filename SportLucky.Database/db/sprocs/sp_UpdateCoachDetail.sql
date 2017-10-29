
-- ----------------------------
-- Procedure structure for `sp_UpdateCoachDetail`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_UpdateCoachDetail`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_UpdateCoachDetail` (IN P_CoachID int, IN P_Name varchar(10), IN P_Level tinyint(4), IN P_IsFree bit, IN P_PersonalSign varchar(200), IN P_BriefIntroduction varchar(300),
IN P_HonorDesc varchar(300), IN P_Certificates varchar(300), IN P_CourseDesc varchar(500), IN P_GymDesc varchar(500), IN P_AreaDesc varchar(500), IN P_IsHomeRecommended bit)
BEGIN
    UPDATE coach
    SET Name = P_Name,
        Level = P_Level,
        IsFree = P_IsFree,
        PersonalSign = P_PersonalSign,
        BriefIntroduction = P_BriefIntroduction,
        HonorDesc = P_HonorDesc,
        Certificates = P_Certificates,
        CourseDesc = P_CourseDesc,
        GymDesc = P_GymDesc,
        AreaDesc = P_AreaDesc,
        IsHomeRecommended = P_IsHomeRecommended,
        DataChange_LastTime = NOW()
    WHERE CoachID = P_CoachID;

END;;
DELIMITER ;;