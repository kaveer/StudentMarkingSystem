USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[AddGrade]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddGrade]
	@userId int,
	@moduleId int,
	@studentId int,
	@grade decimal(5,2),
	@gradeStatus nvarchar(50)


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into gradeTable(userId , moduleId , studentId , grade , gradeStatus)
    values(@userId , @moduleId , @studentId , @grade , @studentId)
END

GO
