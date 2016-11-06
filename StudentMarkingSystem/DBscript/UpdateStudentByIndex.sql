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
CREATE PROCEDURE [dbo].[UpdateStudentByIndex]
	       @firstname nvarchar(50),
            @lastname nvarchar(50),
            @email nvarchar(50),
            @address nvarchar(50),
            @contact int,
		  @studentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update studentTable 
	set firstname = @firstname ,
	lastname = @lastname ,
	email = @email , 
	studentAddress = @address ,
	contact = @contact 
	where studentId = @studentId
    
END
GO
