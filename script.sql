USE [demirbas]
GO
/****** Object:  Table [dbo].[demirbasGirisListe]    Script Date: 14.09.2022 21:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[demirbasGirisListe](
	[URUN] [varchar](50) NULL,
	[URUNKOD] [int] IDENTITY(1,1) NOT NULL,
	[URUNSERINO] [int] NULL,
	[MARKA] [varchar](50) NULL,
	[TARIH] [varchar](50) NULL,
	[ZIMMETLIKISI] [varchar](50) NULL,
	[ZIMMETLIBIRIM] [varchar](50) NULL,
	[ZIMMETLIBIRIMDETAY] [varchar](50) NULL,
	[ZIMMETKATAGORI] [varchar](50) NULL,
	[ZIMMETKULLANICI] [varchar](50) NULL,
 CONSTRAINT [PK_demirbasGirisListe] PRIMARY KEY CLUSTERED 
(
	[URUNKOD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[katagoriler]    Script Date: 14.09.2022 21:41:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[katagoriler](
	[KATAGORIID] [int] IDENTITY(1,1) NOT NULL,
	[KATAGORI] [varchar](50) NULL,
 CONSTRAINT [PK_katagoriler] PRIMARY KEY CLUSTERED 
(
	[KATAGORIID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personel]    Script Date: 14.09.2022 21:41:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AD] [varchar](50) NULL,
	[SOYAD] [varchar](50) NULL,
	[PAROLA] [varchar](50) NULL,
	[YETKI] [varchar](50) NULL,
 CONSTRAINT [PK_personel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[demirbasGirisListe] ON 

INSERT [dbo].[demirbasGirisListe] ([URUN], [URUNKOD], [URUNSERINO], [MARKA], [TARIH], [ZIMMETLIKISI], [ZIMMETLIBIRIM], [ZIMMETLIBIRIMDETAY], [ZIMMETKATAGORI], [ZIMMETKULLANICI]) VALUES (N'Monitor', 3, 888898, N'Siemens', N'12.02.2022', N'Ayhan', N'Bilgi İşlem', N'Kalem verdik', N'Bilgi İşlem', N'Berat')
INSERT [dbo].[demirbasGirisListe] ([URUN], [URUNKOD], [URUNSERINO], [MARKA], [TARIH], [ZIMMETLIKISI], [ZIMMETLIBIRIM], [ZIMMETLIBIRIMDETAY], [ZIMMETKATAGORI], [ZIMMETKULLANICI]) VALUES (N'Masa', 12, 0, N'Masachi', N'28.07.2022', N'Berat', N'Basın Yayın', N'', N'Masa', N'Ahmet')
SET IDENTITY_INSERT [dbo].[demirbasGirisListe] OFF
SET IDENTITY_INSERT [dbo].[katagoriler] ON 

INSERT [dbo].[katagoriler] ([KATAGORIID], [KATAGORI]) VALUES (11, N'Tencere')
SET IDENTITY_INSERT [dbo].[katagoriler] OFF
SET IDENTITY_INSERT [dbo].[personel] ON 

INSERT [dbo].[personel] ([ID], [AD], [SOYAD], [PAROLA], [YETKI]) VALUES (1, N'Berat', N'Karabulut', N'123', N'memur')
INSERT [dbo].[personel] ([ID], [AD], [SOYAD], [PAROLA], [YETKI]) VALUES (2, N'Burak', N'Yılmaz', N'123', N'memur')
INSERT [dbo].[personel] ([ID], [AD], [SOYAD], [PAROLA], [YETKI]) VALUES (3, N'Ayse', N'Yıldıran', N'123', N'memur')
SET IDENTITY_INSERT [dbo].[personel] OFF
