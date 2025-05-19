using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region Worker

        public static Worker GetWorker(string workerID)
        {
            ISession session = SessionManager.GetSession();
            Worker worker = new Worker();

            if (session == null)
                return null;

            Row workerData = session.Execute("select * from \"Worker\" where \"workerID\"='"+workerID+"'").FirstOrDefault();

            if (workerData != null)
            {
                worker.workerID = workerData["workerID"] != null ? workerData["workerID"].ToString() : string.Empty;
                worker.officeID = workerData["officeID"] != null ? workerData["officeID"].ToString() : string.Empty;
                worker.firstName = workerData["firstname"] != null ? workerData["firstname"].ToString() : string.Empty;
                worker.lastName = workerData["lastname"] != null ? workerData["lastname"].ToString() : string.Empty;
                worker.phone = workerData["phone"] != null ? workerData["phone"].ToString() : string.Empty;
                worker.email = workerData["email"] != null ? workerData["email"].ToString() : string.Empty;
                worker.addres = workerData["addres"] != null ? workerData["addres"].ToString() : string.Empty;
                worker.birthyear = workerData["birthyear"] != null ? workerData["birthyear"].ToString() : string.Empty;
                worker.birthplace = workerData["birthplace"] != null ? workerData["birthplace"].ToString() : string.Empty;
                worker.highSchool = workerData["highschool"] != null ? workerData["highschool"].ToString() : string.Empty;
                worker.faculty = workerData["faculty"] != null ? workerData["faculty"].ToString() : string.Empty;

            }
            else worker = null;

            return worker;
        }

        public static List<Worker> GetWorkers()
        {
            ISession session = SessionManager.GetSession();
            List<Worker> workers = new List<Worker>();


            if (session == null)
                return null;

            var workersData = session.Execute("select * from \"Worker\"");


            foreach (var workerData in workersData)
            {
                Worker worker = new Worker();

                worker.workerID = workerData["workerID"] != null ? workerData["workerID"].ToString() : string.Empty;
                worker.officeID = workerData["officeID"] != null ? workerData["officeID"].ToString() : string.Empty;
                worker.firstName = workerData["firstname"] != null ? workerData["firstname"].ToString() : string.Empty;
                worker.lastName = workerData["lastname"] != null ? workerData["lastname"].ToString() : string.Empty;
                worker.phone = workerData["phone"] != null ? workerData["phone"].ToString() : string.Empty;
                worker.email = workerData["email"] != null ? workerData["email"].ToString() : string.Empty;
                worker.addres = workerData["addres"] != null ? workerData["addres"].ToString() : string.Empty;
                worker.birthyear = workerData["birthyear"] != null ? workerData["birthyear"].ToString() : string.Empty;
                worker.birthplace = workerData["birthplace"] != null ? workerData["birthplace"].ToString() : string.Empty;
                worker.highSchool = workerData["highschool"] != null ? workerData["highschool"].ToString() : string.Empty;
                worker.faculty = workerData["faculty"] != null ? workerData["faculty"].ToString() : string.Empty;

                workers.Add(worker);
            }
            
            return workers;
        }

        public static bool AddWorker(Worker worker)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;


            if (worker != null)
            {
                RowSet workerData = session.Execute("insert into \"Worker\" (\"workerID\", addres, birthplace, birthyear, email, faculty, firstname, highschool, lastname, \"officeID\", phone) " +
                    " values ('" + worker.workerID + "','" + worker.addres + "', '" + worker.birthplace + "', '" + worker.birthyear + "', '" + worker.email + "', '" + worker.faculty + "', '" + worker.firstName + "', '" + worker.highSchool + "', '" + worker.lastName + "', '" + worker.officeID + "', '" + worker.phone + "')");
                return true;
            }
            else return false;
        }

        public static void DeleteWorker(string workerID)
        {
            ISession session = SessionManager.GetSession();
            Worker worker = new Worker();

            if (session == null)
                return;

            

            RowSet hotelData = session.Execute("delete from \"Worker\" where \"workerID\" = '" + workerID + "'");

        }

        public static string[] GetWorkerComment(string workerID)
        {

            ISession session = SessionManager.GetSession();
            Worker worker = new Worker();

            if (session == null)
                return null;

            Row workerData = session.Execute("select * from \"Worker\" where \"workerID\"='" + workerID + "'").FirstOrDefault();

            return (string[]) workerData["comments"];
            
        }

        public static void AddWorkerComments(List<string> comments,string id)
        {
            ISession session = SessionManager.GetSession();
            

            if (session == null)
                return ;

            string forExecute="";

            foreach (string str in comments)
            {
                if (str == comments[0])
                {
                    forExecute = forExecute + "'" + str + "'";
                }
                else forExecute= forExecute+",'" + str + "'";
            }


            RowSet workerData = session.Execute("UPDATE \"Worker\" SET comments =["+ forExecute + "] WHERE \"workerID\" = '"+ id +"'; ");
             
        }



       #endregion

        #region Computer

        public static Computer GetComputer(string computerID)
        {
            ISession session = SessionManager.GetSession();
            Computer computer = new Computer();

            if (session == null)
                return null;

            Row computerData = session.Execute("select * from \"Computer\" where \"computerId\"='" + computerID + "'").FirstOrDefault();

            if (computerData != null)
            {
                computer.computerId = computerData["computerId"] != null ? computerData["computerId"].ToString() : string.Empty;
                computer.officeId = computerData["officeId"] != null ? computerData["officeId"].ToString() : string.Empty;
                computer.code = computerData["code"] != null ? computerData["code"].ToString() : string.Empty;
                computer.laptopDesktop = computerData["laptopdesktop"] != null ? computerData["laptopdesktop"].ToString() : string.Empty;
                computer.brand = computerData["brand"] != null ? computerData["brand"].ToString() : string.Empty;
                computer.type = computerData["type"] != null ? computerData["type"].ToString() : string.Empty;
                computer.cpu = computerData["cpu"] != null ? computerData["cpu"].ToString() : string.Empty;
                computer.disc = computerData["disc"] != null ? computerData["disc"].ToString() : string.Empty;
                computer.ram = computerData["ram"] != null ? computerData["ram"].ToString() : string.Empty;
                computer.graphics = computerData["graphics"] != null ? computerData["graphics"].ToString() : string.Empty;
                computer.operatingSystem = computerData["operatingsystem"] != null ? computerData["operatingsystem"].ToString() : string.Empty;
                computer.guaranty = computerData["guaranty"] != null ? computerData["guaranty"].ToString() : string.Empty;
                computer.operatingSystem = computerData["purchaseddate"] != null ? computerData["purchaseddate"].ToString() : string.Empty;
            }
            else computer = null;

            return computer;
        }

        public static List<Computer> GetComputers()
        {
            ISession session = SessionManager.GetSession();
            List<Computer> computers = new List<Computer>();


            if (session == null)
                return null;

            var computersData = session.Execute("select * from \"Computer\"");


            foreach (var computerData in computersData)
            {
                Computer computer = new Computer();

                computer.computerId = computerData["computerId"] != null ? computerData["computerId"].ToString() : string.Empty;
                computer.officeId = computerData["officeId"] != null ? computerData["officeId"].ToString() : string.Empty;
                computer.code = computerData["code"] != null ? computerData["code"].ToString() : string.Empty;
                computer.laptopDesktop = computerData["laptopdesktop"] != null ? computerData["laptopdesktop"].ToString() : string.Empty;
                computer.brand = computerData["brand"] != null ? computerData["brand"].ToString() : string.Empty;
                computer.type = computerData["type"] != null ? computerData["type"].ToString() : string.Empty;
                computer.cpu = computerData["cpu"] != null ? computerData["cpu"].ToString() : string.Empty;
                computer.disc = computerData["disc"] != null ? computerData["disc"].ToString() : string.Empty;
                computer.ram = computerData["ram"] != null ? computerData["ram"].ToString() : string.Empty;
                computer.graphics = computerData["graphics"] != null ? computerData["graphics"].ToString() : string.Empty;
                computer.operatingSystem = computerData["operatingsystem"] != null ? computerData["operatingsystem"].ToString() : string.Empty;
                computer.guaranty = computerData["guaranty"] != null ? computerData["guaranty"].ToString() : string.Empty;
                computer.purchasedDate = computerData["purchaseddate"] != null ? computerData["purchaseddate"].ToString() : string.Empty;

                computers.Add(computer);
            }

            return computers;
        }

        public static bool AddComputer(Computer computer)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return true;


            if (computer != null)
            {
                RowSet computerData = session.Execute("insert into \"Computer\" (\"computerId\", brand, code, cpu, disc, graphics, guaranty, laptopdesktop, \"officeId\", operatingsystem, purchaseddate, ram, \"type\")  values" +
                  " ('" + computer.computerId + "','" + computer.brand + "','" + computer.code + "','" + computer.cpu + "','" + computer.disc + "','" + computer.graphics + "','" + computer.guaranty + "','" + computer.laptopDesktop + "','" + computer.officeId + "','" + computer.operatingSystem + "','" + computer.purchasedDate + "','" + computer.ram + "','" + computer.type + "')");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DeleteComputer (string computerID)
        {
            ISession session = SessionManager.GetSession();
            Computer computer = new Computer();

            if (session == null)
                return;
            
            RowSet computerData = session.Execute("delete from \"Computer\" where \"computerId\" = '" + computerID + "'");

        }


        public static string[] GetComputerRepairs(string computerID)
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            Row computerData = session.Execute("select * from \"Computer\" where \"computerId\"='" + computerID + "';").FirstOrDefault();

            return (string[]) computerData["repairs"];

        }

        public static void AddComputerRepairs(List<string> repairs, string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            string forExecute = "";

            foreach (string str in repairs)
            {
                if (str == repairs[0])
                {
                    forExecute = forExecute + "'" + str + "'";
                }
                else forExecute = forExecute + ",'" + str + "'";
            }


            RowSet workerData = session.Execute("UPDATE \"Computer\" SET repairs =[" + forExecute + "] WHERE \"computerId\" = '" + id + "'; ");

        }

        #endregion

        #region Vehicle

        public static Vehicle GetVehicle(string vehicleID)
        {
            ISession session = SessionManager.GetSession();
            Vehicle vehicle = new Vehicle();

            if (session == null)
                return null;

            Row vehicleData = session.Execute("select * from \"Vehicle\" where \"vehicleID\"='" + vehicleID + "'").FirstOrDefault();

            if (vehicleData != null)
            {
                vehicle.vehicleID = vehicleData["vehicleID"] != null ? vehicleData["vehicleID"].ToString() : string.Empty;
                vehicle.vehicleType = vehicleData["vehicletype"] != null ? vehicleData["vehicletype"].ToString() : string.Empty;
                vehicle.brand = vehicleData["brand"] != null ? vehicleData["brand"].ToString() : string.Empty;
                vehicle.brandType = vehicleData["brandtype"] != null ? vehicleData["brandtype"].ToString() : string.Empty;
                vehicle.enginePower = vehicleData["enginepower"] != null ? vehicleData["enginepower"].ToString() : string.Empty;
                vehicle.number = vehicleData["number"] != null ? vehicleData["number"].ToString() : string.Empty;
                vehicle.numberOfSeats = vehicleData["numberofseats"] != null ? vehicleData["numberofseats"].ToString() : string.Empty;
                vehicle.capacity = vehicleData["capacity"] != null ? vehicleData["capacity"].ToString() : string.Empty;
                vehicle.year = vehicleData["year"] != null ? vehicleData["year"].ToString() : string.Empty;
            }
            else vehicle = null;

            return vehicle;
        }

        public static List<Vehicle> GetVehicles()
        {
            ISession session = SessionManager.GetSession();
            List<Vehicle> vehicles = new List<Vehicle>();


            if (session == null)
                return null;

            var vehiclesData = session.Execute("select * from \"Vehicle\"");


            foreach (var vehicleData in vehiclesData)
            {
                Vehicle vehicle = new Vehicle();

                vehicle.vehicleID = vehicleData["vehicleID"] != null ? vehicleData["vehicleID"].ToString() : string.Empty;
                vehicle.vehicleType = vehicleData["vehicletype"] != null ? vehicleData["vehicletype"].ToString() : string.Empty;
                vehicle.brand = vehicleData["brand"] != null ? vehicleData["brand"].ToString() : string.Empty;
                vehicle.brandType = vehicleData["brandtype"] != null ? vehicleData["brandtype"].ToString() : string.Empty;
                vehicle.enginePower = vehicleData["enginepower"] != null ? vehicleData["enginepower"].ToString() : string.Empty;
                vehicle.number = vehicleData["number"] != null ? vehicleData["number"].ToString() : string.Empty;
                vehicle.numberOfSeats = vehicleData["numberofseats"] != null ? vehicleData["numberofseats"].ToString() : string.Empty;
                vehicle.capacity = vehicleData["capacity"] != null ? vehicleData["capacity"].ToString() : string.Empty;
                vehicle.year = vehicleData["year"] != null ? vehicleData["year"].ToString() : string.Empty;

                vehicles.Add(vehicle);
            }

            return vehicles;
        }

        public static bool AddVehicle(Vehicle vehicle)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;


            if (vehicle != null)
            {
                RowSet computerData = session.Execute("insert into \"Vehicle\" (\"vehicleID\", brand, brandtype, capacity, enginepower, number, numberofseats, vehicletype, year)  values" +
                    " ('" + vehicle.vehicleID + "','" + vehicle.brand + "','" + vehicle.brandType + "','" + vehicle.capacity + "','" + vehicle.enginePower + "','" + vehicle.number + "','" + vehicle.numberOfSeats+ "','" + vehicle.vehicleType + "','" + vehicle.year + "')");
                return true;
            }
            else return false;
        }

        public static void DeleteVehicle(string vehicleID)
        {
            ISession session = SessionManager.GetSession();
            //Computer computer = new Computer();

            if (session == null)
                return;



            RowSet vehicleData = session.Execute("delete from \"Vehicle\" where \"vehicleID\" = '" + vehicleID + "'");

        }
        #endregion

        #region Device

        public static Device GetDevice(string deviceID)
        {
            ISession session = SessionManager.GetSession();
            Device device = new Device();

            if (session == null)
                return null;

            Row deviceData = session.Execute("select * from \"Device\" where \"deviceID\"='" + deviceID + "'").FirstOrDefault();

            if (deviceData != null)
            {
                device.deviceID = deviceData["deviceID"] != null ? deviceData["deviceID"].ToString() : string.Empty;
                device.officeID = deviceData["officeID"] != null ? deviceData["officeID"].ToString() : string.Empty;
                device.name = deviceData["name"] != null ? deviceData["name"].ToString() : string.Empty;
                device.type = deviceData["type"] != null ? deviceData["type"].ToString() : string.Empty;
                device.material = deviceData["material"] != null ? deviceData["material"].ToString() : string.Empty;
                device.number = deviceData["number"] != null ? deviceData["number"].ToString() : string.Empty;
                device.size = deviceData["size"] != null ? deviceData["size"].ToString() : string.Empty;
                device.purpose = deviceData["purpose"] != null ? deviceData["purpose"].ToString() : string.Empty;
                device.accessories = deviceData["accessories"] != null ? deviceData["accessories"].ToString() : string.Empty;
                device.purchaseDate = deviceData["purchasedate"] != null ? deviceData["purchasedate"].ToString() : string.Empty;


            }
            else device = null;

            return device;
        }

        public static List<Device> GetDevices()
        {
            ISession session = SessionManager.GetSession();
            List<Device> devices = new List<Device>();


            if (session == null)
                return null;

            var devicesData = session.Execute("select * from \"Device\"");


            foreach (var deviceData in devicesData)
            {
                Device device = new Device();

                device.deviceID = deviceData["deviceID"] != null ? deviceData["deviceID"].ToString() : string.Empty;
                device.officeID = deviceData["officeID"] != null ? deviceData["officeID"].ToString() : string.Empty;
                device.name = deviceData["name"] != null ? deviceData["name"].ToString() : string.Empty;
                device.type = deviceData["type"] != null ? deviceData["type"].ToString() : string.Empty;
                device.material = deviceData["material"] != null ? deviceData["material"].ToString() : string.Empty;
                device.number = deviceData["number"] != null ? deviceData["number"].ToString() : string.Empty;
                device.size = deviceData["size"] != null ? deviceData["size"].ToString() : string.Empty;
                device.purpose = deviceData["purpose"] != null ? deviceData["purpose"].ToString() : string.Empty;
                device.accessories = deviceData["accessories"] != null ? deviceData["accessories"].ToString() : string.Empty;
                device.purchaseDate = deviceData["purchasedate"] != null ? deviceData["purchasedate"].ToString() : string.Empty;

                 devices.Add(device);
            }

            return devices;
        }

        public static bool AddDevice(Device device)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;


            if (device != null)
            {
                RowSet deviceData = session.Execute("insert into \"Device\" (\"deviceID\", accessories, material, name, number, \"officeID\", purchasedate, purpose, size, \"type\")  values " +
                    "('" + device.deviceID + "', '" + device.accessories + "','" + device.material + "','" + device.name + "','" + device.number + "','" + device.officeID + "','" + device.officeID + "','" + device.purchaseDate + "','" + device.size + "','" + device.type + "')");
                return true;
            }
            else return false;
        }

        public static void DeleteDevice(string deviceID)
        {
            ISession session = SessionManager.GetSession();
            //Computer computer = new Computer();

            if (session == null)
                return;



            RowSet deviceData = session.Execute("delete from \"Device\" where \"deviceID\" = '" + deviceID + "'");

        }
        #endregion

        #region Furniture

        public static Furniture GetFurniture(string furnitureID)
        {
            ISession session = SessionManager.GetSession();
            Furniture furniture = new Furniture();

            if (session == null)
                return null;

            Row furnitureData = session.Execute("select * from \"Furniture\" where \"furnitureID\"='" + furnitureID + "'").FirstOrDefault();

            if (furnitureData != null)
            {
                furniture.furnitureID = furnitureData["furnitureID"] != null ? furnitureData["furnitureID"].ToString() : string.Empty;
                furniture.officeID = furnitureData["officeID"] != null ? furnitureData["officeID"].ToString() : string.Empty;
                furniture.type = furnitureData["type"] != null ? furnitureData["type"].ToString() : string.Empty;
                furniture.material = furnitureData["material"] != null ? furnitureData["material"].ToString() : string.Empty;
                furniture.colour = furnitureData["colour"] != null ? furnitureData["colour"].ToString() : string.Empty;
                furniture.number = furnitureData["number"] != null ? furnitureData["number"].ToString() : string.Empty;
                furniture.purchaseDate = furnitureData["purchasedate"] != null ? furnitureData["purchasedate"].ToString() : string.Empty;


            }
            else furniture = null;

            return furniture;
        }

        public static List<Furniture> GetFurnitures()
        {
            ISession session = SessionManager.GetSession();
            List<Furniture> furnitures = new List<Furniture>();


            if (session == null)
                return null;

            var furniutresData = session.Execute("select * from \"Furniture\"");


            foreach (var furnitureData in furniutresData)
            {
                Furniture furniture = new Furniture();

                furniture.furnitureID = furnitureData["furnitureID"] != null ? furnitureData["furnitureID"].ToString() : string.Empty;
                furniture.officeID = furnitureData["officeID"] != null ? furnitureData["officeID"].ToString() : string.Empty;
                furniture.type = furnitureData["type"] != null ? furnitureData["type"].ToString() : string.Empty;
                furniture.material = furnitureData["material"] != null ? furnitureData["material"].ToString() : string.Empty;
                furniture.colour = furnitureData["colour"] != null ? furnitureData["colour"].ToString() : string.Empty;
                furniture.number = furnitureData["number"] != null ? furnitureData["number"].ToString() : string.Empty;
                furniture.purchaseDate = furnitureData["purchasedate"] != null ? furnitureData["purchasedate"].ToString() : string.Empty;

                furnitures.Add(furniture);
            }

            return furnitures;
        }

        public static bool AddFurniture(Furniture furniture)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;


            if (furniture == null)
            {
                return false;
            }
            else
            {
                RowSet furnitureData = session.Execute("insert into \"Furniture\"(\"furnitureID\", colour, material, number, \"officeID\", purchasedate, \"type\")  values" +
                    " ('" + furniture.furnitureID + "', '" + furniture.colour + "','" + furniture.material + "','" + furniture.number + "','" + furniture.officeID + "','" + furniture.purchaseDate + "','" + furniture.type + "')");
                return true;
            }
        }

        public static void DeleteFurniture(string furnitureID)
        {
            ISession session = SessionManager.GetSession();
            //Computer computer = new Computer();

            if (session == null)
                return;



            RowSet furnitureData = session.Execute("delete from \"Furniture\" where \"furnitureID\" = '" + furnitureID + "'");

        }
        #endregion

        #region Contract

        public static Contract GetContract(string contractID)
        {
            ISession session = SessionManager.GetSession();
            Contract contract = new Contract();      

            if (session == null)
                return null;

            Row contractData = session.Execute("select * from \"Contract\" where \"contractID\"='" + contractID + "'").FirstOrDefault();

            if (contractData != null)
            {
                contract.contractID = contractData["contractID"] != null ? contractData["contractID"].ToString() : string.Empty;
                contract.name = contractData["name"] != null ? contractData["name"].ToString() : string.Empty;
                contract.type = contractData["type"] != null ? contractData["type"].ToString() : string.Empty;
                contract.value = contractData["value"] != null ? contractData["value"].ToString() : string.Empty;
                contract.country = contractData["country"] != null ? contractData["country"].ToString() : string.Empty;
                contract.companyName = contractData["companyname"] != null ? contractData["companyname"].ToString() : string.Empty;
                contract.subject = contractData["subject"] != null ? contractData["subject"].ToString() : string.Empty;
                contract.startTime = contractData["starttime"] != null ? contractData["starttime"].ToString() : string.Empty;
                contract.endTime = contractData["endtime"] != null ? contractData["endtime"].ToString() : string.Empty;
                contract.description = contractData["description"] != null ? contractData["description"].ToString() : string.Empty;


            }
            else contract = null;

            return contract;
        }

        public static List<Contract> GetContracts()
        {
            ISession session = SessionManager.GetSession();
            List<Contract> contracts = new List<Contract>();


            if (session == null)
                return null;

            var contractsData = session.Execute("select * from \"Contract\"");


            foreach (var contractData in contractsData)
            {
                Contract contract = new Contract();

                contract.contractID = contractData["contractID"] != null ? contractData["contractID"].ToString() : string.Empty;
                contract.name = contractData["name"] != null ? contractData["name"].ToString() : string.Empty;
                contract.type = contractData["type"] != null ? contractData["type"].ToString() : string.Empty;
                contract.value = contractData["value"] != null ? contractData["value"].ToString() : string.Empty;
                contract.country = contractData["country"] != null ? contractData["country"].ToString() : string.Empty;
                contract.companyName = contractData["companyname"] != null ? contractData["companyname"].ToString() : string.Empty;
                contract.subject = contractData["subject"] != null ? contractData["subject"].ToString() : string.Empty;
                contract.startTime = contractData["starttime"] != null ? contractData["starttime"].ToString() : string.Empty;
                contract.endTime = contractData["endtime"] != null ? contractData["endtime"].ToString() : string.Empty;
                contract.description = contractData["description"] != null ? contractData["description"].ToString() : string.Empty;

                contracts.Add(contract);
            }

            return contracts;
        }

        public static bool AddContract(Contract contract)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;


            if (contract == null)
            {
                return false;
            }
            else
            {
                RowSet contractData = session.Execute("insert into \"Contract\" (\"contractID\", companyname, country, description, endtime, name, starttime, subject, \"type\", value)  values" +
                    " ('" + contract.contractID + "','" + contract.companyName + "','" + contract.country + "','" + contract.description + "','" + contract.endTime + "','" + contract.name + "','" + contract.startTime + "','" + contract.subject + "','" + contract.type + "','" + contract.value + "')");
                return true;
            }
        }

        public static void DeleteContract(string contractID)
        {
            ISession session = SessionManager.GetSession();
            //Computer computer = new Computer();

            if (session == null)
                return;



            RowSet furnitureData = session.Execute("delete from \"Contract\" where \"contractID\" = '" + contractID + "'");

        }
        #endregion

        #region Office

        public static Office GetOffice(string officeID)
        {
            ISession session = SessionManager.GetSession();
            Office office = new Office();

            if (session == null)
                return null;

            Row officeData = session.Execute("select * from \"Office\" where \"officeID\"='" + officeID + "'").FirstOrDefault();

            if (officeData != null)
            {
                office.officeID = officeData["officeID"] != null ? officeData["officeID"].ToString() : string.Empty;
                office.name = officeData["name"] != null ? officeData["name"].ToString() : string.Empty;
                office.fieldOfWork = officeData["fieldofwork"] != null ? officeData["fieldofwork"].ToString() : string.Empty;
                office.city = officeData["city"] != null ? officeData["city"].ToString() : string.Empty;
                office.country = officeData["country"] != null ? officeData["country"].ToString() : string.Empty;
                office.streetAndNumber = officeData["streetandnumber"] != null ? officeData["streetandnumber"].ToString() : string.Empty;
                office.numberOfRooms = officeData["numberofrooms"] != null ? officeData["numberofrooms"].ToString() : string.Empty;
                office.maxNumberOfWorkers = officeData["maxnumberofworkers"] != null ? officeData["maxnumberofworkers"].ToString() : string.Empty;


            }
            else office = null;

            return office;
        }

        public static List<Office> GetOffices()
        {
            ISession session = SessionManager.GetSession();
            List<Office> offices = new List<Office>();


            if (session == null)
                return null;

            var officesData = session.Execute("select * from \"Office\"");


            foreach (var officeData in officesData)
            {
                Office office = new Office();

                office.officeID = officeData["officeID"] != null ? officeData["officeID"].ToString() : string.Empty;
                office.name = officeData["name"] != null ? officeData["name"].ToString() : string.Empty;
                office.fieldOfWork = officeData["fieldofwork"] != null ? officeData["fieldofwork"].ToString() : string.Empty;
                office.city = officeData["city"] != null ? officeData["city"].ToString() : string.Empty;
                office.country = officeData["country"] != null ? officeData["country"].ToString() : string.Empty;
                office.streetAndNumber = officeData["streetandnumber"] != null ? officeData["streetandnumber"].ToString() : string.Empty;
                office.numberOfRooms = officeData["numberofrooms"] != null ? officeData["numberofrooms"].ToString() : string.Empty;
                office.maxNumberOfWorkers = officeData["maxnumberofworkers"] != null ? officeData["maxnumberofworkers"].ToString() : string.Empty;

                offices.Add(office);
            }

            return offices;
        }

        public static bool AddOffice(Office office)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;


            if (office != null)
            {
                RowSet computerData = session.Execute("insert into \"Office\" (\"officeID\", city, country, fieldofwork, maxnumberofworkers, name, numberofrooms, streetandnumber)" +
                    "  values ('" + office.officeID + "', '" + office.city + "', '" + office.country + "', '" + office.fieldOfWork + "', '" + office.maxNumberOfWorkers + "', '" + office.name + "', '" + office.numberOfRooms + "','" + office.streetAndNumber + "')");
                return true;
            }
            else return false;
        }

        public static void DeleteOffice(string officeID)
        {
            ISession session = SessionManager.GetSession();
            //Computer computer = new Computer();

            if (session == null)
                return;



            RowSet officeData = session.Execute("delete from \"Office\" where \"officeID\" = '" + officeID + "'");

        }



        public static string[] GetOfficeRecords(string officeID)
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            Row officeData = session.Execute("select * from \"Office\" where \"officeID\"='" + officeID + "'").FirstOrDefault();

            return (string[])officeData["records"];

        }

        public static void AddOfficeRecords(List<string> record, string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            string forExecute = "";

            foreach (string str in record)
            {
                if (str == record[0])
                {
                    forExecute = forExecute + "'" + str + "'";
                }
                else forExecute = forExecute + ",'" + str + "'";
            }


            RowSet workerData = session.Execute("UPDATE \"Office\" SET records =[" + forExecute + "] WHERE \"officeID\" = '" + id + "'; ");

        }
            #endregion

        #region Login

            public static Login GetUser(string username)
        {
            ISession session = SessionManager.GetSession();
            Login login = new Login();

            if (session == null)
                return null;

            Row loginData = session.Execute("select * from \"Login\" where \"Username\"='" + username + "'").FirstOrDefault();

            if (loginData != null)
            {
                login.username = loginData["Username"] != null ? loginData["Username"].ToString() : string.Empty;
                login.password = loginData["password"] != null ? loginData["password"].ToString() : string.Empty;


            }
            else login = null;
            

            return login;
        }

        public static void AddUser(Login login)
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return;



            RowSet computerData = session.Execute("insert into \"Login\" (\"Username\", password)  values ('" + login.username + "', '" + login.password + "')");

        }

        #endregion

    }

}
