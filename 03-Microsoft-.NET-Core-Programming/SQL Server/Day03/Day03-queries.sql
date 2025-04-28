use Company_SD;

/*== 1 ==*/
select depts.Dnum , depts.Dname , emps.SSN as 'Manager SSN' , emps.Fname + ' ' + emps.Lname as 'Manager name'
from Departments depts inner join Employee emps
on depts.MGRSSN = emps.SSN;

/*== 2 ==*/
select depts.Dname, proj.Pname 
from Departments depts inner join Project as proj
on depts.Dnum = proj.Dnum;

/*== 3 ==*/
select emp.Fname+' ' + emp.Lname as 'Employee Name' , depn.*
from Employee emp inner join [dbo].[Dependent] as depn
on emp.SSN = depn.ESSN;

/*== 4 ==*/
select Pnumber , Pname , Plocation
from Project
where City in ('Cairo' , 'Alex');

/*== 5 ==*/
select *
from Project 
where Pname LIKE 'a%';

/*== 6 ==*/
select * 
from Employee
where Dno = 30 and Salary between 1000 and 2000;


/*== 7 ==*/
select emp.Fname + ' ' + emp.Lname as 'Employee Name'
from Employee emp inner join Works_for work
on emp.SSN = work.ESSn AND work.Hours >= 10
inner join Project proj 
on work.Pno = proj.Pnumber
where proj.Pname = 'AL Rabwah' and proj.Dnum = 10;


/*== 8 ==*/
select empX.fname + ' '+ empX.lname as 'Employee Name',  empY.fname + ' ' + empY.lname as 'Supervisor Name'
from Employee empX , Employee empY
where empx.Superssn = empY.SSN AND empY.Fname = 'Kamel' AND empY.Lname = 'Mohamed';

/*== 9 ==*/
select emp.Fname + ' ' + emp.Lname as 'Employee Name' , proj.Pname 
from Employee emp inner join Works_for work
on emp.SSN = work.ESSn
inner join Project proj
on work.Pno = proj.Pnumber;
/*== 10 ==*/
select proj.Pnumber , depts.Dname , emp.Lname , emp.Address , emp.Bdate
from Project proj inner join Departments depts
on proj.Dnum = depts.Dnum 
inner join Employee emp
on depts.MGRSSN = emp.SSN
where proj.City = 'Cairo';
/*== 11 ==*/
select * 
from Employee emp inner join Departments depts
on emp.SSN = depts.MGRSSN
/*== 12 ==*/
select emp.* , depn.*
from Employee emp left outer join Dependent depn
on emp.SSN = depn.ESSN

/*== 13 ==*/

insert into Employee(Fname , Lname,Bdate , Address , Sex , Salary, Superssn,Dno,SSN)
values ('Mustafa','Hegazy', '2001-05-05', 'Ashmoun menofia', 'M',3000,112233,10,102672);

select * from Employee where Fname = 'Mustafa';
/*== 14 ==*/
insert into Employee(Fname , Lname,Bdate , Address , Sex ,Dno,SSN)
values ('Ahmed','Mohamed', '2003-05-05', 'Shebin menofia', 'M',30,102660);

select * from Employee where Fname = 'Ahmed' AND Lname = 'Mohamed';

/*== 15 ==*/
update Employee
set Salary*=1.2
where Fname = 'Mustafa' AND Lname = 'Hegazy';

