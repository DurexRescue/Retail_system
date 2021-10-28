create definer = root@localhost procedure Update_Inquiry_customer(IN SKU1 varchar(10), IN uID varchar(50), IN time int)
Begin
Update Inquiry_customer SET Purchased=1,Times=time
Where SKU=SKU1 AND User_ID=uID;
End;

