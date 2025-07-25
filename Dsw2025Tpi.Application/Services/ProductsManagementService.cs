using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Tpi.Application.Dtos;
using Dsw2025Tpi.Domain.Interfaces;

namespace Dsw2025Tpi.Application.Services;

public class ProductsManagementService
{
	private readonly IRepository _repository;

	public ProductsManagementService(IRepository repository)
	{
		_repository = repository;
	}

	public async Task<ProductModel.Response> AddProduct(ProductModel.Request request)
	{
		/*
		return await Task.FromResult(new ProductModel.Response(
			Guid.NewGuid(),
			request.Sku,
			request.Name
		));
		*/
		return await Task.FromResult(new ProductModel.Response(Guid.NewGuid()));
	}
}

