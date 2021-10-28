create definer = root@localhost procedure Delete_cascade_product(IN para varchar(50))
Begin
Delete From product where SKU=para;
End;

