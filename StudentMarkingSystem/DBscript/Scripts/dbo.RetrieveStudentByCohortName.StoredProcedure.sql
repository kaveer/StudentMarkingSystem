USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveStudentByCohortName]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveStudentByCohortName]
	@cohort nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   select * from cohortTable as coh
   inner join studentTable as stu
   on coh.cohortId = stu.cohortId
   where cohort = @cohort
END

GO
