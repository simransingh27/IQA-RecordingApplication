using AutoMapper;
using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using IQA_RecordingApplication.Models;
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

        public SKUCodeController(ISKUCode repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: SKUCodeController
        public ActionResult Index()
        {
            var sKUCodeValue = _repo.FindAll().ToList();
            var model = _mapper.Map<List<SKUCode1>, List<SKUCodeViewModel>>(sKUCodeValue);
            return View(model);
        }

        // GET: SKUCodeController/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.IsExists(id)){
                return NotFound();
            }
            var skuCode = _repo.Find(id);
            var model = _mapper.Map<SKUCodeViewModel>(skuCode);
            return View(model);
        }

        // GET: SKUCodeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SKUCodeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SKUCodeViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return View(model);
                }
                var skuCode = _mapper.Map<SKUCode1>(model);
                skuCode.SKUCodeId = 1;
                skuCode.CreatedAt = DateTime.Now;
                skuCode.UpdatedAt = DateTime.Now;

                var isSuccess = _repo.Create(skuCode);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
               // return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: SKUCodeController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.IsExists(id))
            {

                return NotFound();

            }
            var skuCode = _repo.Find(id);
            var model = _mapper.Map<SKUCodeViewModel>(skuCode);

            return View(model);
        }

            // POST: SKUCodeController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
           public  ActionResult Edit(SKUCodeViewModel model)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {

                        return View(model);
                    }
                    var skuCode = _mapper.Map<SKUCode1>(model);
                    skuCode.UpdatedAt = DateTime.Now;
                    var isSuccess = _repo.Update(skuCode);

                    if (!isSuccess) {
                        ModelState.AddModelError("", "Something Went Wrong");
                        return View(model);
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Something Went Wrong");
                    return View();
                }
            }

            // GET: SKUCodeController/Delete/5
           public ActionResult Delete(int id)
            {
            var skuCode = _repo.Find(id);
            if (skuCode == null)
            {
                return NotFound();
            }
            var isSuccess = _repo.Delete(skuCode);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SKUCodeViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var skuCode = _repo.Find(id);
                if (skuCode == null)
                {
                    return NotFound();
                }
                var isSuccess = _repo.Delete(skuCode);
                if (!isSuccess)
                {
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
    }
