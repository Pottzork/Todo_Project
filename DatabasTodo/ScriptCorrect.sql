USE [master]
GO
/****** Object:  Database [ToDoProj]    Script Date: 2020-09-11 09:50:21 ******/
CREATE DATABASE [ToDoProj]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ToDoProj', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ToDoProj.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ToDoProj_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ToDoProj.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ToDoProj] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ToDoProj].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ToDoProj] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [ToDoProj] SET ANSI_NULLS ON 
GO
ALTER DATABASE [ToDoProj] SET ANSI_PADDING ON 
GO
ALTER DATABASE [ToDoProj] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [ToDoProj] SET ARITHABORT ON 
GO
ALTER DATABASE [ToDoProj] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ToDoProj] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ToDoProj] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ToDoProj] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ToDoProj] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [ToDoProj] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [ToDoProj] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ToDoProj] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [ToDoProj] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ToDoProj] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ToDoProj] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ToDoProj] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ToDoProj] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ToDoProj] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ToDoProj] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ToDoProj] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ToDoProj] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ToDoProj] SET RECOVERY FULL 
GO
ALTER DATABASE [ToDoProj] SET  MULTI_USER 
GO
ALTER DATABASE [ToDoProj] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ToDoProj] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ToDoProj] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ToDoProj] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ToDoProj] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ToDoProj] SET QUERY_STORE = OFF
GO
USE [ToDoProj]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ToDoProj]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresss]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresss](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[PostalCode] [nvarchar](max) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Addresss] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](32) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](32) NOT NULL,
	[LastName] [nvarchar](32) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CusId] [int] IDENTITY(1,1) NOT NULL,
	[CusName] [nvarchar](max) NOT NULL,
	[CusInfo] [nvarchar](max) NOT NULL,
	[CusEmail] [nvarchar](max) NOT NULL,
	[CusPhone] [nvarchar](max) NOT NULL,
	[CusCompany] [nvarchar](max) NULL,
	[AddressId] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operators]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operators](
	[OpId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](32) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](32) NOT NULL,
	[LastName] [nvarchar](32) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Location] [nvarchar](max) NULL,
 CONSTRAINT [PK_Operators] PRIMARY KEY CLUSTERED 
(
	[OpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderHistorys]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderHistorys](
	[OrderHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDescription] [nvarchar](max) NOT NULL,
	[OrderResponse] [nvarchar](max) NOT NULL,
	[OrderAccept] [bit] NOT NULL,
	[OrderStart] [datetime2](7) NOT NULL,
	[OrderEnd] [datetime2](7) NOT NULL,
	[OrderTime] [datetime2](7) NOT NULL,
	[OrderComplete] [bit] NOT NULL,
	[OrderPrice] [float] NOT NULL,
	[OrderId] [int] NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_OrderHistorys] PRIMARY KEY CLUSTERED 
(
	[OrderHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2020-09-11 09:50:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDescription] [nvarchar](max) NOT NULL,
	[OrderResponse] [nvarchar](max) NOT NULL,
	[OrderAccept] [bit] NOT NULL,
	[OrderEstTime] [datetime2](7) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[OrderStart] [datetime2](7) NOT NULL,
	[OrderEnd] [datetime2](7) NOT NULL,
	[OrderComplete] [bit] NOT NULL,
	[OrderPrice] [float] NOT NULL,
	[CustomerCusId] [int] NULL,
	[AddressId] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Customers_AddressId]    Script Date: 2020-09-11 09:50:21 ******/
CREATE NONCLUSTERED INDEX [IX_Customers_AddressId] ON [dbo].[Customers]
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderHistorys_AddressId]    Script Date: 2020-09-11 09:50:21 ******/
CREATE NONCLUSTERED INDEX [IX_OrderHistorys_AddressId] ON [dbo].[OrderHistorys]
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderHistorys_OrderId1]    Script Date: 2020-09-11 09:50:21 ******/
CREATE NONCLUSTERED INDEX [IX_OrderHistorys_OrderId1] ON [dbo].[OrderHistorys]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AddressId]    Script Date: 2020-09-11 09:50:21 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AddressId] ON [dbo].[Orders]
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_CustomerCusId]    Script Date: 2020-09-11 09:50:21 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerCusId] ON [dbo].[Orders]
(
	[CustomerCusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Addresss_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresss] ([AddressId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Addresss_AddressId]
GO
ALTER TABLE [dbo].[OrderHistorys]  WITH CHECK ADD  CONSTRAINT [FK_OrderHistorys_Addresss_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresss] ([AddressId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderHistorys] CHECK CONSTRAINT [FK_OrderHistorys_Addresss_AddressId]
GO
ALTER TABLE [dbo].[OrderHistorys]  WITH CHECK ADD  CONSTRAINT [FK_OrderHistorys_Orders_OrderId1] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderHistorys] CHECK CONSTRAINT [FK_OrderHistorys_Orders_OrderId1]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Addresss_AddressId] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresss] ([AddressId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Addresss_AddressId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CustomerCusId] FOREIGN KEY([CustomerCusId])
REFERENCES [dbo].[Customers] ([CusId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CustomerCusId]
GO
USE [master]
GO
ALTER DATABASE [ToDoProj] SET  READ_WRITE 
GO
