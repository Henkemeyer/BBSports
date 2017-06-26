alter table dbo.Teams add DeactiveDate datetime null;
alter table dbo.Athlete drop column AdministrationId;
alter table dbo.Athlete alter column MiddleName varchar(25) null;
truncate table MeetTeams
EXEC sp_rename 'dbo.Administration.AdminstrationId', 'AdministrationId', 'COLUMN';  

update	dbo.Teams
set		TeamName = 'Men''s Cross Country'
where	TeamId = 2

drop table dbo.MeetTeams
drop procedure dbo.[Procedure]

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.Meets
values(1, 'Stout Alumni', 'Menomonie Red Cedar Trail', '9/2/2017', null, null, null, 'Female')

insert into SupportedSports
values('Outdoor Track and Field')

select * from Administration
select * from Teams
select * from dbo.SupportedSports
select * from Meets
select * from MeetTeams

exec dbo.GetTeams 1, 'Cross Country', 'All', 'All', 'All', 1

update SupportedSports
set SportName = 'Basketball'
where SportsId = 2

declare @administrationId int,
		@sportName varchar(50),
		@gender char(6)

select @administrationId = 1,
		@sportName = 'Cross Country',
		@gender = 'All'

select	t.TeamId, t.TeamName, t.Gender, t.Level, t.Active
from	Teams t,
		SupportedSports ss
where	t.AdministrationId = case when @administrationId > 0 then @administrationId
							else t.AdministrationId end
and ss.SportName = case when @sportName = 'All' then ss.SportName
					else @sportName end
and ss.SportId = t.SportId
and t.Gender = case when @gender = 'All' then t.Gender
				else @gender end
and t.Level = case when @level = 'All' then t.Level
				else @level end
and t.Season = case when @season = 'All' then t.Season
				else @season end
and t.Active >= @active
