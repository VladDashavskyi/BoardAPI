CREATE OR ALTER PROCEDURE CreateAnnouncement
    @Title NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @Status NVARCHAR(50),
    @CategoryId INT,
    @SubCategoryId INT
AS
BEGIN
    INSERT INTO Announcements (Title, Description, CreatedDate, Status, CategoryId, SubCategoryId)
    VALUES (@Title, @Description, GETDATE(), @Status, @CategoryId, @SubCategoryId);
END
GO;

CREATE OR ALTER PROCEDURE DeleteAnnouncement
    @Id INT
AS
BEGIN
    DELETE FROM Announcements
    WHERE Id = @Id;
END
GO;

CREATE OR ALTER PROCEDURE GetAllCategories
AS
BEGIN
    SELECT 
        Id, 
        Name AS CategoryName, 
        DisplayName AS CategoryDisplayName
    FROM 
        Categories;
END;
GO;

CREATE OR ALTER PROCEDURE GetAllSubCategories
AS
BEGIN
    SELECT 
        s.Id AS SubCategoryId, 
        s.Name AS SubCategoryName, 
        s.DisplayName AS SubCategoryDisplayName,
        c.Name AS CategoryName, 
        c.DisplayName AS CategoryDisplayName
    FROM 
        SubCategories s
    INNER JOIN 
        Categories c ON s.CategoryId = c.Id;
END;
GO;

CREATE OR ALTER PROCEDURE GetAnnouncementById
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Id,
        Title,
        Description,
        CreatedDate,
        Status,
        CategoryId,
        SubCategoryId
    FROM Announcements
    WHERE Id = @Id;
END;
GO;

CREATE OR ALTER PROCEDURE GetAnnouncements
AS
BEGIN
    SELECT * FROM Announcements;
END
GO;

CREATE OR ALTER PROCEDURE GetCategoryById
    @CategoryId INT
AS
BEGIN
    SELECT 
        Id, 
        Name AS CategoryName, 
        DisplayName AS CategoryDisplayName
    FROM 
        Categories
    WHERE 
        Id = @CategoryId;
END;
GO;

CREATE OR ALTER PROCEDURE GetSubCategoryById
    @SubCategoryId INT
AS
BEGIN
    SELECT 
        s.Id AS SubCategoryId, 
        s.Name AS SubCategoryName, 
        s.DisplayName AS SubCategoryDisplayName,
        c.Name AS CategoryName, 
        c.DisplayName AS CategoryDisplayName
    FROM 
        SubCategories s
    INNER JOIN 
        Categories c ON s.CategoryId = c.Id
    WHERE 
        s.Id = @SubCategoryId;
END;
GO;

CREATE  OR ALTER  PROCEDURE UpdateAnnouncement
    @Id INT,
    @Title NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @Status NVARCHAR(50),
    @CategoryId INT,
    @SubCategoryId INT
AS
BEGIN
    UPDATE Announcements
    SET 
        Title = @Title,
        Description = @Description,
        Status = @Status,
        CategoryId = @CategoryId,
        SubCategoryId = @SubCategoryId
    WHERE Id = @Id;
END
GO;