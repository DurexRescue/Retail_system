create definer = root@localhost view sold as select `drsql`.`product`.`SKU`                                              AS `SKU`,
       `drsql`.`product`.`Product_description`                              AS `Product_description`,
       `drsql`.`product`.`Product_condition`                                AS `Product_condition`,
       (`drsql`.`product`.`Selling_Price` - `drsql`.`put_in`.`cost`)        AS `Product.Selling_Price-Put_in.cost`,
       (`drsql`.`product`.`Selling_date` - `drsql`.`put_in`.`Arrival_Date`) AS `Product.Selling_Date-Put_in.Arrival_Date`
from `drsql`.`product`
         join `drsql`.`put_in`
where ((`drsql`.`product`.`Selling_Price` is not null) and (`drsql`.`product`.`SKU` = `drsql`.`put_in`.`SKU`));

