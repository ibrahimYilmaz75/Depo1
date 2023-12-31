USE [YilmazKafe]
GO
/****** Object:  Table [dbo].[TblFirmalar]    Script Date: 25.12.2023 23:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblFirmalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[isim] [nvarchar](50) NULL,
	[sektor] [nvarchar](50) NULL,
	[telefon] [nvarchar](15) NULL,
	[email] [nvarchar](50) NULL,
	[adres] [nvarchar](150) NULL,
 CONSTRAINT [PK_TblFirmalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMalzeme]    Script Date: 25.12.2023 23:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMalzeme](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[personel] [int] NULL,
	[firma] [int] NULL,
	[urun] [nvarchar](50) NULL,
	[fiyat] [nvarchar](50) NULL,
	[miktar] [int] NULL,
	[tarih] [date] NULL,
 CONSTRAINT [PK_tblMalzeme] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonel]    Script Date: 25.12.2023 23:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdiSoyadi] [nvarchar](100) NULL,
	[Telefon] [nvarchar](15) NULL,
	[Adres] [nvarchar](150) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblPersonel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYiyecek]    Script Date: 25.12.2023 23:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYiyecek](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[personel] [int] NULL,
	[firma] [int] NULL,
	[urun] [nvarchar](50) NULL,
	[fiyat] [nvarchar](50) NULL,
	[miktar] [int] NULL,
	[tarih] [date] NULL,
 CONSTRAINT [PK_tblYiyecek] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_tblMalzeme_TblFirmalar] FOREIGN KEY([firma])
REFERENCES [dbo].[TblFirmalar] ([ID])
GO
ALTER TABLE [dbo].[tblMalzeme] CHECK CONSTRAINT [FK_tblMalzeme_TblFirmalar]
GO
ALTER TABLE [dbo].[tblMalzeme]  WITH CHECK ADD  CONSTRAINT [FK_tblMalzeme_tblPersonel] FOREIGN KEY([personel])
REFERENCES [dbo].[tblPersonel] ([ID])
GO
ALTER TABLE [dbo].[tblMalzeme] CHECK CONSTRAINT [FK_tblMalzeme_tblPersonel]
GO
ALTER TABLE [dbo].[tblYiyecek]  WITH CHECK ADD  CONSTRAINT [FK_tblYiyecek_TblFirmalar] FOREIGN KEY([firma])
REFERENCES [dbo].[TblFirmalar] ([ID])
GO
ALTER TABLE [dbo].[tblYiyecek] CHECK CONSTRAINT [FK_tblYiyecek_TblFirmalar]
GO
ALTER TABLE [dbo].[tblYiyecek]  WITH CHECK ADD  CONSTRAINT [FK_tblYiyecek_tblPersonel] FOREIGN KEY([personel])
REFERENCES [dbo].[tblPersonel] ([ID])
GO
ALTER TABLE [dbo].[tblYiyecek] CHECK CONSTRAINT [FK_tblYiyecek_tblPersonel]
GO
