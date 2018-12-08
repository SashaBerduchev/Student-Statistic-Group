
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/08/2018 14:17:21
-- Generated from EDMX file: D:\Project\WCF\StudentStatisticGroup\StudentStatisticGroupe\StudentStatisticGroupe\StudentStatisticsEDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StudentGroupe];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GroupSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupSet];
GO
IF OBJECT_ID(N'[dbo].[StudentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentSet];
GO
IF OBJECT_ID(N'[dbo].[TeacherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherSet];
GO
IF OBJECT_ID(N'[dbo].[DisciplineSetSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DisciplineSetSet];
GO
IF OBJECT_ID(N'[dbo].[StudentStatisticSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentStatisticSet];
GO
IF OBJECT_ID(N'[dbo].[PointSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PointSet];
GO
IF OBJECT_ID(N'[dbo].[TypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GroupSet'
CREATE TABLE [dbo].[GroupSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Sername] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Groupe] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TeacherSet'
CREATE TABLE [dbo].[TeacherSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Sername] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Discipline] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DisciplineSetSet'
CREATE TABLE [dbo].[DisciplineSetSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Kafedra] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudentStatisticSet'
CREATE TABLE [dbo].[StudentStatisticSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [NameStudent] nvarchar(max)  NOT NULL,
    [NameTeacher] nvarchar(max)  NOT NULL,
    [Point] nvarchar(max)  NOT NULL,
    [Comment] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PointSet'
CREATE TABLE [dbo].[PointSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Num] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TypeSet'
CREATE TABLE [dbo].[TypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameType] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GroupSet'
ALTER TABLE [dbo].[GroupSet]
ADD CONSTRAINT [PK_GroupSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [PK_TeacherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DisciplineSetSet'
ALTER TABLE [dbo].[DisciplineSetSet]
ADD CONSTRAINT [PK_DisciplineSetSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentStatisticSet'
ALTER TABLE [dbo].[StudentStatisticSet]
ADD CONSTRAINT [PK_StudentStatisticSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PointSet'
ALTER TABLE [dbo].[PointSet]
ADD CONSTRAINT [PK_PointSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeSet'
ALTER TABLE [dbo].[TypeSet]
ADD CONSTRAINT [PK_TypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------