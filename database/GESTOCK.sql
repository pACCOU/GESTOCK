-- =====================================================================
--  GESTOCK — base "GESTOCK" (SQL Server / SQL Express / LocalDB)
--  Schéma reconstruit à partir des requêtes du code source.
--  Exécuter :  sqlcmd -S .\SQLEXPRESS -i GESTOCK.sql
-- =====================================================================
IF DB_ID('GESTOCK') IS NULL CREATE DATABASE GESTOCK;
GO
USE GESTOCK;
GO

CREATE TABLE profil (
    idprofil   INT          NOT NULL PRIMARY KEY,   -- 1 = administrateur
    libprofil  NVARCHAR(50) NOT NULL
);

CREATE TABLE utilisateur (
    login     NVARCHAR(50)  NOT NULL PRIMARY KEY,
    motpasse  NVARCHAR(64)  NOT NULL,              -- empreinte MD5 (voir CalculMD5Hash dans Module1.vb)
    nom       NVARCHAR(50)  NOT NULL,
    prenom    NVARCHAR(50)  NULL,
    idprofil  INT           NOT NULL REFERENCES profil(idprofil)
);

CREATE TABLE client (
    numcli    NVARCHAR(20)  NOT NULL PRIMARY KEY,
    nomcli    NVARCHAR(50)  NOT NULL,
    prenomcli NVARCHAR(50)  NULL,
    telcli    NVARCHAR(30)  NULL,
    adrcli    NVARCHAR(100) NULL,
    emailcli  NVARCHAR(100) NULL,
    datenais  DATE          NULL
);

CREATE TABLE produit (
    numprod     NVARCHAR(20)  NOT NULL PRIMARY KEY,
    designation NVARCHAR(100) NOT NULL,
    prixunit    DECIMAL(12,2) NOT NULL DEFAULT 0
);

CREATE TABLE mouvement (
    idmvt     INT           NOT NULL PRIMARY KEY,
    datemvt   DATETIME      NOT NULL,
    typemvt   NVARCHAR(20)  NOT NULL,   -- ENTREE / SORTIE
    monttotal DECIMAL(14,2) NOT NULL DEFAULT 0,
    tva       DECIMAL(5,2)  NOT NULL DEFAULT 0,
    monttva   DECIMAL(14,2) NOT NULL DEFAULT 0,
    numcli    NVARCHAR(20)  NULL REFERENCES client(numcli)
);

CREATE TABLE d_mouvement (
    idmvt    INT           NOT NULL REFERENCES mouvement(idmvt),
    numprod  NVARCHAR(20)  NOT NULL REFERENCES produit(numprod),
    qte      INT           NOT NULL,
    prixunit DECIMAL(12,2) NOT NULL,
    PRIMARY KEY (idmvt, numprod)
);
GO

INSERT INTO profil VALUES (1, 'Administrateur'), (2, 'Utilisateur');
-- mot de passe "admin" (MD5 = 21232F297A57A5A743894A0E4A801FC3)
INSERT INTO utilisateur VALUES ('admin', '21232F297A57A5A743894A0E4A801FC3', 'Administrateur', 'Système', 1);
GO
