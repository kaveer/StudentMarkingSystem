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
CREATE PROCEDURE [dbo].[AddStudent]
    @cohortId int,
    @index nvarchar(50),
    @firstname nvarchar(50),
    @lastname nvarchar(50),
    @email nvarchar(50),
    @address nvarchar(50),
    @contact int,
    @status nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    insert into studentTable(cohortId , studentIndex , firstname , lastname , email , studentAddress , contact , studentStatus)
    values (@cohortId , @index , @firstname , @lastname , @email , @address , @contact , @status)
END
GO
