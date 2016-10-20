USE StudentMarkingSystemDb;
GO

CREATE TABLE userTable
(userId       INT PRIMARY KEY IDENTITY(1 , 1)
															NOT NULL ,
 email        NVARCHAR(50) ,
 userPassword NVARCHAR(100) ,
 userStatus   NVARCHAR(10) ,
 userType     NVARCHAR(10)
);

CREATE TABLE userInfoTable
(userInfoId  INT PRIMARY KEY IDENTITY(1 , 1)
														 NOT NULL ,
 userId      INT ,
 firstname   NVARCHAR(50) ,
 lastname    NVARCHAR(50) ,
 Useraddress NVARCHAR(50) ,
 contact     INT ,
);

CREATE TABLE programmeTable
(programmeId     INT PRIMARY KEY IDENTITY(1 , 1)
																 NOT NULL ,
 programme       NVARCHAR(50) ,
 duration        INT ,
 programmeStatus NVARCHAR(10)
);

CREATE TABLE cohortTable
(cohortId     INT PRIMARY KEY IDENTITY(1 , 1)
															NOT NULL ,
 programmeId  INT ,
 cohort       NVARCHAR(50) ,
 cohortStatus NVARCHAR(10)
);

CREATE TABLE semesterTable
(semesterId     INT PRIMARY KEY
										NOT NULL ,
 cohortId       INT ,
 semester       NVARCHAR(50) ,
 semesterYear   NVARCHAR(50) ,
 semesterStatus NVARCHAR(10)
);

CREATE TABLE studentTable
(studentId      INT PRIMARY KEY IDENTITY(1 , 1)
																NOT NULL ,
 cohortId       INT ,
 studentIndex   NVARCHAR(10) ,
 firstname      NVARCHAR(50) ,
 lastname       NVARCHAR(50) ,
 email          NVARCHAR(50) ,
 studentAddress NVARCHAR(50) ,
 contact        INT ,
 studentStatus  NVARCHAR(10)
);

CREATE TABLE gradeTable
(gradeId     INT PRIMARY KEY IDENTITY(1 , 1)
														 NOT NULL ,
 moduleId    INT ,
 grade       DECIMAL(5 , 2) ,
 userId      INT ,
 gradeStatus NVARCHAR(10)
);

CREATE TABLE moduleTable
(moduleId     INT PRIMARY KEY IDENTITY(1 , 1)
															NOT NULL ,
 semesterId   INT ,
 studentId    INT ,
 name         NVARCHAR(50) ,
 code         NVARCHAR(50) ,
 moduleStatus NVARCHAR(10)
);

CREATE TABLE historyTable
(historyId         INT PRIMARY KEY IDENTITY(1 , 1)
																	 NOT NULL ,
 moduleId          INT ,
 HistoryDate       DATE ,
 HistoryDescrition NVARCHAR(100) ,
 historyStatus     NVARCHAR(10)
);