alter table dbo.Administration add [State] char(2);
alter table dbo.Users drop column Pepper;
alter table dbo.Users alter column [Grade] VARCHAR (15) 
truncate table Users
EXEC sp_rename 'dbo.RacingEvents.[Event Name]', 'EventName', 'COLUMN';  

update	dbo.RacingEvents
set		Distance = 6436
where	RacingEventId = 2

drop table dbo.Users
drop procedure dbo.NewUser

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.Meets
values(1, 'Stout Alumni', 'Menomonie Red Cedar Trail', '9/2/2017', 0, ' ', ' ', 'Male', 1)

insert into SupportedSports
values('Cross Country')

select * from Administration
select * from Teams
select * from dbo.SupportedSports
select * from Meets
select * from MeetTeams
select * from Users
select * from Roster
select * from Classifications
select * from Coaches
select * from AthleteStatus
select * from RacingEvents

select UserId, Password from Users where Email = 'henkemeyer92@gmail.com'

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