SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveCohortByProgrammeName]
	@programName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
    FROM programmeTable AS program
	    INNER JOIN cohortTable AS cohort ON program.programmeId = cohort.programmeId
    WHERE programmeStatus = 'active'
		AND cohortStatus = 'active'
		AND programme = @programName;
    
END
GO
