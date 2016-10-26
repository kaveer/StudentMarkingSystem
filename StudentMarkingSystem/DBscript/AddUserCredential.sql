SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUserCredential]
	@email nvarchar(50),
	@password nvarchar(100),
	@status nvarchar(10),
	@type nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into userTable(email , userPassword , userStatus , userType)
	values (@email , @password , @status , @type);
    
END
GO
