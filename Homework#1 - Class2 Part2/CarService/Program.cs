using CarService.Domain.Models;

CarCenter carCenter = new CarCenter();

Car car = new("Audi", "A4", 2018, 150);
Truck truck = new("Man", "Man Tgx Truck", 2020, 540);

carCenter.ServiceVehicle(car);

carCenter.ServiceVehicle(truck);
