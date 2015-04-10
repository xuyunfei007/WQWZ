
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/10/2015 08:35:38
-- Generated from EDMX file: D:\Documents\GitHub\WQWZ\wqwz.Models\wqwz.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [wqwz];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_NewsNewsType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NewsTypeSet] DROP CONSTRAINT [FK_NewsNewsType];
GO
IF OBJECT_ID(N'[dbo].[FK_UserForm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormSet] DROP CONSTRAINT [FK_UserForm];
GO
IF OBJECT_ID(N'[dbo].[FK_NewsUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NewsSet] DROP CONSTRAINT [FK_NewsUser];
GO
IF OBJECT_ID(N'[dbo].[FK_FormDataUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormDataSet] DROP CONSTRAINT [FK_FormDataUser];
GO
IF OBJECT_ID(N'[dbo].[FK_FormTypeForm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormSet] DROP CONSTRAINT [FK_FormTypeForm];
GO
IF OBJECT_ID(N'[dbo].[FK_FormFormField]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormFieldSet] DROP CONSTRAINT [FK_FormFormField];
GO
IF OBJECT_ID(N'[dbo].[FK_FormFieldFormData]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormDataSet] DROP CONSTRAINT [FK_FormFieldFormData];
GO
IF OBJECT_ID(N'[dbo].[FK_FormFieldFormFieldEnum]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormFieldEnumSet] DROP CONSTRAINT [FK_FormFieldFormFieldEnum];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[NewsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NewsSet];
GO
IF OBJECT_ID(N'[dbo].[NewsTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NewsTypeSet];
GO
IF OBJECT_ID(N'[dbo].[FormSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormSet];
GO
IF OBJECT_ID(N'[dbo].[FormTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormTypeSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[FormFieldSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormFieldSet];
GO
IF OBJECT_ID(N'[dbo].[FormDataSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormDataSet];
GO
IF OBJECT_ID(N'[dbo].[FormFieldEnumSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormFieldEnumSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'NewsSet'
CREATE TABLE [dbo].[NewsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NOT NULL,
    [ReleaseUserId] int  NOT NULL,
    [Type] int  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Status] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'NewsTypeSet'
CREATE TABLE [dbo].[NewsTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [NewsId] int  NOT NULL
);
GO

-- Creating table 'FormSet'
CREATE TABLE [dbo].[FormSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [ReleaseDate] datetime  NOT NULL,
    [Status] int  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL,
    [FormTypeId] int  NOT NULL
);
GO

-- Creating table 'FormTypeSet'
CREATE TABLE [dbo].[FormTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Pwd] nvarchar(max)  NOT NULL,
    [Sex] int  NOT NULL,
    [RegDate] datetime  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FormFieldSet'
CREATE TABLE [dbo].[FormFieldSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] int  NOT NULL,
    [FormId] int  NOT NULL,
    [Regex] nvarchar(max)  NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FormDataSet'
CREATE TABLE [dbo].[FormDataSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PostUserId] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [FormFieldId] int  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'FormFieldEnumSet'
CREATE TABLE [dbo].[FormFieldEnumSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] int  NOT NULL,
    [FormFieldId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'NewsSet'
ALTER TABLE [dbo].[NewsSet]
ADD CONSTRAINT [PK_NewsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NewsTypeSet'
ALTER TABLE [dbo].[NewsTypeSet]
ADD CONSTRAINT [PK_NewsTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormSet'
ALTER TABLE [dbo].[FormSet]
ADD CONSTRAINT [PK_FormSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormTypeSet'
ALTER TABLE [dbo].[FormTypeSet]
ADD CONSTRAINT [PK_FormTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormFieldSet'
ALTER TABLE [dbo].[FormFieldSet]
ADD CONSTRAINT [PK_FormFieldSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormDataSet'
ALTER TABLE [dbo].[FormDataSet]
ADD CONSTRAINT [PK_FormDataSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormFieldEnumSet'
ALTER TABLE [dbo].[FormFieldEnumSet]
ADD CONSTRAINT [PK_FormFieldEnumSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NewsId] in table 'NewsTypeSet'
ALTER TABLE [dbo].[NewsTypeSet]
ADD CONSTRAINT [FK_NewsNewsType]
    FOREIGN KEY ([NewsId])
    REFERENCES [dbo].[NewsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NewsNewsType'
CREATE INDEX [IX_FK_NewsNewsType]
ON [dbo].[NewsTypeSet]
    ([NewsId]);
GO

-- Creating foreign key on [UserId] in table 'FormSet'
ALTER TABLE [dbo].[FormSet]
ADD CONSTRAINT [FK_UserForm]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserForm'
CREATE INDEX [IX_FK_UserForm]
ON [dbo].[FormSet]
    ([UserId]);
GO

-- Creating foreign key on [User_Id] in table 'NewsSet'
ALTER TABLE [dbo].[NewsSet]
ADD CONSTRAINT [FK_NewsUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NewsUser'
CREATE INDEX [IX_FK_NewsUser]
ON [dbo].[NewsSet]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'FormDataSet'
ALTER TABLE [dbo].[FormDataSet]
ADD CONSTRAINT [FK_FormDataUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormDataUser'
CREATE INDEX [IX_FK_FormDataUser]
ON [dbo].[FormDataSet]
    ([User_Id]);
GO

-- Creating foreign key on [FormTypeId] in table 'FormSet'
ALTER TABLE [dbo].[FormSet]
ADD CONSTRAINT [FK_FormTypeForm]
    FOREIGN KEY ([FormTypeId])
    REFERENCES [dbo].[FormTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormTypeForm'
CREATE INDEX [IX_FK_FormTypeForm]
ON [dbo].[FormSet]
    ([FormTypeId]);
GO

-- Creating foreign key on [FormId] in table 'FormFieldSet'
ALTER TABLE [dbo].[FormFieldSet]
ADD CONSTRAINT [FK_FormFormField]
    FOREIGN KEY ([FormId])
    REFERENCES [dbo].[FormSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormFormField'
CREATE INDEX [IX_FK_FormFormField]
ON [dbo].[FormFieldSet]
    ([FormId]);
GO

-- Creating foreign key on [FormFieldId] in table 'FormDataSet'
ALTER TABLE [dbo].[FormDataSet]
ADD CONSTRAINT [FK_FormFieldFormData]
    FOREIGN KEY ([FormFieldId])
    REFERENCES [dbo].[FormFieldSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormFieldFormData'
CREATE INDEX [IX_FK_FormFieldFormData]
ON [dbo].[FormDataSet]
    ([FormFieldId]);
GO

-- Creating foreign key on [FormFieldId] in table 'FormFieldEnumSet'
ALTER TABLE [dbo].[FormFieldEnumSet]
ADD CONSTRAINT [FK_FormFieldFormFieldEnum]
    FOREIGN KEY ([FormFieldId])
    REFERENCES [dbo].[FormFieldSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormFieldFormFieldEnum'
CREATE INDEX [IX_FK_FormFieldFormFieldEnum]
ON [dbo].[FormFieldEnumSet]
    ([FormFieldId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------