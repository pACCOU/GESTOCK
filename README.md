# GESTOCK — Gestion de stock

Application Windows (VB.NET / WinForms, .NET Framework 3.5) de gestion de stock :
produits, clients, mouvements d'entrée/sortie avec lignes de détail, TVA,
utilisateurs avec profils, et éditions Crystal Reports.

> **English** — Inventory management desktop app (VB.NET WinForms, SQL
> Server). Products, customers, stock movements with line items and VAT,
> user profiles, Crystal Reports printouts. 2020 academic project, cleaned
> up in 2026 (config-based connection string, SQL schema script).

![VB.NET](https://img.shields.io/badge/VB.NET-WinForms-5C2D91)
![.NET Framework 3.5](https://img.shields.io/badge/.NET%20Framework-3.5-512BD4)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927)
![Licence MIT](https://img.shields.io/badge/licence-MIT-green)

## Fonctionnalités

- Produits (désignation, prix unitaire) et clients (coordonnées, date de naissance)
- Mouvements de stock : en-tête (date, type ENTREE/SORTIE, client, TVA, totaux) + lignes (produit, quantité, prix)
- Recherche plein texte dans les clients et les produits
- Utilisateurs avec mot de passe haché (MD5) et profil ; le menu Utilisateurs n'est actif que pour le profil administrateur
- État imprimable des mouvements (Crystal Reports)

## Installation

Prérequis : Windows, Visual Studio avec **.NET Framework 3.5** activé, SQL
Server Express ou LocalDB, runtime Crystal Reports (version 10.5 / 2008 — ou
recompiler les états avec le runtime 13).

```powershell
git clone https://github.com/pACCOU/GESTOCK.git
cd GESTOCK
sqlcmd -S .\SQLEXPRESS -i database\GESTOCK.sql       # base + compte admin/admin
```

Ouvrir `GESTOCK.sln`, adapter la chaîne de connexion dans `GESTOCK/app.config`
(clé `GESTOCK`) si votre instance n'est pas `.\SQLEXPRESS`, puis F5.

## Schéma de la base

Reconstruit à partir des requêtes du code — [`database/GESTOCK.sql`](database/GESTOCK.sql).

```
profil (idprofil, libprofil)
utilisateur (login PK, motpasse MD5, nom, prenom, idprofil -> profil)
client (numcli PK, nomcli, prenomcli, telcli, adrcli, emailcli, datenais)
produit (numprod PK, designation, prixunit)
mouvement (idmvt PK, datemvt, typemvt, monttotal, tva, monttva, numcli -> client)
d_mouvement (idmvt -> mouvement, numprod -> produit, qte, prixunit)
```

## Historique

**2026 — remise en état** : chaîne de connexion lue dans `app.config` (elle
visait le poste `WHANNOU` en dur), script SQL complet avec données de
démarrage, `.gitignore`, licence.

**2020 — version initiale** (projet de formation).

## Limites connues

- MD5 n'est plus un hachage acceptable pour des mots de passe : passer à PBKDF2 / BCrypt.
- Les requêtes des formulaires sont construites par concaténation ; à migrer vers des requêtes paramétrées (voir `database/` et le module `Module1.vb`).
- Le stock courant n'est pas matérialisé : il se déduit des mouvements.

Licence MIT — Florian Whannou
