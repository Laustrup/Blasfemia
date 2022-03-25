using System;
using System.Collections;
using System.Collections.Generic;
using creatures;
using buildings;
using religions;
using subservices;

namespace entities;

public class Community : BehaviourEntity {

    private Religion religion {get;}

    private List<Follower> followers {get;}
    private List<Building> buildings {get;}
    private List<God> gods {get;}

    private Boolean isMonotheism {get;}

    private Calendar calendar {get;}

    private float faith {get;}
    private float loyalty {get;}
    private float happiness {get;}

    private double wealth {get; set;}
    private double income {get; set;}
    private double taxPercentage {get; set;}

    private CommunityService communityService = new CommunityService();

    public Community(string title, string description,
                    Religion religion, List<God> gods,
                    double taxPercentage) : base(title,description) {

        this.religion = religion;
        this.gods = gods;

        if (gods.Count==1) {isMonotheism=true;}
        else if (gods.Count>1) {isMonotheism=false;}

        followers = new List<Follower>();
        buildings = new List<Building>();

        wealth = 0;
        this.taxPercentage = taxPercentage;

    }

    public void Update() {

        commandmentEffectFollowers();
        faith = communityService.calculateFaith();
        loyalty = communityService.calculateLoyalty();
        happiness = communityService.calculateHappiness();
        income = communityService.calculateIncome();
    }

    private void commandmentEffectFollowers() {
        for (int i = 0; i < followers.Count; i++) {
            followers.get(i).commandmentsEffect(List<Commandments> religion.getCommandments());
        }
    }

    private double payTaxes() {
        wealth += income;
        return wealth;
    }
    
    public Calendar endOfDay() {
        calendar.next();
        payTaxes();
        return calendar;
    }

    public class Calendar {

        private List<CalendarSection> sections {get;}
        private string title {get;set;}

        public Calendar(string title, List<CalendarSection> sections) {
            this.title = title;    
            this.sections = sections;
        }

        public void next() {
            for (int i = sections.size(); i > 0;i--) {
                if (sections.get(i).getValue()!=sections.get(i).getAllowedLength()) {
                    sections.get(i).incrementValue();
                    break;
                }
            }
        } 

        private class CalendarSection {

            private int value {get;}
            private int allowedLength {get;}
            private string title {get;}

            public CalendarSection(int value, int allowedLength, string title) {
                this.value = value;
                this.allowedLength = allowedLength;
                this.title = title;
            }

            public int incrementValue() {
                if (value!=allowedLength) {value++;}
                return value;
            }
        }
    }
}