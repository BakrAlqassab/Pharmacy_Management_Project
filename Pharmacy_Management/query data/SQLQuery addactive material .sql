﻿CREATE PROCEDURE  SP_ADDACTIVEMATERIAL
@AMNAME VARCHAR(50),@ACMDES VARCHAR(MAX)

AS
INSERT INTO tbl_activeMaterial( Am_name , Am_Desecription) VALUES(@AMNAME , @ACMDES)


RETURN