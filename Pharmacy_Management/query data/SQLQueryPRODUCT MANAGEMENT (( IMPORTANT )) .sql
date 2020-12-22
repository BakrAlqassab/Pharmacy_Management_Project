CREATE PROCEDURE SP_PRODECTSELECT

AS
SELECT 

P.pr_ID,
CA.Cat_name,
P.Pr_Name,
AM.Am_name,
sn.sn_Name,
P.Saleprice,
p.butprice,
ISNULL(sum(convert(DECIMAL,ED.Qty)),0),
p.Barcode,
P.pr_Description


FROM tbl_Products P JOIN  Category CA on P.Cat_ID =CA.Cat_Id
JOIN tbl_activeMaterial AM on P.Am_ID =AM.Am_ID
JOIN tbl_sceintificName sn ON P.sn_ID=sn.sn_ID
LEFT JOIN tbl_ExpireDate ED on P.pr_ID =ED.Pr_ID
GROUP BY P.pr_ID,
CA.Cat_name,
P.Pr_Name,
AM.Am_name,
sn.sn_Name,
P.Saleprice,
p.butprice,
p.Barcode,
P.pr_Description

RETURN