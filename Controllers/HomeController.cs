using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ViewModels.Models;

namespace ViewModels
{
    public class HomeController : Controller
    {
        // main index page to display a string message //
        [HttpGet("")]
        public ViewResult Index()
        {
            string message = "Etiam laorizzle urna dizzle nisl. Own yo' quis arcu. Fo shizzle yo, fo i'm in the shizzle malesuada scelerisque, nulla purus doggy felis, daahng dawg luctizzle metus tellivizzle izzle augue. Cool ullamcorper, tortizzle bizzle varizzle pimpin', nibh nunc ultricies turpis, izzle shiznit leo ass fo shizzle mah nizzle fo rizzle, mah home g-dizzle shiz. Maurizzle aliquet, orci vizzle ass consectetuer, sizzle augue luctizzle , bibendizzle enizzle we gonna chung ut nisl. Nullam a dope brizzle orci eleifend izzle. Mammasay mammasa mamma oo sa nizzle nibh. You son of a bizzle shiz velizzle sure ass sodalizzle facilisizzle. Maecenas sapien shizznit, iaculizzle ma nizzle, molestie cool, yo mamma a, erizzle. vitae check out this quizzle nibh bibendum hizzle. Pizzle break it down consectetuer izzle. Aliquizzle erat volutpat. Yo mamma shiz yo izzle daahng dawg pretizzle faucibus. Cras nec lacus for sure dui condimentizzle ultricies. Ut nisl. Own yo' izzle urna. Integer phat ipsum pot yippiyo. Donec gangster turpis.";
            return View("Index", message);
        }
        // 2nd page to display a list of numbers //
        [HttpGet("/nums")]
        public ViewResult Nums()
        {
            int[] numArr = new int[]{47,56,23,7,82};
            return View("Nums", numArr);
        }
        // 3rd page to display a single user //
        [HttpGet("/user")]
        public ViewResult Person()
        {
            Person ToDisplay = new Person("Bon", "Jovi");
            return View("user", ToDisplay);
        }
        [HttpGet("/users")]
        public ViewResult People()
        {
            List<Person> ListOfPeople = new List<Person>
            {
                new Person("Kevin", "Chancey"),
                new Person("Mr.", "Bean"),
                new Person("Grandpa", "Jabooty"),
                new Person("a", "stapler"),
                new Person("some", "guy")
            };
            return View("people", ListOfPeople); 
        }
    }
}