USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[userInfoTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userInfoTable](
	[userInfoId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
	[firstname] [nvarchar](50) NULL,
	[lastname] [nvarchar](50) NULL,
	[Useraddress] [nvarchar](50) NULL,
	[contact] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[userInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[userInfoTable] ON 

INSERT [dbo].[userInfoTable] ([userInfoId], [userId], [firstname], [lastname], [Useraddress], [contact]) VALUES (1, 1, N'kaveer', N'rajcoomar', N'vacoas', 5256626)
INSERT [dbo].[userInfoTable] ([userInfoId], [userId], [firstname], [lastname], [Useraddress], [contact]) VALUES (2, 2, N'tester', N'test', N'tester road', 23422322)
INSERT [dbo].[userInfoTable] ([userInfoId], [userId], [firstname], [lastname], [Useraddress], [contact]) VALUES (1002, 1002, N'debug', N'debugger', N'debugger street', 2344423)
INSERT [dbo].[userInfoTable] ([userInfoId], [userId], [firstname], [lastname], [Useraddress], [contact]) VALUES (1003, 1003, N'kaveer', N'rajcoomar', N'tets', 1238723)
INSERT [dbo].[userInfoTable] ([userInfoId], [userId], [firstname], [lastname], [Useraddress], [contact]) VALUES (1004, 1004, N'cc', N'ddd', N'qb', 1234)
SET IDENTITY_INSERT [dbo].[userInfoTable] OFF
