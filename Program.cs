using System;

/** Computerizing health records could make it easier for patients to share their health profiles and histories among their various health-care professional. 
this could improve the quality of health care, help avoid drug conflicts and erroneous drug prescriptions, reduce costs and, in emergencies, could save lives. In this exercise, you'll design a "starter" Healthprofile class for a person. 
The class attributes should include the person's first name, last name, gender, date of birth (consisting of separate attributes for the month,day, and year of birth), height (in inches) and weight (in pounds). Your class should have a constructor that receives this data. 
For each attribute provide a property with set and get accessors. 
the class also should include methods that calculate and return the user's age in years, maximum heart rate and target-heart-rate range (see Exercise 4.14), and body mass index (BMI: see Exercise 3.31). Write an app that prompts for the person's information, 
instantiates an object of class Healthprofile for that person and displays 
the information from that object--including the person's first name, last name, gender, date of birth, height and weight -- 
then calculates and displays the person's age in years, BMI, maximum heart rate and target-heart-rate range. It should also display the "BMI values" chart from Exercise 3.31)*/


namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hospital Console!");
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            

            Console.WriteLine ("Please enter your M of male and F for Female:");
            char sex = char.Parse(Console.ReadLine());
            

            Console.WriteLine("Please enter birth month in two digits:");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birth day in two digits:");
            int birthDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birth year in four digits");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height:");
            Console.WriteLine("Feet:");
            int heightFeet = int.Parse(Console.ReadLine());

            Console.WriteLine("Inches");
            int heightInches = int.Parse(Console.ReadLine());   

            Console.WriteLine("Weight");
            int weight = int.Parse(Console.ReadLine());         

            

           string genderPrint(char sex){
               if(sex == 'm'){
                   return "Male";

               }else{
                   return "Female";
               }
           }

           int bmiCalculator(int weight, int heightFeet, int heightInches){

               int totalInches = (heightFeet *12) + heightInches;
              
               int BMI = ((weight * 705) / totalInches) / totalInches;
               
               return BMI;
           }

        var today = DateTime.Today;

        var age = today.Year - birthYear;

      

           



            HealthProfileClass profile1 = new HealthProfileClass(firstName,lastName, genderPrint(sex),birthMonth,birthDay, birthYear,heightFeet, heightInches, weight);


            Console.WriteLine($"Thank You: {profile1.firstName} {profile1.lastName} for entering your information!");
            Console.WriteLine($"Please confirm if this info is correct \n First Name: {profile1.firstName} \n Last Name: {profile1.lastName} \n Gender: {profile1.gender} \n Age: {age}");

            bmiCalculator(weight,heightFeet,heightInches);

            
           
        }
    }
}
