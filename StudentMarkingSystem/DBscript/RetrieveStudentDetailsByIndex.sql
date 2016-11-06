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
CREATE PROCEDURE [dbo].[RetrieveStudentDetailsByIndex]
	@cohortName nvarchar(50),
	@programmeName nvarchar(50),
	@index nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from studentTable as stu
    inner join cohortTable as cor on stu.cohortId = cor.cohortId
    inner join programmeTable as pro on pro.programmeId = cor.programmeId
    where cohort = @cohortName
    and programme = @programmeName
    and studentIndex = @index
    and studentStatus = 'active'
END
GO
