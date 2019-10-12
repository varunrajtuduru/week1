create database assessment3

create table branch_master
(branch_id varchar(6) primary key,
branch_name varchar(30),
branch_city varchar(30))


create table loan_details
(customer_number varchar(6) foreign key references customer_master(customer_number),
branch_id varchar(6) foreign key references branch_master(branch_id),
loan_amount bigint)
 

 create table account_master
 (account_number varchar(6) primary key,
 customer_number varchar(6)foreign key references customer_master(customer_number),
 branch_id varchar(6)foreign key references branch_master(branch_id),
 opening_balance bigint,
 account_opening_date date,
 account_type varchar(10),
 account_status varchar(10))
 DROP TABLE TRANSACTION_DETAILS
 create table transaction_details
 (transaction_number varchar(6) primary key,account_number varchar(6),
 date_of_transaction DATE,
 medium_of_transaction varchar(6),
 transaction_type varchar(20),
 transaction_amount bigint)


create table customer_master
(customer_number varchar(6) primary key ,
first_name varchar(30),
middle_name varchar(30),
last_name varchar(30),
customer_city varchar(15),
customer_contact_no varchar(10),
occupation varchar(20),
customer_date_of_birth date)

insert into account_master values('A00001','C00001','B00001',1000,'2012-12-15','SAVING','ACTIVE')
insert into account_master values('A00002','C00002','B00001',1000,'2012-06-12','SAVING','ACTIVE')
insert into account_master values('A00003','C00003','B00002',1000,'2012-05-17','SAVING','ACTIVE')
insert into account_master values('A00004','C00002','B00005',1000,'2013-01-27','SAVING','ACTIVE')
insert into account_master values('A00005','C00006','B00006',1000,'2012-12-17','SAVING','ACTIVE')
insert into account_master values('A00006','C00007','B00007',1000,'2010-08-12','SAVING','SUSPENDED')
insert into account_master values('A00007','C00007','B00001',1000,'2012-10-02','SAVING','ACTIVE')
insert into account_master values('A00008','C00001','B00003',1000,'2009-11-09','SAVING','TERMINATED')
insert into account_master values('A00009','C00003','B00007',1000,'2008-11-30','SAVING','TERMINATED')
insert into account_master values('A00010','C00004','B00002',1000,'2013-03-01','SAVING','ACTIVE')

insert into transaction_details values ('T00001','A00001','2013-01-01','CHEQUE','DEPOSIT',2000)
	insert into transaction_details values ('T00002','A00001','2013-02-01','CASH','WITHDRAWAL',1000)
	insert into transaction_details values ('T00004','A00002','2013-02-01','CASH','DEPOSIT',3000)
	insert into transaction_details values ('T00005','A00007','2013-01-11','CASH','DEPOSIT',7000)
	insert into transaction_details values ('T00006','A00007','2013-01-13','CASH','DEPOSIT',9000)
	insert into transaction_details values ('T00007','A00001','2013-03-13','CASH','DEPOSIT',4000)
	insert into transaction_details values ('T00008','A00001','2013-03-14','CHEQUE','DEPOSIT',3000)
	insert into transaction_details values ('T00009','A00001','2013-03-21','CASH','WITHDRAWAL',9000)
	insert into transaction_details values ('T00010','A00001','2013-03-22','CASH','WITHDRAWAL',2000)
	insert into transaction_details values ('T00011','A00002','2013-03-25','CASH','WITHDRAWAL',7000)
	insert into transaction_details values ('T00012','A00007','2013-03-26','CASH','WITHDRAWAL',2000)

	  insert into loan_details values ('C00001','B00001',100000)
	insert into loan_details values ('C00002','B00001',100000)
	insert into loan_details values ('C00009','B00001',100000)
	insert into loan_details values ('C00010','B00001',100000)
	insert into loan_details values ('C00001','B00001',100000)
	insert into loan_details values ('C00002','B00001',100000)

SELECT * FROM CUSTOMER_MASTER
SELECT * FROM BRANCH_MASTER
SELECT * FROM LOAN_DETAILS
SELECT * FROM ACCOUNT_MASTER
SELECT * FROM TRANSACTION_DETAILS
 
 --1
 select c.account_number,s.customer_number,s.first_name,s.last_name,c.account_opening_date from account_master c inner join customer_master s
 on c.customer_number=s.customer_number 
 order by account_number



 --2

 select count(*) from customer_master AS Cust_Count where customer_city='DELHI' 

 --3


 select c.customer_number,c.first_name,m.account_number 
  from account_master m inner join customer_master c on m.customer_number=c.customer_number
 where day(account_opening_date)>15
 order by c.customer_number,m.account_number
 --4
  select c.customer_number,c.first_name,m.account_number 
  from account_master m inner join customer_master c on m.customer_number=c.customer_number
 where m.account_status='TERMINATED'
 order by c.customer_number,m.account_number

 --5
  select t.transaction_type,count(t.transaction_type) as Trans_Count
	from transaction_details t inner join account_master a
	on a.account_number=t.account_number
	where a.customer_number like '%001'  
	group by t.transaction_type

--6
select count(*) as Count_Customer 
	from customer_master 
	where customer_number not in (select distinct customer_number from account_master )

	--7

	select t.account_number,(sum(t.transaction_amount)+1000) as deposit_amount 
	from transaction_details t 
	where t.transaction_type='deposit' 
	group by t.account_number
	order by account_number




 



