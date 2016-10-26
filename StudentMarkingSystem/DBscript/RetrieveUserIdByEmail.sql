SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveUserIdByEmail]
	@email nvarchar(50),
	@password nvarchar(100),
	@status nvarchar(10),
	@type nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT *
    FROM userTable
    WHERE email = @email
		AND userPassword = @password
		AND userStatus = @status
		AND userType = @type;
    
END
GO
