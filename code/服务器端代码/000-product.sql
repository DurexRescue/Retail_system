create table product
(
	SKU varchar(10) not null
		primary key,
	Product_description varchar(50) null,
	Product_condition varchar(50) null,
	Expected_Price int null,
	Selling_Price int null,
	Selling_date date null
);

