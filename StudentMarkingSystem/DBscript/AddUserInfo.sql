SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUserInfo]
	@userId int,
	@firstname nvarchar(50),
	@lastname nvarchar(50),
	@address nvarchar(50),
	@contact int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into userInfoTable(userId , firstname , lastname , Useraddress , contact)
    values (@userId , @firstname , @lastname , @address , @contact)

END
GO
