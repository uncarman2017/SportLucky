
-- ----------------------------
-- Procedure structure for `sp_SubmitCmuNoteComment`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_SubmitCmuNoteComment`;
DELIMITER ;;
CREATE PROCEDURE `sp_SubmitCmuNoteComment` (IN P_NoteID int, IN P_UserID int, IN P_Content varchar(300), IN P_IsAgreed bit)
BEGIN
    IF EXISTS(SELECT NULL FROM cmu_note WHERE NoteID=P_NoteID)
    THEN
        INSERT INTO cmu_notecomment (NoteID, UserID, Content, IsAgreed)
            VALUES (P_NoteID, P_UserID, P_Content, P_IsAgreed);

        SELECT AUTO_INCREMENT-1 AS NoteCommentID
		    FROM  INFORMATION_SCHEMA.TABLES
		    WHERE TABLE_SCHEMA = 'sportlucky'
		    AND   TABLE_NAME   = 'cmu_notecomment';
    ELSE
        SELECT 0;
    END IF;
END;;
DELIMITER ;;