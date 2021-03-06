USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveModuleByCohortName]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveModuleByCohortName]
	@cohort nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	 SELECT *
    FROM programmeTable AS pro
	    INNER JOIN cohortTable AS coh ON pro.programmeId = coh.programmeId
	    INNER JOIN moduleTable AS mod ON mod.cohortId = coh.cohortId
    WHERE moduleStatus = 'active'
		AND cohort = @cohort;
END

GO
