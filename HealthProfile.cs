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
    public class HealthProfileClass
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string gender {get; set;}
        public int birthMonth{get; set;}
        public int birthDay{get; set;}
        public int birthYear{get; set;}
        public int heightFeet{get; set;}
        public int heightInches{get; set;}
        public int weight{get; set;}
        public int maxHeartRate {get; set;}
        public string targetHeartRate{get; set;}

        public HealthProfileClass( string fName, string lName, string gder, int bMonth, int bDay , int bYear, int hFeet, int hInches, int wght){
            firstName = fName;
            lastName = lName;
            gender = gder;
            birthMonth = bMonth;
            birthDay = bDay;
            birthYear = bYear;
            hFeet = heightFeet;
            hInches = heightInches;
            weight = wght;
        }

        public HealthProfileClass(string fName, string lName){
            firstName = fName;
            lastName = lName;

        }

        
    }
}