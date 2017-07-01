alter table dbo.RacingEvents add SportId int;
alter table dbo.Administration drop column Type;
alter table dbo.Athletes alter column Birthday date;
truncate table Athletes
EXEC sp_rename 'dbo.Administration.AdminstrationId', 'AdministrationId', 'COLUMN';  

update	dbo.Teams
set		Gender = RTRIM(Ltrim(Gender))
where	TeamId = 2

drop table dbo.Athlete
drop procedure dbo.ActivateNewSport

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
select * from Athletes
select * from Roster
select * from Classifications

exec dbo.GetTeams 1, 'Cross Country', 'All', 'All', 'All', 1

update Administration
set Classification = 'College'
where SportsId = 2

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


declare @admin int,
		@gender char(6),
		@team varchar(max),
		@grades varchar(max)

select @admin = 1,
		@gender = 'All',
		@team = 'Test'

select  a.AthleteId,
		a.FullName,
		a.Birthday,
		a.Gender,
		a.Grade
from	Athletes a,
		Roster r,
		Teams t
where	t.AdministrationId = 1
and		t.TeamName in (@team)
and		t.TeamId = r.TeamId
and		r.Eligibility in ('Freshman', 'Sophmore', 'Junior', 'Senior', 'Super Senior')
and		r.AthleteId = a.AthleteId
and		a.Gender = case when @gender = 'All' then A.Gender
					else @gender end