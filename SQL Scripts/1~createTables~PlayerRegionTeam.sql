CREATE TABLE Team (
	team_id int identity(1,1) PRIMARY KEY, 
	name varchar(255) NOT NULL,
	school varchar(255), 
	captain varchar(255),
	region_id int FOREIGN KEY REFERENCES Region(region_id), 
	playercount int 
	)

CREATE TABLE Region (
	region_id int identity(1,1) PRIMARY KEY, 
	name varchar(255),
	location varchar(255)
	)

CREATE TABLE Player (
	player_id int identity(1,1) PRIMARY KEY,
	name varchar(255), 
	age int, 
	number int,
	position varchar(255),
	team_id int FOREIGN KEY REFERENCES Team(team_id)
	) 

