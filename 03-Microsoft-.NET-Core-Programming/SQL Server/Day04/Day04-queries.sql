use Company_SD;

--1
select d.Dependent_name, d.Sex
from Dependent d inner join Employee emp
	on emp.SSN = d.ESSN and emp.Sex = 'f' and d.Sex = 'f'
union
select d.Dependent_name, d.Sex
from Dependent d inner join Employee emp
	on emp.SSN = d.ESSN and emp.Sex = 'm' and d.Sex = 'm'


--2
select p.Pname, sum(w.Hours) as 'Total hours'
from Project p inner join Works_for w
	on p.Pnumber = w.Pno
group by p.Pname


--3
select dept.* , emp.Fname + ' ' + emp.Lname as 'Full Name'
from Departments dept inner join Employee emp
on dept.Dnum = emp.Dno 
and emp.SSN = (select min(SSN) from Employee)


--4
select dept.Dname, min(emp.Salary) as 'Minimum Salary',
	max(emp.Salary) as 'Maximum Salary', 
	avg(emp.Salary) as 'Avg Salary'
from Departments dept inner join Employee emp
	on dept.Dnum = emp.Dno
group by dept.Dname


-- 5
select emp.Fname+ ' '+ emp.Lname as 'Manager Full Name'
from Departments dept inner join Employee emp
	on dept.MGRSSN = emp.SSN
where emp.SSN not in (select ESSN from Dependent)


--6
select dept.Dname, dept.Dnum, count(emp.SSN) as 'Workers-in'
from Departments dept inner join Employee emp
	on dept.Dnum = emp.Dno
group by dept.Dname, dept.Dnum
having avg(emp.salary) < (select avg(salary) from Employee) 


--7
select emp.Fname, emp.Lname, p.Pname, emp.Dno
from Employee emp inner join Works_for w
	on emp.SSN = w.ESSn
inner join Project p
	on p.Pnumber = w.Pno
order by emp.Dno, emp.Lname, emp.Fname


--8
select 
	(select max(Salary) from Employee) as 'Max Salary', 
	(select max(Salary) from Employee
	where Salary not in (select max(Salary) from Employee )) as 'Second Max way 2'


--9
select Fname + ' ' + Lname as 'full name'
from Employee
intersect
select Dependent_name
from Dependent


--10
select Fname, SSN
from Employee
where exists (select *
			  from Dependent
			  where Dependent.ESSN = Employee.SSN)


--11
insert into Departments(Dname , Dnum, MGRSSN, [MGRStart Date])
values ('DEPT IT', 100, 112233, '1-11-2006')


--12
update Departments
	set MGRSSN = 968574
where Dnum = 100

update Departments
	set MGRSSN = 102672
where Dnum = 20

update Employee
	set Superssn = 102672
where SSN = 102672

--13
update Employee
	set Superssn = 102672
where Superssn = 223344

update Departments
	set MGRSSN = 102672
where MGRSSN = 223344

delete Works_for
where ESSn = 223344

delete Dependent
where ESSN = 223344

delete from Employee where SSN = 223344


--14
update Employee
	set Salary*=1.3 
where SSN in (select w.ESSn 
			  from Works_for w inner join Project p 
			  on p.Pnumber = w.Pno and p.Pname = 'Al Rabwah')




