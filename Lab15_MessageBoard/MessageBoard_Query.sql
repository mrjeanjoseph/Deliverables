CREATE TABLE messages (
	Id INT PRIMARY KEY IDENTITY,
	UserId NVARCHAR(75),
	EmailAddress NVARCHAR(75),
	PostedTime DATETIME,
	Updated BIT,
	[Message] NVARCHAR(500)
)