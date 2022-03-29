using System;
using System.Collections.Generic;
using entities;
using UnityEngine.Assertions;
using Xunit;

namespace tests;

public class CalendarTest
{

    private Calendar calendar { get; set; }
    
    /*  Constructs a Calendar for every [InlineData()].
     *  First parameter is title of calendar, second is whether calendar is randomly or not.
     *  sectionTitle and allowLength is at the beginning of every collection of values. 
     */
    [InlineData("Christian", "isDefault",
        "January", "12",
        "Day", "30",
        "Hours", "24",
        "Minutes", "60",
        "Seconds", "60",
        "Milliseconds", "1000")]
    public void Construct_Test(params string[] parameters)
    {
        // Arrange
        List<Calendar.CalendarSection> sections;
        if (parameters[1] == "isRandom")
        {
            sections = Generate_Random_Sections();
        }
        else
        {
            sections = Generate_Default_Sections(parameters);
        }

        // Act
        calendar = new Calendar(parameters[0],sections);
        
        // Assert
        Assert.Equal(calendar.Title,parameters[0]);

        calendar = null;
    }
    private List<Calendar.CalendarSection> Generate_Random_Sections()
    {
        List<Calendar.CalendarSection> sections = new List<Calendar.CalendarSection>();
        Random random = new Random();
        bool withLeapYear = random.Equals(random.Next(0,1) == 1);

        // Max length of the mayan calendar years
        for (long i = 0; i < random.Next(1, 5125); i++)
        {
            
        }

        return sections;
    }

    private List<Calendar.CalendarSection> Generate_Default_Sections(string[] parameters)
    {
        for (int i = 1; i < parameters.Length; i++) // Skips first index, since it's the title of the calendar
        {
            try { sections.Add(new Calendar.CalendarSection(parameters[i], int.Parse(parameters[i + 1]),
                int.Parse(parameters[i + 2]))); }
            catch { Console.WriteLine("Something went wrong when Arranging sections in Construct_Test at index " + i + "..."); }
        }
    }
    
    
    [Fact]
    [InlineData()]
    public void Next_Test()
    {
        // Arrange
        
        
        // Act
        
        // Assert
        Assert.Equal();
    }
}