/****** Object:  Table [dbo].[Produkts]    Script Date: 2023-03-20 15:34:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produkts](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Nazwa] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Narzedzias]    Script Date: 2023-03-20 15:35:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Narzedzias](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Nazwa] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[ProduktZmianas]    Script Date: 2023-03-20 15:35:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProduktZmianas](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[ProduktId] [int] NOT NULL,
	[DataWprowadzenie] [datetime] NOT NULL,
	[OpisZmiana] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[NarzedzieUzycies]    Script Date: 2023-03-20 15:35:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NarzedzieUzycies](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[NarzedzieId] [int] NOT NULL,
	[ZmianaId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[NarzedzieUzycies]  WITH CHECK ADD FOREIGN KEY([NarzedzieId])
REFERENCES [dbo].[Narzedzias] ([Id])
GO

ALTER TABLE [dbo].[NarzedzieUzycies]  WITH CHECK ADD FOREIGN KEY([ZmianaId])
REFERENCES [dbo].[ProduktZmianas] ([Id])
GO

