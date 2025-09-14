Create Database Practice
use Practice

Create table Candidate
(
Id bigint Primary key identity(1,1),
Name nvarchar(50),
Gender nvarchar(10),
Country bigint foreign key references Country(CountryId),
State bigint foreign key references State(StateId),
City bigint foreign key references City(CityId),
Python bit,
Java bit,
Photo nvarchar(50),
Desingnation bigint
)

Create table Desingnation
(
JobId bigint primary key identity(1,1),
Jobtitle nvarchar(50)
)

Create table Country
(
CountryId bigint Primary key identity(1,1),
CountryName nvarchar(50)
)

Create table State
(
StateId bigint primary key identity(1,1),
StateName nvarchar(50),
CountId bigint foreign key references Country(CountryId)
)

Create table City
(
CityId bigint primary key identity(1,1),
CityName nvarchar(50),
StatId bigint foreign key references State(StateId)
)

Create Procedure AddCandidateData
(
@Name nvarchar(50),
@Gender nvarchar(10),
@Country bigint,
@State bigint,
@City bigint,
@Python bit,
@Java bit,
@Photo nvarchar(50),
@Desingnation bigint
)
as
begin
Insert into Candidate(Name,Gender,Country,State,City,Python,Java,Photo,Desingnation)
Values(@Name,@Gender,@Country,@State,@City,@Python,@Java,@Photo,@Desingnation)
End


Create procedure GetCountryList
as
begin
Select * from Country
end

Create procedure GetStateList
(
@CountId bigint
)
as
begin
Select * from State where CountId=@CountId
end

Create procedure GetCityList
(
@StatId bigint
)
as
begin	
select * from City where StatId=@StatId
end


