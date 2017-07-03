alter table dbo.Meets add Alumni bit Default 0;
alter table dbo.Administration drop column Type;
alter table dbo.Athletes alter column Birthday date;
truncate table MeetTeams
EXEC sp_rename 'dbo.Administration.AdminstrationId', 'AdministrationId', 'COLUMN';  

update	dbo.Teams
set		Gender = RTRIM(Ltrim(Gender))
where	TeamId = 2

drop table dbo.Athlete
drop procedure dbo.ActivateNewSport

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.Meets
values(1, 'Stout Alumni', 'Menomonie Red Cedar Trail', '9/2/2017', 0, ' ', ' ', 'Male', 1)

insert into SupportedSports
values('Outdoor Track and Field')

select * from Administration
select * from Teams
select * from dbo.SupportedSports
select * from Meets
select * from MeetTeams
select * from Athletes
select * from Roster
select * from Classifications
select * from Coaches
select * from AthleteStatus

exec dbo.GetTeams 1, 'Cross Country', 'All', 'All', 'All', 1

update MeetTeams
set TeamId = 1
where MeetTeamId = 2

declare @administrationId int,
		@sportName varchar(50),
		@gender char(6)

select c.Grades from Classifications c, Administration a
where a.AdministrationId = 1
and a.Classification = c.Classification
order by c.ClassId asc

insert into RacingEvents values('60 Meter Hurdles', 60, 'Female', 2)
insert into RacingEvents values('1 Mile', 1609, 'Female', 2)
select * from RacingEvents Order by SportId, Gender, Distance



select  TeamId,
		Gender
from	Teams
where	SportId = 1
and		AdministrationId = 1
and		Gender <> 'Male'