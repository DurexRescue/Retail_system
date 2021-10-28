create definer = root@localhost procedure Insert_Supplier(IN name varchar(50), IN country varchar(20))
Begin
Insert into Supplier(Name,Country) VALUES(name,country);
End;

