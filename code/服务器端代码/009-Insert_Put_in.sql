create definer = root@localhost procedure Insert_Put_in(IN order_num varchar(50), IN SKU varchar(10), IN cost int, IN pd date, IN dd date, IN ad date, IN Supp varchar(50))
Begin
Insert into Put_in(Order_NUM,SKU,cost,Payment_Date,Delivery_Date,Arrival_Date,Supplier_Name) VALUES (order_num,SKU,cost,pd,dd,ad,Supp);
End;

