using PartyInvite.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvite.Models
{
    public static class Respository
    {
        public class GuestResponse
        {
            [Required(ErrorMessage = "Please enter your name")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Please enter your email address")] [RegularExpression(".+@.+..+", ErrorMessage = "Please enter a valid email address")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Please enter your phone number")]
            public string Phone { get; set; }
            [Required(ErrorMessage = "Please specify whether you’ll attend")]
            public bool? WillAttend { get; set; }
        }
    }

    private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}


    

