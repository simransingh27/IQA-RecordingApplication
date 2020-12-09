using AutoMapper;
using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Controllers
{
    public class SKUCodeController : Controller
    {
        private readonly ISKUCode _repo;
        private readonly IMapper _mapper;

        public SKUCodeController( ISKUCode repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: SKUCodeController
        public ActionResult Index()
        {
            var sKUCodeValue= _repo.FindAll().ToList();
            var model = _mapper.Map<ICollection<SKUCode>, ICollection<SKUCode>>(sKUCodeValue);
            return View();
        }

        // GET: SKUCodeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SKUCodeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SKUCodeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SKUCodeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SKUCodeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SKUCodeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SKUCodeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
