using System;

namespace Tema
{
    public class City {
        private string name;
        Streets street; 
        Parks park;
        Buildings building;
        Schools school;
        Cars car;
        public City(String name,Cars car, Streets street, Parks park, Buildings building, Schools school) {
            this.name = name; this.street = street; this.school = school;this.park = park; this.building = building;this.car = car;
        }
     public string ToString() { return name+" city["+street.ToString()+car.ToString()+"]"; }
}
    public class Cars
    { private string ID;
        private int capacity;
        public Cars(string ID, int capacity) {
            this.capacity = capacity;
            this.ID = ID;
        }
        public string ToString() { return ID+", seat("+capacity+")"; }
    

    }
    public class Streets {
        private string name;
     private Buildings building;
        private Parks park;
        public Streets(string name, Buildings building,Parks park) { this.name = name;this.building = building; this.park = park; }
        public string ToString() { return "Street name:" + name + " with one " + building.ToString() + " and a park(" + park.ToString()+ ")"; }
    }
    public class Parks
    {
        private int size;
        private string name;
        public Parks(string name,int size)
        {
            this.name = name; this.size = size;

        }
        public string ToString() { return name+", size "+size; }
    }

    public class Buildings
    {
        public string type;
        public Buildings(string type)
        {
            this.type = type;

        }
        public string ToString() { return type; }


    }
    public class Schools 
    {
        public string name;
        public int nrStudents,nrProfessors;
        public Schools(string name, int nrStudents, int nrProfessors) {
            this.name = name; this.nrProfessors = nrProfessors;this.nrStudents = nrStudents; }
        public string ToString() { return name+" with "+nrProfessors+" professor and "+nrStudents+" student "; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schools school = new Schools("Emanuel", 250, 15);
            Buildings building = new Buildings("house");
            Parks park = new Parks("Jurassic", 150);
            Streets street = new Streets("St. Peter", building, park);
            Cars car = new Cars("SJ 01 BIG", 5);
            City city = new City("Oradea",car, street, park, building, school);
            Console.WriteLine(city.ToString());
        }
    }
}
