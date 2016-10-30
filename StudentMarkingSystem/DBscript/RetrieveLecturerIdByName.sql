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
CREATE PROCEDURE [dbo].[RetrieveLecturerIdByName]
	@firstname nvarchar(50),
	@lastname nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from userTable as users
    inner join userInfoTable as info on users.userId = info.userId
    where userStatus = 'active'
    and userType = 'lecturer'
    and firstname = @firstname
    and lastname = @lastname
END
GO
