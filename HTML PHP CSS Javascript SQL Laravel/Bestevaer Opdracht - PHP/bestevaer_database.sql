
CREATE DATABASE bestevaer_database;

USE bestevaer_database;

CREATE TABLE boten (
    id VARCHAR(5) NOT NULL PRIMARY KEY,
    naam VARCHAR(20),
    pic VARCHAR(20),
    teu INT(7),
    dwt INT(7),
    lengte INT(6),
    breedte INT(6),
    diepte INT(6),
    c bit(1)
);

CREATE TABLE users (
    username varchar(20) NOT NULL PRIMARY KEY,
    password VARCHAR(20),
    Mwerker BIT(1) NOT NULL
);