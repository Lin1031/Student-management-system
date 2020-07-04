CREATE TABLE Student (
  Sno     VARCHAR(20)       PRIMARY KEY,
  Sname   VARCHAR(20)     NOT NULL,
  Class    VARCHAR(20), 
  Birthday  VARCHAR(20), 
  Place  VARCHAR(10),
  Spassword INT,
)

CREATE TABLE Course (
  Cno       VARCHAR(20)   PRIMARY KEY,
  Cname     VARCHAR(20)  NOT NULL,
  Credit    INT,
  Instructor  VARCHAR(6)
)

CREATE TABLE Teacher (
  TID    VARCHAR(20)   PRIMARY KEY,
  TName   VARCHAR(20)  NOT NULL,
  TPassword  INT,
  Title  VARCHAR(20),
  Tplace  VARCHAR(10)
)  
CREATE TABLE SC (
  Sno    VARCHAR(20)  NOT NULL,
  Cno    VARCHAR(20)  NOT NULL,
  PRIMARY KEY (Sno, Cno),
  FOREIGN KEY (Sno)  REFERENCES  Student (Sno),
  FOREIGN KEY (Cno)  REFERENCES  Course (Cno)  
)  

insert into Student values('0811102','刘晨','计科1班','1999-1-5','安徽','23789')
insert into Student values('0811103','王敏','计科1班','2000-3-6','河北','67349')
insert into Student values('0811104','张小红','数媒1班','2000-7-7','北京','76598')
insert into Student values('0821101','张立','软件2班','1999-2-10','福建','66789')
insert into Student values('0821102','吴宾','计科2班','1999-8-19','浙江','33609')
insert into Student values('0831101','钱小平','软工3班','2000-8-20','福建','25780')
insert into Student values('0831102','夏文','计科2班','1998-3-6','北京','09745')
insert into Student values('0831103','张荷','软工2班','1998-9-28','安徽','67389')
insert into Student values('0841101','刘佳玉','计科3班','2001-2-19','四川','10776')
insert into Student values('0841102','王明','计科3班','2000-8-9','湖北','66879')
insert into Student values('0841103','林霖','数媒1班','1999-1-18','福建','55765')

insert into Course values('C001','高等数学',4,'张珊珊')
insert into Course values('C002','大学英语',3,'张海')
insert into Course values('C003','数据库基础',3,'郭伟')
insert into Course values('C004','数据结构',4,'刘潇')
insert into Course values('C005','计算机文化',4,'刘海洋')
insert into Course values('C006','线性代数',3,'林华')
insert into Course values('C007','Python',3,'贾芳')
insert into Course values('C008','VB',4,'叶忠')
insert into Course values('C009','计算机网络',3,'何珊丽')


insert into Teacher values('001','张珊珊','21106','教授','四川')
insert into Teacher values('002','张海','35674','教授','浙江')
insert into Teacher values('003','郭伟','43358','副教授','重庆')
insert into Teacher values('004','刘潇','22267','副教授','山东')
insert into Teacher values('005','王大山','59246','助教','福建')
insert into Teacher values('006','刘海洋','12345','教授','北京')
insert into Teacher values('007','林华','23567','教授','福建')
insert into Teacher values('008','贾芳','45798','副教授','浙江')
insert into Teacher values('009','叶忠','44569','副教授','福建')
insert into Teacher values('010','何珊丽','67904','教授','北京')

insert into SC values('0811102','C001')
insert into SC values('0811102','C003')
insert into SC values('0811103','C003')
insert into SC values('0811104','C004')
insert into SC values('0821101','C002')
insert into SC values('0821102','C003')
insert into SC values('0831101','C003')
insert into SC values('0831102','C007')
insert into SC values('0831102','C003')
insert into SC values('0841101','C005')
insert into SC values('0841102','C006')
