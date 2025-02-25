using PicPaySimplificado.Models.DTOs;
using PicPaySimplificado.Models.Request;
using PicPaySimplificado.Models.Response;

namespace PicPaySimplificado.Services.Transferencias
{
    public interface ITransferenciaService
    {
        Task<Result<TransferenciaDto>> ExecuteAsync(TransferenciaRequest request);
    }
}
