create database Day03DB;

use Day03DB;

create table instructor (
    id int identity(1,1),
    fname nvarchar(50),
    lname nvarchar(50),
    address nvarchar(50),
    hiredate datetime default getdate(),
    birthdate datetime,
    salary int default 3000,
    overtime int,
    netsal as (salary + overtime),
    age as (year(getdate()) - year(birthdate)),

    constraint setprimary primary key (id),
    constraint checkingminsal check (salary > 1000),
    constraint checkingmaxsal check (salary < 5000),
    constraint overtimeuniqueness unique (overtime),
);


create table course(
cid int identity(1,1),
cname nvarchar(50),
duration nvarchar(50),

constraint settingPrimary primary key(cid),
constraint setUniqueness unique(duration),
);

create table course_instructor(
ins_id int,
cid int,
cname nvarchar(50),

constraint setComposPrims primary key(ins_id, cid),
constraint setForign1 foreign key(ins_id) references instructor(id)
	on delete cascade on update cascade,
constraint setForign2 foreign key(cid) references course(cid)
	on delete cascade on update cascade,
);

create table lab(
lab_id int identity(1,1),
cid int,
capacity int,
location nvarchar(50)

constraint setPrims primary key(lab_id , cid),
constraint setForign foreign key (cid) references course(cid)
	on delete cascade on update cascade,
constraint capacityCheck check(capacity <20)
);
