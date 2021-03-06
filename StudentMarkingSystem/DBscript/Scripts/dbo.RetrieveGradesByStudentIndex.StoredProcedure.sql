USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveGradesByStudentIndex]    Script Date: 2/7/2017 6:02:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveGradesByStudentIndex]
	@index nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select firstname, lastname , name , code , grade , semester , semesterYear from moduleTable as mod
	inner join gradeTable as gra on gra.moduleId = mod.moduleId
	inner join studentTable as stu on stu.studentId = gra.studentId
	where gradeStatus = 1 and studentIndex = @index
	order by semesterYear asc
END

GO
