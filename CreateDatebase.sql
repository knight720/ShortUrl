CREATE DATABASE [UrlDB];
GO

USE [UrlDB];
GO

CREATE TABLE [Url] (
    [Url_Id] int NOT NULL IDENTITY,
    [Url_Code] nvarchar(36) NOT NULL,
	[Url_Url] nvarchar(1000) NOT NULL,
    CONSTRAINT [PK_Url] PRIMARY KEY ([Url_Id])
);
GO
