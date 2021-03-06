USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[cohortTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cohortTable](
	[cohortId] [int] IDENTITY(1,1) NOT NULL,
	[programmeId] [int] NULL,
	[cohort] [nvarchar](50) NULL,
	[cohortStatus] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[cohortId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[cohortTable] ON 

INSERT [dbo].[cohortTable] ([cohortId], [programmeId], [cohort], [cohortStatus]) VALUES (1, 1, N'BSE16FT', N'active')
INSERT [dbo].[cohortTable] ([cohortId], [programmeId], [cohort], [cohortStatus]) VALUES (2, 1, N'BSE15FT', N'active')
INSERT [dbo].[cohortTable] ([cohortId], [programmeId], [cohort], [cohortStatus]) VALUES (3, 1, N'BSE14FT', N'deactive')
SET IDENTITY_INSERT [dbo].[cohortTable] OFF
