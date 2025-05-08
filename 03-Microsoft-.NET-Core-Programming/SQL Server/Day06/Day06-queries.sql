use ITI

-- 1 
create function getMonth(@date date)
returns varchar(10)
begin
	return FORMAT(@date,'MMM')
end

select dbo.getmonth(getdate()) as [current month];

-- 2
create function valueInBetween(@value1 int ,@value2 int)
returns @t table (values_between int)
as 
	begin 
	while @value2-1 >@value1
		begin
		set @value1+=1

		insert into @t values(@value1)
		end
		return;
end

select * from valueInBetween(4,9);

-- 3
create function getStudentData(@id int)
returns table
as
return
( select CONCAT(s.St_Fname,' ',s.St_Lname)as [Full Name]
,d.Dept_Name from Student s inner join department d
on s.Dept_Id = d.Dept_Id and @id = s.St_Id)

select * from getStudentData(8);


-- 4
CREATE FUNCTION studentsNamesCheck(@id INT)
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @first VARCHAR(50), @last VARCHAR(50), @indicator NVARCHAR(50);

    SELECT @first = s.St_Fname, @last = s.St_Lname
    FROM Student s
    WHERE s.St_Id = @id;

    IF @first IS NULL AND @last IS NULL
        SET @indicator = 'First name & last name are null';
    ELSE IF @first IS NULL
        SET @indicator = 'First name is null';
    ELSE IF @last IS NULL
        SET @indicator = 'Last name is null';
    ELSE
        SET @indicator = 'First name & last name are not null';

    RETURN @indicator;
END;
 
select dbo.studentsNamesCheck(13) as Indicator;

-- 5 
create function getManager(@id int)
returns table
as 
	return (
			select d.Dept_Name, d.Dept_Manager,d.Manager_hiredate
			from Department d inner join Instructor ins
			on @id = ins.Ins_Id and d.Dept_Manager = ins.Ins_Id)

select * from getManager(1);

-- 6
create function filterStudentsNamesValues (@str varchar(50))
returns @t table(id int,name varchar(20))
as
	begin
		if @str='first name'
			insert into @t
			select st_id,ISNULL( st_fname,'') from Student
		else if @str='last name'
			insert into @t       
			select st_id,ISNULL( st_lname,'') from Student
		else if @str='full name'
			insert into @t
			select st_id,concat(st_fname,' ',st_lname) from Student
		return 
	end

select * from filterStudentsNamesValues('full name')


-- 7
select s.St_Id,
SUBSTRING(s.St_Fname,1, len(s.St_Fname)-1) as name from Student s


-- 8
update Stud_Course
set Grade = null
where St_Id in (select S.St_Id
from Student S inner join Department D
on S.Dept_Id = D.Dept_Id and D.Dept_Name = 'SD');

-- 9
declare @dailyTransaction table(userid int ,amount int )
insert into @dailyTransaction values (1,500),(2,800),(3,1200)
declare @lastTransaction table(userid int ,amount int )
insert into @lastTransaction values (1,2000),(4,2000),(2,10000)

merge @dailyTransaction as T
using @lastTransaction as S
on T.userid = S.userid
when matched then
update set T.amount = S.amount
when not matched then 
insert values (S.userid,S.amount);
select * from @dailyTransaction
select * from @lastTransaction

-- 10
create schema lab6_schema 
alter schema lab6_schema  transfer student
alter schema lab6_schema  transfer course



-- BONUS --	
create table companydepartments (
    deptid int primary key,
    deptname varchar(50),
    deptlevel hierarchyid
);

insert into companydepartments values (1, 'company', '/');
insert into companydepartments values (2, 'sales', '/1/');
insert into companydepartments values (3, 'it', '/2/');
insert into companydepartments values (4, 'hr', '/3/');

insert into companydepartments values (5, 'retail sales', '/1/1/');
insert into companydepartments values (6, 'online sales', '/1/2/');

select 
    deptid,
    deptname,
    cast(deptlevel as varchar(50)) as hierarchypath
from companydepartments
order by deptlevel;
