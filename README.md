sqlitrep is a  command line programme for working with SQLite database files.

Depends on the CoreComponents, SQLiteConnector and dbrep projects.

example usage:

sqlitrep -con "Data Source=test.db; Version=3;" -out

	Connection: "Data Source=test.db; Version=3;" is open
	
	CREATE TABLE Coolness ( Level INTEGER PRIMARY KEY AUTOINCREMENT, Label TEXT )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Sub Zero" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Ice" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Freezing" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Cold" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Cool" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Lukewarm" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Warm" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Really Warm" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Hot" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Really Hot" )
	
	INSERT INTO Coolness ( Label ) VALUES ( "Blazing" )
	
	SELECT Label FROM Coolness WHERE Level = 11
	
	+---------+
	| Label   |
	+---------+
	| Blazing |
	+---------+

	SELECT * FROM Coolness
	
	+-------+-------------+
	| Level | Label       |
	+-------+-------------+
	| 1     | Sub Zero    |
	| 2     | Ice         |
	| 3     | Freezing    |
	| 4     | Cold        |
	| 5     | Cool        |
	| 6     | Lukewarm    |
	| 7     | Warm        |
	| 8     | Really Warm |
	| 9     | Hot         |
	| 10    | Really Hot  |
	| 11    | Blazing     |
	+-------+-------------+

	q

	Connection is closed

	bye!
