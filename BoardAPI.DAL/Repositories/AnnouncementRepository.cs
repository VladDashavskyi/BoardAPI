using BoardAPI.Common.DTO;
using BoardAPI.DAL.Model;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BoardAPI.DAL.Repositories
{
    public class AnnouncementRepository
    {
        private readonly string _connectionString;

        public AnnouncementRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Announcement>> GetAllAnnouncementsAsync()
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.QueryAsync<Announcement>("EXEC GetAnnouncements");
            }
        }

        public async Task<Announcement?> GetAnnouncementByIdAsync(int id)
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                var result = await dbConnection.QueryAsync<Announcement>("EXEC GetAnnouncementById @Id", new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<int> CreateAnnouncementAsync(AnnouncementDto announcement)
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.ExecuteAsync("EXEC CreateAnnouncement @Title, @Description, @Status, @CategoryId, @SubCategoryId", 
                    new 
                    {
                        announcement.Title,
                        announcement.Description,
                        Status = announcement.Status.ToString(),
                        announcement.CategoryId,
                        announcement.SubCategoryId
                    });
            }
        }

        public async Task<int> UpdateAnnouncementAsync(AnnouncementDto announcement)
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.ExecuteAsync("EXEC UpdateAnnouncement @Id, @Title, @Description, @Status, @CategoryId, @SubCategoryId",
                    new
                    {
                        announcement.Id,
                        announcement.Title,
                        announcement.Description,
                        Status = announcement.Status.ToString(),
                        announcement.CategoryId,
                        announcement.SubCategoryId
                    });
            }
        }

        public async Task<int> DeleteAnnouncementAsync(int id)
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.ExecuteAsync("EXEC DeleteAnnouncement @Id", new { Id = id });
            }
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.QueryAsync<Category>("EXEC GetAllCategories");
            }
        }       
        
        public async Task<IEnumerable<Category>> GetCategoryByIdAsync(int id)
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.QueryAsync<Category>("EXEC GetCategoryById @Id", new {Id = id});
            }
        }

        public async Task<IEnumerable<SubCategory>> GetAllSubCategoriesAsync()
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.QueryAsync<SubCategory>("EXEC GetAllSubCategories");
            }
        }
        
        public async Task<IEnumerable<SubCategory>> GetSubCategoryByIdAsync(int id)
        {
            using (DbConnection dbConnection = new SqlConnection(_connectionString))
            {
                await dbConnection.OpenAsync();
                return await dbConnection.QueryAsync<SubCategory>("EXEC GetSubCategoryById @Id", new { Id = id });
            }
        }
    }
}
