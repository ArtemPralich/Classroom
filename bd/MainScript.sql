--drop table Teacher;
--drop table [Subject];
--drop table [Task];
--drop table [Group];
--drop table city;
--drop table banks;

create table Teacher
(
	Id int NOT NULL IDENTITY(1, 1),
	Firstname varchar(20),
	Lastname varchar(20),
	Age smallint,
	constraint pk_teacher Primary Key (Id)
);

create table [Subject]
(
	Id int NOT NULL IDENTITY(1, 1),
	Title varchar(20),
	TeacherId int NOT NUll,
	[Year] smallint,
	constraint pk_subject Primary Key (Id),
	constraint fk_teacher_id FOREIGN KEY (TeacherId) REFERENCES Teacher (Id),
);

create table [Task]
(
	Id int NOT NULL IDENTITY(1, 1),
	Mark smallint,
	Progress smallint,
	SubjectId int not null,
	[Type] smallint,
	constraint pk_task Primary Key (Id),
	constraint fk_subject_id FOREIGN KEY (SubjectId) REFERENCES [Subject] (Id)
);

create table [Group]
(
	Id int NOT NULL IDENTITY(1, 1),
	Number varchar(20),
	Course smallint,
	constraint pk_group Primary Key (Id),
);

create table [Student]
(
	Id int NOT NULL IDENTITY(1, 1),
	Firstname varchar(20),
	Lastname varchar(20),
	Age smallint,
	GroupId int, 
	constraint pk_student Primary Key (Id),
	constraint fk_group_id FOREIGN KEY (GroupId) REFERENCES [Group] (Id)
);

create table [Attachment]
(
	Id int NOT NULL IDENTITY(1, 1),
	[Path] varchar(50),
	[Name] varchar(20),
	StudentId int, 
	TaskId int
	constraint pk_attachment Primary Key (Id),
	constraint fk_student_id FOREIGN KEY (StudentId) REFERENCES [Student] (Id),
	constraint fk_task_id FOREIGN KEY (TaskId) REFERENCES [Task] (Id),
);

create table [Secretary]
(
	Id int NOT NULL IDENTITY(1, 1),
	Firstname varchar(20),
	Lastname varchar(20),
	constraint pk_secretary Primary Key (Id),
);
