CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,         
    DisplayName NVARCHAR(100) NOT NULL   
);

CREATE TABLE SubCategories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CategoryId INT NOT NULL,
    Name NVARCHAR(100) NOT NULL,        
    DisplayName NVARCHAR(100) NOT NULL,  
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

CREATE TABLE Announcements (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    CreatedDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50),
    CategoryId INT NOT NULL,
    SubCategoryId INT NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
    FOREIGN KEY (SubCategoryId) REFERENCES SubCategories(Id)
);
