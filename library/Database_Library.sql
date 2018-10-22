--create database library

use library
go


-- Create schema --


create schema LB
go

create schema BOOK
go

create schema PB
go

create schema BR
go

create schema BK
go

-- Create tables --

create table LB.LIBRARY_BRANCH
(BranchID int primary key not null,
BranchName varchar(50) not null,
Address varchar(50) not null)

create table PB.PUBLISHER
(PublisherName varchar(50) primary key not null,
Address varchar(50) not null,
Phone varchar(50) not null)

create table BR.BORROWER
(CardNo int primary key not null identity (1000,1),
Name varchar(50) not null,
Address varchar(50) not null,
Phone varchar(50) not null)

create table BK.BOOKS
(BookID int primary key not null identity (1,1),
Title varchar(50) not null,
PublisherName varchar(50) not null CONSTRAINT fk_publishername FOREIGN KEY REFERENCES pb.publisher(publishername) ON UPDATE CASCADE ON DELETE CASCADE)

create table BOOK.BOOK_AUTHORS
(BookID int not null CONSTRAINT fk_bookIdAuthors FOREIGN KEY REFERENCES bk.books(bookId) ON UPDATE CASCADE ON DELETE CASCADE,
AuthorName varchar(50) not null)


create table BOOK.BOOK_COPIES
(BookID int not null CONSTRAINT fk_bookIdCopies FOREIGN KEY REFERENCES bk.Books(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
BranchID int not null CONSTRAINT fk_branchidcopies FOREIGN KEY REFERENCES lb.library_branch(branchId) ON UPDATE CASCADE ON DELETE CASCADE,
Number_Of_Copies int not null)

create table BOOK.BOOK_LOANS
(BookID int not null CONSTRAINT fk_bookidLoans FOREIGN KEY REFERENCES bk.books(bookId) ON UPDATE CASCADE ON DELETE CASCADE,
BranchID int not null CONSTRAINT fk_branchidloans FOREIGN KEY REFERENCES lb.library_branch(branchId) ON UPDATE CASCADE ON DELETE CASCADE,
CardNo int not null CONSTRAINT fk_cardno FOREIGN KEY REFERENCES br.borrower(cardno) ON UPDATE CASCADE ON DELETE CASCADE,
DateOut varchar(50) not null,
DateDue varchar(50) not null)

-- Inserting tables --

insert into LB.LIBRARY_BRANCH
	(BranchID, BranchName, Address)
	values
	('100', 'Sharpstown', 'Sharpstown Road WA'),
	('101', 'Central', 'Central Street MN'),
	('102', 'King', 'King Hill WI'),
	('103', 'Novelty', 'Novelty Way PA')
;
select * from lb.library_branch

insert into pb.PUBLISHER
	(PublisherName, Address, Phone)
	values
	('Pierson', '2093 Coverntry Court LA', '463-255-2362'),
	('Kimsomonto Press', '1462 Elliot Ave. WA', '234-632-8457'),
	('Blumbarry', '2227 Ersel St. TX', '456-246-3634'),
	('Oxpord Press', '589 Circle Drive TX', '256-212-8674'),
	('Zoka','2452 Hilltop Heaven Drive NJ', '923-144-1874'),
	('Benta', '4610 Anmoore Road NY', '743-553-2344'),
	('Tosana', '1253 Loving Road TX', '235-356-3296'),
	('Kingston Press', '424 Canterbury Drive NY', '896-990-0023'),
	('Tilson', '1361 Benson Drive OK', '234-734-0081'),
	('Blink', '773 Dawson Drive AR', '834-360-6703'),
	('Saks', '3125 Cityview Road PA', '235-267-2780'),
	('Novelkis', '1421 Farm Meadow Hill AZ', '634-835-0572'),
	('Zealion', '712 New Creek Road AL', '533-638-0360'),
	('Pandan', '1702 Adams Drive TX', '267-734-8993'),
	('Cherrin', '1721 Tail Ends Road WI', '678-257-1723'),
	('Kail', '3821 Sand Fork Hill IN', '743-518-0532'),
	('Evelin', '2387 Sardis Station', '473-267-0471'),
	('Talom', '2772 Java Lane SC', '296-566-9342'),
	('Meroni', '4137 Wescam Court MA', '745-346-8430'),
	('Bella Tona', '179 Doctors Drive CA', '352-785-6030')
;
select * from pb.PUBLISHER


insert into br.BORROWER
	(Name, Address, Phone)
	values
	('Jin Na', '10512 Pine Drive MN', '452-634-3473'),
	('Kim Scott', '2033 Roguski Rd LA', '235-623-6234'),
	('Jordan Michaelson', '6923 Plesant Hill CA', '733-257-9800'),
	('Duke Trann', '2283 Pratt Ave WA', '567-374-4743'),
	('Mike Tyson', '3325 Tera Street WA', '632-623-7452'),
	('Jim White', '992 Felming Street AL', '843-563-2346'),
	('Doug Chism', '152 Oliver Street TX', '426-743-8906'),
	('Arthur King', '2231 Corbin Road TN', '264-078-0895'),
	('Puri Watson', '612 Canterbury Drive NY', '742-326-7450'),
	('Isabel Nado', '912 Tea Berry Lane WI', '523-620-9760'),
	('Qwer Ty', '256 Road Drive CA', '123-345-6378')
;
select * from br.BORROWER

insert into bk.BOOKS
	(Title, PublisherName)
	values
	('The Lost Tribe', 'Pierson'),
	('Treasure Hunting', 'Benta'),
	('Arrowhead', 'Tosana'),
	('Avengers', 'Kimsomonto Press'),
	('Adventure of Blueberry', 'Kingston Press'),
	('The King', 'Tilson'),
	('Supply 101', 'Blumbarry'),
	('To the Greenhouse', 'Blink'),
	('Heavnely Words', 'Saks'),
	('Morning Glory', 'Novelkis'),
	('Night Sky Begin', 'Zealion'),
	('Return of The Man', 'Pandan'),
	('Plum Season', 'Oxpord Press'),
	('Dead by Day', 'Cherrin'),	
	('Twiright', 'Zoka'),
	('Bank of Wisdom', 'Kail'),
	('Doctor Phantom ', 'Evelin'),
	('King Joe', 'Talom'),
	('Sunny Night','Meroni'),
	('20 Days of Winter','Bella Tona')
;
select * from bk.BOOKS

insert into BOOK.BOOK_COPIES
	(BookID, BranchID, Number_Of_Copies)
	values
	(1, '100', 2),
	(2, '100', 2),
	(3, '100', 2),
	(4, '100', 2),
	(5, '100', 2),
	(6, '100', 2),
	(7, '100', 2),
	(8, '100', 2),
	(9, '100', 2),
	(10, '100', 2),
	(1, '101', 2),
	(5, '101', 2),
	(6, '101', 2),
	(10, '101', 2),
	(11, '101', 2),
	(12, '101', 2),
	(13, '101', 2),
	(14, '101', 2),
	(15, '101', 2),
	(16, '101', 2),
	(11, '102', 2),
	(12, '102', 2),
	(13, '102', 2),
	(14, '102', 2),
	(15, '102', 2),
	(16, '102', 2),
	(17, '102', 2),
	(18, '102', 2),
	(19, '102', 2),
	(20, '102', 2),
	(1, '103', 2),
	(2, '103', 2),
	(4, '103', 2),
	(6, '103', 2),
	(10, '103', 2),
	(11, '103', 2),
	(13, '103', 2),
	(18, '103', 2),
	(19, '103', 2),
	(20, '103', 2)
;
select * from book.BOOK_COPIES


insert into BOOK.BOOK_LOANS
	(BookID, BranchID, CardNo, DateOut, DateDue)
	values
	(1, '100', '1000', '10/09/18','10/23/18'),
	(2, '100', '1000', '10/09/18','10/23/18'),
	(3, '100', '1000', '10/09/18','10/23/18'),
	(4, '100', '1000', '10/09/18','10/23/18'),
	(5,'100', '1000', '10/09/18','10/23/18'),
	(3, '100', '1001', '10/10/18','10/24/18'),
	(4, '100', '1001', '10/10/18','10/24/18'),
	(5, '100', '1001', '10/10/18','10/24/18'),
	(6, '100', '1001', '10/11/18','10/25/18'),
	(7, '100', '1001', '10/11/18','10/25/18'),
	(5, '100', '1002', '10/11/18','10/25/18'),
	(6, '100', '1002', '10/11/18','10/25/18'),
	(7, '100', '1002', '10/12/18','10/26/18'),
	(8, '100', '1002', '10/12/18','10/26/18'),
	(5, '101', '1002', '10/09/18','10/23/18'),
	(6, '101', '1003', '10/09/18','10/23/18'),
	(8, '101', '1003', '10/09/18','10/23/18'),
	(9, '101', '1003', '10/09/18','10/23/18'),
	(10, '101', '1003', '10/09/18','10/23/18'),
	(11, '101', '1003', '10/11/18','10/25/18'),
	(12, '101', '1004', '10/11/18','10/25/18'),
	(13, '101', '1004', '10/12/18','10/26/18'),
	(14, '101', '1004', '10/12/18','10/26/18'),
	(15, '101', '1004', '10/12/18','10/26/18'),
	(16, '101', '1004', '10/12/18','10/26/18'),
	(17, '102', '1004', '10/09/18','10/23/18'),
	(13, '102', '1005', '10/09/18','10/23/18'),
	(14, '102', '1005', '10/09/18','10/23/18'),
	(15, '102', '1005', '10/09/18','10/23/18'),
	(16, '102', '1005', '10/09/18','10/23/18'),
	(17, '102', '1005', '10/09/18','10/23/18'),
	(14, '102', '1006', '10/09/18','10/23/18'),
	(16, '102', '1006', '10/09/18','10/23/18'),
	(17, '102', '1006', '10/09/18','10/23/18'),
	(19, '102', '1006', '10/09/18','10/23/18'),
	(20, '102', '1006', '10/11/18','10/25/18'),
	(15, '102', '1007', '10/12/18','10/26/18'),
	(16, '102', '1007', '10/12/18','10/26/18'),
	(17, '103', '1007', '10/09/18','10/23/18'),
	(18, '103', '1007', '10/09/18','10/23/18'),
	(19, '103', '1007', '10/09/18','10/23/18'),
	(20, '103', '1008', '10/09/18','10/23/18'),
	(1, '103', '1008', '10/09/18','10/23/18'),
	(2, '103', '1008', '10/09/18','10/23/18'),
	(3, '103', '1008', '10/09/18','10/23/18'),
	(4, '103', '1008', '10/12/18','10/26/18'),
	(5, '103', '1009', '10/12/18','10/26/18'),
	(6, '103', '1009', '10/12/18','10/26/18'),
	(7, '103', '1009', '10/12/18','10/26/18'),
	(8, '103', '1009', '10/12/18','10/26/18')
;
select * from book.BOOK_LOANS

insert into book.BOOK_AUTHORS
	(bookid, AuthorName)
	values
	(1, 'Justin Rolling'),
	(2, 'Parry Horter'),
	(3, 'Gary Bill'),
	(4, 'C.S. Louis'),
	(5, 'Stephen King'),
	(6, 'Stephen King'),
	(7, 'Joyce Oath'),
	(8, 'Issac Hampton'),
	(9, 'Hong Broms'),
	(10, 'Rachel Do'),
	(11, 'Simon Dominic'),
	(12, 'Simon Dominic'),
	(13, 'Liah Johnson'),
	(14, 'Nathan Lee'),
	(15, 'Huey Montario'),
	(16, 'David Severson'),
	(17, 'Austin Timons'),
	(18, 'Caitlyn Kang'),
	(19, 'Kira Takasi'),
	(20, 'James Don')
;
select * from book.BOOK_AUTHORS