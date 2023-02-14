using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Products.Commands.CreateProduct
{
    public record CreateProductCommandResponse(string Message = "Ürün başarıyla eklendi");
    
}
