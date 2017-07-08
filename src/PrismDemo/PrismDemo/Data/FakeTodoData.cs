﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismDemo.Models;

namespace PrismDemo.Data
{
/// <summary>
    ///     Holds the fake data
    /// </summary>
    public static class FakeTodoData
    {
        private static List<TodoItem> _fakeData;

        /// <summary>
        ///     Gets the fake data.
        /// </summary>
        /// <value>The data.</value>
        public static List<TodoItem> FakeData
        {
            get
            {
                if (_fakeData == null)
                {
                    _fakeData = new List<TodoItem>()
                    {

                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-34),
                            Name = "Read book for 15 minutes",
                            Description = "I want to start reading Gabriel Garcia Marquez",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-30),
                            Name = "Finish organizing craft cabinet",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-2),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-29),
                            Name = "Talk to Mom",
                            Description = "About new house",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-45),
                            Name = "Finish one load of laundry",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-22),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-18),
                            Name = "Fix desk",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-27),
                            Name = "Spend time as a family – picnic",
                            Description = "Maybe in the north of the town",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-30),
                            Name = "Collate receipts to update April’s budget",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-24),
                            Name = "Work on e-book",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-12),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-39),
                            Name = "Write two blog posts",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-29),
                            Name = "Make grocery list",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-22),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-17),
                            Name = "Wake up early",
                            Description =  "I am a big fan of waking at 5am and spending time working on myself before going to work.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-36),
                            Name = "Exercise",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-50),
                            Name = "Rewrite goals",
                            Description = "About life",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-33),
                            Name = "Read motivational material",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-21),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-44),
                            Name = "Write a “To Do” List",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-22),
                            Name = "Check the News Headlines",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-21),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-44),
                            Name = "Write a blog about food",
                            Description = "Spicy food mainly",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-24),
                            Name = "Take time to look good",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-31),
                            Name = "Go to bed at a reasonable time",
                            Description = "Maximum at 1am",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-41),
                            Name = "Write a book about travelling in India",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-32),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-46),
                            Name = "Go to the gym 3 times a week",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-42),
                            Name = "Run a marathon",
                            Description = "First is in Madrid",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-41),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-23),
                            Name = "Travel to Colombia",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-23),
                            Name = "Cook for the children",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-15),
                            Name = "Buy a new guitar",
                            Description = "Get a Fender",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-32),
                            Name = "Buy a new car",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-11),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-19),
                            Name = "Get a new job",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-32),
                            Name = "Pay the electricity bills ",
                            Description = "200$",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-2),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-23),
                            Name = "Sell my house",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-41),
                            Name = "Rent an office",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-19),
                            Name = "Walk around the lake",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-14),
                            Name = "Visit my relatives in Scotland",
                            Description = "Summer time",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-10),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-18),
                            Name = "Buy Swiss chocolate",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-13),
                            Name = "Tidy my room",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-12),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-25),
                            Name = "Clean the fridge",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-25),
                            Name = "Repair the kitchen door",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-34),
                            Name = "Prepare my speech for my brother's weeding",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-50),
                            Name = "Travel to Sweden",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-44),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-36),
                            Name = "Prepare my Chinese exam",
                            Description = "Advanced level",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-50),
                            Name = "Study Portuguese",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-2),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-21),
                            Name = "Download new app for chatting",
                            Description = "WeChat",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-22),
                            Name = "Paint my house",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-30),
                            Name = "Plan the next two years of investment",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-24),
                            Name = "Plan to have children",
                            Description = "Maybe two, a boy and a girl",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-1),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-44),
                            Name = "Go to the waterpark with the family",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-27),
                            Name = "Go to New York on a business trip",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-22),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-47),
                            Name = "Attend to Jaime's party ",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-12),
                            Name = "Think carefully about moving abroad",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-43),
                            Name = "Getting a diploma in Business Administration",
                            Description = "I plan to go to study to Barcelona",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-48),
                            Name = "Get my nails done",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-8),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-44),
                            Name = "Visit Hawaii for a few days",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-14),
                            Name = "Buy candies for my niece",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-7),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-18),
                            Name = "Get a ticket for the next week of Bruno Mars",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-49),
                            Name = "Top up my subway card",
                            Description = "20$",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-28),
                            Name = "Sell my old phone",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-30),
                            Name = "Buy coffee",
                            Description = "Italian coffee",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-9),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-35),
                            Name = "Visit mom and dad",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-11),
                            Name = "Drink 2 litres of water a day",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-1),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-34),
                            Name = "Buy a keyboard",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-44),
                            Name = "Go to the Museum of Modern Art",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-10),
                            Name = "Find my friend house keys",
                            Description = "They should be somewhere in my room",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-48),
                            Name = "Set up a company in Luxembourg",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-45),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-30),
                            Name = "Fix TV antenna",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-34),
                            Name = "Go out with Mark next week",
                            Description = "Take him to the opera",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-33),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-40),
                            Name = "Record a video of myself surfing",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-16),
                            Name = "Learn how to make my own beer",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-37),
                            Name = "Go for a walk with Tracy",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-24),
                            Name = "Get healthy food for my cat",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-20),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-45),
                            Name = "Sell my camera",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-39),
                            Name = "Go for a picnic to the river",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-29),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-15),
                            Name = "Call to my Internet Provider",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-11),
                            Name = "Take the garbage out",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-48),
                            Name = "Find an USB cable for my phone",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-16),
                            Name = "Get a flight to Bahamas",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-15),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-26),
                            Name = "Leave the house in perfect conditions",
                            Description = "It as to be cleaned by the 15th of this month",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-18),
                            Name = "Find a boyfriend",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-17),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-46),
                            Name = "Feed my dog",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-22),
                            Name = "Eat as much pasta as I can",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-33),
                            Name = "Buy a ring to Mary",
                            Description = "A diamond one",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-33),
                            Name = "Get some fresh flowers",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-32),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-15),
                            Name = "Read a book in the park",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-36),
                            Name = "Listen to the latest Foo Fighters album",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-27),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-19),
                            Name = "Ride my bike to the office every morning",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-37),
                            Name = "Play my new brand videogame with friends",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-49),
                            Name = "Send an email to Charles",
                            Description = "I need to remember him I will go to the club on Sunday",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-42),
                            Name = "Get a pair of shoes",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-28),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-13),
                            Name = "Travel around Spain",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-15),
                            Name = "Arrange a football match at the office",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-12),
                        },
                        new TodoItem
                        {
                            Created = DateTime.Now.AddDays(-50),
                            Name = "Play tennis with dad",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-40),
                            Name = "Go out to Eduard's bar",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.InProgress
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-33),
                            Name = "Leave a good tip to the restaurant manager",
                            Description = "Around 10$",
                            TodoStatus = TodoStatus.Open
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-12),
                            Name = "Get some medicines for my back pain",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut pretium suscipit ante, eu sodales arcu. Vivamus sodales purus faucibus lacus eleifend, vel convallis elit finibus.",
                            TodoStatus = TodoStatus.Closed,
                            CompletionDate = DateTime.Now.AddDays(-2),
                        },
                        new TodoItem
                        {

                            Created = DateTime.Now.AddDays(-33),
                            Name = "Visit my grandmother",
                            Description = "Some time around May",
                            TodoStatus = TodoStatus.InProgress
                        },
                    };
                }

                return _fakeData;
            }

            set { _fakeData = value; }
        }
    }
}
