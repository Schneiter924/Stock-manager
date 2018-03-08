CREATE USER 'vendeur'@'localhost' IDENTIFIED BY 'Pa$$w0rd';

GRANT select, insert, update, delete, execute ON stock_manager . * TO 'vendeur'@'localhost';

FLUSH PRIVILEGES;