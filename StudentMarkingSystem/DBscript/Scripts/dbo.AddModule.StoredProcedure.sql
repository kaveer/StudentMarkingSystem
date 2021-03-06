USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[AddModule]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddModule]
	@Name nvarchar(50),
	@Code nvarchar(50),
	@ModuleStatus nvarchar(50),
	@Semester int,
	@semesterYear int,
	@CohortId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO moduleTable
    (name,
	code,
	moduleStatus,
	semester,
	semesterYear,
	cohortId
    )
    VALUES
    (@Name,
	@Code,
	@ModuleStatus,
	@Semester,
	@semesterYear,
	@CohortId
    );
END

GO
