# Infertafa baza de date EUROPEDIRECT
Acest proiect are nevoie de un folder "Raport" partitia C pentru a exporta raporturile si o baza de date cu numele "SQL Evidenta"
Daca doriti un alt nume pentru baza de date accesati fisierul app.config din fisierul Interfata dbo EUROPEDIRECT si modificati urmaroare linie de cod 


<add name="ConexiuneDBO" connectionString ="Data Source=.\SQLEXPRESS;Initial Catalog=SQL Evidenta;Integrated Security=True"/>


In loc de SQL Evidenta introduceti numele bazei de date "Initial Catalog=NumelDorit"

Baza de date a fost creata prin Microsoft SQL Server Management Studio 18
Instalati Microsoft SQL Server Management Studio 18 creati o baza de date cu numele SQL Evidenta sau ce nume doriti deschideti un querry si introduceti pe rand urmatoarele


CREATE TABLE [dbo].[PersNoi] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Prenume-Nume]     VARCHAR (80) NULL,
    [PersoaneUnice]    VARCHAR (50) NULL,
    [Sex]              VARCHAR (50) NULL,
    [DataInregistrari] DATETIME     CONSTRAINT [DF_PersNoi_DataInregistrari] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_dbo.PersNoi] PRIMARY KEY CLUSTERED ([ID] ASC)
);


CREATE TABLE [dbo].[PersVechi] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [Prenume-Nume]     VARCHAR (80) NULL,
    [Sex]              VARCHAR (50) NULL,
    [DataInregistrari] DATETIME     CONSTRAINT [DF_PersVechi_DataInregistrari] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_dbo.PersVechi] PRIMARY KEY CLUSTERED ([ID] ASC)
);


CREATE TABLE [dbo].[Vizite] (
    [ID]               INT          IDENTITY (1, 1) NOT NULL,
    [TipulVizitei]     VARCHAR (50) NULL,
    [Prenume]          VARCHAR (50) NULL,
    [Nume]             VARCHAR (50) NULL,
    [Varsta]           VARCHAR (50) NULL,
    [Studii]           VARCHAR (50) NULL,
    [Ocupatie]         VARCHAR (50) NULL,
    [Subiect]          VARCHAR (50) NULL,
    [Domiciliu]        VARCHAR (50) NULL,
    [Sex]              VARCHAR (50) NULL,
    [DataInregistrari] DATETIME     CONSTRAINT [DF_Vizite_DataInregistrari] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Vizite] PRIMARY KEY CLUSTERED ([ID] ASC)
);


CREATE PROC PersNoiADD
@NumePers varchar (80),
@Titlu varchar (50),
@Sex varchar (50)
AS
    INSERT INTO PersNoi([Prenume-Nume],[PersoaneUnice],[Sex])
    VALUES (@NumePers,@Titlu,@Sex)
    
    
CREATE PROC PersVechiADD
@NumePers varchar (80),
@Sex varchar (50)
AS
    INSERT INTO PersVechi([Prenume-Nume],Sex)
    VALUES (@NumePers,@Sex)
    
   
CREATE PROC ViziteADD
@TipulVizitei varchar (50),
@Prenume varchar (50),
@Nume varchar (50),
@Varsta varchar (50),
@Studii varchar (50),
@Ocupatie varchar (50),
@Subiect varchar (50),
@Domiciliu varchar (50),
@Sex varchar (50)
AS
    INSERT INTO Vizite(TipulVizitei,Prenume,Nume,Varsta,Studii,Ocupatie,Subiect,Domiciliu,Sex)
    VALUES (@TipulVizitei,@Prenume,@Nume,@Varsta,@Studii,@Ocupatie,@Subiect,@Domiciliu,@Sex)
    
    
 Daca ati urmarit pasi felicitari programul este perfect functional
 
 
 
