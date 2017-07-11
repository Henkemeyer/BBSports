alter table dbo.RacingEvents add EventType varchar(10) default 'Track';
alter table dbo.Test drop column Type;
alter table dbo.Athletes alter column Birthday date;
truncate table Athletes
EXEC sp_rename 'dbo.RacingEvents.[Event Name]', 'EventName', 'COLUMN';  

update	dbo.RacingEvents
set		Distance = 6436
where	RacingEventId = 2

drop table dbo.Test
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
select * from RacingEvents

exec dbo.AddEditAthlete 0, 'Stephanie', 'Ann', 'Henkemeyer', 'Pothead', '12/23/1999', 'Female', ' ', ' ', 'Twelfth', 55068

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

select r.* from RacingEvents r, Teams t
where t.TeamId = 4 and t.Gender = r.Gender and r.SportId = t.SportId
order by distance desc

select distinct a.AthleteId, a.FullName 
from Athletes a, 
	Teams t, 
	Roster r
where t.AdministrationId = 1 
and t.Active = 1 
and t.TeamId = r.TeamId
and r.Eligibility <> 'Alumni' 
and r.Status <> 'Cut' 
and r.AthleteId = a.AthleteId
and a.AthleteId not in(select sg.AthleteId 
						from StrengthGroups sg
						where sg.AdministrationId = t.AdministrationId)