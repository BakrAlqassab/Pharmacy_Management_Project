﻿CREATE PROCEDURE SP_UPDATECATEGORY
@CAT_ID INT , @CAT_NAME VARCHAR(50)
AS
UPDATE Category set Cat_Name=@CAT_NAME
WHERE Cat_ID=@CAT_ID
RETURN;