using AutoMapper;
using Generico.Business.Interfaces;
using Generico.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WebAvaliacoes.ViewModels;


namespace WebAvaliacoes.Controllers
{
    public class EstadosController : Controller
    {

        private readonly IEstadoRepository _estadoRepository;
        private readonly IMapper _mapper;


        public EstadosController(IEstadoRepository estadoRepository, IMapper mapper)
        {
            _estadoRepository = estadoRepository;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<EstadoViewModel>>(await _estadoRepository.ObterTodos()));
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EstadoViewModel estadoViewModel)
        {
            if (!ModelState.IsValid) return View(estadoViewModel);

            var dados = _mapper.Map<Estado>(estadoViewModel);
            await _estadoRepository.Adicionar(dados);

            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Edit(int id)
        {
            var estadoViewModel = _mapper.Map<EstadoViewModel>(await _estadoRepository.ObterPorId(id));
            if (estadoViewModel == null)
            {
                return NotFound();
            }

            return View(estadoViewModel);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EstadoViewModel estadoViewModel)
        {
            if (id != estadoViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(estadoViewModel);

            var dados = _mapper.Map<Estado>(estadoViewModel);
            await _estadoRepository.Atualizar(dados);

            return RedirectToAction(nameof(Index));

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Deletar(int id)
        {
            await _estadoRepository.Remover(id);
            return Json("Registro excluído com sucesso");
        }

    }
}
