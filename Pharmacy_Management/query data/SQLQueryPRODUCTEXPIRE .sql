﻿CREATE PROCEDURE SP_PRODUCTGETEXPIREDATE
@ID  BIGINT 
AS
select Ex_Date, ISNULL(Qty,0)QTY from tbl_ExpireDate where pr_ID = @ID
RETURN