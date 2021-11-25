using Microsoft.AspNetCore.Mvc;
using ProcAccess.ViewModels;
using ProcAccess.Repositories;

namespace ProcAccess.Controllers
{
    public class ProcessoController:Controller
    {
        private readonly IProcessoRepository _processoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProcessoController(IProcessoRepository processoRepository, ICategoriaRepository categoriaRepository)
        {
            _processoRepository = processoRepository;   
            _categoriaRepository = categoriaRepository; 
        }
        public IActionResult Create()
        {
            return View();  
        }

        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult List()
        {
            //ViewBag.Processo = "Processos";
            //ViewData["Categoria"] = "Categoria";

            var _processosListViewModel = new ProcessoListViewModel();
            _processosListViewModel.Processos = _processoRepository.Processos;
            _processosListViewModel.Categorias = "Categorias";

            return View(_processosListViewModel);
        }
    }
}
