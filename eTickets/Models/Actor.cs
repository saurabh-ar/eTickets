using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    //Actor Model
    public class Actor
    {
        [Key] 
        public int Id { get; set; }  //Unique Indentifier for an Actor

        //Actor has three properties thats going to be translated to three rows in table
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
