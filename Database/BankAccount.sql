CREATE TABLE [BankAccount]
(
    [Id] BIGINT PRIMARY KEY IDENTITY,
    [Holder] VARCHAR(MAX) NOT NULL,
    [HolderDocument] VARCHAR(MAX) NOT NULL,
    [PasswordHash] VARCHAR(MAX) NOT NULL,
    [PasswordSalt] VARCHAR(MAX) NOT NULL,
    [AllowsOverdraft] BIT NOT NULL DEFAULT(0),
    [UpdatedPosition] DECIMAL(18,2) NOT NULL,
    [CreationDate] DATETIME DEFAULT(GETDATE())
)