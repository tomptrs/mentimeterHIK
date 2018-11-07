using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentiMeterTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentiMeterTest.Controllers
{
    public class VragenController : Controller
    {
        IRepository lesRepository;
        public VragenController(IRepository _repository)
        {
            lesRepository = _repository;
        }
        /// <summary>
        /// Get alle lessen
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(lesRepository.GetAlleLessen());
        }

        public IActionResult Vragen(int id)
        {
            ViewData["LesId"] = 1;
            var vraag = lesRepository.GetVraagById(1, id);
            return View(vraag);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> is previous vraagId</param>
        /// <returns></returns>
        public IActionResult Volgende(int id)
        {
            var result = lesRepository.GetNextVraag(id);
            if (result != null)
            {
                return RedirectToAction("vragen", result.VraagId);
            }
            else
                return RedirectToAction("vragen",id);
        }


    }
}