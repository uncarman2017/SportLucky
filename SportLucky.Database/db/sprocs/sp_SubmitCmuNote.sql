
-- ----------------------------
-- Procedure structure for `sp_SubmitCmuNote`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_SubmitCmuNote`;
DELIMITER ;;
CREATE PROCEDURE `sp_SubmitCmuNote` (IN P_UserID int, IN P_Content varchar(300))
BEGIN
    INSERT INTO cmu_note (UserID, Content, DataChange_LastTime)
        VALUES (P_UserID, P_Content, NOW());

    SELECT
        AUTO_INCREMENT - 1 AS NoteID
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'sportlucky'
    AND TABLE_NAME = 'cmu_note';
END;;
DELIMITER ;;