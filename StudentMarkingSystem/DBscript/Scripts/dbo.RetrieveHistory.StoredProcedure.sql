USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveHistory]    Script Date: 2/6/2017 9:43:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveHistory] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select 
	distinct gradeId ,
		HistoryDate as [Date], 
		HistoryDescrition as [Description], 
		grade, 
		name as [Module], 
		code as [Module code]
		 
	from historyTable as his
	inner join moduleTable as mod on mod.moduleId = his.moduleId
	inner join gradeTable as gra on gra.moduleId = mod.moduleId
	Where historyStatus = 'active'
	order by gradeId desc
	
END


GO
