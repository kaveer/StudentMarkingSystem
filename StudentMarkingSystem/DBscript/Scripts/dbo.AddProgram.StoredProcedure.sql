USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[AddProgram]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddProgram]
	@name nvarchar(50),
	@duration int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into programmeTable(programme , duration , programmeStatus) 
    values (@name , @duration , 'active')
END

GO
