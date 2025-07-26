using Microsoft.EntityFrameworkCore;

namespace Dsw2025Tpi.Data;

public class Dsw2025TpiContext: DbContext
{
	public Dsw2025TpiContext(DbContextOptions options) : base(options)
	{

	}
}
