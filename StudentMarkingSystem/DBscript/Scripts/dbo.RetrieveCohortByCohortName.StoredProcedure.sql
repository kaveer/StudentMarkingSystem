USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveCohortByCohortName]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveCohortByCohortName]
	@cohortName nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select * from cohortTable
	where cohort = @cohortName 
	and cohortStatus = 'active'

   
END

GO
