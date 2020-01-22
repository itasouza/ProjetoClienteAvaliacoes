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
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IMapper _mapper;


        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            _produtoRepository = produtoRepository;
            _hostingEnvironment = hostingEnvironment;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterTodos()));
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel, IFormFile arquivofoto)
        {
            if (!ModelState.IsValid) return View(produtoViewModel);

            var imgPrefixo = Guid.NewGuid() + "_";
            var linkUpload = Path.Combine(_hostingEnvironment.WebRootPath, "ImagensPerfil");
            if (arquivofoto != null)
            {
                using (var fileStream = new FileStream(Path.Combine(linkUpload, imgPrefixo + arquivofoto.FileName), FileMode.Create))
                {
                    await arquivofoto.CopyToAsync(fileStream);
                    produtoViewModel.FotoProduto = imgPrefixo + arquivofoto.FileName;
                }
            }

            var dados = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Adicionar(dados);

            return RedirectToAction(nameof(Index));

        }


        public async Task<IActionResult> Edit(int id)
        {
            var produtoViewModel = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterPorId(id));
            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProdutoViewModel produtoViewModel, IFormFile arquivofoto)
        {

            if (id != produtoViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(produtoViewModel);

            //se tiver imagem nova, vou sobrescrever 
            var imgPrefixo = Guid.NewGuid() + "_";
            var linkUpload = Path.Combine(_hostingEnvironment.WebRootPath, "ImagensPerfil");
            if (arquivofoto != null)
            {
                using (var fileStream = new FileStream(Path.Combine(linkUpload, imgPrefixo + arquivofoto.FileName), FileMode.Create))
                {
                    await arquivofoto.CopyToAsync(fileStream);
                    produtoViewModel.FotoProduto = imgPrefixo + arquivofoto.FileName;
                }
            }

            var dados = _mapper.Map<Produto>(produtoViewModel);
            await _produtoRepository.Atualizar(dados);

            return RedirectToAction(nameof(Index));

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Deletar(int id)
        {
            await _produtoRepository.Remover(id);
            return Json("Categoria excluída com sucesso");
        }


    }
}