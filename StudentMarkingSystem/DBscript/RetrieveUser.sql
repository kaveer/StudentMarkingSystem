USE [StudentMarkingSystemDb]
GO

/****** Object:  StoredProcedure [dbo].[RetrieveUser]    Script Date: 10/27/2016 9:06:05 AM ******/
DROP PROCEDURE [dbo].[RetrieveUser]
GO

/****** Object:  StoredProcedure [dbo].[RetrieveUser]    Script Date: 10/27/2016 9:06:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveUser]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
     
    SELECT *
    FROM userTable
    INNER JOIN userInfoTable ON userTable.userId = userInfoTable.userId
    where userStatus = 'active' and userType = 'lecturer'

END

GO


