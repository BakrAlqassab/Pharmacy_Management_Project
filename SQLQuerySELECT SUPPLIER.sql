﻿CREATE PROCEDURE SP_SUPPLIERSSELECTBYID
@ID INT 

AS
SELECT Su_Name ,Su_Mobile FROM tbl_Suppliers
WHERE Su_ID=@ID
RETURN