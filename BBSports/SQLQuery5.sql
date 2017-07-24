alter table dbo.Administration add [State] char(2);
alter table dbo.Users drop column Pepper;
alter table dbo.Teams alter column [Grade] VARCHAR (15) 
truncate table Users
EXEC sp_rename 'dbo.Teams.[Subevel]', 'SubLevel', 'COLUMN';  

update	dbo.Administration
set		AdministrationId = 3
where	AdministrationId = 7

update	dbo.Director
set		DirectorId = 3,
		AdministrationId = 3
where	DirectorId = 7

drop table dbo.Coaches
drop procedure dbo.NewUser

delete top (1)
from Coaches
where TeamId = 12

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.Meets
values(1, 'Stout Alumni', 'Menomonie Red Cedar Trail', '9/2/2017', 0, ' ', ' ', 'Male', 1)

insert into SupportedSports
values('Cross Country')

select * from Administration
select * from Director
select * from Teams where AdministrationId = 7
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

select distinct *
from Teams t, 
	Coaches c 
where t.AdministrationId = 7
and t.TeamId = c.TeamId
and t.Active = 1 
and Gender = 'Female' 
and c.CoachId = 1

insert into Classifications values('Alumni', 'High School')
insert into RacingEvents values('1 Mile', 1609, 'Female', 2)
select * from RacingEvents Order by SportId, Gender, Distance

select r.* from RacingEvents r, Teams t
where t.TeamId = 4 and t.Gender = r.Gender and r.SportId = t.SportId
order by distance desc

