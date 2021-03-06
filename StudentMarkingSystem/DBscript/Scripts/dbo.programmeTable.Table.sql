USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[programmeTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programmeTable](
	[programmeId] [int] IDENTITY(1,1) NOT NULL,
	[programme] [nvarchar](50) NULL,
	[duration] [int] NULL,
	[programmeStatus] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[programmeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[programmeTable] ON 

INSERT [dbo].[programmeTable] ([programmeId], [programme], [duration], [programmeStatus]) VALUES (1, N'software engineering', 4, N'active')
INSERT [dbo].[programmeTable] ([programmeId], [programme], [duration], [programmeStatus]) VALUES (2, N'civil engineering', 3, N'active')
INSERT [dbo].[programmeTable] ([programmeId], [programme], [duration], [programmeStatus]) VALUES (3, N'electric engineering', 4, N'active')
SET IDENTITY_INSERT [dbo].[programmeTable] OFF
