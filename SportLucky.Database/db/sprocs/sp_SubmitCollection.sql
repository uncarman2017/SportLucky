
-- ----------------------------
-- Procedure structure for `sp_SubmitCollection`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp_SubmitCollection`;
DELIMITER ;;
CREATE DEFINER = `root`@`localhost` PROCEDURE `sp_SubmitCollection` (IN P_UserID int, IN P_CollectionType int, IN P_ObjectID int)
BEGIN
    IF NOT EXISTS (SELECT
                NULL
            FROM mycollection
            WHERE UserID = P_UserID
            AND CollectionType = P_CollectionType
            AND ObjectID = P_ObjectID) THEN
        INSERT INTO mycollection (UserID, CollectionType, ObjectID)
            VALUES (P_UserID, P_CollectionType, P_ObjectID);
        SELECT
            AUTO_INCREMENT - 1 AS CollectionID
        FROM INFORMATION_SCHEMA.TABLES
        WHERE TABLE_SCHEMA = 'sportlucky'
        AND TABLE_NAME = 'mycollection';
    ELSE
        SELECT
            CollectionID
        FROM mycollection
        WHERE UserID = P_UserID
        AND CollectionType = P_CollectionType
        AND ObjectID = P_ObjectID;
    END IF;

END;;
DELIMITER ;;