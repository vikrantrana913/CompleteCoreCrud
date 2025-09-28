Insert into Country(CountryName)values('India')
Insert into Country(CountryName)values('USA')
Insert into Country(CountryName)values('Rusia')
Insert into Country(CountryName)values('Pakistan')

Select * from Country

--Insert states of India
Insert into State(StateName,CountId)Values('UP',1)
Insert into State(StateName,CountId)Values('Vihar',1)
Insert into State(StateName,CountId)Values('Hariyana',1)
Insert into State(StateName,CountId)Values('Panjab',1)

Select * from state

Update Country set CountryName='USA' where CountryId=2

--Insert city of UP
INSERT INTO City(CityName, StatId) VALUES
('Lucknow', 1),
('Kanpur', 1),
('Varanasi', 1),
('Agra', 1);

--insert city of vihar
INSERT INTO City (CityName, StatId) VALUES
('Patna', 2),
('Gaya', 2),
('Bhagalpur', 2),
('Muzaffarpur', 2);

--insert city of vihar
INSERT INTO City (CityName, StatId) VALUES
('Gurgaon', 3),
('Faridabad', 3),
('Panipat', 3),
('Hisar', 3);


-- insert city of punjab
INSERT INTO City(CityName, StatId) VALUES
('Amritsar', 4),
('Ludhiana', 4),
('Patiala', 4),
('Jalandhar', 4);


--states of new york
insert into State(StateName,CountId)Values('New York',2)
insert into State(StateName,CountId)Values('Texas',2)
insert into State(StateName,CountId)Values('California',2)
insert into State(StateName,CountId)Values('Florida',2)

INSERT INTO City(CityName, StatId) VALUES ('New York City', 5);
INSERT INTO City(CityName, StatId) VALUES ('Buffalo', 5);
INSERT INTO City(CityName, StatId) VALUES ('Rochester', 5);

INSERT INTO City(CityName, StatId) VALUES ('Houston', 6);
INSERT INTO City(CityName, StatId) VALUES ('Dallas', 6);
INSERT INTO City(CityName, StatId) VALUES ('Austin', 6);

INSERT INTO City(CityName, StatId) VALUES ('Los Angeles', 7);
INSERT INTO City(CityName, StatId) VALUES ('San Francisco', 7);
INSERT INTO City(CityName, StatId) VALUES ('San Diego', 7);

INSERT INTO City(CityName, StatId) VALUES ('Miami', 8);
INSERT INTO City(CityName, StatId) VALUES ('Orlando', 8);
INSERT INTO City(CityName, StatId) VALUES ('Tampa', 8);


select * from State

INSERT INTO State(StateName, CountId) VALUES ('Moscow Oblast', 3);
INSERT INTO State(StateName, CountId) VALUES ('Saint Petersburg', 3);
INSERT INTO State(StateName, CountId) VALUES ('Novosibirsk Oblast', 3);
INSERT INTO State(StateName, CountId) VALUES ('Krasnodar Krai', 3);
INSERT INTO State(StateName, CountId) VALUES ('Tatarstan', 3);

INSERT INTO City(CityName, StatId) VALUES ('Moscow', 9);
INSERT INTO City(CityName, StatId) VALUES ('Zelenograd', 9);
INSERT INTO City(CityName, StatId) VALUES ('Khimki', 9);

INSERT INTO City(CityName, StatId) VALUES ('Saint Petersburg', 10);
INSERT INTO City(CityName, StatId) VALUES ('Kolpino', 10);
INSERT INTO City(CityName, StatId) VALUES ('Pushkin', 10);

-- Novosibirsk Oblast (StatId = 11)
INSERT INTO City(CityName, StatId) VALUES ('Novosibirsk', 11);
INSERT INTO City(CityName, StatId) VALUES ('Berdsk', 11);
INSERT INTO City(CityName, StatId) VALUES ('Iskitim', 11);

-- Krasnodar Krai (StatId = 12)
INSERT INTO City(CityName, StatId) VALUES ('Krasnodar', 12);
INSERT INTO City(CityName, StatId) VALUES ('Sochi', 12);
INSERT INTO City(CityName, StatId) VALUES ('Novorossiysk', 12);

-- Tatarstan (StatId = 13)
INSERT INTO City(CityName, StatId) VALUES ('Kazan', 13);
INSERT INTO City(CityName, StatId) VALUES ('Naberezhnye Chelny', 13);
INSERT INTO City(CityName, StatId) VALUES ('Almetyevsk', 13);

select * from Country

INSERT INTO State(StateName, CountId) VALUES ('Punjab', 4);
INSERT INTO State(StateName, CountId) VALUES ('Sindh', 4);
INSERT INTO State(StateName, CountId) VALUES ('Khyber Pakhtunkhwa', 4);
INSERT INTO State(StateName, CountId) VALUES ('Balochistan', 4);
INSERT INTO State(StateName, CountId) VALUES ('Gilgit-Baltistan', 4);
INSERT INTO State(StateName, CountId) VALUES ('Azad Jammu and Kashmir', 4);

-- Punjab (StatId = 14)
INSERT INTO City(CityName, StatId) VALUES ('Lahore', 14);
INSERT INTO City(CityName, StatId) VALUES ('Faisalabad', 14);
INSERT INTO City(CityName, StatId) VALUES ('Rawalpindi', 14);

-- Sindh (StatId = 15)
INSERT INTO City(CityName, StatId) VALUES ('Karachi', 15);
INSERT INTO City(CityName, StatId) VALUES ('Hyderabad', 15);
INSERT INTO City(CityName, StatId) VALUES ('Sukkur', 15);

-- Khyber Pakhtunkhwa (StatId = 16)
INSERT INTO City(CityName, StatId) VALUES ('Peshawar', 16);
INSERT INTO City(CityName, StatId) VALUES ('Mardan', 16);
INSERT INTO City(CityName, StatId) VALUES ('Abbottabad', 16);

-- Balochistan (StatId = 17)
INSERT INTO City(CityName, StatId) VALUES ('Quetta', 17);
INSERT INTO City(CityName, StatId) VALUES ('Gwadar', 17);
INSERT INTO City(CityName, StatId) VALUES ('Khuzdar', 17);

-- Gilgit-Baltistan (StatId = 18)
INSERT INTO City(CityName, StatId) VALUES ('Gilgit', 18);
INSERT INTO City(CityName, StatId) VALUES ('Skardu', 18);

--  Jammu and Kashmir (StatId = 19)
INSERT INTO City(CityName, StatId) VALUES ('Muzaffarabad', 19);
INSERT INTO City(CityName, StatId) VALUES ('Mirpur', 19);
INSERT INTO City(CityName, StatId) VALUES ('Kotli', 19);

select * from City

insert into Desingnation(Jobtitle)values('Manager')
insert into Desingnation(Jobtitle)values('Software Developer')
insert into Desingnation(Jobtitle)values('Accountant')
insert into Desingnation(Jobtitle)values('Human Resources')
insert into Desingnation(Jobtitle)values('Admin')

-- Saturday updated --- 
