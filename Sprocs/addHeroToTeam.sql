USE [FantasySports]
GO
/****** Object:  StoredProcedure [dbo].[addHeroToTeam]    Script Date: 11/25/2019 12:04:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[addHeroToTeam]
	-- Add the parameters for the stored procedure here
	@heroId int, @playerId int, @teamId int 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into TeamHeroInstances(heroInstanceId, teamId, heroId)
	values(@heroId, @playerId, @teamId)
END
