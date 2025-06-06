USE [master]
GO
/****** Object:  Database [LightAndLens]    Script Date: 5/31/2025 3:54:06 AM ******/
CREATE DATABASE [LightAndLens]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LightAndLens', FILENAME = N'C:\Users\6alal\LightAndLens.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LightAndLens_log', FILENAME = N'C:\Users\6alal\LightAndLens_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LightAndLens] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LightAndLens].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LightAndLens] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LightAndLens] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LightAndLens] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LightAndLens] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LightAndLens] SET ARITHABORT OFF 
GO
ALTER DATABASE [LightAndLens] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LightAndLens] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LightAndLens] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LightAndLens] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LightAndLens] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LightAndLens] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LightAndLens] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LightAndLens] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LightAndLens] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LightAndLens] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LightAndLens] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LightAndLens] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LightAndLens] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LightAndLens] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LightAndLens] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LightAndLens] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LightAndLens] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LightAndLens] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LightAndLens] SET  MULTI_USER 
GO
ALTER DATABASE [LightAndLens] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LightAndLens] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LightAndLens] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LightAndLens] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LightAndLens] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LightAndLens]
GO
/****** Object:  Table [dbo].[AvailabilityStatuses]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AvailabilityStatuses](
	[AvailabilityID] [int] IDENTITY(1,1) NOT NULL,
	[AvailabilityStatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AvailabilityStatuses] PRIMARY KEY CLUSTERED 
(
	[AvailabilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConditionStatuses]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConditionStatuses](
	[ConditionID] [int] IDENTITY(1,1) NOT NULL,
	[ConditionName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ConditionStatuses] PRIMARY KEY CLUSTERED 
(
	[ConditionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[EquipmentID] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentName] [varchar](50) NOT NULL,
	[Description] [text] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[RentalPricePerDay] [decimal](10, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ConditionID] [int] NOT NULL,
	[AvailabilityID] [int] NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[EquipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentImages]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentImages](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentID] [int] NOT NULL,
	[ImagePath] [varchar](200) NOT NULL,
	[IsMain] [bit] NULL,
	[ImageData] [varbinary](max) NULL,
 CONSTRAINT [PK_EquipmentImages] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[FeedbackID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[EquipmentID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comments] [text] NULL,
	[ReturnId] [int] NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[FeedbackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Action] [text] NOT NULL,
	[Timestamp] [datetime] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Message] [varchar](200) NULL,
	[Type] [varchar](50) NOT NULL,
	[IsRead] [bit] NOT NULL,
 CONSTRAINT [PK_Notifications] PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalItems]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalItems](
	[RentalItemID] [int] IDENTITY(1,1) NOT NULL,
	[RentalID] [int] NOT NULL,
	[EquipmentID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Subtotal] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_RentalItems] PRIMARY KEY CLUSTERED 
(
	[RentalItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalRequests]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalRequests](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[EquipmentID] [int] NOT NULL,
	[RequestStartDate] [date] NOT NULL,
	[RequestEndDate] [date] NOT NULL,
	[RequestStatusID] [int] NOT NULL,
	[RequestSetDate] [datetime] NOT NULL,
 CONSTRAINT [PK_RentalRequests] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransactions]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransactions](
	[RentalID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[RentalFee] [decimal](10, 2) NOT NULL,
	[DepositPaid] [decimal](10, 2) NULL,
	[Status] [varchar](50) NOT NULL,
	[RequestID] [int] NOT NULL,
 CONSTRAINT [PK_RentalTransactions] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestStatuses]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestStatuses](
	[RequestStatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RequestStatuses] PRIMARY KEY CLUSTERED 
(
	[RequestStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnRecords]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnRecords](
	[ReturnID] [int] IDENTITY(1,1) NOT NULL,
	[RentalID] [int] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[ConditionStatus] [varchar](50) NOT NULL,
	[Notes] [text] NULL,
 CONSTRAINT [PK_ReturnRecords] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDocuments]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDocuments](
	[DocumentID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](450) NOT NULL,
	[FileName] [nvarchar](250) NOT NULL,
	[FileType] [nvarchar](50) NOT NULL,
	[FileData] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_UserDocuments] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/31/2025 3:54:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](200) NOT NULL,
	[Email] [varchar](200) NOT NULL,
	[PhoneNumber] [int] NULL,
	[RoleID] [int] NOT NULL,
	[IdentityUserID] [nvarchar](500) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AvailabilityStatuses] ON 

INSERT [dbo].[AvailabilityStatuses] ([AvailabilityID], [AvailabilityStatusName]) VALUES (1, N'Available')
INSERT [dbo].[AvailabilityStatuses] ([AvailabilityID], [AvailabilityStatusName]) VALUES (2, N'Rented')
INSERT [dbo].[AvailabilityStatuses] ([AvailabilityID], [AvailabilityStatusName]) VALUES (3, N'Under Maintenance')
INSERT [dbo].[AvailabilityStatuses] ([AvailabilityID], [AvailabilityStatusName]) VALUES (4, N'Out of Service')
SET IDENTITY_INSERT [dbo].[AvailabilityStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Accessories')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Cameras')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Lenses')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Lights')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Stabilizers')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[ConditionStatuses] ON 

INSERT [dbo].[ConditionStatuses] ([ConditionID], [ConditionName]) VALUES (1, N'Excellent')
INSERT [dbo].[ConditionStatuses] ([ConditionID], [ConditionName]) VALUES (2, N'Slight Wear')
INSERT [dbo].[ConditionStatuses] ([ConditionID], [ConditionName]) VALUES (3, N'Requires Maintenance')
SET IDENTITY_INSERT [dbo].[ConditionStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipment] ON 

INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (1, N'Canon EOS 5D', N'A professional-grade DSLR known for its full-frame sensor and superb image quality.', 1, CAST(93.75 AS Decimal(10, 2)), 1, 1, 4)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (2, N'Nikon D3500', N'A lightweight, beginner-friendly DSLR with excellent battery life and sharp images.', 1, CAST(62.45 AS Decimal(10, 2)), 1, 1, 3)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (3, N'Sony Alpha a6400', N'A compact mirrorless camera with fast autofocus and 4K video recording.', 1, CAST(22.62 AS Decimal(10, 2)), 1, 3, 3)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (4, N'Fujifilm X-T30', N'Stylish and powerful mirrorless camera with film simulation modes and great ergonomics.', 1, CAST(18.18 AS Decimal(10, 2)), 1, 2, 1)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (5, N'Panasonic Lumix G7', N'A mirrorless camera offering 4K video, touch screen, and mic input for vlogging.
', 1, CAST(64.42 AS Decimal(10, 2)), 1, 2, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (6, N'Godox SL-60W', N'A powerful and budget-friendly LED video light with Bowens mount compatibility.', 2, CAST(50.61 AS Decimal(10, 2)), 1, 3, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (7, N'Neewer Ring Light', N'A 18-inch LED ring light ideal for portraits, makeup tutorials, and streaming.', 2, CAST(64.21 AS Decimal(10, 2)), 1, 3, 1)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (8, N'Aputure AL-MX', N'A durable pocket-sized light with adjustable brightness and color temperature.', 2, CAST(10.49 AS Decimal(10, 2)), 1, 1, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (9, N'Lume Cube Panel', N'A compact bi-color LED light panel with built-in battery, ideal for mobile setups.
', 2, CAST(71.24 AS Decimal(10, 2)), 1, 1, 1)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (10, N'Yongnuo YN360', N'A versatile LED light wand with full RGB and adjustable white lighting.', 2, CAST(40.26 AS Decimal(10, 2)), 1, 2, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (11, N'Canon EF 50mm', N'A fast and sharp prime lens ideal for portraits and low-light photography.', 3, CAST(92.45 AS Decimal(10, 2)), 1, 1, 1)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (12, N'Nikon 70-300mm', N'A lightweight telephoto zoom lens suitable for sports and wildlife.', 3, CAST(56.77 AS Decimal(10, 2)), 1, 1, 4)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (13, N'Sony 24-70mm', N'A professional zoom lens with wide aperture, perfect for events and travel.', 3, CAST(37.02 AS Decimal(10, 2)), 1, 3, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (14, N'Tamron 28-75mm', N'A third-party standard zoom lens offering sharp optics and compact design.', 3, CAST(39.99 AS Decimal(10, 2)), 1, 3, 1)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (15, N'Sigma 35mm f/1.4', N' A high-end prime lens praised for its clarity, bokeh, and sharpness.', 3, CAST(71.35 AS Decimal(10, 2)), 1, 2, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (16, N'DJI Ronin-S', N'A 3-axis handheld gimbal stabilizer designed for DSLR and mirrorless cameras.', 4, CAST(38.75 AS Decimal(10, 2)), 1, 1, 3)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (17, N'Zhiyun Crane 2', N'A professional stabilizer with focus control and long battery life.', 4, CAST(72.90 AS Decimal(10, 2)), 1, 2, 1)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (18, N'Moza AirCross 2', N'A lightweight yet powerful gimbal with smart time-lapse and motion tracking.', 4, CAST(69.80 AS Decimal(10, 2)), 1, 1, 3)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (19, N'FeiyuTech AK2000', N'An advanced gimbal supporting larger cameras with touchscreen controls.', 4, CAST(88.16 AS Decimal(10, 2)), 1, 3, 4)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (20, N'Glidecam HD-PRO', N'A mechanical stabilizer offering smooth handheld shots without batteries.', 4, CAST(60.30 AS Decimal(10, 2)), 1, 1, 4)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (21, N'128GB SD Card', N'High-speed memory card suitable for 4K video and burst photography.', 5, CAST(31.88 AS Decimal(10, 2)), 1, 3, 4)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (22, N'Manfrotto Tripod', N'A sturdy and adjustable tripod ideal for both studio and field use.', 5, CAST(49.34 AS Decimal(10, 2)), 1, 3, 4)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (23, N'Camera Backpack', N'A weather-resistant padded backpack designed for safe gear transport.', 5, CAST(18.66 AS Decimal(10, 2)), 1, 2, 3)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (24, N'Lens Cleaning Kit', N'A compact kit containing microfiber cloths, blower, and lens cleaning solution.', 5, CAST(95.84 AS Decimal(10, 2)), 1, 3, 3)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (25, N'Battery Pack', N'Rechargeable power bank compatible with cameras and other accessories.', 5, CAST(87.65 AS Decimal(10, 2)), 1, 1, 2)
INSERT [dbo].[Equipment] ([EquipmentID], [EquipmentName], [Description], [CategoryID], [RentalPricePerDay], [Quantity], [ConditionID], [AvailabilityID]) VALUES (26, N'aaa', N'aaa', 5, CAST(123.00 AS Decimal(10, 2)), 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Equipment] OFF
GO
SET IDENTITY_INSERT [dbo].[EquipmentImages] ON 

INSERT [dbo].[EquipmentImages] ([ImageID], [EquipmentID], [ImagePath], [IsMain], [ImageData]) VALUES (1, 26, N'equipment_5d4797be-80a9-41c1-a494-2c148518ea6c.jpg', 1, NULL)
SET IDENTITY_INSERT [dbo].[EquipmentImages] OFF
GO
INSERT [dbo].[Feedback] ([FeedbackID], [UserID], [EquipmentID], [Rating], [Comments], [ReturnId]) VALUES (0, 1006, 22, 5, N'perfection', 14)
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (1, 6, N'Viewed Equipment List', CAST(N'2025-05-29T23:53:50.720' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (2, 6, N'Edited Equipment: Canon EOS 5D', CAST(N'2025-05-29T23:53:58.207' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (3, 6, N'Viewed Equipment List', CAST(N'2025-05-29T23:53:58.223' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (4, 6, N'Viewed Equipment List', CAST(N'2025-05-29T23:57:10.047' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (5, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T02:15:34.850' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (6, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T02:19:00.280' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (7, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T02:24:51.910' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (8, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T02:25:05.083' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (9, 1, N'Viewed All Rental Transactions', CAST(N'2025-05-30T02:26:26.753' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (10, 1, N'Viewed All Rental Transactions', CAST(N'2025-05-30T02:26:29.330' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (11, 1, N'Viewed Equipment List', CAST(N'2025-05-30T02:26:30.193' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (12, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:13:19.283' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (13, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:16:06.203' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (14, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:16:10.890' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (15, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:16:15.320' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (16, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:16:41.457' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (17, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:16:47.030' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (18, 6, N'Viewed Equipment List', CAST(N'2025-05-30T14:16:57.067' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (19, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:17:46.647' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (20, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:17:48.997' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (21, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:17:50.730' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (22, 1, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:18:05.590' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (23, 1, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:23:22.313' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (24, 1, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:23:33.790' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (25, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:23:45.950' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (26, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:23:48.380' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (27, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:25:19.100' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (28, 1006, N'Submitted return for Rental #10', CAST(N'2025-05-30T14:25:21.050' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (29, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:25:21.067' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (30, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T14:25:36.863' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (31, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-30T14:26:10.657' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (32, 6, N'Viewed All Rental Transactions', CAST(N'2025-05-30T17:12:42.413' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (33, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T00:25:49.577' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (34, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T01:52:09.900' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (35, 1006, N'Submitted return for Rental #11', CAST(N'2025-05-31T01:52:11.513' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (36, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T01:53:08.437' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (37, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T01:54:38.013' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (38, 1006, N'Submitted return for Rental #11', CAST(N'2025-05-31T01:54:41.243' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (39, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T03:34:04.133' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (40, 1006, N'Submitted return for Rental #12', CAST(N'2025-05-31T03:34:05.600' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (41, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T03:34:20.233' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (42, 1006, N'Viewed My Rental Orders', CAST(N'2025-05-31T03:39:10.397' AS DateTime))
INSERT [dbo].[Logs] ([LogID], [UserID], [Action], [Timestamp]) VALUES (43, 1006, N'Submitted return for Rental #13', CAST(N'2025-05-31T03:39:13.147' AS DateTime))
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalItems] ON 

INSERT [dbo].[RentalItems] ([RentalItemID], [RentalID], [EquipmentID], [Quantity], [Subtotal]) VALUES (1, 1, 2, 1, CAST(150.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItems] ([RentalItemID], [RentalID], [EquipmentID], [Quantity], [Subtotal]) VALUES (2, 2, 7, 1, CAST(135.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItems] ([RentalItemID], [RentalID], [EquipmentID], [Quantity], [Subtotal]) VALUES (3, 3, 12, 1, CAST(90.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItems] ([RentalItemID], [RentalID], [EquipmentID], [Quantity], [Subtotal]) VALUES (4, 4, 17, 1, CAST(120.00 AS Decimal(10, 2)))
INSERT [dbo].[RentalItems] ([RentalItemID], [RentalID], [EquipmentID], [Quantity], [Subtotal]) VALUES (5, 5, 22, 1, CAST(100.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[RentalItems] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalRequests] ON 

INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (1, 3, 1, CAST(N'2025-05-15' AS Date), CAST(N'2025-05-17' AS Date), 2, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (2, 3, 2, CAST(N'2025-05-15' AS Date), CAST(N'2025-05-17' AS Date), 1, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (3, 4, 6, CAST(N'2025-05-16' AS Date), CAST(N'2025-05-18' AS Date), 2, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (4, 4, 7, CAST(N'2025-05-16' AS Date), CAST(N'2025-05-18' AS Date), 1, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (5, 5, 11, CAST(N'2025-05-17' AS Date), CAST(N'2025-05-19' AS Date), 2, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (6, 5, 12, CAST(N'2025-05-17' AS Date), CAST(N'2025-05-19' AS Date), 1, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (7, 3, 16, CAST(N'2025-05-18' AS Date), CAST(N'2025-05-20' AS Date), 2, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (8, 3, 17, CAST(N'2025-05-18' AS Date), CAST(N'2025-05-20' AS Date), 1, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (9, 4, 21, CAST(N'2025-05-19' AS Date), CAST(N'2025-05-21' AS Date), 2, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (10, 4, 22, CAST(N'2025-05-19' AS Date), CAST(N'2025-05-21' AS Date), 1, CAST(N'2025-05-13T20:00:00.000' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (11, 6, 1, CAST(N'2025-05-29' AS Date), CAST(N'2025-05-31' AS Date), 1, CAST(N'2025-05-29T23:57:24.960' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (12, 6, 7, CAST(N'2025-05-29' AS Date), CAST(N'2025-05-31' AS Date), 1, CAST(N'2025-05-30T02:16:05.847' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (13, 1006, 5, CAST(N'2025-05-31' AS Date), CAST(N'2025-05-26' AS Date), 1, CAST(N'2025-05-30T14:16:27.417' AS DateTime))
INSERT [dbo].[RentalRequests] ([RequestID], [UserID], [EquipmentID], [RequestStartDate], [RequestEndDate], [RequestStatusID], [RequestSetDate]) VALUES (14, 1006, 18, CAST(N'2025-05-31' AS Date), CAST(N'2025-06-23' AS Date), 1, CAST(N'2025-05-30T17:12:15.050' AS DateTime))
SET IDENTITY_INSERT [dbo].[RentalRequests] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransactions] ON 

INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (1, 3, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-17' AS Date), CAST(150.00 AS Decimal(10, 2)), CAST(75.00 AS Decimal(10, 2)), N'Ongoing', 2)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (2, 4, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-17' AS Date), CAST(135.00 AS Decimal(10, 2)), CAST(67.50 AS Decimal(10, 2)), N'Ongoing', 4)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (3, 5, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-17' AS Date), CAST(90.00 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'Ongoing', 6)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (4, 3, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-17' AS Date), CAST(120.00 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'Ongoing', 8)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (5, 4, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Ongoing', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (6, 6, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Ongoing', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (7, 6, CAST(N'2025-05-14' AS Date), CAST(N'2025-05-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Ongoing', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (8, 6, CAST(N'2025-07-14' AS Date), CAST(N'2025-07-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Pending', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (9, 6, CAST(N'2025-07-14' AS Date), CAST(N'2025-07-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Pending', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (10, 1006, CAST(N'2025-07-14' AS Date), CAST(N'2025-07-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Pending', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (11, 1006, CAST(N'2025-07-14' AS Date), CAST(N'2025-07-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Ongoing', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (12, 1006, CAST(N'2025-07-14' AS Date), CAST(N'2025-07-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Ongoing', 10)
INSERT [dbo].[RentalTransactions] ([RentalID], [UserID], [StartDate], [EndDate], [RentalFee], [DepositPaid], [Status], [RequestID]) VALUES (13, 1006, CAST(N'2025-07-14' AS Date), CAST(N'2025-07-17' AS Date), CAST(100.00 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'Ongoing', 10)
SET IDENTITY_INSERT [dbo].[RentalTransactions] OFF
GO
SET IDENTITY_INSERT [dbo].[RequestStatuses] ON 

INSERT [dbo].[RequestStatuses] ([RequestStatusID], [StatusName]) VALUES (1, N'Approved')
INSERT [dbo].[RequestStatuses] ([RequestStatusID], [StatusName]) VALUES (2, N'Pending')
INSERT [dbo].[RequestStatuses] ([RequestStatusID], [StatusName]) VALUES (3, N'Rejected')
SET IDENTITY_INSERT [dbo].[RequestStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnRecords] ON 

INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (1, 1, CAST(N'2025-05-18' AS Date), N'Excellent', N'Returned in mint condition.')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (2, 2, CAST(N'2025-05-18' AS Date), N'Slight Wear', N'Slight smudges on lens.')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (3, 3, CAST(N'2025-05-18' AS Date), N'Requires Maintenance', N'Tripod leg is loose.')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (4, 4, CAST(N'2025-05-18' AS Date), N'Excellent', N'No visible issues.')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (5, 5, CAST(N'2025-05-18' AS Date), N'Slight Wear', N'Minor scratches on casing.')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (6, 6, CAST(N'2025-05-31' AS Date), N'Excellent', N'No notes')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (7, 8, CAST(N'2025-05-31' AS Date), N'Excellent', N'No notes')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (8, 7, CAST(N'2025-05-31' AS Date), N'Slight Wear', N'No notes')
INSERT [dbo].[ReturnRecords] ([ReturnID], [RentalID], [ReturnDate], [ConditionStatus], [Notes]) VALUES (14, 13, CAST(N'2025-05-31' AS Date), N'Requires Maintenance', N'user broke it')
SET IDENTITY_INSERT [dbo].[ReturnRecords] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (3, N'Customer')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'Staff')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (1, N'Sara Abdullah', N'sara.admin@example.com', 12345601, 1, NULL)
INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (2, N'Ali Mahmood', N'ali.staff@example.com', 12345602, 2, NULL)
INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (3, N'Fatima Hasan', N'fatima.customer@example.com', 12345603, 3, NULL)
INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (4, N'Hassan Yousif', N'hassan.customer@example.com', 12345604, 3, NULL)
INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (5, N'Amina Khalid', N'amina.customer@example.com', 12345605, 3, NULL)
INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (6, N'T A', N'test1@gmail.com', 33430100, 2, N'da2f5231-9a1b-4d07-bfd5-f8531b451376')
INSERT [dbo].[Users] ([UserID], [FullName], [Email], [PhoneNumber], [RoleID], [IdentityUserID]) VALUES (1006, N'T C', N'test2@gmail.com', 33430100, 3, N'c743e5f6-8ec0-4f20-a723-a36ddf1c4697')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Categories]    Script Date: 5/31/2025 3:54:06 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Categories] ON [dbo].[Categories]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Roles]    Script Date: 5/31/2025 3:54:06 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Roles] ON [dbo].[Roles]
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users]    Script Date: 5/31/2025 3:54:06 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users] ON [dbo].[Users]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Feedback] ADD  DEFAULT ((0)) FOR [ReturnId]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_AvailabilityID_AvailabilityStatuses_Equipment] FOREIGN KEY([AvailabilityID])
REFERENCES [dbo].[AvailabilityStatuses] ([AvailabilityID])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_AvailabilityID_AvailabilityStatuses_Equipment]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_CategoryID_Categories_Equipment] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_CategoryID_Categories_Equipment]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_ConditionID_ConditionStatuses_Equipment] FOREIGN KEY([ConditionID])
REFERENCES [dbo].[ConditionStatuses] ([ConditionID])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_ConditionID_ConditionStatuses_Equipment]
GO
ALTER TABLE [dbo].[EquipmentImages]  WITH CHECK ADD  CONSTRAINT [FK_EquipmentID_Equipment_EquipmentImages] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipment] ([EquipmentID])
GO
ALTER TABLE [dbo].[EquipmentImages] CHECK CONSTRAINT [FK_EquipmentID_Equipment_EquipmentImages]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Equipment] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipment] ([EquipmentID])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Equipment]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Feedback] FOREIGN KEY([FeedbackID])
REFERENCES [dbo].[Feedback] ([FeedbackID])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Feedback]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_ReturnRecords] FOREIGN KEY([ReturnId])
REFERENCES [dbo].[ReturnRecords] ([ReturnID])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_ReturnRecords]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_UserID_Users_Feedback] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_UserID_Users_Feedback]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_UserID_Users_Logs] FOREIGN KEY([LogID])
REFERENCES [dbo].[Logs] ([LogID])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_UserID_Users_Logs]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_UserID_Users_Notifications] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_UserID_Users_Notifications]
GO
ALTER TABLE [dbo].[RentalItems]  WITH CHECK ADD  CONSTRAINT [FK_EquipmentID_Equipment_RentalItems] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipment] ([EquipmentID])
GO
ALTER TABLE [dbo].[RentalItems] CHECK CONSTRAINT [FK_EquipmentID_Equipment_RentalItems]
GO
ALTER TABLE [dbo].[RentalItems]  WITH CHECK ADD  CONSTRAINT [FK_RentalID_RentalTransactions_RentalItems] FOREIGN KEY([RentalID])
REFERENCES [dbo].[RentalTransactions] ([RentalID])
GO
ALTER TABLE [dbo].[RentalItems] CHECK CONSTRAINT [FK_RentalID_RentalTransactions_RentalItems]
GO
ALTER TABLE [dbo].[RentalRequests]  WITH CHECK ADD  CONSTRAINT [FK_RentalRequests_Equipment] FOREIGN KEY([EquipmentID])
REFERENCES [dbo].[Equipment] ([EquipmentID])
GO
ALTER TABLE [dbo].[RentalRequests] CHECK CONSTRAINT [FK_RentalRequests_Equipment]
GO
ALTER TABLE [dbo].[RentalRequests]  WITH CHECK ADD  CONSTRAINT [FK_RentalRequests_RequestStatuses] FOREIGN KEY([RequestStatusID])
REFERENCES [dbo].[RequestStatuses] ([RequestStatusID])
GO
ALTER TABLE [dbo].[RentalRequests] CHECK CONSTRAINT [FK_RentalRequests_RequestStatuses]
GO
ALTER TABLE [dbo].[RentalRequests]  WITH CHECK ADD  CONSTRAINT [FK_RentalRequests_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[RentalRequests] CHECK CONSTRAINT [FK_RentalRequests_Users]
GO
ALTER TABLE [dbo].[RentalTransactions]  WITH CHECK ADD  CONSTRAINT [FK_RequestID_RentalRequests_RentalTransactions] FOREIGN KEY([RequestID])
REFERENCES [dbo].[RentalRequests] ([RequestID])
GO
ALTER TABLE [dbo].[RentalTransactions] CHECK CONSTRAINT [FK_RequestID_RentalRequests_RentalTransactions]
GO
ALTER TABLE [dbo].[RentalTransactions]  WITH CHECK ADD  CONSTRAINT [FK_UserID_Users_RentalTransactions] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[RentalTransactions] CHECK CONSTRAINT [FK_UserID_Users_RentalTransactions]
GO
ALTER TABLE [dbo].[ReturnRecords]  WITH CHECK ADD  CONSTRAINT [FK_RentalID_RentalTransactions_ReturnRecords] FOREIGN KEY([RentalID])
REFERENCES [dbo].[RentalTransactions] ([RentalID])
GO
ALTER TABLE [dbo].[ReturnRecords] CHECK CONSTRAINT [FK_RentalID_RentalTransactions_ReturnRecords]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_RoleID_Roles_Users] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_RoleID_Roles_Users]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [CK_Feedback_StarsRating] CHECK  (([Rating]>=(1) AND [Rating]<=(5)))
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [CK_Feedback_StarsRating]
GO
USE [master]
GO
ALTER DATABASE [LightAndLens] SET  READ_WRITE 
GO
