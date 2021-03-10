using Microsoft.AspNetCore.Mvc;
using ProjectAlkemy.Model;
using ProjectAlkemy.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlkemy.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var users = _userRepository.GetAll();
            return View(users);
        }

        public IActionResult GetTeachers()
        {
            var users = _userRepository.GetTeachers();
            return View("Index",users);
        }

        public IActionResult GetStudents()
        {
            var users = _userRepository.GetStudents();
            return View("Index", users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            user = _userRepository.Create(user);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var user = _userRepository.GetById(Id);
            _userRepository.Delete(user);
            return RedirectToAction("Index");
        }
    }
}
