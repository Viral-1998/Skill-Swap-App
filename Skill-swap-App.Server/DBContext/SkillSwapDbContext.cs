using Microsoft.EntityFrameworkCore;

namespace Skill_swap_App.Server.DBContext
{
	public class SkillSwapDbContext:DbContext
	{
		public SkillSwapDbContext(DbContextOptions<SkillSwapDbContext> options):base(options)
		{
			
		}
	}
}
