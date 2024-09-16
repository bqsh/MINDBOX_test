select p.name as product_name, c.name as category_name
FROM product p
    LEFT JOIN product_category pc on p.id = pc.product_id
    LEFT JOIN category c on pc.category_id = c.id