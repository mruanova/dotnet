use mydb;
INSERT INTO users (FirstName, LastName) VALUES ('mau', 'rua');
update users set CreatedAt = CURDATE(), UpdatedAt = CURDATE(), Email='mau@rua.com',Password='hurtado' where UserId=1;
select * from users;

drop table users;
truncate table users;

use mydb;
INSERT INTO cars (CarId,Name, Make, Year) VALUES (2,'crosstrek', 'tsubaru', 2016);
select * from cars;

INSERT INTO messages (MessageId,Content, UserId) VALUES (1,'my first message', 1);