create view v1 as
SELECT Sno,Sname,Class,DATEDIFF(yyyy,Birthday,getdate())Sage,Place
FROM Student
