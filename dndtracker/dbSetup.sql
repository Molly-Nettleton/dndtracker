-- Active: 1668895251805@@bobocat.mysql.database.azure.com@3306@dnd

CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS characters(
        id INT NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        level INT,
        class JSON,
        secondClass JSON,
        subClass VARCHAR(255),
        race VARCHAR(255),
        background VARCHAR(255),
        hp varchar(255),
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS abilityScores(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        str INT,
        dex INT,
        con INT,
        intel INT,
        wis INT,
        char INT,
        characterId INT NOT NULL,
        accountId INT NOT NULL,
        FOREIGN KEY (characterId) REFERENCES characters(id) ON DELETE CASCADE,
        FOREIGN KEY (accountId) REFERENCES accounts(id) ON DELETE CASCADE
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS spellBooks(
        id INT NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        level INT,
        class JSON,
        secondClass JSON,
        subClass VARCHAR(255),
        race VARCHAR(255),
        background VARCHAR(255),
        hp varchar(255),
    ) default charset utf8 COMMENT '';

    CREATE TABLE
    IF NOT EXISTS spells(
        id INT NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255),
        index VARCHAR(255),
        url VARCHAR(500),
        desc VARCHAR(255),
        higher_level VARCHAR(255),
         VARCHAR(255),
        index VARCHAR(255),
        index VARCHAR(255),
        index VARCHAR(255),
        index VARCHAR(255),
        index VARCHAR(255),
        index VARCHAR(255),
        index VARCHAR(255),
        spellbook
    ) default charset utf8 COMMENT '';