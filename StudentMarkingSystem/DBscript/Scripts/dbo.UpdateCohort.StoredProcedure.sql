USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCohort]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCohort]
	@cohortId int,
	@cohortName nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	   UPDATE cohortTable
		SET
		    cohort = @cohortName
	   WHERE cohortId = @cohortId;
END

GO
