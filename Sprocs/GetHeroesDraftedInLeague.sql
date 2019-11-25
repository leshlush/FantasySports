Create PROCEDURE [dbo].[getHerosDraftedInLeague]
	-- Add the parameters for the stored procedure here
	@heroId int, @leagueId int 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Heroes
	inner join TeamHeroInstances on
	Heroes.id=TeamHeroInstances.heroId
	where TeamHeroInstances.leagueId=@leagueId
	and TeamHeroInstances.heroId=@heroId
	

	
END