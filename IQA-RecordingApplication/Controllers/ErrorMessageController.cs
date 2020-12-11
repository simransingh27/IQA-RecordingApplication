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
    public class ErrorMessageController : Controller
    {
        private readonly IErrorMessage _repo;
        private readonly IMapper _mapper;
        public ErrorMessageController( IErrorMessage repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper; 

        }

        // GET: ErrorMessageController
        public ActionResult Index()
        {
            var productValue = _repo.FindAll().ToList();
            var model = _mapper.Map<List<ErrorMessage>, List<CreateErrorMessageViewModel>>(productValue);
            return View(model);
        }

        // GET: ErrorMessageController/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.IsExists(id))
            {
                return NotFound();
            }
            var errorMessage = _repo.Find(id);
            var model = _mapper.Map<CreateErrorMessageViewModel>(errorMessage);
            return View(model);
        }

        // GET: ErrorMessageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ErrorMessageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateErrorMessageViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    return View(model);
                }
                var errorMessge = _mapper.Map<ErrorMessage>(model);
                //   product.ProductId = 2;
               // errorMessge.ErrorMessageId = 1;
               

                var isSuccess = _repo.Create(errorMessge);
              
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something Went Wrong");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: ErrorMessageController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.IsExists(id))
            {

                return NotFound();

            }
            var errorMessage = _repo.Find(id);
            var model = _mapper.Map<CreateErrorMessageViewModel>(errorMessage);

            return View(model);
        }

        // POST: ErrorMessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CreateErrorMessageViewModel model)
        {

            try
            {
                if (!ModelState.IsValid)
                {

                    return View(model);
                }
                var product = _mapper.Map<ErrorMessage>(model);
                
                var isSuccess = _repo.Update(product);

                if (!isSuccess)
                {
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

        // GET: ErrorMessageController/Delete/5
        public ActionResult Delete(int id)
        {
            var errorMessage = _repo.Find(id);
            if (errorMessage == null)
            {
                return NotFound();
            }
            var isSuccess = _repo.Delete(errorMessage);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: ErrorMessageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id, CreateErrorMessageViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var errorMessage = _repo.Find(Id);
                if (errorMessage == null)
                {
                    return NotFound();
                }
                var isSuccess = _repo.Delete(errorMessage);
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
