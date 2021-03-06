USE [StudentMarkingSystemDb]
GO
/****** Object:  StoredProcedure [dbo].[RetrieveModuleIdByModuleName]    Script Date: 2/4/2017 9:09:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RetrieveModuleIdByModuleName]
	@moduleName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
	   SELECT *
    FROM moduleTable
    WHERE name = @moduleName
		AND moduleStatus = 'active';

END

GO
