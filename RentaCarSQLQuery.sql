CREATE TABLE [dbo].[Cars] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [ModelYear]   INT           NULL,
    [Description] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [BrandsFK] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([Id]),
    CONSTRAINT [ColorsFK] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([Id])
);


CREATE TABLE [dbo].[Colors] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Brands] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50) NULL,
    [LastName]     NVARCHAR (50) NULL,
    [Email]        NVARCHAR (50) NULL,
    [PasswordHash] BINARY (500)  NULL,
    [PasswordSalt] BINARY (500)  NULL,
    [Status]       BIT           NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);




CREATE TABLE [dbo].[Customers] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [UserId]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UsersFK] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);


CREATE TABLE [dbo].[Rentals] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [CarId]      INT      NOT NULL,
    [CustomerId] INT      NOT NULL,
    [RentDate]   DATETIME NULL,
    [ReturnDate] DATETIME NULL,
    CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CarsFk] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id]),
    CONSTRAINT [CustomerFk] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
);

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL,
    CONSTRAINT [PK_UserOperationClaims] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_OperationClaims] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[CarImages] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [CarId]     INT            NOT NULL,
    [ImagePath] NVARCHAR (500) NOT NULL,
    [Date]      DATETIME       NOT NULL,
    CONSTRAINT [PK_CarImages] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [CarId_FK] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id])
);



