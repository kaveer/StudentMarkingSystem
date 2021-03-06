USE [StudentMarkingSystemDb]
GO
/****** Object:  Table [dbo].[historyTable]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historyTable](
	[historyId] [int] IDENTITY(1,1) NOT NULL,
	[moduleId] [int] NULL,
	[HistoryDate] [date] NULL,
	[HistoryDescrition] [nvarchar](100) NULL,
	[historyStatus] [nvarchar](10) NULL,
	[timestamp] [timestamp] NULL,
PRIMARY KEY CLUSTERED 
(
	[historyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[historyTable] ON 

INSERT [dbo].[historyTable] ([historyId], [moduleId], [HistoryDate], [HistoryDescrition], [historyStatus]) VALUES (1, 4, CAST(0x3A3C0B00 AS Date), N'Grade added for student sam witwiki by lecturer cc ddd', N'active')
INSERT [dbo].[historyTable] ([historyId], [moduleId], [HistoryDate], [HistoryDescrition], [historyStatus]) VALUES (2, 4, CAST(0x3C3C0B00 AS Date), N'Grade added for student sam witwiki by lecturer cc ddd', N'active')
SET IDENTITY_INSERT [dbo].[historyTable] OFF
