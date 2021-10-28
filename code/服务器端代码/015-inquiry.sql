create table inquiry
(
	Inquiry_Date date not null,
	SKU varchar(10) not null,
	User_ID varchar(50) not null,
	primary key (Inquiry_Date, SKU, User_ID),
	constraint inquiry_ibfk_3
		foreign key (SKU) references product (SKU)
			on delete cascade,
	constraint inquiry_ibfk_4
		foreign key (User_ID) references inquiry_customer (User_ID)
			on delete cascade
);

create index SKU
	on inquiry (SKU);

create index User_ID
	on inquiry (User_ID);

