namespace PolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // without polymorphism

            SalariedEmployee salEmp = new SalariedEmployee(101, "John", 1000);
            Console.WriteLine(salEmp);
            Console.WriteLine($"\nEarnings = {salEmp.Earnings():C}\n\n");

            HourlyEmployee hrEmp = new HourlyEmployee(102, "Anne", 50, 20);
            Console.WriteLine(hrEmp);
            Console.WriteLine($"\nEarnings = {hrEmp.Earnings():C}\n\n");

            CommissionEmployee commEmp = new CommissionEmployee(103, "Mark", 10000, 0.15);
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings = {commEmp.Earnings():C}\n\n");


            Console.WriteLine("\n\n\n");



            // with polymorphism

            Employee emp;

            emp = new SalariedEmployee(101, "John", 1000);
            Console.WriteLine(emp);
            Console.WriteLine($"\nEarnings = {emp.Earnings():C}\n\n");

            emp = new HourlyEmployee(102, "Anne", 50, 20);
            Console.WriteLine(emp);
            Console.WriteLine($"\nEarnings = {emp.Earnings():C}\n\n");

            emp = new CommissionEmployee(103, "Mark", 10000, 0.15);
            Console.WriteLine(emp);
            Console.WriteLine($"\nEarnings = {emp.Earnings():C}\n\n");

            Console.WriteLine("\n\n\n");



            // real-life use of polymorphism

            Employee[] employees = new Employee[3];
            employees[0] = new SalariedEmployee(101, "John", 1000);
            employees[1] = new HourlyEmployee(102, "Anne", 50, 20);
            employees[2] = new CommissionEmployee(103, "Mark", 10000, 0.15);

            foreach (Employee em in employees)
            {
                Console.WriteLine(em);
                Console.WriteLine($"\nEarnings = {em.Earnings():C}\n\n");
            }
        }
    }
}
