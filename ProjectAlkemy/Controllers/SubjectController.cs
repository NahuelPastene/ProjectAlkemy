using Microsoft.AspNetCore.Mvc;
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
        public SubjectController(SubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public IActionResult Index()
        {
            var subjects = _subjectRepository.GetAll();
            return View(subjects);
        }

        [HttpGet]
        public IActionResult Create()
        {
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
