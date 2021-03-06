USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[gradeTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gradeTable](
	[gradeId] [int] IDENTITY(1,1) NOT NULL,
	[moduleId] [int] NULL,
	[studentId] [int] NULL,
	[grade] [decimal](5, 2) NULL,
	[userId] [int] NULL,
	[gradeStatus] [nvarchar](10) NULL,
	[timestamp] [timestamp] NULL,
 CONSTRAINT [PK__gradeTab__FB4362F975984964] PRIMARY KEY CLUSTERED 
(
	[gradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[gradeTable] ON 

INSERT [dbo].[gradeTable] ([gradeId], [moduleId], [studentId], [grade], [userId], [gradeStatus]) VALUES (1, 4, 1, CAST(50.50 AS Decimal(5, 2)), 1004, N'1')
INSERT [dbo].[gradeTable] ([gradeId], [moduleId], [studentId], [grade], [userId], [gradeStatus]) VALUES (2, 4, 1, CAST(30.90 AS Decimal(5, 2)), 1004, N'1')
INSERT [dbo].[gradeTable] ([gradeId], [moduleId], [studentId], [grade], [userId], [gradeStatus]) VALUES (3, 4, 1, CAST(56.30 AS Decimal(5, 2)), 1004, N'1')
SET IDENTITY_INSERT [dbo].[gradeTable] OFF
