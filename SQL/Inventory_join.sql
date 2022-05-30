SELECT Inventory.inventory_id,Inventory.side,Gas.type,Inventory.Volume,Inventory.Price,Inventory.Date FROM tas_project.Inventory INNER JOIN Gas ON Inventory.gas_id = Gas.gas_id;
