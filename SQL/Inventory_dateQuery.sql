SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM tas_project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id  
WHERE date >= '2022-01-01 00:00:00 AM' AND date <= '2022-01-01 3:53:04 AM'; 
