
-- ----------------------------
-- Procedure structure for `sp_ApproveCoach`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_ApproveCoach`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ApproveCoach`(IN P_CoachApprovalID int,IN P_ApproveStatus int, IN P_ApproverUserID int)
BEGIN
	Declare @CoachID int;
	SET @CoachID=0;
	IF NOT EXISTS(SELECT NULL FROM coachapproval WHERE CoachApprovalID=P_CoachApprovalID AND ApproveStatus=2)
	THEN
		IF P_ApproveStatus=1
		THEN
			INSERT INTO coach (UserID,Name,Level,ContactInfo,PersonalSign,BriefIntroduction,HonorDesc,IsFree,Certificates,CourseDesc,GymDesc,AreaDesc,Photos,IsHomeRecommended,RecommendDate,Years) 
			SELECT UserID,Name,Level,ContactInfo,PersonalSign,BriefIntroduction,HonorDesc,IsFree,Certificates,CourseDesc,GymDesc,AreaDesc,Photos,IsHomeRecommended,RecommendDate,Years FROM coachapproval
			WHERE CoachApprovalID=P_CoachApprovalID;

			SET @CoachID=(SELECT AUTO_INCREMENT-1 AS CoachID FROM  INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'sportlucky'	AND TABLE_NAME = 'coach');
		END IF;

		UPDATE coachapproval SET ApproveTime=NOW(),ApproverUserID=P_ApproverUserID,CoachID=@CoachID,ApproveStatus=P_ApproveStatus WHERE CoachApprovalID=P_CoachApprovalID;
	END IF;
	return @CoachID;
END;;
DELIMITER;;
