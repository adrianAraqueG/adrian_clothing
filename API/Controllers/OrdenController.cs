using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]

    [Authorize]
    public class OrdenController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;
        public OrdenController(IUnitOfWork unitofwork, IMapper mapper)
        {
            _unitOfwork = unitofwork;
            _mapper = mapper;
        }

        /*
        * MÉTODOS ESPECÍFICOS
        */
        [HttpGet("listarPorEstado/{estado}")]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<OrdenSimpleDto>>> ObtenerPorEstado(string estado)
        {
            string espParsed = estado;
            if(estado.Contains("%")){
                espParsed = estado.Replace("%", " ");
            }
            var ordenes = await _unitOfwork.Ordenes.ObtenerOrdenXEstado(espParsed);
            return _mapper.Map<List<OrdenSimpleDto>>(ordenes);
        }


        /*
        * CRUD
        */
        // GET
        [HttpGet("listar")]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<OrdenSimpleDto>>> GetAll()
        {
            var Ordens = await _unitOfwork.Ordenes.GetAllAsync();
            return _mapper.Map<List<OrdenSimpleDto>>(Ordens);
        }
        // PAGINADO
        // [HttpGet]
        // [MapToApiVersion("1.1")]
        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // public async Task<ActionResult<Pager<OrdenSimpleDto>>> GetPagination([FromQuery] Params Params)
        // {
        //     var (totalRecords, records) = await _unitOfwork.Ordenes.GetAllAsync(Params.PageIndex, Params.PageSize, Params.Search);
        //     var listOrden = _mapper.Map<List<OrdenSimpleDto>>(records);
        //     return new Pager<OrdenSimpleDto>(listOrden, totalRecords, Params.PageIndex, Params.PageSize, Params.Search);
        // }



        // POST
        [HttpPost("crear")]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> RegisterAsync(OrdenRegDto model)
        {
            try{
                var Orden = _mapper.Map<Orden>(model);
                _unitOfwork.Ordenes.Add(Orden);
                await _unitOfwork.SaveAsync();
                return Ok($"Orden creado correctamente!");
            }catch(Exception err){
                return BadRequest($"{err}");
            }
            
        }



        // PUT
        [HttpPut("actualizar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> Put(int id, [FromBody] OrdenRegDto OrdenActualizado)
        {
            var OrdenExists = _unitOfwork.Ordenes.GetByIdAsync(id);

            if (OrdenExists == null)
            {
                return NotFound();
            }

            var Orden = _mapper.Map<Orden>(OrdenActualizado);
            _unitOfwork.Ordenes.Update(Orden);
            await _unitOfwork.SaveAsync();
            return Ok($"Orden {id} actualizado!");
        }



        // DELETE
        [HttpDelete("eliminar/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> Delete(int id)
        {
            var Orden = await _unitOfwork.Ordenes.GetByIdAsync(id);

            if (Orden == null)
            {
                return NotFound();
            }

            _unitOfwork.Ordenes.Remove(Orden);
            await _unitOfwork.SaveAsync();
            return Ok($"Registro {id} eliminado correctamente!");
        }
    }
}