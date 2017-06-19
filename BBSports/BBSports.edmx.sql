
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/19/2017 12:37:45
-- Generated from EDMX file: C:\Users\Tyler\Documents\Visual Studio 2017\Projects\BBSports\BBSports\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BBSports];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sports'
CREATE TABLE [dbo].[Sports] (
    [SportId] int IDENTITY(1,1) NOT NULL,
    [SportName] nvarchar(max)  NOT NULL,
    [Season] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Meets'
CREATE TABLE [dbo].[Meets] (
    [MeetId] int IDENTITY(1,1) NOT NULL,
    [SportId] int  NOT NULL,
    [MeetName] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Temperature] nvarchar(max)  NOT NULL,
    [WeatherNotes] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Sport_SportId] int  NOT NULL
);
GO

-- Creating table 'Athletes'
CREATE TABLE [dbo].[Athletes] (
    [AthleteId] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [NickName] nvarchar(max)  NOT NULL,
    [Birthday] datetime  NOT NULL,
    [Grade] nvarchar(max)  NOT NULL,
    [Roster_RosterId] int  NOT NULL
);
GO

-- Creating table 'Coaches'
CREATE TABLE [dbo].[Coaches] (
    [CoachId] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Birthday] nvarchar(max)  NOT NULL,
    [CoachedBy_RelationId] int  NOT NULL
);
GO

-- Creating table 'CoachedBies'
CREATE TABLE [dbo].[CoachedBies] (
    [RelationId] int IDENTITY(1,1) NOT NULL,
    [SportId] nvarchar(max)  NOT NULL,
    [CoachId] nvarchar(max)  NOT NULL,
    [StartDate] nvarchar(max)  NOT NULL,
    [EndDate] nvarchar(max)  NOT NULL,
    [Sport_SportId] int  NOT NULL
);
GO

-- Creating table 'Rosters'
CREATE TABLE [dbo].[Rosters] (
    [RosterId] int IDENTITY(1,1) NOT NULL,
    [SportId] nvarchar(max)  NOT NULL,
    [AthleteId] nvarchar(max)  NOT NULL,
    [Eligibility] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Sport_SportId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SportId] in table 'Sports'
ALTER TABLE [dbo].[Sports]
ADD CONSTRAINT [PK_Sports]
    PRIMARY KEY CLUSTERED ([SportId] ASC);
GO

-- Creating primary key on [MeetId] in table 'Meets'
ALTER TABLE [dbo].[Meets]
ADD CONSTRAINT [PK_Meets]
    PRIMARY KEY CLUSTERED ([MeetId] ASC);
GO

-- Creating primary key on [AthleteId] in table 'Athletes'
ALTER TABLE [dbo].[Athletes]
ADD CONSTRAINT [PK_Athletes]
    PRIMARY KEY CLUSTERED ([AthleteId] ASC);
GO

-- Creating primary key on [CoachId] in table 'Coaches'
ALTER TABLE [dbo].[Coaches]
ADD CONSTRAINT [PK_Coaches]
    PRIMARY KEY CLUSTERED ([CoachId] ASC);
GO

-- Creating primary key on [RelationId] in table 'CoachedBies'
ALTER TABLE [dbo].[CoachedBies]
ADD CONSTRAINT [PK_CoachedBies]
    PRIMARY KEY CLUSTERED ([RelationId] ASC);
GO

-- Creating primary key on [RosterId] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [PK_Rosters]
    PRIMARY KEY CLUSTERED ([RosterId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Sport_SportId] in table 'Meets'
ALTER TABLE [dbo].[Meets]
ADD CONSTRAINT [FK_SportsMeets]
    FOREIGN KEY ([Sport_SportId])
    REFERENCES [dbo].[Sports]
        ([SportId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SportsMeets'
CREATE INDEX [IX_FK_SportsMeets]
ON [dbo].[Meets]
    ([Sport_SportId]);
GO

-- Creating foreign key on [Sport_SportId] in table 'CoachedBies'
ALTER TABLE [dbo].[CoachedBies]
ADD CONSTRAINT [FK_SportsCoachedBy]
    FOREIGN KEY ([Sport_SportId])
    REFERENCES [dbo].[Sports]
        ([SportId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SportsCoachedBy'
CREATE INDEX [IX_FK_SportsCoachedBy]
ON [dbo].[CoachedBies]
    ([Sport_SportId]);
GO

-- Creating foreign key on [CoachedBy_RelationId] in table 'Coaches'
ALTER TABLE [dbo].[Coaches]
ADD CONSTRAINT [FK_CoachedByCoaches]
    FOREIGN KEY ([CoachedBy_RelationId])
    REFERENCES [dbo].[CoachedBies]
        ([RelationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CoachedByCoaches'
CREATE INDEX [IX_FK_CoachedByCoaches]
ON [dbo].[Coaches]
    ([CoachedBy_RelationId]);
GO

-- Creating foreign key on [Sport_SportId] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [FK_SportsRoster]
    FOREIGN KEY ([Sport_SportId])
    REFERENCES [dbo].[Sports]
        ([SportId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SportsRoster'
CREATE INDEX [IX_FK_SportsRoster]
ON [dbo].[Rosters]
    ([Sport_SportId]);
GO

-- Creating foreign key on [Roster_RosterId] in table 'Athletes'
ALTER TABLE [dbo].[Athletes]
ADD CONSTRAINT [FK_RosterAthletes]
    FOREIGN KEY ([Roster_RosterId])
    REFERENCES [dbo].[Rosters]
        ([RosterId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RosterAthletes'
CREATE INDEX [IX_FK_RosterAthletes]
ON [dbo].[Athletes]
    ([Roster_RosterId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------