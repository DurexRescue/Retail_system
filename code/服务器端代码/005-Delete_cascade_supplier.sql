create definer = root@localhost procedure Delete_cascade_supplier(IN para varchar(50))
Begin
Delete From supplier where Name=para;
End;

