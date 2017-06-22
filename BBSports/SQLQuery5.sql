alter table dbo.Athlete add Grade varchar(15) null;
alter table dbo.Athlete drop column PrimaryGroup;
alter table dbo.Sports alter column SportsId int; 
EXEC sp_rename 'dbo.Administration.AdminstrationId', 'AdministrationId', 'COLUMN';  

update	dbo.Administration
set		SportsActivated = SportsActivated+1
where	AdministrationId = 1

drop table dbo.Athlete

insert into dbo.Administration
values('University of Wisconsin Stout', '1/1/2018', 100, 0)

insert into dbo.SupportedSports
values('Cross Country')

select * from Administration
select * from Teams
select * from dbo.SupportedSports

update dbo.Sports 
set SportName = 'Basketball'
where SportsId = 2
