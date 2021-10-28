create definer = root@localhost view on_stock as select `drsql`.`product`.`SKU`                 AS `SKU`,
       `drsql`.`product`.`Product_description` AS `Product_description`,
       `drsql`.`product`.`Product_condition`   AS `Product_condition`,
       `drsql`.`product`.`Expected_Price`      AS `Expected_Price`,
       `drsql`.`product`.`Selling_Price`       AS `Selling_Price`,
       `drsql`.`product`.`Selling_date`        AS `Selling_date`
from `drsql`.`product`
where ((`drsql`.`product`.`Selling_Price` is null) or (`drsql`.`product`.`Selling_date` is null));

