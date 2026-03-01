-- ============================================================
-- ZooZen - Test Seed Data
-- Run after: dotnet ef database update
-- ============================================================

-- Roles (already seeded by ZooZenDbContext / SeedAdmin)
-- If missing, add manually:
-- INSERT INTO Roles (Id, Name) VALUES
--   ('A1B2C3D4-E5F6-7890-ABCD-EF1234567890', 'Admin'),
--   ('B2C3D4E5-F6A7-8901-BCDE-F12345678901', 'Client');

-- ============================================================
-- Test Products
-- ============================================================
INSERT INTO Products (Id, Name, Description, Price, StockQuantity, ImageUrl, Category)
VALUES
-- Animals (Category = 0)
  (NEWID(), 'Persian Cat',          'Purebred Persian kitten, 3 months old',        850.00,  5, NULL, 0),
  (NEWID(), 'Golden Retriever',     'Golden Retriever puppy, vaccinated',           1200.00, 3, NULL, 0),
  (NEWID(), 'Rex Rabbit',           'Domestic rabbit, Rex breed',                    120.00, 8, NULL, 0),
  (NEWID(), 'Syrian Hamster',       'Tame Syrian hamster',                            35.00, 15, NULL, 0),

-- Food (Category = 1)
  (NEWID(), 'Royal Canin Adult',    'Dry cat food, 2 kg',                            42.90, 30, NULL, 1),
  (NEWID(), 'Pedigree Adult',       'Dry dog food, 3 kg',                            38.50, 25, NULL, 1),
  (NEWID(), 'Versele-Laga Crispy',  'Pellets for rabbits and guinea pigs, 1 kg',     12.90, 40, NULL, 1),
  (NEWID(), 'Vitakraft Drops',      'Vitamin treats for hamsters',                     5.50, 50, NULL, 1),

-- Cosmetics (Category = 2)
  (NEWID(), 'Bio-Groom Shampoo',    'Gentle dog shampoo, 250 ml',                    18.90, 20, NULL, 2),
  (NEWID(), 'Trixie Brush',         'Grooming brush for cats and dogs',                9.90, 35, NULL, 2),
  (NEWID(), 'Hygiene Wipes',        'Wet wipes for paw cleaning, 40 pcs',              6.50, 45, NULL, 2),

-- Accessories (Category = 3)
  (NEWID(), 'Cat Tower',            'Multi-level cat climbing tree, 150 cm',         189.00,  7, NULL, 3),
  (NEWID(), 'Dog Leash',            'Adjustable leather leash, size M',               24.90, 20, NULL, 3),
  (NEWID(), 'Rabbit Cage',          'Spacious two-level cage, 90x60 cm',              95.00,  6, NULL, 3),
  (NEWID(), 'Hamster Wheel',        'Silent hamster exercise wheel, 20 cm',             8.90, 25, NULL, 3),

-- Promotions & Services (Category = 4)
  (NEWID(), 'Kitten Starter Pack',  'Cat tower + shampoo + brush + food bundle',     220.00, 10, NULL, 4),
  (NEWID(), 'Puppy Starter Pack',   'Leash + shampoo + Royal Canin 3 kg bundle',      75.00, 10, NULL, 4),
  (NEWID(), 'Vet Checkup',          'Basic preventive veterinary examination',         40.00, 99, NULL, 4);
