
ALTER TABLE `gymapproval`
ADD COLUMN `GymType` tinyint NULL DEFAULT 0 COMMENT '场馆类型，0-政府场馆 1-私人场馆' AFTER `GymID`,
ADD COLUMN `AdditionalService`  varchar(500) DEFAULT NULL COMMENT '附加服务信息' AFTER `GymType`,
ADD COLUMN `IsFree` bit NULL COMMENT '是否免费' AFTER `AdditionalService`,
ADD COLUMN `HasWifi` bit NULL DEFAULT 0 COMMENT '是否有无线' AFTER `IsFree`,
ADD COLUMN `HasShower` bit NULL DEFAULT 0 COMMENT '是否有淋浴' AFTER `HasWifi`,
ADD COLUMN `HasParking` bit NULL DEFAULT 0 COMMENT '有无停车位' AFTER `HasShower`,
ADD COLUMN `HasDrink` bit NULL DEFAULT 0 COMMENT '有无饮料' AFTER `HasParking`,
ADD COLUMN `HasEquipmentRented` bit NULL DEFAULT 0 COMMENT '是否出租器材' AFTER `HasDrink`,
ADD COLUMN `HasEquipmentSale` bit NULL DEFAULT 0 COMMENT '是否售卖器材' AFTER `HasEquipmentRented`;

ALTER TABLE `coachapproval`
ADD COLUMN `CourseDesc` varchar(500) DEFAULT NULL COMMENT '课程安排' AFTER `Certificates`,
ADD COLUMN `GymDesc` varchar(500) DEFAULT NULL AFTER `CourseDesc`,
ADD COLUMN `AreaDesc` varchar(500) DEFAULT NULL COMMENT '活动区域描述' AFTER `GymDesc`,
ADD COLUMN `IsHomeRecommended` bit(1) DEFAULT b'0' COMMENT '是否首页推荐' AFTER `CoachID`,
ADD COLUMN `RecommendDate`smallint(6) DEFAULT NULL COMMENT '教龄' AFTER `IsHomeRecommended`,
ADD COLUMN `Years` smallint(6) DEFAULT NULL COMMENT '教龄' AFTER `RecommendDate`;
