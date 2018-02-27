SELECT 
    *
FROM
    location
        INNER JOIN
    loueur ON idLoueur = fkLoueur
        INNER JOIN
    Produit ON idProduit = fkProduit
WHERE
    endDate IS NULL
ORDER BY startDate