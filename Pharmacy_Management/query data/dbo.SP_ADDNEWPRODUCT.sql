CREATE PROCEDURE SP_ADDNEWPRODUCT
@PR_NAME VARCHAR(50),
@PR_DESECRIPTION VARCHAR(MAX),
@PR_IMG IMAGE,
@BUYPRICE VARCHAR(50),
@PR_SELLPRICE VARCHAR(50),
@CAT_ID INT ,
@AMID INT,
@SNID INT,
@BARCODE VARCHAR(50)

AS

	INSERT INTO [dbo].[tbl_Products]
	([Pr_Name]       
    ,[Pr_Description] 
    ,[Pr_Image]      
    ,[butprice]       
    ,[Saleprice]     
    ,[Cat_ID]         
    ,[Am_ID]         
    ,[sn_ID]          
    ,[Barcode]  )




VALUES


   
  (@PR_NAME,@PR_DESECRIPTION,@PR_IMG,@BUYPRICE,@PR_SELLPRICE,@CAT_ID,@AMID,@SNID,@BARCODE)





RETURN