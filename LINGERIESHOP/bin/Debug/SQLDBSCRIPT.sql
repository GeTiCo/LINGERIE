USE [master]
GO
/****** Object:  Database [SwimSuitShop]    Script Date: 21.04.2023 19:30:31 ******/
CREATE DATABASE [SwimSuitShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SwimSuitShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SwimSuitShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SwimSuitShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SwimSuitShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SwimSuitShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SwimSuitShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SwimSuitShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SwimSuitShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SwimSuitShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SwimSuitShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SwimSuitShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [SwimSuitShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SwimSuitShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SwimSuitShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SwimSuitShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SwimSuitShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SwimSuitShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SwimSuitShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SwimSuitShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SwimSuitShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SwimSuitShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SwimSuitShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SwimSuitShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SwimSuitShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SwimSuitShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SwimSuitShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SwimSuitShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SwimSuitShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SwimSuitShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SwimSuitShop] SET  MULTI_USER 
GO
ALTER DATABASE [SwimSuitShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SwimSuitShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SwimSuitShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SwimSuitShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SwimSuitShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SwimSuitShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SwimSuitShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [SwimSuitShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SwimSuitShop]
GO
/****** Object:  Table [dbo].[category]    Script Date: 21.04.2023 19:30:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[categoryId] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [varchar](255) NOT NULL,
	[categoryPhotoURL] [varchar](255) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 21.04.2023 19:30:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[productId] [int] IDENTITY(1,1) NOT NULL,
	[categoryId] [int] NOT NULL,
	[productName] [varchar](255) NOT NULL,
	[productCost] [int] NOT NULL,
	[productSize] [varchar](255) NULL,
	[productMaterial] [varchar](255) NULL,
	[productStructure] [varchar](255) NULL,
	[productInformation] [text] NULL,
	[productPhotoUrl] [varchar](255) NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[productId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 21.04.2023 19:30:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[userLogin] [varchar](50) NOT NULL,
	[userPassword] [varchar](50) NOT NULL,
	[userRole] [int] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([categoryId], [categoryName], [categoryPhotoURL]) VALUES (1, N'Закрытый купальник', N'/BANERS/Закрытый купальник.jpg')
INSERT [dbo].[category] ([categoryId], [categoryName], [categoryPhotoURL]) VALUES (2, N'Открытый купальник', N'/BANERS/Открытый купальник.jpg')
INSERT [dbo].[category] ([categoryId], [categoryName], [categoryPhotoURL]) VALUES (3, N'Декоративный купальник', N'/BANERS/Декоративный купальник.jpg')
INSERT [dbo].[category] ([categoryId], [categoryName], [categoryPhotoURL]) VALUES (4, N'Цельный купальник', N'/BANERS/Цельный купальник.jpg')
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (3, 1, N'Kaedehara Kazuha Derivative Deep V', 2550, N'S, M, L, XL', N'Polyester, Chiffon', N'One-piece swimsuit, Cover-up, Choker, Clip', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Закрытый купальник/Kaedehara Kazuha Derivative Deep V.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (4, 1, N'Lisa Derivative Sexy One-Piece Swimsuit', 2050, N'S, M, L, XL', N'Polyester', N'One-piece swimsuit, Choker', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Закрытый купальник/Lisa Derivative Sexy One-Piece Swimsuit.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (5, 1, N'Cover Ups Layla Derivative Beach', 650, N'S, M, L, XL, XXL', N'Polyester', N'Sarong wrap', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Закрытый купальник/Cover Ups Layla Derivative Beach.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (6, 1, N'Swimwear Cover Ups Nahida Derivative', 600, N'S, M, L, XL, XXL', N'Polyester', N'Sarong wrap', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Закрытый купальник/Swimwear Cover Ups Nahida Derivative.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (7, 4, N'Raiden Shogun Derivative', 2500, N'S, M, L, XL', N'Polyester, Chiffon', N'one-piece swimsuit, cover-up, clip', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Цельный купальник/Raiden Shogun Derivative.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (8, 4, N'Ganyu One-Piece Swimsuit Backless', 2400, N'S, M, L, XL', N'Polyester, Chiffon', N'one-piece swimsuit, cover-up', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Цельный купальник/Ganyu One-Piece Swimsuit Backless.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (9, 4, N'Hu Tao Derivative One-Piece Swimsuit', 2400, N'S, M, L, XL', N'Polyester, Chiffon', N'one-piece swimsuit, cover-up, clip', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Цельный купальник/Hu Tao Derivative One-Piece Swimsuit.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (11, 3, N'Cyno Derivative Bikini', 1900, N'S, M, L, XL', N'Polyester, Chiffon, Spandex', N'Top, Bottoms, Mesh top, Skirt, Choker.', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Cyno Derivative Bikini.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (12, 3, N'Venti Derivative One-Piece Swimsuit', 1800, N'S, M, L, XL', N'Polyester, Chiffon', N'One-piece swimsuit, Headband', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Venti Derivative One-Piece Swimsuit.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (13, 3, N'Ms Hina Gorou Derivative Bikini', 2150, N'S, M, L, XL', N'Polyester, Chiffon', N'Top, Bottoms, Cover-up, Choker, Belt', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Ms Hina Gorou Derivative Bikini.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (14, 3, N'Keqing Derivative Two-Piece Swimsuit', 2650, N'S, M, L, XL', N'Polyester, Chiffon', N'Top, Panty, Ribbon*2', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Keqing Derivative Two-Piece Swimsuit.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (15, 3, N'Kamisato Ayato Derivative Kimono Haori', 1600, N'S, M, L, XL', N'Chiffon', N'Cover-up', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Kamisato Ayato Derivative Kimono Haori.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (16, 3, N'Raiden Shogun Derivative Bikini Set Halter', 1600, N'S, M, L, XL', N'Polyester, Chiffon', N'Top, Briefs, Cover-up, Choker, Clip', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Raiden Shogun Derivative Bikini Set Halter.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (17, 3, N'Hu Tao Derivative Bikini Set Chinese Style', 2050, N'S, M, L, XL', N'Polyester, Chiffon', N'Top, Bottoms, Cover-up, Clips*2', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Декоративный купальник/Hu Tao Derivative Bikini Set Chinese Style.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (18, 2, N'Xiao Derivative Two-Piece Swimsuit', 1350, N'S, M, L, XL', N'Polyester', N'Top, Panty', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Xiao Derivative Two-Piece Swimsuit.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (19, 2, N'Keqing Derivative Bikini Set', 1750, N'S, M, L, XL', N'Polyester, Chiffon', N'Top, Bottoms, Wrap skirt', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Keqing Derivative Bikini Set.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (20, 2, N'Mona Derivative Two-Piece Cute Star', 1000, N'S, M, L, XL', N'Swimwear fabric', N'Top, Panty', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Mona Derivative Two-Piece Cute Star.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (21, 2, N'Tighnari Derivative Beach', 650, N'S, M, L, XL, XXL', N'Polyester', N'Sarong wrap', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Tighnari Derivative Beach.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (22, 2, N'Venti Two-Piece Swimsuit Green Prints', 1200, N'S, M, L, XL', N'Polyester, Spandex', N'Top, Bottoms', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Venti Two-Piece Swimsuit Green Prints.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (23, 2, N'Childe Tartaglia Derivative Bikini', 1250, N'S, M, L, XL', N'Polyester, Chiffon', N'Top, Panty, Skirt, Clip', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Childe Tartaglia Derivative Bikini.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (24, 2, N'Ganyu Derivative Two-piece Swimsuit', 2050, N'S, M, L, XL', N'Polyester', N'Top, Panty, Stickers', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Ganyu Derivative Two-piece Swimsuit.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (25, 2, N'Cyno Derivative Women Swimwear Cover', 1350, N'S, M, L, XL, XXL', N'Polyester', N'Sarong wrap', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Cyno Derivative Women Swimwear Cover.png')
INSERT [dbo].[product] ([productId], [categoryId], [productName], [productCost], [productSize], [productMaterial], [productStructure], [productInformation], [productPhotoUrl]) VALUES (26, 2, N'Dori Derivative Women Swimwear Cover', 1300, N'S, M, L, XL, XXL', N'Polyester', N'Sarong wrap', N'"Attention:
1.Swimwear products have exclusive tags (on the crotch of the clothing). After the tag is removed, the product cannot be returned or exchanged.
2.Swimwear products are personal clothing and cannot be returned or exchanged after use.
3.The swimming suits belong to underwear, so please wear shorts when you try on, otherwise the swimming suits can’t be returned or exchanged if the question appears.
4.All the swimming suits are with Protective Hygienic/Hygienic Panty Swimwear Liner, and the swimming suits can’t be returned or exchanged if ripped the liner."', N'/photo/Открытый купальник/Dori Derivative Women Swimwear Cover.png')
SET IDENTITY_INSERT [dbo].[product] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([userId], [userLogin], [userPassword], [userRole]) VALUES (1, N'admin', N'admin', 1)
INSERT [dbo].[user] ([userId], [userLogin], [userPassword], [userRole]) VALUES (2, N'manager', N'manager', 2)
INSERT [dbo].[user] ([userId], [userLogin], [userPassword], [userRole]) VALUES (3, N'test1', N'test1', 3)
INSERT [dbo].[user] ([userId], [userLogin], [userPassword], [userRole]) VALUES (4, N'test2', N'test2', 3)
INSERT [dbo].[user] ([userId], [userLogin], [userPassword], [userRole]) VALUES (5, N'test3', N'test3', 3)
INSERT [dbo].[user] ([userId], [userLogin], [userPassword], [userRole]) VALUES (6, N'test4', N'1', 3)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_category] FOREIGN KEY([categoryId])
REFERENCES [dbo].[category] ([categoryId])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_category]
GO
USE [master]
GO
ALTER DATABASE [SwimSuitShop] SET  READ_WRITE 
GO
