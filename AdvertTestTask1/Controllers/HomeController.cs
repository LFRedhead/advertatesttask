using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdvertTestTask1.Models;
using AdvertTestTask1.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AdvertTestTask1.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace AdvertTestTask1.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        private ICommRepository _repository;
        private ILogger<HomeController> _loggerFactory;
        private CommissionContext db;



        public HomeController(IMailService mailService, IConfigurationRoot config, ICommRepository repository,
            ILogger<HomeController> loggerFactory, CommissionContext context)
        {
            _mailService = mailService;
            _config = config;
            _repository = repository;
            _loggerFactory = loggerFactory;
            db = context;


        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult ViewCommissions()
        {
            try
            {
                var data = _repository.GetAllCommissions();
                return View(db.Commissions.ToList());
            }
            catch (Exception ex)
            {
                _loggerFactory.LogError($"Failed to get commissions in Index page: {ex.Message}");
                return Redirect("/error");
            }
        }


        public IActionResult Order()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Order(Commission model)
        {

            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings: ToAddress"], model.CommEmail, "From LF", model.OrderText, 10, true);

                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent";
            }
            db.Commissions.Add(model);
            await db.SaveChangesAsync();
            return RedirectToAction("ViewCommissions");
        }

        public IActionResult About()
        {
            return View();
        }

        [Authorize]
        public IActionResult AboutReg()

        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Commission commission = await db.Commissions.FirstOrDefaultAsync(p => p.CommissionId == id);
                if (commission != null)
                    return View(commission);
            }
            return NotFound();
        }


        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id != null)
        //    {
        //        Commission newCommission = new Commission { CommissionId = id.Value };
        //        db.Entry(newCommission).State = EntityState.Deleted;
        //        Commission commission = await db.Commissions.FirstOrDefaultAsync(p => p.CommissionId == id);
        //        if (commission != null)
        //            return View(commission);
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(Commission commission)
        //{

        //    db.Commissions.Update(commission);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        public IActionResult Delete()
        {
            try
            {
                var data = _repository.GetAllCommissions();
                return View(db.Commissions.ToList());
            }
            catch (Exception ex)
            {
                _loggerFactory.LogError($"Failed to get commissions in View page: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Commission commission = await db.Commissions.FirstOrDefaultAsync(p => p.CommissionId == id);
                if (commission != null)
                    return View(commission);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Commission commission = await db.Commissions.FirstOrDefaultAsync(p => p.CommissionId == id);
                if (commission != null)
                {
                    db.Commissions.Remove(commission);
                    await db.SaveChangesAsync();
                    return RedirectToAction("ViewCommissions");
                }
            }
            return NotFound();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        //{
        //    if (uploadedFile != null)
        //    {
        //        // путь к папке Files
        //        string path = "/Files/" + uploadedFile.FileName;
        //        // сохраняем файл в папку Files в каталоге wwwroot
        //        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        //        {
        //            await uploadedFile.CopyToAsync(fileStream);
        //        }
        //        FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
        //        db.Files.Add(file);
        //        db.SaveChanges();
        //    }

        //    return RedirectToAction("Index");
        //}

    }
}
