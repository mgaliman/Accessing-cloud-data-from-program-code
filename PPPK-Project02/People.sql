create database People

create table Profession
(
	IDProfession int identity primary key,
	ProfessionName nvarchar(30) not null
)

GO
create table Person
(
	IDPerson int identity primary key,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	Age int,
	Email nvarchar(30) not null,
	Picture varbinary(max),
	ProfessionName nvarchar(30) not null,
	ProfessionID int foreign key references Profession(IDProfession)
)

GO
CREATE PROC [dbo].[AddPerson]
	@firstname nvarchar(20),
	@lastname nvarchar(20),
	@age int,
	@email nvarchar(30),
	@picture varbinary(max),
	@professionid int,
	@professionname nvarchar(30),
	@idPerson INT OUTPUT
AS 
BEGIN
INSERT INTO Person VALUES (@firstname, @lastname, @age, @email, @picture, @professionname, @professionid)
	SET @idPerson = SCOPE_IDENTITY()
END

GO
CREATE PROC [dbo].[AddProfession]
	@professionname nvarchar(30),
	@idProfession INT OUTPUT
AS 
BEGIN
INSERT INTO Profession (ProfessionName) VALUES (@professionname)
	SET @idProfession = SCOPE_IDENTITY()
END

GO
CREATE PROC [dbo].[DeletePerson]
	@idPerson int
AS
DELETE FROM Person WHERE IDPerson = @idPerson

GO
CREATE PROC [dbo].[DeleteProfession]
	@idProfession int
AS
DELETE FROM Person where ProfessionID = @idProfession
DELETE FROM Profession WHERE IDProfession = @idProfession

GO
CREATE PROC [dbo].[GetPeople]
AS
SELECT * FROM Person

GO
CREATE PROC [dbo].[GetPerson]
	@idPerson int
AS
SELECT * FROM Person WHERE IDPerson = @idPerson

GO
CREATE PROC [dbo].[GetProfessions]
AS
SELECT * FROM Profession

GO
CREATE PROC [dbo].[UpdatePerson]
	@firstname nvarchar(20),
	@lastname nvarchar(20),
	@age int,
	@email nvarchar(30),
	@picture varbinary(max),
	@idPerson int,
	@ProfessionId int
AS
UPDATE Person SET 
		FirstName = @firstname,
		LastName = @lastname,
		Age = @age,
		Email = @email,
		Picture = @picture,
		ProfessionID = @ProfessionId
	WHERE 
		IDPerson = @idPerson 

GO	
CREATE PROC [dbo].[UpdateProfession]
	@professionname nvarchar(30),
	@idProfession int
AS
update person set
		professionname= @professionname
		where professionid= @idProfession
UPDATE Profession SET 
		ProfessionName = @professionname
	WHERE 
		IDProfession = @idProfession