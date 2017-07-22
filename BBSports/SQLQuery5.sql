alter table dbo.Administration add [State] char(2);
alter table dbo.Users drop column Pepper;
alter table dbo.Teams alter column [Grade] VARCHAR (15) 
truncate table Users
EXEC sp_rename 'dbo.Teams.[Subevel]', 'SubLevel', 'COLUMN';  

update	dbo.Administration
set		SportsAllowed = 25
where	AdministrationId = 2

drop table dbo.Coaches
drop procedure dbo.NewUser

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.Meets
values(1, 'Stout Alumni', 'Menomonie Red Cedar Trail', '9/2/2017', 0, ' ', ' ', 'Male', 1)

insert into SupportedSports
values('Cross Country')

select * from Administration
select * from Director
select * from Teams
select * from Users
select * from Roster
select * from dbo.SupportedSports
select * from Meets
select * from MeetTeams
select * from Classifications
select * from Coaches
select * from AthleteStatus
select * from RacingEvents

select UserId, Password from Users where Email = 'henkemeyer92@gmail.com'

exec dbo.AddEditAthlete 0, 'Stephanie', 'Ann', 'Henkemeyer', 'Pothead', '12/23/1999', 'Female', ' ', ' ', 'Twelfth', 55068

update Users
set Email = 'nrun14@gmail.com'
where UserId = 2

declare @administrationId int,
		@sportName varchar(50),
		@gender char(6)

select c.Grades from Classifications c, Administration a
where a.AdministrationId = 1
and a.Classification = c.Classification
order by c.ClassId asc

insert into Classifications values('Alumni', 'Collegiate')
insert into RacingEvents values('1 Mile', 1609, 'Female', 2)
select * from RacingEvents Order by SportId, Gender, Distance

select r.* from RacingEvents r, Teams t
where t.TeamId = 4 and t.Gender = r.Gender and r.SportId = t.SportId
order by distance desc

select t.TeamId, t.TeamName 
from Teams t, Coaches c
where c.CoachId = 2
and t.Active = 1
and  (t.TeamId = c.TeamId
or t.TeamId in (select r.TeamId
				from Roster r
				where r.AthleteId = 2
				and Status not in ('Cut', 'Alumni')))