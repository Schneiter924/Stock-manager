SELECT 
    *
FROM
    location
        INNER JOIN
    loueur ON idLoueur = fkLoueur
        INNER JOIN
    Produit ON idProduit = fkProduit
WHERE
    endDate IS NULL AND idProduit = 3
ORDER BY startDate