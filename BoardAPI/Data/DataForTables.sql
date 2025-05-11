INSERT INTO Categories (Name, DisplayName) VALUES 
('appliances', N'Побутова техніка'),
('computers', N'Комп''ютерна техніка'),
('smartphones', N'Смартфони'),
('other', N'Інше');

INSERT INTO SubCategories (CategoryId, Name, DisplayName) VALUES

(1, 'refrigerators', N'Холодильники'),
(1, 'washing_machines', N'Пральні машини'),
(1, 'boilers', N'Бойлери'),
(1, 'ovens', N'Печі'),
(1, 'hoods', N'Витяжки'),
(1, 'microwaves', N'Мікрохвильові печі'),

(2, 'desktop_pcs', N'ПК'),
(2, 'laptops', N'Ноутбуки'),
(2, 'monitors', N'Монітори'),
(2, 'printers', N'Принтери'),
(2, 'scanners', N'Сканери'),

(3, 'android', N'Android смартфони'),
(3, 'ios', N'iOS/Apple смартфони'),

(4, 'clothes', N'Одяг'),
(4, 'shoes', N'Взуття'),
(4, 'accessories', N'Аксесуари'),
(4, 'sports_equipment', N'Спортивне обладнання'),
(4, 'toys', N'Іграшки');

INSERT INTO Announcements (Title, Description, Status, CategoryId, SubCategoryId)
VALUES 
(N'Продам новий холодильник Samsung', N'Повністю новий, з гарантією 2 роки', 'Active', 1, 1), 
(N'Продам ноутбук Lenovo', N'8GB RAM, 512GB SSD, як новий', 'Active', 2, 8), 
(N'iPhone 13 Pro Max', N'Стан ідеальний, заряд тримає чудово', 'Sold', 3, 13), 
(N'Дитячий велосипед', N'Майже новий, підходить для дітей 5-7 років', 'Available', 4, 17), 
(N'Сканер Canon Lide', N'Компактний та зручний для дому', 'Active', 2, 11); 
