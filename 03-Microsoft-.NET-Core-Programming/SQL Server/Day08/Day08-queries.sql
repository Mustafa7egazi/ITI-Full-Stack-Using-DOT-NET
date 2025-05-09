use ITI;

/* ================== 1 ================== */
create or alter proc numOfStudentsInDepts
as
	select Dept_Name , count(s.St_Id) as [# at this dept]
	from department d inner join Student s
	on d.Dept_Id = s.Dept_Id
	group by d.Dept_Name;
go
--test
numOfStudentsInDepts

/* ================== 2 ================== */
use Company_SD

create or alter proc checkingEmployeeInProjects
as
	declare @totalNumAtProject int;
	declare @t as table(fname varchar(50) , lname varchar(50))

	select @totalNumAtProject = count(e.ssn)
	from [HumanResource].[Employee] as e
	inner join [company].[Departments] d
	on e.dno = d.dnum
	inner join [company].[Project] p
	on d.dnum = p.dnum
	where p.pname = 'p1';
	if @totalNumAtProject >= 3
	select 'The number of employees in the project p1 is 3 or more'
	else
	begin
		insert into @t
		select e.fname , e.lname
		from [HumanResource].[Employee] as e
		inner join [company].[Departments] d
		on e.dno = d.dnum
		inner join [company].[Project] p
		on d.dnum = p.dnum
		where p.pname = 'p1';
	end
	select 'These are who are working on p1'
	select * from @t

--test
checkingEmployeeInProjects
/* ================== 3 ================== */
use Company_SD;

create or alter proc replaceEmpWithAnother
@oldId int, @newId int ,@projNum int
as
	update Works_for
	set essn = @newId
	where essn = @oldId and pno = @projNum


--test
replaceEmpWithAnother 968574,102672,700

/* ================== 4 ================== */
use Company_SD;

-- adding the new column
alter table company.project add budget int

-- creating the table
create table history_audit(
	projectNo int,
	username varchar(50),
	modifiedDate date,
	oldBudget int,
	newBudget int
	)


create trigger auditTrigger
on company.project
after update
as
	declare @budget_new int , @budget_old int , @projNum int
	if(update(budget))
	begin
	select	@budget_new = budget , @projNum = pnumber from inserted
	select	@budget_old = budget , @projNum = pnumber from deleted
	insert into history_audit
	values(@projNum , SUSER_NAME(), GETDATE(),@budget_old , @budget_new);
	end
	else
	select 'Update not in budget so it will not be saved in history'


-- test after editing one value	
select * from history_audit

/* ================== 5 ================== */
use ITI;

create trigger preventInsertion
on [dbo].[Department]
instead of insert
as
	select 'It is not allowed to insert in this table'

	select * from Department
--test
	insert into Department
	values(80,'ML','Machine learning', 'New vally', null,GETDATE());

/* ================== 6 ================== */
use Company_SD;




create trigger preventMarchInsertion
on [HumanResource].[Employee]
after insert
as 
	declare @empId int
	if Month(GETDATE()) = 3
	begin
	select @empId = ssn
	from inserted
	delete from [HumanResource].[Employee]
	where ssn = @empId
	end


/* ================== 7 ================== */
use ITI;

create table student_audit(
serverName varchar(50),
dateOfInsertion date,
note varchar(100)
)

create trigger registerInsertionNote
on student
after insert
as
	declare @insertedId int
	select @insertedId = st_id from inserted
	insert into student_audit
	values(SUSER_NAME(),
	GETDATE(),
	concat(USER_NAME(),' Inserted new row with key=',@insertedId,' at table Student'))

-- test after inserted one row
select * from student_audit

/* ================== 8 ================== */
create trigger registerTryingDeleteNote
on student
after delete
as
	declare @deletedId int
	select @deletedId = st_id from deleted
	alter table student disable trigger registerInsertionNote
	insert into Student
	select * from deleted
	alter table student enable trigger registerInsertionNote
	insert into student_audit
	values(SUSER_NAME(),
	GETDATE(),
	concat(SUSER_NAME(),' Tried to delete row with key=',@deletedId,' at table Student'))

-- test delete
	delete from Student
	where st_id = 15;

	select * from student_audit
