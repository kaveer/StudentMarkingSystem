USE StudentMarkingSystemDb
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveStudentDetailsByCohortName]
	@cohortName nvarchar(50),
	@programmeName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	select * from programmeTable as prog
	inner join cohortTable as cor on cor.programmeId = prog.programmeId
	inner join studentTable as stu on stu.cohortId = cor.cohortId
	where studentStatus = 'active'
	and cohortStatus = 'active'
	and programmeStatus = 'active'
	and cohort = @cohortName
	and programme = @programmeName
END
GO
