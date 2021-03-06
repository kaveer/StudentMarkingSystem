USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[moduleTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[moduleTable](
	[moduleId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[moduleStatus] [nvarchar](10) NULL,
	[cohortId] [int] NULL,
	[semester] [int] NULL,
	[semesterYear] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[moduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[moduleTable] ON 

INSERT [dbo].[moduleTable] ([moduleId], [name], [code], [moduleStatus], [cohortId], [semester], [semesterYear]) VALUES (1, N'programming', N'pg12c', N'deactive', 2, 2, 3)
INSERT [dbo].[moduleTable] ([moduleId], [name], [code], [moduleStatus], [cohortId], [semester], [semesterYear]) VALUES (2, N'analysis', N'ana66', N'deactive', 1, 1, 1)
INSERT [dbo].[moduleTable] ([moduleId], [name], [code], [moduleStatus], [cohortId], [semester], [semesterYear]) VALUES (3, N'programming', N'anprg3', N'deactive', 1, 1, 1)
INSERT [dbo].[moduleTable] ([moduleId], [name], [code], [moduleStatus], [cohortId], [semester], [semesterYear]) VALUES (4, N'programming', N'anprg3', N'active', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[moduleTable] OFF
