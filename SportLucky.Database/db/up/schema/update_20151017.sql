ALTER TABLE coursecomment CONVERT TO CHARACTER SET utf8;
ALTER TABLE mycollection CHANGE CollectionID CollectionID bigint(20) NOT NULL AUTO_INCREMENT;

-- 根据Michael 2015-10-14提出的需求更改脚本如下
ALTER TABLE `gym`
ADD COLUMN `GymType`  tinyint NULL DEFAULT 0 COMMENT '场馆类型，0-政府场馆 1-私人场馆' AFTER `GymID`,
ADD COLUMN `IsFree`  bit NULL COMMENT '是否免费' AFTER `AdditionalService`,
ADD COLUMN `HasWifi`  bit NULL DEFAULT 0 COMMENT '是否有无线' AFTER `IsFree`,
ADD COLUMN `HasShower`  bit NULL DEFAULT 0 COMMENT '是否有淋浴' AFTER `HasWifi`,
ADD COLUMN `HasParking`  bit NULL DEFAULT 0 COMMENT '有无停车位' AFTER `HasShower`,
ADD COLUMN `HasDrink`  bit NULL DEFAULT 0 COMMENT '有无饮料' AFTER `HasParking`,
ADD COLUMN `HasEquipmentRented`  bit NULL DEFAULT 0 COMMENT '是否出租器材' AFTER `HasDrink`,
ADD COLUMN `HasEquipmentSale`  bit NULL DEFAULT 0 COMMENT '是否售卖器材' AFTER `HasEquipmentRented`;


ALTER TABLE `gymcomment`
DROP COLUMN `StarLevel`,
ADD COLUMN `TotalAssessment`  tinyint NULL DEFAULT 1 COMMENT '整体评价,1-5表示1~5星' AFTER `CommentDate`,
ADD COLUMN `EnviromentAssessment`  tinyint NULL DEFAULT 1 COMMENT '场馆环境评价,1-5表示1~5星' AFTER `TotalAssessment`,
ADD COLUMN `ServiceAssessment`  tinyint NULL DEFAULT 1 COMMENT '服务态度评价,1-5表示1~5星' AFTER `EnviromentAssessment`,
ADD COLUMN `EquipmentAssessment`  tinyint NULL DEFAULT 1 COMMENT '设备新旧评价,1-5表示1~5星' AFTER `ServiceAssessment`;

