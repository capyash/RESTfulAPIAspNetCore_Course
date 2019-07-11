using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    using Library.API.Services;

    using Microsoft.AspNetCore.Mvc;

    public class AuthorsController : Controller
    {

        private ILibraryRepository libraryRepository;

        public AuthorsController(ILibraryRepository libraryRepository)
        {
            this.libraryRepository = libraryRepository;
        }
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = this.libraryRepository.GetAuthors();
            return new JsonResult(authorsFromRepo);
        }
    }
}
