using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Tpi.Application.Dtos;

public record ProductModel
{
	public record Request
	(
		string Sku, 
		string InternalCode, 
		string Name, 
		decimal CurrentUnitPrice,  
		string Descripcion,
		int StockCuantity
	);


	public record Response(Guid Id);
}

