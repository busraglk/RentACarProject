USE [master]
GO
/****** Object:  Database [ReCap]    Script Date: 17.02.2021 03:42:49 ******/
CREATE DATABASE [ReCap]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReCap', FILENAME = N'C:\Users\busra\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ReCap.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReCap_log', FILENAME = N'C:\Users\busra\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ReCap.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ReCap] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReCap].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReCap] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [ReCap] SET ANSI_NULLS ON 
GO
ALTER DATABASE [ReCap] SET ANSI_PADDING ON 
GO
ALTER DATABASE [ReCap] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [ReCap] SET ARITHABORT ON 
GO
ALTER DATABASE [ReCap] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ReCap] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReCap] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReCap] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReCap] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [ReCap] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [ReCap] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReCap] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [ReCap] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReCap] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ReCap] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReCap] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReCap] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReCap] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReCap] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReCap] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReCap] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReCap] SET RECOVERY FULL 
GO
ALTER DATABASE [ReCap] SET  MULTI_USER 
GO
ALTER DATABASE [ReCap] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReCap] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReCap] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReCap] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReCap] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReCap] SET QUERY_STORE = OFF
GO
USE [ReCap]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ReCap]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 17.02.2021 03:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 17.02.2021 03:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandId] [int] NULL,
	[ColorId] [int] NULL,
	[ModelYear] [int] NULL,
	[DailyPrice] [decimal](18, 0) NULL,
	[Description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 17.02.2021 03:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 17.02.2021 03:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CompanyName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 17.02.2021 03:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NULL,
	[CustomerId] [int] NULL,
	[RentDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.02.2021 03:42:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (1, N'Honda')
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (2, N'Mercedes')
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (3, N'BMW')
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (4, N'Renault')
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (5, N'Nissan')
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (1003, N'Skoda')
GO
INSERT [dbo].[Brands] ([Id], [BrandName]) VALUES (3002, N'Volvo')
GO
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (2, 1, 2, 2018, CAST(300 AS Decimal(18, 0)), N'Honda/Civic - Beyaz - Otomatik Hybrid')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (3, 2, 1, 2015, CAST(450 AS Decimal(18, 0)), N'Mercedes - Kirmizi - Otomatik Dizel')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (4, 3, 3, 2017, CAST(300 AS Decimal(18, 0)), N'BMW - Siyah - Otomatik Hybrid')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (5, 4, 3, 2013, CAST(115 AS Decimal(18, 0)), N'Renault/Kangoo - Mavi - Manuel Benzin')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (7, 3, 1, 2019, CAST(500 AS Decimal(18, 0)), N'BMW İ8')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (8, 1, 3, 2015, CAST(200 AS Decimal(18, 0)), N'Honda/Civic - Otomatik Hybrid')
GO
INSERT [dbo].[Cars] ([Id], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Description]) VALUES (1008, 1, 4, 2016, CAST(400 AS Decimal(18, 0)), N'Honda - Kırmızı ')
GO
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Colors] ON 
GO
INSERT [dbo].[Colors] ([Id], [ColorName]) VALUES (1, N'Beyaz')
GO
INSERT [dbo].[Colors] ([Id], [ColorName]) VALUES (2, N'Siyah')
GO
INSERT [dbo].[Colors] ([Id], [ColorName]) VALUES (3, N'Gri')
GO
INSERT [dbo].[Colors] ([Id], [ColorName]) VALUES (4, N'Kırmızı')
GO
INSERT [dbo].[Colors] ([Id], [ColorName]) VALUES (5, N'Vişne Çürüğü')
GO
SET IDENTITY_INSERT [dbo].[Colors] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([Id], [UserId], [CompanyName]) VALUES (1, 1, N'Entes Elektronik')
GO
INSERT [dbo].[Customers] ([Id], [UserId], [CompanyName]) VALUES (2, 2, N'Türk Telekom')
GO
INSERT [dbo].[Customers] ([Id], [UserId], [CompanyName]) VALUES (3, 3, N'Turkcell')
GO
INSERT [dbo].[Customers] ([Id], [UserId], [CompanyName]) VALUES (4, 4, N'Ayedaş')
GO
INSERT [dbo].[Customers] ([Id], [UserId], [CompanyName]) VALUES (5, 5, N'Korkmazlar')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Rentals] ON 
GO
INSERT [dbo].[Rentals] ([Id], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (3, 2, 1, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2021-01-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Rentals] ([Id], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (4, 4, 3, CAST(N'2021-01-06T00:00:00.000' AS DateTime), CAST(N'2021-01-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Rentals] ([Id], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (5, 3, 2, CAST(N'2021-01-15T00:00:00.000' AS DateTime), CAST(N'2021-01-20T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Rentals] ([Id], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (6, 5, 4, CAST(N'2021-01-21T00:00:00.000' AS DateTime), CAST(N'2021-01-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Rentals] ([Id], [CarId], [CustomerId], [RentDate], [ReturnDate]) VALUES (7, 7, 5, CAST(N'2021-02-01T00:00:00.000' AS DateTime), CAST(N'2021-02-10T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Rentals] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password]) VALUES (1, N'Barış', N'Orta', N'bo@hotmail.com', N'12345ee')
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password]) VALUES (2, N'Ahsen', N'Öncel', N'aö@gmail.com', N'1234567')
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password]) VALUES (3, N'Ayşe', N'Coşku', N'aysec@gmail.com', N'ertyu45')
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password]) VALUES (4, N'Faruk', N'Kapan', N'farukkapan@hotmail.com', N'12345678')
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password]) VALUES (5, N'İlayda', N'Akyüz', N'ilayda@gmail.com', N'12345abc')
GO
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password]) VALUES (2003, N'Sena', N'Sevor', N'senaort@hotmail.com', N'9876543')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([ColorId])
REFERENCES [dbo].[Colors] ([Id])
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([Id])
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
USE [master]
GO
ALTER DATABASE [ReCap] SET  READ_WRITE 
GO
