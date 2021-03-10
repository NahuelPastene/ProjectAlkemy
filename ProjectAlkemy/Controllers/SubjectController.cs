using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectAlkemy.Model;
using ProjectAlkemy.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlkemy.Controllers
{
    public class SubjectController : Controller
    {
        private readonly SubjectRepository _subjectRepository;
        private readonly UserRepository _userRepository;
        public SubjectController(SubjectRepository subjectRepository,UserRepository userRepository)
        {
            _subjectRepository = subjectRepository;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var subjects = _subjectRepository.GetAll();
            return View(subjects);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var teachers = 
                _userRepository
                    .GetTeachers()
                    .Select(x=> new SelectListItem(x.FullName,x.Id.ToString()));
            ViewData["Teachers"]=teachers;
            return View(new Subject());
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            subject = _subjectRepository.Create(subject);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var subject = _subjectRepository.GetById(Id);
            _subjectRepository.Delete(subject);
            return RedirectToAction("Index");
        }
    }
}
