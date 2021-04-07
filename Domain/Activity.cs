using System;
namespace Domain
{
    //when we return Activity, we are going to return an object with all these properties
    //it will also become columns in the activies database 
    public class Activity
    {
        //generate from client side,
        //advantage: don't need to database server to generate id for us and wait
        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string City{ get; set; }

        public string Venue { get; set; }
    }
}
