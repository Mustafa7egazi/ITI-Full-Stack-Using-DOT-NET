use ITI;

-- 1
select count(st_age) as [Number of valid students ages]
from Student;

-- 2
select distinct Ins_Name
from Instructor;

-- 3
select st_id [student id] , 
ISNULL(St_Fname,'unknown') + ' ' + ISNULL(St_Lname,'unknown') as [student full name],
ISNULL(d.dept_name,' No Dept') as [department name]
from Student s left join Department d
on s.Dept_Id = d.Dept_Id;

-- 4
select Ins_Name , Dept_Name
from Instructor i left join Department d
on i.Dept_Id = d.Dept_Id;

-- 5
select s.St_Fname + ' ' + s.St_Lname [Student Full name],
c.Crs_Name as [Course]
from Student s inner join Stud_Course sc
on s.St_Id = sc.St_Id
inner join Course c
on c.Crs_Id = sc.Crs_Id
where sc.Grade is not null;

-- 6
select count(Crs_Id) as [Course count]
from Course inner join Topic
on Course.Top_Id = Topic.Top_Id
where Course.Top_Id = Topic.Top_Id

-- 7
select max(Salary) as [Maximum],
min(Salary) as [Minimum]
from Instructor;

-- 8
select ins_name 
from Instructor
where Salary < (select AVG(Salary) from Instructor);

-- 9
select Dept_Name
from Department d inner join Instructor i
on d.Dept_Id = i.Dept_Id
where i.Salary = (select min(Salary) from Instructor);

-- 10
select top(2) Salary
from Instructor
order by Salary desc;

-- 11
select ins_name, coalesce(convert(varchar, salary), 'bonus') as compensation
from instructor;

-- 12
select AVG(Salary) as [Average Salary]
from Instructor

-- 13
select s.St_Fname + ' '+ s.St_Lname as [Student full name] , ss.* 
from Student s , Student ss
where ss.st_id = s.st_super;

-- 14
select *
from (select * , ROW_NUMBER() over(partition by dept_id order by salary desc) as RN
      from Instructor) as newtable
where RN<=2 and Salary is not null;

-- 15
select * 
from (select *, row_number() over (partition by dept_id order by newid()) as RN 
    from student
) as newtable
where RN = 1;
