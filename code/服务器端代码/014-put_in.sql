create table put_in
(
	Order_NUM varchar(50) not null,
	SKU varchar(10) not null,
	cost int null,
	Payment_Date date null,
	Delivery_Date date null,
	Arrival_Date date null,
	Supplier_Name varchar(50) null,
	primary key (Order_NUM, SKU),
	constraint put_in_ibfk_3
		foreign key (SKU) references product (SKU)
			on delete cascade,
	constraint put_in_ibfk_4
		foreign key (Supplier_Name) references supplier (Name)
			on delete cascade
);

create index SKU
	on put_in (SKU);

create index Supplier_Name
	on put_in (Supplier_Name);

