create definer = root@localhost procedure Update_Product(IN SKU1 varchar(10), IN prize int, IN d1 date)
Begin
Update Product SET Selling_Price=prize,Selling_date=d1
Where Product.SKU=SKU1;
End;

