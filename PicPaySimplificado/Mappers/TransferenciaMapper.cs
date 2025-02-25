using PicPaySimplificado.Models.DTOs;
using PicPaySimplificado.Models;

namespace PicPaySimplificado.Mappers
{
    public static class TransferenciaMapper
    {
        public static TransferenciaDto ToTransferenciaDto(this TransferenciaEntity transaction)
        {
            return new TransferenciaDto(
                transaction.IdTransferencia,
                transaction.Sender,
                transaction.Reciver,
                transaction.Valor
            );
        }
    }
}
