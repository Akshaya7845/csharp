//factory method patten example:
using System;
namespace LoanFactoryExample
{
    public abstract class Loan
    {
        public abstract void ApplyLoan();
    }
    public class HomeLoan : Loan
    {
        public override void ApplyLoan()
        {
            Console.WriteLine("Home loan applied successfully!");
        }
    }
    public class CarLoan : Loan
    {
        public override void ApplyLoan()
        {
            Console.WriteLine("car loan applied successfully!");
        }
    }
    public class EducationLoan : Loan
    {
        public override void ApplyLoan()
        {
            Console.WriteLine("education loan applied successfully!");
        }
    }
    public class LoanFactory
    {
        public Loan GetLoan(string loanType)
        {
            switch (loanType.ToLower())
            {
                case "home":
                    return new HomeLoan();
                case "car":
                    return new CarLoan();
                case "education":
                    return new EducationLoan();
                default:
                    throw new ArgumentException("Invalid loan type. Please enter home, car, or education.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create factory instance
            LoanFactory factory = new LoanFactory();

            Console.WriteLine("Loan application system!");
            Console.Write("enter loan type (home/car/education): ");
            string loanType = Console.ReadLine();

            try
            { 
                Loan loan = factory.GetLoan(loanType);
                loan.ApplyLoan();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
