CREATE PROCEDURE SP_LOGIN
@UsName VARCHAR(50) , @UsPassowrd VARCHAR(50)
AS
SELECT * FROM tbl_Users WHERE Us_Name=@UsName AND Us_Passowrd=@UsPassowrd
RETURN