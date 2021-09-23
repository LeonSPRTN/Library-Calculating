# Library-Calculating
 Library Calculating

```
SELECT p.title AS Product, c.title AS Category
FROM product p
RIGHT JOIN product_category pc ON pc.product_id = p.id
LEFT JOIN category c ON c.id = pc.category_id
```