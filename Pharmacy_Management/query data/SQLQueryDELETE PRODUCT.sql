﻿CREATE PROCEDURE SP_DELETEPRODUCTS
@ID BIGINT

AS
DELETE  FROM tbl_Products where pr_ID = @ID
RETURN