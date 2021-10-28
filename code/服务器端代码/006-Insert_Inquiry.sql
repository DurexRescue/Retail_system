create definer = root@localhost procedure Insert_Inquiry(IN Date date, IN SKU1 varchar(10), IN uID varchar(50))
Begin
Insert into Inquiry(Inquiry_Date,SKU,User_ID) VALUES(Date,SKU1,uID);
End;

