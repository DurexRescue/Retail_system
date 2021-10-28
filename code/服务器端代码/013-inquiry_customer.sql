create table inquiry_customer
(
	User_ID varchar(50) not null,
	SKU varchar(10) not null,
	Times int null,
	Purchased tinyint(1) null,
	primary key (User_ID, SKU),
	constraint inquiry_customer_ibfk_2
		foreign key (SKU) references product (SKU)
			on delete cascade
);

create index SKU
	on inquiry_customer (SKU);

