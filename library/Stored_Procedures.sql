use library
go


-- Stored Procedure 1
-- This procedure will find how many copies of the book titled "The Lost Tribe" 
-- are owned by the branch named "Sharpstown"
create proc usp_SharpstownLostTribe
as
begin
	select a2.Number_Of_Copies
	from bk.books a1
	inner join book.BOOK_COPIES a2 on a2.BookID = a1.BookID
	inner join lb.LIBRARY_BRANCH a3 on a3.BranchID = a2.BranchID
	inner join book.BOOK_AUTHORS a4 on a4.BookID = a1.BookID
	inner join pb.PUBLISHER a5 on a5.PublisherName = a1.PublisherName
	inner join book.BOOK_loans a6 on a6.BookID = a1.BookID
	inner join br.BORROWER a7 on a7.CardNo = a6.CardNo
	where title = 'The Lost Tribe' and branchname = 'Sharpstown'
end

exec usp_SharpstownLostTribe


-- Stored Procedure 2
-- This will find how many copies of "The Lost Tribe 
-- are owned by each library branch
create proc usp_BrachLostTribe
as
begin
	select distinct a2.Number_Of_Copies, a3.BranchName
	from bk.books a1
	inner join book.BOOK_COPIES a2 on a2.BookID = a1.BookID
	inner join lb.LIBRARY_BRANCH a3 on a3.BranchID = a2.BranchID
	inner join book.BOOK_AUTHORS a4 on a4.BookID = a1.BookID
	inner join pb.PUBLISHER a5 on a5.PublisherName = a1.PublisherName
	inner join book.BOOK_loans a6 on a6.BookID = a1.BookID
	inner join br.BORROWER a7 on a7.CardNo = a6.CardNo
	where title = 'The Lost Tribe'
end

exec usp_BrachLostTribe


-- Stored Procedure 3
-- This will give all the names of borrowers who
-- do not have any books checked out
create proc usp_UncheckedBorrowers
as
begin 
	select *
	from br.BORROWER a1
	left join book.BOOK_LOANS a2 on a2.CardNo = a1.CardNo
	where a2.DateOut is null
end

exec usp_UncheckedBorrowers


-- Stored Procedure 4
-- This will give book title, name of borrowers and addresses
-- of the borroweres that are from "Sharpstown" branch and 
-- due date is today, which I set to 10/23/18
create proc usp_SharpstownToday @today varchar(50) = null
as
begin
	set @today = '10/23/18'
	select a3.Title as 'book title', a1.Name as 'borrower name', a1.Address as 'borrower address'
	from br.BORROWER a1
	inner join book.BOOK_LOANS a2 on a2.CardNo = a1.CardNo
	inner join bk.BOOKS a3 on a3.BookID = a2.BookID
	inner join lb.LIBRARY_BRANCH a4 on a4.BranchID = a2.BranchID
	where a2.DateDue = @today and a4.BranchName = 'Sharpstown'
end

exec usp_sharpstownToday @today = '10/23/18'


-- Stored Procedure 5
-- This will show the branch name and the total number of books
-- loaned from each library branch
create proc usp_BranchLoaned
as
begin
	select a2.BranchName, count(a1.BookID) as 'Books Loaned'
	from book.BOOK_LOANS a1
	inner join lb.LIBRARY_BRANCH a2 on a2.BranchID = a1.BranchID
	group by a2.BranchName
end

exec usp_BranchLoaned


-- Stored Procedure 6
-- This will retreive the names, addresses, and the number of books
-- checked out for all borrowers who have more than five books checked out
create proc usp_MoreThanFive
as
begin
	select a1.Name, a1.Address, count(a2.BookID) as ' Books Loaned'
	from br.BORROWER a1
	inner join book.BOOK_LOANS a2 on a2.CardNo = a1.CardNo
	group by a1.name, a1.address
	having count(a2.bookID) > 5
end

exec usp_MoreThanFive


-- Stored Procedure 7
-- This will retreive the title and the number of copies owned by
-- "Central" library branch that are authored by "Stephen King"
create proc usp_StephenKingCentral
as
begin
	select a1.title, a3.Number_Of_Copies
	from bk.BOOKS a1
	inner join book.BOOK_AUTHORS a2 on a2.BookID = a1.BookID
	inner join book.BOOK_COPIES a3 on a3.BookID = a1.BookID
	inner join lb.LIBRARY_BRANCH a4 on a4.BranchID = a3.BranchID
	where a2.AuthorName = 'Stephen King' and a4.BranchName = 'Central'
end

exec usp_StephenKingCentral