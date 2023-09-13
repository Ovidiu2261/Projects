# EUROPEDIRECT database visual interface
This project requires a 'Report' folder in the C:\ partition for exporting reports and a database named 'SQL Evidenta.' If you wish to use a different database name, access the 'app.config' file within the 'Interfata dbo EUROPEDIRECT' folder and modify the following line of code:

Replace 'SQL Evidenta' with your desired name: 'Initial Catalog=Desired Name.'

The database was created using 'Microsoft SQL Server Management Studio 18.' To set it up, install 'Microsoft SQL Server Management Studio 18,' create a database with the name 'SQL Evidenta' (or your preferred name), open a query, and execute the following commands one by one.

<add name="ConexiuneDBO" connectionString ="Data Source=.\SQLEXPRESS;Initial Catalog=SQL Evidenta;Integrated Security=True"/>

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
    
