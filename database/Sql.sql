--create database ElectronicSystem

/*编码设计
User_id 1018071001
Meter_id 2018071001
sernum 10001
Supplier_id 3018071001
Component_id 1001
Data_id 4018071001
*/
--用户信息
create table user_info
(
	--limit 0 :normal 1:engineer 2:manage 
	User_id bigint identity(1018071001,1) not null primary key,
	User_name VARCHAR(30) not null,
	User_pwd VARCHAR(10) not null DEFAULT '111',
	User_limit int not null
)

insert into user_info
	(User_name,User_pwd,User_limit)
VALUES
	('张华', '111', 1),
	('王小伟', '111', 2),
	('王莞尔', '111', 2),
	('张明华', '111', 0),
	('李一琛', '111', 0),
	('李二飞', '111', 0);

--供应商信息
CREATE TABLE supplier_info
(
	Supplier_id bigint identity(3018071001,1) not NULL PRIMARY KEY,
	Supplier_name VARCHAR(30) not NULL,
	Supplier_addr VARCHAR(10)
)

INSERT INTO supplier_info
	(Supplier_name,Supplier_addr)
VALUES
	('江南电机制造厂', '江苏'),
	('迅雷叶片制造厂', '天津'),
	('优酷齿轮制造厂', '浙江'),
	('腾讯液压制造厂', '新疆'),
	('阿里电机制造厂', '内蒙古'),
	('网易显示屏制造厂', '河北');


--所需零件信息
CREATE TABLE component_info
(
	Component_id int identity(1001,1) NOT NULL PRIMARY KEY,
	Component_name VARCHAR(20) not NULL,
)

INSERT INTO component_info
	(Component_name)
VALUES
	('发电机'),
	('风机叶片'),
	('齿轮箱'),
	('液压装置'),
	('显示屏');

--向供应商的订单管理
CREATE TABLE order_list
(
	sernum bigint identity(10001,1) not NULL PRIMARY KEY,
	--FOREIGN KEY REFERENCES supplier_info(Supplier_id) 
	Supplier_id bigint not NULL ,
	-- FOREIGN KEY REFERENCES component_info(Component_id) 
	Component_id int NOT NULL,
	Order_num int NOT NULL DEFAULT 2
)

INSERT INTO order_list
	(Supplier_id,Component_id,Order_num)
VALUES
	(3018071001,1001,5),
	(3018071002,1002,2),
	(3018071003,1003,3),
	(3018071004,1004,2),
	(3018071005,1001,1),
	(3018071006,1005,5);

--仪表设备
CREATE TABLE config
(
	Meter_id bigint identity(2018071001,1) not NULL PRIMARY KEY,
	Meter_type VARCHAR(30) not null,
	--仪表安装位置 0:  1:  2: 
	Meter_addr int not NULL DEFAULT 0,
	--仪表是否正常 默认为1 正常
	Meter_malfunc int not null DEFAULT 1
)

insert INTO config
	(Meter_type,Meter_addr,Meter_malfunc)
VALUES
	('叶片监测仪表', 0, 1),
	('齿轮箱监测仪表', 0, 1),
	('发电机监测仪表', 1, 1),
	('液压监测仪表', 1, 1),
	('叶片监测仪表', 2, 1),
	('发电机监测仪表', 2, 1);

--机器状况,由相应风机每隔一定时间自动填入
--打算运作管理中使用
CREATE TABLE machine_data
(
	Data_id bigint identity(4018071001,1) not NULL PRIMARY KEY,
	数据载入时间 date,
	叶轮直径 float,
	功率 float,--单位 kw
	额定风速 float,
	扫风面积 float,
	抗最大风速 float,
	切入风速 float
)

insert into machine_data
(数据载入时间,叶轮直径,功率,额定风速,扫风面积,抗最大风速,切入风速)
VALUES
('2018-03-15',43.2,600,14,1466,70,3),
('2018-03-16',44,600,12,1500,70,3),
('2018-03-17',43.8,600,17.5,1563,70,3.2),
('2018-03-15',56.3,900,15,2056.5,63,2.9),
('2018-03-15',58.3,900,15,2286,64.3,3),
('2018-03-17',62,1200,12,3019,59.5,3),
('2018-03-18',60,1200,12,3009,60,3.1);

--3种mchine 1-600kw 2-900kw 3-1200kw
ALTER Table machine_data
ADD 切出风速 float,
Machine_id bigint,
输出电流 float,
输出电压 float,
当前环境温度 float;

update machine_data 
set 切出风速 = 25,
Machine_id = 1,
输出电流 = 1200,
输出电压 = 620,
当前环境温度 = 35
where Data_id = 4018071001;

update machine_data 
set 切出风速 = 26,
Machine_id = 1,
输出电流 = 1190,
输出电压 = 618,
当前环境温度 = 40
where Data_id = 4018071002;

update machine_data 
set 切出风速 = 27,
Machine_id = 1,
输出电流 = 1189,
输出电压 = 630,
当前环境温度 = 36
where Data_id = 4018071003;

update machine_data 
set 切出风速 = 24.8,
Machine_id = 2,
输出电流 = 1380,
输出电压 = 625,
当前环境温度 = 36
where Data_id = 4018071004;

update machine_data 
set 切出风速 = 23,
Machine_id = 2,
输出电流 = 1400,
输出电压 = 619,
当前环境温度 = 33
where Data_id = 4018071005;

update machine_data 
set 切出风速 = 26,
Machine_id = 3,
输出电流 = 1500,
输出电压 = 624,
当前环境温度 = 40
where Data_id = 4018071006;

update machine_data 
set 切出风速 = 23.9,
Machine_id = 3,
输出电流 = 1530,
输出电压 = 630,
当前环境温度 = 31
where Data_id = 4018071007;


-- IT will help me 2333
--select DATEDIFF(DY,数据载入时间,convert(date,GETDATE(),23)) as 用时 from machine_data
--select isnull(convert(varchar(50),DATEDIFF(DY,开始维护时间,convert(date,GETDATE(),23))),'未开工') as 已施工天数 from config where Meter_malfunc = 0

ALTER Table config
ADD 计划维护时长 int,
开始维护时间 date,
-- 0 : 不延期 1：延期维护 
延期 int not null DEFAULT 0;

--test data
insert INTO config
	(Meter_type,Meter_addr,Meter_malfunc)
VALUES
	('叶片监测仪表', 0, 0),
	('齿轮箱监测仪表', 1, 0),
	('发电机监测仪表', 2, 0),
	('液压监测仪表', 1, 0);


--这个约束名称可能有差异 -to 老王
alter table config
DROP constraint DF__config__延期__02084FDA

alter table config
drop column 延期
