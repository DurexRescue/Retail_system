create definer = root@localhost procedure Insert_Product(IN SKU varchar(10), IN description varchar(50), IN cond varchar(50), IN Price int)
Begin
Insert into Product(SKU,Product_description,Product_condition,Expected_Price) VALUES(SKU,description,cond,Price);
End;

