CREATE PROCEDURE SP_GETSELECTEDPRODUCT
@ID INT

AS
SELECT 


CA.Cat_name,
P.Pr_Name,
AM.Am_name,
sn.sn_Name,
P.Saleprice,
p.butprice,

p.Barcode,
P.pr_Description,
P.Pr_image


FROM tbl_Products P JOIN  Category CA on P.Cat_ID =CA.Cat_Id
JOIN tbl_activeMaterial AM on P.Am_ID =AM.Am_ID
JOIN tbl_sceintificName sn ON P.sn_ID=sn.sn_ID

WHERE P.Pr_ID=@ID




RETURN