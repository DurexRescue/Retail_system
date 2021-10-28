create definer = root@localhost procedure Insert_Inquiry_customer(IN uID varchar(50), IN SKU1 varchar(10), IN itime int)
Begin
Insert into Inquiry_customer(User_ID,SKU,Times) VALUES(uID,SKU1,itime);
End;

