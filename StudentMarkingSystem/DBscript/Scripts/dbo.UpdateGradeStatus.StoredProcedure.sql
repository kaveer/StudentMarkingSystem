USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[UpdateGradeStatus]    Script Date: 2/7/2017 9:36:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateGradeStatus]
	@moduleId int,
	@StudentId int,
	@gradeStatus nvarchar(10)
AS
BEGIN
	SET NOCOUNT ON;

    update gradeTable
	set gradeStatus = @gradeStatus
	where moduleId = @moduleId and studentId = @StudentId
	
END

GO
