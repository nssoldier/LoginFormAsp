drop database demoasp;
create database if not exists DemoASP;
use DemoASP;
create table if not exists users(
	user_id int primary key auto_increment,
    user_name varchar(20),
    user_password varchar(20),
    registration_date datetime
);
/**/
select * from users;
alter table users  add constraint user_name unique(user_name);
insert into users(user_name,user_password,registration_date) values
('account1','password1',now()),
('account2','password2',now()),
('account3','password3',now()),
('account4','password4',now())
;