USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[studentTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentTable](
	[studentId] [int] IDENTITY(1,1) NOT NULL,
	[cohortId] [int] NULL,
	[studentIndex] [nvarchar](10) NULL,
	[firstname] [nvarchar](50) NULL,
	[lastname] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[studentAddress] [nvarchar](50) NULL,
	[contact] [int] NULL,
	[studentStatus] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[studentTable] ON 

INSERT [dbo].[studentTable] ([studentId], [cohortId], [studentIndex], [firstname], [lastname], [email], [studentAddress], [contact], [studentStatus]) VALUES (1, 1, N'127732', N'sam', N'witwiki', N'tester@test.com', N'vacoas', 12992, N'active')
INSERT [dbo].[studentTable] ([studentId], [cohortId], [studentIndex], [firstname], [lastname], [email], [studentAddress], [contact], [studentStatus]) VALUES (2, 2, N'123332', N'rf', N'fr', N'tester@tester.com', N'ed', 232323, N'deactive')
SET IDENTITY_INSERT [dbo].[studentTable] OFF
