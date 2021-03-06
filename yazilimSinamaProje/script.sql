USE [master]
GO
/****** Object:  Database [YazilimTestiProjesi]    Script Date: 25.12.2017 23:38:01 ******/
CREATE DATABASE [YazilimTestiProjesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YazilimTestiProjesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\YazilimTestiProjesi.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'YazilimTestiProjesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\YazilimTestiProjesi_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [YazilimTestiProjesi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YazilimTestiProjesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [YazilimTestiProjesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [YazilimTestiProjesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [YazilimTestiProjesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [YazilimTestiProjesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [YazilimTestiProjesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET RECOVERY FULL 
GO
ALTER DATABASE [YazilimTestiProjesi] SET  MULTI_USER 
GO
ALTER DATABASE [YazilimTestiProjesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [YazilimTestiProjesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [YazilimTestiProjesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [YazilimTestiProjesi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [YazilimTestiProjesi] SET DELAYED_DURABILITY = DISABLED 
GO
USE [YazilimTestiProjesi]
GO
/****** Object:  Table [dbo].[tbl_DemirbasAtamalar]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DemirbasAtamalar](
	[odaDemirbasAtamaID] [int] IDENTITY(1,1) NOT NULL,
	[odaID] [int] NULL,
	[demirbasID] [int] NULL,
	[atanmaAdedi] [int] NULL,
	[personelID] [int] NULL,
 CONSTRAINT [PK_tbl_DemirbasAtamalar] PRIMARY KEY CLUSTERED 
(
	[odaDemirbasAtamaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Demirbaslar]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Demirbaslar](
	[demirbasID] [int] IDENTITY(1,1) NOT NULL,
	[demirbasAdi] [nvarchar](250) NULL,
	[fiyat] [money] NULL,
	[alimTarihi] [datetime] NULL,
	[demirbasTuruID] [int] NULL,
	[fakulteID] [int] NULL,
	[departmanID] [int] NULL,
	[demirbasAdedi] [int] NULL,
 CONSTRAINT [PK_tbl_Demirbaslar] PRIMARY KEY CLUSTERED 
(
	[demirbasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_DemirbasTuru]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DemirbasTuru](
	[demirbasTuruID] [int] NOT NULL,
	[demeribasTuruAdi] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_DemirbasTuru] PRIMARY KEY CLUSTERED 
(
	[demirbasTuruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Departmanlar]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Departmanlar](
	[departmanID] [int] NOT NULL,
	[departmanAdi] [nvarchar](250) NULL,
	[fakulteID] [int] NULL,
 CONSTRAINT [PK_tbl_Departmanlar] PRIMARY KEY CLUSTERED 
(
	[departmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Fakulteler]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Fakulteler](
	[fakulteID] [int] NOT NULL,
	[fakulteAdi] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Fakulteler] PRIMARY KEY CLUSTERED 
(
	[fakulteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Kullanicilar]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Kullanicilar](
	[kullaniciID] [int] NOT NULL,
	[personelID] [int] NULL,
	[kullaniciAdi] [nvarchar](250) NULL,
	[yetki] [bit] NULL,
	[sifre] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Odalar]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Odalar](
	[odaID] [int] IDENTITY(1,1) NOT NULL,
	[odaAdi] [nvarchar](250) NULL,
	[departmanID] [int] NULL,
	[personelID] [int] NULL,
 CONSTRAINT [PK_tbl_Odalar] PRIMARY KEY CLUSTERED 
(
	[odaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Personeller]    Script Date: 25.12.2017 23:38:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Personeller](
	[personelID] [int] NOT NULL,
	[personelAdi] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Personeller] PRIMARY KEY CLUSTERED 
(
	[personelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_DemirbasAtamalar] ON 

INSERT [dbo].[tbl_DemirbasAtamalar] ([odaDemirbasAtamaID], [odaID], [demirbasID], [atanmaAdedi], [personelID]) VALUES (3, 8, 15, 24, 2)
INSERT [dbo].[tbl_DemirbasAtamalar] ([odaDemirbasAtamaID], [odaID], [demirbasID], [atanmaAdedi], [personelID]) VALUES (4, 9, 16, 15, 4)
INSERT [dbo].[tbl_DemirbasAtamalar] ([odaDemirbasAtamaID], [odaID], [demirbasID], [atanmaAdedi], [personelID]) VALUES (5, 8, 17, 1, 5)
INSERT [dbo].[tbl_DemirbasAtamalar] ([odaDemirbasAtamaID], [odaID], [demirbasID], [atanmaAdedi], [personelID]) VALUES (6, 11, 15, 2, 1)
INSERT [dbo].[tbl_DemirbasAtamalar] ([odaDemirbasAtamaID], [odaID], [demirbasID], [atanmaAdedi], [personelID]) VALUES (7, 11, 15, 2, 6)
SET IDENTITY_INSERT [dbo].[tbl_DemirbasAtamalar] OFF
SET IDENTITY_INSERT [dbo].[tbl_Demirbaslar] ON 

INSERT [dbo].[tbl_Demirbaslar] ([demirbasID], [demirbasAdi], [fiyat], [alimTarihi], [demirbasTuruID], [fakulteID], [departmanID], [demirbasAdedi]) VALUES (15, N'vestel', 20.0000, CAST(N'2017-12-24 00:00:00.000' AS DateTime), 1, 1, 1, 172)
INSERT [dbo].[tbl_Demirbaslar] ([demirbasID], [demirbasAdi], [fiyat], [alimTarihi], [demirbasTuruID], [fakulteID], [departmanID], [demirbasAdedi]) VALUES (16, N'logitech', 80.0000, CAST(N'2017-12-01 00:00:00.000' AS DateTime), 3, 2, 4, 30)
INSERT [dbo].[tbl_Demirbaslar] ([demirbasID], [demirbasAdi], [fiyat], [alimTarihi], [demirbasTuruID], [fakulteID], [departmanID], [demirbasAdedi]) VALUES (17, N'ikea masa', 300.0000, CAST(N'2017-11-08 00:00:00.000' AS DateTime), 4, 1, 1, 4)
INSERT [dbo].[tbl_Demirbaslar] ([demirbasID], [demirbasAdi], [fiyat], [alimTarihi], [demirbasTuruID], [fakulteID], [departmanID], [demirbasAdedi]) VALUES (18, N'huwei', 2000.5000, CAST(N'2017-10-11 00:00:00.000' AS DateTime), 6, 1, 2, 2)
INSERT [dbo].[tbl_Demirbaslar] ([demirbasID], [demirbasAdi], [fiyat], [alimTarihi], [demirbasTuruID], [fakulteID], [departmanID], [demirbasAdedi]) VALUES (19, N'spot sandalye', 20.3000, CAST(N'2017-08-21 00:00:00.000' AS DateTime), 5, 1, 2, 40)
INSERT [dbo].[tbl_Demirbaslar] ([demirbasID], [demirbasAdi], [fiyat], [alimTarihi], [demirbasTuruID], [fakulteID], [departmanID], [demirbasAdedi]) VALUES (20, N'Masa', 100.0000, CAST(N'2017-12-25 00:00:00.000' AS DateTime), 4, 1, 1, 100)
SET IDENTITY_INSERT [dbo].[tbl_Demirbaslar] OFF
INSERT [dbo].[tbl_DemirbasTuru] ([demirbasTuruID], [demeribasTuruAdi]) VALUES (1, N'Monitör')
INSERT [dbo].[tbl_DemirbasTuru] ([demirbasTuruID], [demeribasTuruAdi]) VALUES (2, N'Klavye')
INSERT [dbo].[tbl_DemirbasTuru] ([demirbasTuruID], [demeribasTuruAdi]) VALUES (3, N'Fare')
INSERT [dbo].[tbl_DemirbasTuru] ([demirbasTuruID], [demeribasTuruAdi]) VALUES (4, N'Masa')
INSERT [dbo].[tbl_DemirbasTuru] ([demirbasTuruID], [demeribasTuruAdi]) VALUES (5, N'Sandalye')
INSERT [dbo].[tbl_DemirbasTuru] ([demirbasTuruID], [demeribasTuruAdi]) VALUES (6, N'Projektör')
INSERT [dbo].[tbl_Departmanlar] ([departmanID], [departmanAdi], [fakulteID]) VALUES (1, N'Yazılım', 1)
INSERT [dbo].[tbl_Departmanlar] ([departmanID], [departmanAdi], [fakulteID]) VALUES (2, N'Mekatronik', 1)
INSERT [dbo].[tbl_Departmanlar] ([departmanID], [departmanAdi], [fakulteID]) VALUES (3, N'Elektronik', 2)
INSERT [dbo].[tbl_Departmanlar] ([departmanID], [departmanAdi], [fakulteID]) VALUES (4, N'Makine', 2)
INSERT [dbo].[tbl_Fakulteler] ([fakulteID], [fakulteAdi]) VALUES (1, N'Teknoloji')
INSERT [dbo].[tbl_Fakulteler] ([fakulteID], [fakulteAdi]) VALUES (2, N'Mühendislik')
INSERT [dbo].[tbl_Kullanicilar] ([kullaniciID], [personelID], [kullaniciAdi], [yetki], [sifre]) VALUES (1, 1, N'Kemal', 1, N'1234')
INSERT [dbo].[tbl_Kullanicilar] ([kullaniciID], [personelID], [kullaniciAdi], [yetki], [sifre]) VALUES (2, NULL, N'Hakan', 0, N'0000')
INSERT [dbo].[tbl_Kullanicilar] ([kullaniciID], [personelID], [kullaniciAdi], [yetki], [sifre]) VALUES (3, 2, N'Kaan', 1, N'1111')
SET IDENTITY_INSERT [dbo].[tbl_Odalar] ON 

INSERT [dbo].[tbl_Odalar] ([odaID], [odaAdi], [departmanID], [personelID]) VALUES (8, N'lab1', 1, 1)
INSERT [dbo].[tbl_Odalar] ([odaID], [odaAdi], [departmanID], [personelID]) VALUES (9, N'lab2', 4, 3)
INSERT [dbo].[tbl_Odalar] ([odaID], [odaAdi], [departmanID], [personelID]) VALUES (10, N'lab3', 2, 3)
INSERT [dbo].[tbl_Odalar] ([odaID], [odaAdi], [departmanID], [personelID]) VALUES (11, N'Lab-4', 1, 6)
SET IDENTITY_INSERT [dbo].[tbl_Odalar] OFF
INSERT [dbo].[tbl_Personeller] ([personelID], [personelAdi]) VALUES (1, N'Ahmet')
INSERT [dbo].[tbl_Personeller] ([personelID], [personelAdi]) VALUES (2, N'Burak')
INSERT [dbo].[tbl_Personeller] ([personelID], [personelAdi]) VALUES (3, N'Cenk')
INSERT [dbo].[tbl_Personeller] ([personelID], [personelAdi]) VALUES (4, N'Ekrem')
INSERT [dbo].[tbl_Personeller] ([personelID], [personelAdi]) VALUES (5, N'Faruk')
INSERT [dbo].[tbl_Personeller] ([personelID], [personelAdi]) VALUES (6, N'Boş')
ALTER TABLE [dbo].[tbl_DemirbasAtamalar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DemirbasAtamalar_tbl_Demirbaslar] FOREIGN KEY([demirbasID])
REFERENCES [dbo].[tbl_Demirbaslar] ([demirbasID])
GO
ALTER TABLE [dbo].[tbl_DemirbasAtamalar] CHECK CONSTRAINT [FK_tbl_DemirbasAtamalar_tbl_Demirbaslar]
GO
ALTER TABLE [dbo].[tbl_DemirbasAtamalar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DemirbasAtamalar_tbl_Odalar] FOREIGN KEY([odaID])
REFERENCES [dbo].[tbl_Odalar] ([odaID])
GO
ALTER TABLE [dbo].[tbl_DemirbasAtamalar] CHECK CONSTRAINT [FK_tbl_DemirbasAtamalar_tbl_Odalar]
GO
ALTER TABLE [dbo].[tbl_DemirbasAtamalar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DemirbasAtamalar_tbl_Personeller] FOREIGN KEY([personelID])
REFERENCES [dbo].[tbl_Personeller] ([personelID])
GO
ALTER TABLE [dbo].[tbl_DemirbasAtamalar] CHECK CONSTRAINT [FK_tbl_DemirbasAtamalar_tbl_Personeller]
GO
ALTER TABLE [dbo].[tbl_Demirbaslar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Demirbaslar_tbl_DemirbasTuru] FOREIGN KEY([demirbasTuruID])
REFERENCES [dbo].[tbl_DemirbasTuru] ([demirbasTuruID])
GO
ALTER TABLE [dbo].[tbl_Demirbaslar] CHECK CONSTRAINT [FK_tbl_Demirbaslar_tbl_DemirbasTuru]
GO
ALTER TABLE [dbo].[tbl_Demirbaslar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Demirbaslar_tbl_Departmanlar] FOREIGN KEY([departmanID])
REFERENCES [dbo].[tbl_Departmanlar] ([departmanID])
GO
ALTER TABLE [dbo].[tbl_Demirbaslar] CHECK CONSTRAINT [FK_tbl_Demirbaslar_tbl_Departmanlar]
GO
ALTER TABLE [dbo].[tbl_Demirbaslar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Demirbaslar_tbl_Fakulteler] FOREIGN KEY([fakulteID])
REFERENCES [dbo].[tbl_Fakulteler] ([fakulteID])
GO
ALTER TABLE [dbo].[tbl_Demirbaslar] CHECK CONSTRAINT [FK_tbl_Demirbaslar_tbl_Fakulteler]
GO
ALTER TABLE [dbo].[tbl_Kullanicilar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Kullanicilar_tbl_Personeller] FOREIGN KEY([personelID])
REFERENCES [dbo].[tbl_Personeller] ([personelID])
GO
ALTER TABLE [dbo].[tbl_Kullanicilar] CHECK CONSTRAINT [FK_tbl_Kullanicilar_tbl_Personeller]
GO
ALTER TABLE [dbo].[tbl_Odalar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Odalar_tbl_Departmanlar] FOREIGN KEY([departmanID])
REFERENCES [dbo].[tbl_Departmanlar] ([departmanID])
GO
ALTER TABLE [dbo].[tbl_Odalar] CHECK CONSTRAINT [FK_tbl_Odalar_tbl_Departmanlar]
GO
ALTER TABLE [dbo].[tbl_Odalar]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Odalar_tbl_Personeller] FOREIGN KEY([personelID])
REFERENCES [dbo].[tbl_Personeller] ([personelID])
GO
ALTER TABLE [dbo].[tbl_Odalar] CHECK CONSTRAINT [FK_tbl_Odalar_tbl_Personeller]
GO
USE [master]
GO
ALTER DATABASE [YazilimTestiProjesi] SET  READ_WRITE 
GO
