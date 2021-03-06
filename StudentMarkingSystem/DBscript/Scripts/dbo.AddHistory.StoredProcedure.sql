USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[AddHistory]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddHistory]
	@moduleId int,
	@historyDate date,
	@historyDescription nvarchar(100),
	@status nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into historyTable(moduleId , HistoryDate , HistoryDescrition , historyStatus)
    values (@moduleId ,@historyDate ,@historyDescription ,@status)
END

GO
