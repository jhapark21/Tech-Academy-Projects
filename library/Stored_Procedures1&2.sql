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
	where title = 'The Lost Tribe'
end

exec usp_BrachLostTribe

