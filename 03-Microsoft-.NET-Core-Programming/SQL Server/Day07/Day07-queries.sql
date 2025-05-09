use ITI;

-- 1
create view FullNamesV
as
	select concat(st_fname,' ', st_lname) as [Full Name],
	c.crs_name as [Course Name]
	from student s inner join Stud_Course sc
	on s.St_Id = sc.St_Id
	inner join course c
	on c.crs_id = sc.Crs_Id
	where sc.Grade > 50;

-- test 
select * from FullNamesV;

-- 2
create view ManagersWithSubjectsV
with encryption
as 
	select i.Ins_Name, t.Top_Name 
	from Instructor i inner join Department d
	on i.Ins_Id = d.Dept_Manager
	inner join Ins_Course ic
	on i.Ins_Id = ic.Ins_Id
	inner join course c
	on c.Crs_Id = ic.Crs_Id
	inner join Topic t
	on c.Top_Id = t.Top_Id;

-- test
select * from ManagersWithSubjectsV

-- 3
create view InstructorsInDeptsV
as
	select i.Ins_Name , d.Dept_Name
	from Instructor i inner join Department d
	on i.Dept_Id = d.Dept_Id
	where d.Dept_Name in('SD' , 'Java')

-- test
select * from InstructorsInDeptsV; 

-- 4
create view V1
as 
	select *
	from Student
	where St_Address in('Alex','Cairo')
	with check option

-- test
select * from V1;
Update V1 set st_address='tanta' -- will throw error because of 'with check option'
Where st_address='alex';

-- 5
use Company_SD;
create view ProjectWithEmpsV
as
	select p.Pname , count(e.Dno) as [# of emps]
	from Project p inner join Departments d
	on p.Dnum = d.Dnum
	inner join Employee e
	on e.Dno = d.Dnum
	group by p.Pname;

-- test
select * from ProjectWithEmpsV;

-- 6
-- a
create schema company;
go
alter schema company transfer dbo.Departments
-- test
select * from company.departments
select * from company.project

-- b
create schema HumanResource;
go
alter schema HumanResource transfer dbo.Employee

-- 7
use ITI;

select * from Department
create nonclustered index i2
on department(manager_hiredate)
-- an i2(Non-Unique, Non-Clustered) created on indexes

-- 8
create unique index i3 
on Student(st_age);
-- throw error as there are duplicate values

-- 9
use Company_SD;
declare c1 cursor
for select salary
from HumanResource.Employee
where salary is not null
for update
declare @sal int
open c1
fetch c1 into @sal
while @@FETCH_STATUS = 0
begin
	if @sal <= 3000
	update HumanResource.Employee
	set salary = @sal*1.10
	where current of c1
	else
	update HumanResource.Employee
	set salary = @sal*1.20
	where current of c1
	fetch c1 into @sal
end
close c1
deallocate c1


-- 10
use ITI
declare c1 cursor
for select d.Dept_Name , i.Ins_Name
from Instructor i inner join Department d
on d.Dept_Manager = i.Ins_Id
for read only
declare @deptName varchar(50) , @managerName varchar(50)
open c1
fetch c1 into @deptName , @managerName
while @@FETCH_STATUS =0
begin 
	select @deptName as Department , @managerName as Manager
	fetch c1 into @deptName , @managerName
end
close c1
deallocate c1


-- 11
declare c1 cursor 
for select ins_name
from Instructor
where Ins_Name is not null
for read only

declare @allNames varchar(500) , @currentName varchar(50)
open c1
fetch c1 into @currentName
while @@FETCH_STATUS = 0
begin
	set @allNames = concat(@allNames , ', ',@currentName)
	fetch c1 into @currentName
end
	select @allNames as [Names]
close c1
deallocate c1

-- 12
-- error while scripting as we created an encrypted view


	
	select * from Instructor
	select * from Department
	