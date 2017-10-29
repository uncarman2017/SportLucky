DROP TABLE IF EXISTS `smsvalidationcode`;

CREATE TABLE `smsvalidationcode` (
  `Mobile` varchar(20) NOT NULL COMMENT '手机号码',
  `ValidationCode` varchar(100) COMMENT '短信验证码',
  `ExpireTime` datetime COMMENT '过期时间',
  PRIMARY KEY (`Mobile`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='短信验证码';　