SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[login]
	@EmailAddress nvarchar(50),
	@Password nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
    FROM userTable
	    INNER JOIN userInfoTable ON userTable.userId = userInfoTable.userId
    WHERE email = @EmailAddress
		AND userPassword = @Password
		AND userStatus = 'active';
END
GO
