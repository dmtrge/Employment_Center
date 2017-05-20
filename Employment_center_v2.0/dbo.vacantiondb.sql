CREATE TABLE [dbo].[vacantiondb] (
    [Id]           INT           NOT NULL,
    [profile]      NVARCHAR(MAX) NULL,
    [speciality]   NVARCHAR(MAX) NULL,
    [company]      NVARCHAR(MAX) NULL,
    [requirements] NVARCHAR(MAX) NULL,
    [salary]       NVARCHAR(MAX) NULL,
    [exp]          NVARCHAR(MAX) NULL,
    [graph]        NVARCHAR(MAX) NULL,
    [location]     NVARCHAR(MAX) NULL,
    [about]        NVARCHAR(MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

