﻿CREATE PROCEDURE SP_UPDATESCIENTIFICNAME
@SN_ID INT , @SN_NAME VARCHAR(50)
AS
UPDATE tbl_sceintificName SET sn_Name=@SN_NAME WHERE sn_ID=@SN_ID