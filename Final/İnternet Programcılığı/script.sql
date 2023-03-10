USE [OkulDB]
GO
/****** Object:  Table [dbo].[DersTab]    Script Date: 17.01.2023 20:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DersTab](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Kredi] [float] NULL,
	[OkulYonetimId] [int] NULL,
	[DersRenk] [nvarchar](50) NULL,
 CONSTRAINT [PK_DersTab] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDersTab]    Script Date: 17.01.2023 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDersTab](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DersId] [int] NULL,
	[OgrenciId] [int] NULL,
 CONSTRAINT [PK_OgrenciDersTab] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciTab]    Script Date: 17.01.2023 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciTab](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](50) NULL,
	[KayitTarih] [date] NULL,
	[OgrenciNo] [int] NULL,
	[DTarih] [date] NULL,
	[Bolum] [nvarchar](50) NULL,
 CONSTRAINT [PK_OgrenciTab] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OkulYonetimTab]    Script Date: 17.01.2023 20:58:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OkulYonetimTab](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](50) NULL,
	[Gorevi] [nvarchar](50) NULL,
	[YonetimTip] [int] NULL,
 CONSTRAINT [PK_OkulYonetimTab] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DersTab] ON 

INSERT [dbo].[DersTab] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (7, N'matematik', 25, 1, N'Kırmızı')
INSERT [dbo].[DersTab] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (12, N'Türkçe', 2, 1, NULL)
INSERT [dbo].[DersTab] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (17, N'Matematik', 2, 1, NULL)
INSERT [dbo].[DersTab] ([Id], [Ad], [Kredi], [OkulYonetimId], [DersRenk]) VALUES (1017, N'Yazılım', 2, 1, N'Mavi')
SET IDENTITY_INSERT [dbo].[DersTab] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciTab] ON 

INSERT [dbo].[OgrenciTab] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (1, N'Ayşegül Kutlay', CAST(N'2020-09-10' AS Date), 123456, CAST(N'2002-10-10' AS Date), N'Yazılım')
INSERT [dbo].[OgrenciTab] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [DTarih], [Bolum]) VALUES (4, N'Ahmet Can', CAST(N'2020-10-03' AS Date), 1234568, CAST(N'2000-06-06' AS Date), N'Hukuk')
SET IDENTITY_INSERT [dbo].[OgrenciTab] OFF
GO
SET IDENTITY_INSERT [dbo].[OkulYonetimTab] ON 

INSERT [dbo].[OkulYonetimTab] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (1, N'anıl', N'öğretmen', 1)
INSERT [dbo].[OkulYonetimTab] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (2, N'Ahmet Can', N'öğretmen', 2)
SET IDENTITY_INSERT [dbo].[OkulYonetimTab] OFF
GO
ALTER TABLE [dbo].[DersTab]  WITH CHECK ADD  CONSTRAINT [FK_DersTab_OkulYonetimTab] FOREIGN KEY([OkulYonetimId])
REFERENCES [dbo].[OkulYonetimTab] ([Id])
GO
ALTER TABLE [dbo].[DersTab] CHECK CONSTRAINT [FK_DersTab_OkulYonetimTab]
GO
ALTER TABLE [dbo].[OgrenciDersTab]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDersTab_DersTab] FOREIGN KEY([DersId])
REFERENCES [dbo].[DersTab] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDersTab] CHECK CONSTRAINT [FK_OgrenciDersTab_DersTab]
GO
ALTER TABLE [dbo].[OgrenciDersTab]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDersTab_OgrenciTab] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[OgrenciTab] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDersTab] CHECK CONSTRAINT [FK_OgrenciDersTab_OgrenciTab]
GO
