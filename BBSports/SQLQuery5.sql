alter table dbo.Meets add MeetNotes varchar(max) null;
alter table dbo.Meets drop column Gender;
alter table dbo.Sports alter column SportsId int; 

update dbo.Sports 
set SportName = 'Basketball'
where SportsId = 2

drop table dbo.Sports

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.SupportedSports
values('Cross Country')

insert into dbo.Teams
values()

select * from dbo.SupportedSports

update dbo.Sports 
set SportName = 'Basketball'
where SportsId = 2
