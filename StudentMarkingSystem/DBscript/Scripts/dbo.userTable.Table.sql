USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[userTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userTable](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NULL,
	[userPassword] [nvarchar](100) NULL,
	[userStatus] [nvarchar](10) NULL,
	[userType] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[userTable] ON 

INSERT [dbo].[userTable] ([userId], [email], [userPassword], [userStatus], [userType]) VALUES (1, N'kaveer.rajcoomar@gmail.com', N'dfda598116099d025e0306e225f1b807', N'active', N'admin')
INSERT [dbo].[userTable] ([userId], [email], [userPassword], [userStatus], [userType]) VALUES (2, N'tester@test.com', N'05410a070d8d64f2f925638d33e2f939', N'active', N'lecturer')
INSERT [dbo].[userTable] ([userId], [email], [userPassword], [userStatus], [userType]) VALUES (1002, N'debug@tester.com', N'05410a070d8d64f2f925638d33e2f939', N'active', N'lecturer')
INSERT [dbo].[userTable] ([userId], [email], [userPassword], [userStatus], [userType]) VALUES (1003, N'utm.sbe@gmail.com', N'05410a070d8d64f2f925638d33e2f939', N'deactive', N'lecturer')
INSERT [dbo].[userTable] ([userId], [email], [userPassword], [userStatus], [userType]) VALUES (1004, N'lecturer@tester.com', N'05410a070d8d64f2f925638d33e2f939', N'active', N'lecturer')
SET IDENTITY_INSERT [dbo].[userTable] OFF
