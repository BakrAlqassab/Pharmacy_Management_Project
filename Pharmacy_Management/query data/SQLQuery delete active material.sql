﻿CREATE PROCEDURE SP_DELETESCIENTIFICNAME
@SN_ID INT 
AS
DELETE FROM  tbl_sceintificName WHERE sn_ID=@SN_ID
RETURN