﻿CREATE PROCEDURE SP_PRODUCTGETIMG
@ID BIGINT

AS
SELECT Pr_image FROM tbl_Products WHERE Pr_ID =@ID
RETURN