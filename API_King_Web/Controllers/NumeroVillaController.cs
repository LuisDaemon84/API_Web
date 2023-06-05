﻿using API_King.Modelos;
using API_King_Web.Models.Dto;
using API_King_Web.Models.ViewModel;
using API_King_Web.Services;
using API_King_Web.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.InteropServices;

namespace API_King_Web.Controllers
{
    public class NumeroVillaController : Controller
    {
        private readonly INumeroVillaService _numeroVillaService;
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public NumeroVillaController(INumeroVillaService numeroVillaService, IVillaService villaService, IMapper mapper)
        {
            _numeroVillaService = numeroVillaService;
            _villaService = villaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexNumeroVilla()
        {
            List<NumeroVillaDto> numeroVillaList = new();
            var response = await _numeroVillaService.ObtenerTodos<APIResponse>();

            if (response != null && response.IsExitoso)
            {
                numeroVillaList = JsonConvert.DeserializeObject<List<NumeroVillaDto>>(Convert.ToString(response.Resultado));
            }

            return View(numeroVillaList);
        }

        public async Task<IActionResult> CrearNumeroVilla()
        {
            NumeroVillaViewModel numeroVillaVM = new();
            var response = await _villaService.ObtenerTodos<APIResponse>();

            if (response != null && response.IsExitoso)
            {
                numeroVillaVM.VillaList = JsonConvert.DeserializeObject<List<VillaDto>>(Convert.ToString(response.Resultado))
                                            .Select(v => new SelectListItem
                                            {
                                                Text = v.Nombre,
                                                Value = v.Id.ToString()
                                            });
            }

            return View(numeroVillaVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearNumeroVilla(NumeroVillaViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                var response = await _numeroVillaService.Crear<APIResponse>(modelo.NumeroVilla);

                if (response != null && response.IsExitoso)
                {
                    TempData["exitoso"] = "Número Villa Creada Exitosamente";
                    return RedirectToAction(nameof(IndexNumeroVilla));
                }

                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessages", response.ErrorMessages.FirstOrDefault());
                    }
                }

            }

            var res = await _villaService.ObtenerTodos<APIResponse>();

            if (res != null && res.IsExitoso)
            {
                modelo.VillaList = JsonConvert.DeserializeObject<List<VillaDto>>(Convert.ToString(res.Resultado))
                                            .Select(v => new SelectListItem
                                            {
                                                Text = v.Nombre,
                                                Value = v.Id.ToString()
                                            });

            }

            return View(modelo);

        }

        public async Task<IActionResult> ActualizarNumeroVilla(int villaNo)
        {
            NumeroVillaUpdateViewModel numeroVillaVM = new();
            var response = await _numeroVillaService.Obtener<APIResponse>(villaNo);

            if (response != null && response.IsExitoso)
            {
                NumeroVillaDto modelo = JsonConvert.DeserializeObject<NumeroVillaDto>(Convert.ToString(response.Resultado));
                numeroVillaVM.NumeroVilla = _mapper.Map<NumeroVillaUpdateDto>(modelo);
            }

            response = await _villaService.ObtenerTodos<APIResponse>();

            if (response != null && response.IsExitoso)
            {
                numeroVillaVM.VillaList = JsonConvert.DeserializeObject<List<VillaDto>>(Convert.ToString(response.Resultado))
                                            .Select(v => new SelectListItem
                                            {
                                                Text = v.Nombre,
                                                Value = v.Id.ToString()
                                            });

                return View(numeroVillaVM);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ActualizarNumeroVilla(NumeroVillaUpdateViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                var response = await _numeroVillaService.Actualizar<APIResponse>(modelo.NumeroVilla);

                if (response != null && response.IsExitoso)
                {
                    TempData["exitoso"] = "Número Villa Actualizada Exitosamente";
                    return RedirectToAction(nameof(IndexNumeroVilla));
                }

                else
                {
                    if (response.ErrorMessages.Count > 0)
                    {
                        ModelState.AddModelError("ErrorMessages", response.ErrorMessages.FirstOrDefault());
                    }
                }

            }

            var res = await _villaService.ObtenerTodos<APIResponse>();

            if (res != null && res.IsExitoso)
            {
                modelo.VillaList = JsonConvert.DeserializeObject<List<VillaDto>>(Convert.ToString(res.Resultado))
                                            .Select(v => new SelectListItem
                                            {
                                                Text = v.Nombre,
                                                Value = v.Id.ToString()
                                            });

            }

            return View(modelo);
        }

        public async Task<IActionResult> RemoverNumeroVilla(int villaNo)
        {
            NumeroVillaDeleteViewModel numeroVillaVM = new();
            var response = await _numeroVillaService.Obtener<APIResponse>(villaNo);

            if (response != null && response.IsExitoso)
            {
                NumeroVillaDto modelo = JsonConvert.DeserializeObject<NumeroVillaDto>(Convert.ToString(response.Resultado));
                numeroVillaVM.NumeroVilla = modelo;
            }

            response = await _villaService.ObtenerTodos<APIResponse>();

            if (response != null && response.IsExitoso)
            {
                numeroVillaVM.VillaList = JsonConvert.DeserializeObject<List<VillaDto>>(Convert.ToString(response.Resultado))
                                            .Select(v => new SelectListItem
                                            {
                                                Text = v.Nombre,
                                                Value = v.Id.ToString()
                                            });

                return View(numeroVillaVM);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoverNumeroVilla(NumeroVillaDeleteViewModel modelo)
        {
            var response = await _numeroVillaService.Remover<APIResponse>(modelo.NumeroVilla.VillaNo);

            if (response != null && response.IsExitoso)
            {
                TempData["exitoso"] = "Número de Villa Eliminada Exitosamente";
                return RedirectToAction(nameof(IndexNumeroVilla));
            }

            TempData["error"] = "Ocurrio un error al Eliminar";
            return View(modelo);
        }

    }
}