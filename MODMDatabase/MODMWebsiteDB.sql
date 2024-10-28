USE [master]
GO
/****** Object:  Database [MODMWebsiteDB]    Script Date: 28.10.2024 23:28:16 ******/
CREATE DATABASE [MODMWebsiteDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MODMWebsiteDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MODMWebsiteDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MODMWebsiteDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MODMWebsiteDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MODMWebsiteDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MODMWebsiteDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MODMWebsiteDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MODMWebsiteDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MODMWebsiteDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MODMWebsiteDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MODMWebsiteDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MODMWebsiteDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MODMWebsiteDB] SET  MULTI_USER 
GO
ALTER DATABASE [MODMWebsiteDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MODMWebsiteDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MODMWebsiteDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MODMWebsiteDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MODMWebsiteDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MODMWebsiteDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MODMWebsiteDB', N'ON'
GO
ALTER DATABASE [MODMWebsiteDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MODMWebsiteDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MODMWebsiteDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28.10.2024 23:28:17 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Businesses]    Script Date: 28.10.2024 23:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Businesses](
	[BusinessId] [int] IDENTITY(1,1) NOT NULL,
	[BusinessName] [nvarchar](max) NOT NULL,
	[BusinessType] [nvarchar](max) NOT NULL,
	[ReleaseTime] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Businesses] PRIMARY KEY CLUSTERED 
(
	[BusinessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 28.10.2024 23:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[FeedbackId] [int] IDENTITY(1,1) NOT NULL,
	[FeedbackType] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[ReleaseTime] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[FeedbackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 28.10.2024 23:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobId] [int] IDENTITY(1,1) NOT NULL,
	[JobTitle] [nvarchar](max) NOT NULL,
	[JobDescription] [nvarchar](max) NOT NULL,
	[ReleaseTime] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Jobs] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 28.10.2024 23:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[NewId] [int] IDENTITY(1,1) NOT NULL,
	[NewsTitle] [nvarchar](max) NOT NULL,
	[NewsDescription] [nvarchar](max) NOT NULL,
	[ReleaseTime] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 28.10.2024 23:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28.10.2024 23:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[CCNumber] [int] NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Businesses_UserId]    Script Date: 28.10.2024 23:28:17 ******/
CREATE NONCLUSTERED INDEX [IX_Businesses_UserId] ON [dbo].[Businesses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Feedbacks_UserId]    Script Date: 28.10.2024 23:28:17 ******/
CREATE NONCLUSTERED INDEX [IX_Feedbacks_UserId] ON [dbo].[Feedbacks]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Jobs_UserId]    Script Date: 28.10.2024 23:28:17 ******/
CREATE NONCLUSTERED INDEX [IX_Jobs_UserId] ON [dbo].[Jobs]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_News_UserId]    Script Date: 28.10.2024 23:28:17 ******/
CREATE NONCLUSTERED INDEX [IX_News_UserId] ON [dbo].[News]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_RoleId]    Script Date: 28.10.2024 23:28:17 ******/
CREATE NONCLUSTERED INDEX [IX_Users_RoleId] ON [dbo].[Users]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Businesses]  WITH CHECK ADD  CONSTRAINT [FK_Businesses_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Businesses] CHECK CONSTRAINT [FK_Businesses_Users_UserId]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_Feedbacks_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_Feedbacks_Users_UserId]
GO
ALTER TABLE [dbo].[Jobs]  WITH CHECK ADD  CONSTRAINT [FK_Jobs_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Jobs] CHECK CONSTRAINT [FK_Jobs_Users_UserId]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_Users_UserId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleId]
GO
USE [master]
GO
ALTER DATABASE [MODMWebsiteDB] SET  READ_WRITE 
GO
