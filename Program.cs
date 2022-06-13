using System;

using static System.Console; 

namespace QueenslandCompetitionApp

{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Display competition motto// 
            WriteLine("########*************************########");
            WriteLine("###***The stars shine in Queensland***###");
            WriteLine("########*************************########");
            WriteLine("");

            //Task 2//

            //Task 2.1. Prompt user for the number of adult, child and senior tickets sold//

            int adultNo, childNo, seniorNo;
            Write("Enter number of adult tickets sold: ");
            adultNo = Convert.ToInt32(ReadLine());
            Write("Enter number of children tickets sold: ");
            childNo = Convert.ToInt32(ReadLine());
            Write("Enter number of senior tickets sold: ");
            seniorNo = Convert.ToInt32(ReadLine());


            //Task 2.2. Allow user to enter valid values so the program checks for a valid value//
            //e.g. if each adult ticket = $20.00, each child ticket costs 50% of adult ticket//
            // and a senior ticket costs 70%//

            const double adultFee = 20.00;
            const double childFee = 0.50 * adultFee;
            const double seniorFee = 0.70 * adultFee;


            //Task 2.3 Compute and display the revenue from selling tickets for competition//
            //Task 2.4 Display output in currency format// 


            double revenue;
            revenue = ((adultNo * adultFee) + (childNo * childFee) + (seniorNo * seniorFee));

            WriteLine("Revenue of tickets sold is {0}", revenue.ToString("C"));

            //Task 3//

            //Task 3.1 Display the number of tickets for adults, children, and seniors, and display a statement//
            //showing a statistic of vistors attending//

            int totalNo;
            totalNo = adultNo + childNo + seniorNo;

            WriteLine("The number of tickets sold are as follows: {0} for adults, {1} for children, and {2} for seniors.", adultNo, childNo, seniorNo);
            WriteLine("The statistics of total visitors attending is {0}.", totalNo);


            //Task 3.2 If the number of adult tickets is smaller than or equal to the total of children's and senior//
            //tickets, the app should display 'The competition is becoming a festival for everyone!"//

            //Task 3.3 If the number of children's tickets is greater than or equal to senior tickets, the app should//
            //display 'The competition is attracting more and more young people!"

            //Task 3.4 In other cases, the app should display 'The competition should have more space for kids!"//



            if (adultNo > (childNo + seniorNo))
            {
                if (childNo > seniorNo)
                {
                    WriteLine("The competition is attracting more and more young people!");
                }
                    else
                {
                    WriteLine("The competition should have more space for kids!");
                }
            }
            else if (adultNo <= (childNo + seniorNo))
            {
                if (childNo > seniorNo) 
                {
                    WriteLine("The competition is becoming a festival for everyone!");
                    WriteLine("The competition is attracting more and more young people!");
                }
                    else
                {
                    WriteLine("The competition is becoming a festival for everyone!");
                    WriteLine("The competition should have more space for kids!");
                }
            }


        }

    }
}



